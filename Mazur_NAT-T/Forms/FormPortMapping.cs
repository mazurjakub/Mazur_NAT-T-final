using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Open.Nat;

namespace Mazur_NAT_T.Forms
{
    public partial class FormPortMapping : Form
    {
        public FormPortMapping()
        {
            InitializeComponent();
            Load += new EventHandler(FormPortMapping_Load);
        }

        private void FormPortMapping_Load(object sender, System.EventArgs e)
        {
            _ = ListMappings();
        }


        private async Task CreateMappingAsync()
        {
            string mappingName = txtBoxMappingName.Text,
                extPortText = txtBoxExternalPort.Text,
                intPortText = txtBoxInternalPort.Text;

            // Check if ports are numbers and if they are in registered port range
            if(!(int.TryParse(extPortText, out int extPort)) && extPort < 1024 && extPort > 49151){
                MessageBox.Show("Neplatný externí port");
                return;
            }

            if(!(int.TryParse(intPortText, out int intPort)) && intPort < 1024 && intPort > 49151)
            {
                MessageBox.Show("Neplatný interní port");
                return;
            }
            try
            {
                // Discover mappings
                var discoverer = new NatDiscoverer();

                // Using SSDP protocol to discover NAT device.
                var device = await discoverer.DiscoverDeviceAsync();

                // Create a new mapping in the router [NAT_device_IP:external_port -> host_machine_IP:internal_port]
                var mapping = new Mapping(Protocol.Tcp, intPort, extPort, mappingName);
                await device.CreatePortMapAsync(mapping);

                // Display created mapping
                _ = ListMappings();

                // Configure a TCP socket to listen on internal port
                var endPoint = new IPEndPoint(IPAddress.Any, intPort);
                var socket = new Socket(endPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                socket.SetIPProtectionLevel(IPProtectionLevel.Unrestricted);
                socket.Bind(endPoint);
                socket.Listen(4);
            }
            // Catching if UPnP NAT device wasnt found
            catch (NatDeviceNotFoundException)
            {
                MessageBox.Show("Nebylo nalezeno UPnP zařízení.");
            }

            // Catching mapping errors
            catch(MappingException me)
            {
                switch (me.ErrorCode)
                {
                    case 718:
                        MessageBox.Show("Externí port je již využíván.");
                        break;

                    case 728:
                        MessageBox.Show("Mapovací tabulka routeru je plná.");
                        break;
                }
            }

        }

        private async Task ListMappings()
        {
            try
            {
                int addedMappings = 0;
                // Discover mappings
                var nat = new NatDiscoverer();

                // Stop discovering after 5 seconds
                var cts = new CancellationTokenSource(5000);

                // Discover UPnP NAT device
                var device = await nat.DiscoverDeviceAsync(PortMapper.Upnp, cts);

                checkBoxMappings.Items.Clear();

                // Write each mapping's information "mapping_name: NAT_device_IP:external_port -> host_machine_IP:internal_port"
                foreach (var mapping in await device.GetAllMappingsAsync())
                {
                    string item = mapping.Description + ": " + await device.GetExternalIPAsync() + ":" + mapping.PublicPort + " -> "
                        + mapping.PrivateIP + ":" + mapping.PrivatePort + "\n";

                    checkBoxMappings.Items.Add(item, false);
                    addedMappings++;
                }
                if(addedMappings == 0) checkBoxMappings.Items.Add("Nebyla nalezena žádná mapování", false);
            }
            // Catching if UPnP NAT device wasnt found
            catch (NatDeviceNotFoundException)
            {
                MessageBox.Show("Nebylo nalezeno UPnP zařízení.");
            }
        }

        // Delete mapping using name of the mapping
        private async Task DeleteCheckedMappings()
        {
            try
            {
                // Discover mappings
                var nat = new NatDiscoverer();

                // Stop discovering after 5 seconds
                var cts = new CancellationTokenSource(5000);

                // Discover UPnP NAT device
                var device = await nat.DiscoverDeviceAsync(PortMapper.Upnp, cts);

                //Find checked items
                foreach(var item in checkBoxMappings.CheckedItems)
                {
                    int i = checkBoxMappings.Items.IndexOf(item);
                    string mappingName = GetUntilOrEmpty(checkBoxMappings.Items[i].ToString());

                    // Compare each mapping name with given name, if they match, delete the mapping
                    foreach (var mapping in await device.GetAllMappingsAsync())
                    {
                        if (mapping.Description.Equals(mappingName))
                        {
                            await device.DeletePortMapAsync(mapping);
                        }
                    }

                }
                _ = ListMappings();
            }
            // Catching if UPnP NAT device wasnt found
            catch (NatDeviceNotFoundException)
            {
                MessageBox.Show("Nebylo nalezeno UPnP zařízení.");
            }
        }

        // From https://stackoverflow.com/questions/1857513/get-substring-everything-before-certain-char
        public static string GetUntilOrEmpty(string text, string stopAt = ":")
        {
            if (!String.IsNullOrWhiteSpace(text))
            {
                int charLocation = text.IndexOf(stopAt, StringComparison.Ordinal);

                if (charLocation > 0)
                {
                    return text.Substring(0, charLocation);
                }
            }

            return String.Empty;
        }

        private void btnMapping_Click(object sender, EventArgs e)
        {
            _ = CreateMappingAsync();
            
        }

        private void btnDeleteMapping_Click(object sender, EventArgs e)
        {
            _ = DeleteCheckedMappings();
        }
    }
}

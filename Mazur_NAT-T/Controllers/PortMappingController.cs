using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Open.Nat;

namespace Mazur_NAT_T.Controllers
{
    public class PortMappingController
    {
        private static IPortMappingView _view;

        public PortMappingController(IPortMappingView view)
        {
            _view = view;
            view.SetController(this);
        }

        public async Task ListMappings()
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

                _view.ClearCheckBox();

                // Write each mapping's information "mapping_name: NAT_device_IP:external_port -> host_machine_IP:internal_port"
                foreach (var mapping in await device.GetAllMappingsAsync())
                {
                    string item = mapping.Description + ": " + await device.GetExternalIPAsync() + ":" + mapping.PublicPort + " -> "
                        + mapping.PrivateIP + ":" + mapping.PrivatePort + "\n";

                    _view.AddToCheckBox(item);
                    addedMappings++;
                }
                if (addedMappings == 0) _view.AddToCheckBox("Nebyla nalezena žádná mapování");
            }
            // Catching if UPnP NAT device wasnt found
            catch (NatDeviceNotFoundException)
            {
                _view.ShowMessageBox("Nebylo nalezeno UPnP zařízení.");
            }
        }

        public async Task CreateMappingAsync(string mappingName, string extPortText, string intPortText)
        {

            // Check if ports are numbers and if they are in registered port range
            if (!(int.TryParse(extPortText, out int extPort)) && extPort < 1024 && extPort > 49151)
            {
                _view.ShowMessageBox("Neplatný externí port");
                return;
            }

            if (!(int.TryParse(intPortText, out int intPort)) && intPort < 1024 && intPort > 49151)
            {
                _view.ShowMessageBox("Neplatný interní port");
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
                _view.ShowMessageBox("Nebylo nalezeno UPnP zařízení.");
            }

            // Catching mapping errors
            catch (MappingException me)
            {
                switch (me.ErrorCode)
                {
                    case 718:
                        _view.ShowMessageBox("Externí port je již využíván.");
                        break;

                    case 728:
                        _view.ShowMessageBox("Mapovací tabulka routeru je plná.");
                        break;
                }
            }

        }

        public async Task DeleteCheckedMappings()
        {
            try
            {
                List<string> checkedItems = _view.CheckedItems();

                // Discover mappings
                var nat = new NatDiscoverer();

                // Stop discovering after 5 seconds
                var cts = new CancellationTokenSource(5000);

                // Discover UPnP NAT device
                var device = await nat.DiscoverDeviceAsync(PortMapper.Upnp, cts);

                //Find checked items
                foreach (string item in checkedItems)
                {
                    string mappingName = GetUntilOrEmpty(item);

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
                _view.ShowMessageBox("Nebylo nalezeno UPnP zařízení.");
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
    }
}

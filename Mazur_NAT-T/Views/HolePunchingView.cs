using System;
using Mazur_NAT_T.Controllers;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;

namespace Mazur_NAT_T.Views
{
    public partial class HolePunchingView : Form, IHolePunchingView
    {
        HolePunchingController _controller;

        public HolePunchingView()
        {
            InitializeComponent();
            txtBoxOutput.AppendText("Okno pro komunikaci s klientem a serverem.");
        }

        public void SetController(HolePunchingController controller)
        {
            _controller = controller;
        }

        public void ShowMessageBox(string message)
        {
            MessageBox.Show(message);
        }

        //This method writes given string to textbox
        public void WriteToTextBox(string str)
        {
            if (txtBoxOutput.InvokeRequired)
            {
                Action writeSafe = delegate { WriteToTextBox($"{str}"); };
                txtBoxOutput.Invoke(writeSafe);
            }
            else
            {
                try
                {
                    txtBoxOutput.AppendText(Environment.NewLine);
                    txtBoxOutput.AppendText(str);
                    txtBoxOutput.Refresh();
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        public void ClearTextBox()
        {
            if (txtBoxOutput.InvokeRequired)
            {
                Action writeSafe = delegate { ClearTextBox(); };
                txtBoxOutput.Invoke(writeSafe);
            }
            else
            {
                try
                {
                    txtBoxOutput.Clear();
                    txtBoxOutput.Refresh();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            _controller.SendKeyToServer(txtBoxKey.Text);
            txtBoxKey.Text = "";
            txtBoxKey.Refresh();
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            _controller.SendMessageToClient(txtBoxMessage.Text);
            txtBoxMessage.Text = "";
            txtBoxMessage.Refresh();
        }
    }  
}


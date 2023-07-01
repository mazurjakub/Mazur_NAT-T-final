using System;
using Mazur_NAT_T.Controllers;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Mazur_NAT_T.Views
{
    public partial class PortMappingView : Form, IPortMappingView
    {
        private PortMappingController _controller;
        public PortMappingView()
        {
            InitializeComponent();
        }

        public void SetController(PortMappingController controller)
        {
            _controller = controller;
        }

        public void ShowMessageBox(string message)
        {
            MessageBox.Show(message);
        }

        public void AddToCheckBox(string item)
        {
            checkBoxMappings.Items.Add(item, false);
        }

        public void ClearCheckBox()
        {
            checkBoxMappings.Items.Clear();
        }

        public List<string> CheckedItems()
        {
            List<string> items = new List<string>();
            foreach (string s in checkBoxMappings.CheckedItems)
            {
                items.Add(s);
            }

            return items;
        }

        private void btnMapping_Click(object sender, EventArgs e)
        {
            _ = _controller.CreateMappingAsync(txtBoxMappingName.Text, txtBoxExternalPort.Text, txtBoxInternalPort.Text);
            
        }

        private void btnDeleteMapping_Click(object sender, EventArgs e)
        {
            _ = _controller.DeleteCheckedMappings();
        }
    }
}

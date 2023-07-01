using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Mazur_NAT_T.Controllers;

namespace Mazur_NAT_T
{
    public partial class MainMenuView : Form
    {
        private Button currentButton;
        private Form activeForm;
        public static bool isFirstMessage = true;
        private List<Form> _views;
        private HolePunchingController _hpController;


        public MainMenuView(List<Form> views, HolePunchingController hpc)
        {
            InitializeComponent();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            _views = views;
            _hpController = hpc;
        }

        // This method highlights clicked button

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    currentButton.BackColor = Color.FromArgb(0, 134, 212);
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        // Opposite of ActivateButton method
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(0, 111, 173);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenSecondaryForm(Form secondaryForm, object btnSender)
        {
            //Checking if any ChildForm is open
            if (activeForm != null)
                activeForm.Hide();
            ActivateButton(btnSender);

            //Setting new ChildForm as active form and changing its properties so it fits into panelObrazovka
            activeForm = secondaryForm;
            secondaryForm.TopLevel = false;
            secondaryForm.FormBorderStyle = FormBorderStyle.None;
            secondaryForm.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(secondaryForm);
            this.panelMain.Tag = secondaryForm;
            secondaryForm.BringToFront();
            secondaryForm.Show();
            lblTitle.Text = secondaryForm.Text;
        }

        // Button methods

        private void btnHP_Click(object sender, EventArgs e)
        {
            OpenSecondaryForm(_views[0], sender);
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            OpenSecondaryForm(_views[1], sender);
        }

        private void btnNAT_Click(object sender, EventArgs e)
        {
            OpenSecondaryForm(_views[2], sender);
        }

        private void btnText_Click(object sender, EventArgs e)
        {
            OpenSecondaryForm(_views[3], sender);
        }

        //Closing app button
        private void btnEnd_Click(object sender, EventArgs e)
        {
            _hpController.EndCommunication();
            Application.Exit();
        }

        //Button to close active ChildForm and going back to main screen
        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Hide();
                DisableButton();
                lblTitle.Text = "Domovská obrazovka";
                btnCloseChildForm.Visible = false;
                currentButton = null;

            }
        }
    }
}

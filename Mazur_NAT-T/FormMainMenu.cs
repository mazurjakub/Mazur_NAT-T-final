using System;
using System.Drawing;
using System.Windows.Forms;
using Mazur_NAT_T.Forms;

namespace Mazur_NAT_T
{
    public partial class FormMainMenu : Form
    {
        private Button currentButton;
        private Form activeForm;
        public static bool alreadyLoaded = false;
        public static bool isFirstMessage = true;
        public static string lblHolep = "Okno pro komunikaci se serverem a klientem";


        public FormMainMenu()
        {
            InitializeComponent();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;

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
                activeForm.Close();
            ActivateButton(btnSender);

            //Setting new ChildForm as active form and changing its properties so it fits into panelObrazovka
            activeForm = secondaryForm;
            secondaryForm.TopLevel = false;
            secondaryForm.FormBorderStyle = FormBorderStyle.None;
            secondaryForm.Dock = DockStyle.Fill;
            this.panelObrazovka.Controls.Add(secondaryForm);
            this.panelObrazovka.Tag = secondaryForm;
            secondaryForm.BringToFront();
            secondaryForm.Show();
            lblNadpis.Text = secondaryForm.Text;
        }

        // Button methods

        private void btnNAT_Click(object sender, EventArgs e)
        {
            OpenSecondaryForm(new Forms.FormIntro(), sender);
        }

        private void btnHP_Click(object sender, EventArgs e)
        {
            OpenSecondaryForm(new Forms.FormHolePunching(), sender);
        }

        //Closing app button
        private void btnEnd_Click(object sender, EventArgs e)
        {
            try
            {
                FormHolePunching.client.Close();
            }
            catch(Exception)
            {

            }
            Application.Exit();
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            OpenSecondaryForm(new Forms.FormPortMapping(), sender);
        }

        
        private void btnText_Click(object sender, EventArgs e)
        {
            OpenSecondaryForm(new Forms.FormAnimations(), sender);
        }

        //Button to close active ChildForm and going back to main screen
        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                DisableButton();
                lblNadpis.Text = "Domovská obrazovka";
                btnCloseChildForm.Visible = false;
                currentButton = null;

            }
        }
    }
}

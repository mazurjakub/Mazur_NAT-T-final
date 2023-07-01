using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Mazur_NAT_T.Views
{
    public partial class AnimationsView : Form
    {

        private bool isRunningHP = false, isRunningPM = false;
        private Image gifHP = Image.FromHbitmap(Properties.Resources.UDP_HolePunching.GetHbitmap());
        private Image gifPM = Image.FromHbitmap(Properties.Resources.PortMapping.GetHbitmap());

        public AnimationsView()
        {
            InitializeComponent();
        }

        private void FormAnimations_Load(object sender, EventArgs e)
        {

        }


        private void btnHP_Anim_Click(object sender, EventArgs e)
        {
            if (!isRunningHP)
            {
                pictureBoxHP.Enabled = true;
                btnHP_Anim.Text = "Stop";
                btnHP_Anim.Refresh();
                isRunningHP = true;
            }
            else
            {
                pictureBoxHP.Enabled = false;
                btnHP_Anim.Text = "Start";
                btnHP_Anim.Refresh();
                isRunningHP = false;
            }
        }

        private void btnPM_Anim_Click(object sender, EventArgs e)
        {
            if (!isRunningPM)
            {
                pictureBoxPM.Enabled = true;
                btnPM_Anim.Text = "Stop";
                btnPM_Anim.Refresh();
                isRunningPM = true;
            }
            else
            {
                pictureBoxPM.Enabled = false;
                btnPM_Anim.Text = "Start";
                btnPM_Anim.Refresh();
                isRunningPM = false;
            }
        }
    }
}

using System;
using System.Windows.Forms;

namespace Mazur_NAT_T.Forms
{
    public partial class FormAnimations : Form
    {
        public FormAnimations()
        {
            InitializeComponent();
        }

        private void FormAnimations_Load(object sender, EventArgs e)
        {

        }

        private void btnHP_Anim_Click(object sender, EventArgs e)
        {
            pictureBoxHP.Enabled = true;
        }

        private void btnPM_Anim_Click(object sender, EventArgs e)
        {
            pictureBoxPM.Enabled = true;
        }
    }
}

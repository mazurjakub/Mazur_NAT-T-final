
namespace Mazur_NAT_T
{
    partial class MainMenuView
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuView));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnText = new System.Windows.Forms.Button();
            this.btnPM = new System.Windows.Forms.Button();
            this.btnHP = new System.Windows.Forms.Button();
            this.btnNAT = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelAppName = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblTextIntro = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.panelMenu.Controls.Add(this.btnEnd);
            this.panelMenu.Controls.Add(this.btnText);
            this.panelMenu.Controls.Add(this.btnPM);
            this.panelMenu.Controls.Add(this.btnHP);
            this.panelMenu.Controls.Add(this.btnNAT);
            this.panelMenu.Controls.Add(this.panelLogo);
            resources.ApplyResources(this.panelMenu, "panelMenu");
            this.panelMenu.Name = "panelMenu";
            // 
            // btnEnd
            // 
            this.btnEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnEnd, "btnEnd");
            this.btnEnd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnText
            // 
            this.btnText.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnText, "btnText");
            this.btnText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnText.Name = "btnText";
            this.btnText.UseVisualStyleBackColor = true;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // btnPM
            // 
            this.btnPM.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnPM, "btnPM");
            this.btnPM.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPM.Name = "btnPM";
            this.btnPM.UseVisualStyleBackColor = true;
            this.btnPM.Click += new System.EventHandler(this.btnPM_Click);
            // 
            // btnHP
            // 
            this.btnHP.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnHP, "btnHP");
            this.btnHP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHP.Name = "btnHP";
            this.btnHP.UseVisualStyleBackColor = true;
            this.btnHP.Click += new System.EventHandler(this.btnHP_Click);
            // 
            // btnNAT
            // 
            this.btnNAT.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnNAT, "btnNAT");
            this.btnNAT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNAT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNAT.Name = "btnNAT";
            this.btnNAT.UseVisualStyleBackColor = true;
            this.btnNAT.Click += new System.EventHandler(this.btnNAT_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.panelLogo.Controls.Add(this.labelAppName);
            resources.ApplyResources(this.panelLogo, "panelLogo");
            this.panelLogo.Name = "panelLogo";
            // 
            // labelAppName
            // 
            resources.ApplyResources(this.labelAppName, "labelAppName");
            this.labelAppName.ForeColor = System.Drawing.Color.White;
            this.labelAppName.Name = "labelAppName";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            resources.ApplyResources(this.panelTitleBar, "panelTitleBar");
            this.panelTitleBar.ForeColor = System.Drawing.SystemColors.Control;
            this.panelTitleBar.Name = "panelTitleBar";
            // 
            // btnCloseChildForm
            // 
            resources.ApplyResources(this.btnCloseChildForm, "btnCloseChildForm");
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.Image = global::Mazur_NAT_T.Properties.Resources.cross11;
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.Name = "lblTitle";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.lblTextIntro);
            this.panelMain.Controls.Add(this.lblAutor);
            this.panelMain.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panelMain, "panelMain");
            this.panelMain.Name = "panelMain";
            // 
            // lblTextIntro
            // 
            resources.ApplyResources(this.lblTextIntro, "lblTextIntro");
            this.lblTextIntro.Name = "lblTextIntro";
            // 
            // lblAutor
            // 
            resources.ApplyResources(this.lblAutor, "lblAutor");
            this.lblAutor.Name = "lblAutor";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::Mazur_NAT_T.Properties.Resources.UpolLOgo;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // FormMainMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMainMenu";
            this.ShowIcon = false;
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnText;
        private System.Windows.Forms.Button btnPM;
        private System.Windows.Forms.Button btnHP;
        private System.Windows.Forms.Button btnNAT;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label labelAppName;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblTextIntro;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}


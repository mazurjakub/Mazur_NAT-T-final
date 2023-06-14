
namespace Mazur_NAT_T.Forms
{
    partial class FormAnimations
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelAnimations = new System.Windows.Forms.Panel();
            this.pictureBoxHP = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIntroText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxPM = new System.Windows.Forms.PictureBox();
            this.btnHP_Anim = new System.Windows.Forms.Button();
            this.btnPM_Anim = new System.Windows.Forms.Button();
            this.panelAnimations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPM)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAnimations
            // 
            this.panelAnimations.AutoScroll = true;
            this.panelAnimations.BackColor = System.Drawing.Color.White;
            this.panelAnimations.Controls.Add(this.btnPM_Anim);
            this.panelAnimations.Controls.Add(this.btnHP_Anim);
            this.panelAnimations.Controls.Add(this.pictureBoxPM);
            this.panelAnimations.Controls.Add(this.label2);
            this.panelAnimations.Controls.Add(this.panel1);
            this.panelAnimations.Controls.Add(this.pictureBoxHP);
            this.panelAnimations.Controls.Add(this.label1);
            this.panelAnimations.Controls.Add(this.lblIntroText);
            this.panelAnimations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAnimations.Location = new System.Drawing.Point(0, 0);
            this.panelAnimations.Name = "panelAnimations";
            this.panelAnimations.Size = new System.Drawing.Size(888, 532);
            this.panelAnimations.TabIndex = 0;
            // 
            // pictureBoxHP
            // 
            this.pictureBoxHP.Enabled = false;
            this.pictureBoxHP.Image = global::Mazur_NAT_T.Properties.Resources.UDP_HolePunching;
            this.pictureBoxHP.Location = new System.Drawing.Point(128, 76);
            this.pictureBoxHP.Name = "pictureBoxHP";
            this.pictureBoxHP.Size = new System.Drawing.Size(640, 396);
            this.pictureBoxHP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHP.TabIndex = 3;
            this.pictureBoxHP.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(356, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hole Punching\r\n";
            // 
            // lblIntroText
            // 
            this.lblIntroText.AutoSize = true;
            this.lblIntroText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIntroText.Location = new System.Drawing.Point(143, 9);
            this.lblIntroText.Name = "lblIntroText";
            this.lblIntroText.Size = new System.Drawing.Size(601, 18);
            this.lblIntroText.TabIndex = 1;
            this.lblIntroText.Text = "Tato stránka obsahuje animace simulující jednotlivé metody demonstrované v této a" +
    "plikaci.";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(803, 417);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(56, 592);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(357, 529);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port Mapping";
            // 
            // pictureBoxPM
            // 
            this.pictureBoxPM.Enabled = false;
            this.pictureBoxPM.Image = global::Mazur_NAT_T.Properties.Resources.PortMapping;
            this.pictureBoxPM.Location = new System.Drawing.Point(-57, 577);
            this.pictureBoxPM.Name = "pictureBoxPM";
            this.pictureBoxPM.Size = new System.Drawing.Size(917, 291);
            this.pictureBoxPM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPM.TabIndex = 6;
            this.pictureBoxPM.TabStop = false;
            // 
            // btnHP_Anim
            // 
            this.btnHP_Anim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.btnHP_Anim.ForeColor = System.Drawing.Color.White;
            this.btnHP_Anim.Location = new System.Drawing.Point(707, 471);
            this.btnHP_Anim.Name = "btnHP_Anim";
            this.btnHP_Anim.Size = new System.Drawing.Size(90, 36);
            this.btnHP_Anim.TabIndex = 7;
            this.btnHP_Anim.Text = "Spustit";
            this.btnHP_Anim.UseVisualStyleBackColor = false;
            this.btnHP_Anim.Click += new System.EventHandler(this.btnHP_Anim_Click);
            // 
            // btnPM_Anim
            // 
            this.btnPM_Anim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.btnPM_Anim.ForeColor = System.Drawing.Color.White;
            this.btnPM_Anim.Location = new System.Drawing.Point(707, 870);
            this.btnPM_Anim.Name = "btnPM_Anim";
            this.btnPM_Anim.Size = new System.Drawing.Size(90, 36);
            this.btnPM_Anim.TabIndex = 8;
            this.btnPM_Anim.Text = "Spustit";
            this.btnPM_Anim.UseVisualStyleBackColor = false;
            this.btnPM_Anim.Click += new System.EventHandler(this.btnPM_Anim_Click);
            // 
            // FormAnimations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 532);
            this.Controls.Add(this.panelAnimations);
            this.Name = "FormAnimations";
            this.Text = "Animace";
            this.Load += new System.EventHandler(this.FormAnimations_Load);
            this.panelAnimations.ResumeLayout(false);
            this.panelAnimations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAnimations;
        private System.Windows.Forms.Label lblIntroText;
        private System.Windows.Forms.PictureBox pictureBoxHP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxPM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHP_Anim;
        private System.Windows.Forms.Button btnPM_Anim;
    }
}
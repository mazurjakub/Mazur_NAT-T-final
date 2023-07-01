
namespace Mazur_NAT_T.Views
{
    partial class PortMappingView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortMappingView));
            this.btnMapping = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCanYouSeeMe = new System.Windows.Forms.LinkLabel();
            this.txtBoxMappingName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblExtPort = new System.Windows.Forms.Label();
            this.txtBoxExternalPort = new System.Windows.Forms.TextBox();
            this.lblIntPort = new System.Windows.Forms.Label();
            this.txtBoxInternalPort = new System.Windows.Forms.TextBox();
            this.btnDeleteMapping = new System.Windows.Forms.Button();
            this.checkBoxMappings = new System.Windows.Forms.CheckedListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnMapping
            // 
            this.btnMapping.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMapping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.btnMapping.FlatAppearance.BorderSize = 0;
            this.btnMapping.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMapping.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMapping.Location = new System.Drawing.Point(68, 382);
            this.btnMapping.Name = "btnMapping";
            this.btnMapping.Size = new System.Drawing.Size(140, 61);
            this.btnMapping.TabIndex = 5;
            this.btnMapping.Text = "Vytvořit mapování";
            this.btnMapping.UseVisualStyleBackColor = false;
            this.btnMapping.Click += new System.EventHandler(this.btnMapping_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(881, 98);
            this.label1.TabIndex = 6;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // lblCanYouSeeMe
            // 
            this.lblCanYouSeeMe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCanYouSeeMe.AutoSize = true;
            this.lblCanYouSeeMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCanYouSeeMe.Location = new System.Drawing.Point(472, 58);
            this.lblCanYouSeeMe.Name = "lblCanYouSeeMe";
            this.lblCanYouSeeMe.Size = new System.Drawing.Size(212, 18);
            this.lblCanYouSeeMe.TabIndex = 7;
            this.lblCanYouSeeMe.TabStop = true;
            this.lblCanYouSeeMe.Text = "https://www.canyouseeme.org/";
            // 
            // txtBoxMappingName
            // 
            this.txtBoxMappingName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxMappingName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxMappingName.Location = new System.Drawing.Point(108, 263);
            this.txtBoxMappingName.Name = "txtBoxMappingName";
            this.txtBoxMappingName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMappingName.TabIndex = 8;
            this.txtBoxMappingName.Text = "Test";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(10, 266);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(92, 13);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Název mapování:";
            // 
            // lblExtPort
            // 
            this.lblExtPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblExtPort.AutoSize = true;
            this.lblExtPort.Location = new System.Drawing.Point(37, 303);
            this.lblExtPort.Name = "lblExtPort";
            this.lblExtPort.Size = new System.Drawing.Size(65, 13);
            this.lblExtPort.TabIndex = 11;
            this.lblExtPort.Text = "Externí port:";
            // 
            // txtBoxExternalPort
            // 
            this.txtBoxExternalPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxExternalPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxExternalPort.Location = new System.Drawing.Point(108, 300);
            this.txtBoxExternalPort.Name = "txtBoxExternalPort";
            this.txtBoxExternalPort.Size = new System.Drawing.Size(100, 20);
            this.txtBoxExternalPort.TabIndex = 10;
            this.txtBoxExternalPort.Text = "1702";
            // 
            // lblIntPort
            // 
            this.lblIntPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIntPort.AutoSize = true;
            this.lblIntPort.Location = new System.Drawing.Point(40, 339);
            this.lblIntPort.Name = "lblIntPort";
            this.lblIntPort.Size = new System.Drawing.Size(62, 13);
            this.lblIntPort.TabIndex = 13;
            this.lblIntPort.Text = "Interní port:";
            // 
            // txtBoxInternalPort
            // 
            this.txtBoxInternalPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxInternalPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxInternalPort.Location = new System.Drawing.Point(108, 336);
            this.txtBoxInternalPort.Name = "txtBoxInternalPort";
            this.txtBoxInternalPort.Size = new System.Drawing.Size(100, 20);
            this.txtBoxInternalPort.TabIndex = 12;
            this.txtBoxInternalPort.Text = "1602";
            // 
            // btnDeleteMapping
            // 
            this.btnDeleteMapping.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteMapping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.btnDeleteMapping.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteMapping.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteMapping.Location = new System.Drawing.Point(724, 382);
            this.btnDeleteMapping.Name = "btnDeleteMapping";
            this.btnDeleteMapping.Size = new System.Drawing.Size(148, 61);
            this.btnDeleteMapping.TabIndex = 17;
            this.btnDeleteMapping.Text = "Odstranit vybraná mapování";
            this.btnDeleteMapping.UseVisualStyleBackColor = false;
            this.btnDeleteMapping.Click += new System.EventHandler(this.btnDeleteMapping_Click);
            // 
            // checkBoxMappings
            // 
            this.checkBoxMappings.AccessibleDescription = "Seznam existujících mapování";
            this.checkBoxMappings.AccessibleName = "Seznam existujících mapování";
            this.checkBoxMappings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxMappings.FormattingEnabled = true;
            this.checkBoxMappings.Items.AddRange(new object[] {
            "IP NAT zařízení + externí port -> IP tohoto zařízení + interní port"});
            this.checkBoxMappings.Location = new System.Drawing.Point(256, 127);
            this.checkBoxMappings.MaximumSize = new System.Drawing.Size(616, 232);
            this.checkBoxMappings.MinimumSize = new System.Drawing.Size(616, 232);
            this.checkBoxMappings.Name = "checkBoxMappings";
            this.checkBoxMappings.Size = new System.Drawing.Size(616, 232);
            this.checkBoxMappings.TabIndex = 21;
            // 
            // PortMappingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 455);
            this.Controls.Add(this.checkBoxMappings);
            this.Controls.Add(this.btnDeleteMapping);
            this.Controls.Add(this.lblIntPort);
            this.Controls.Add(this.txtBoxInternalPort);
            this.Controls.Add(this.lblExtPort);
            this.Controls.Add(this.txtBoxExternalPort);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtBoxMappingName);
            this.Controls.Add(this.lblCanYouSeeMe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMapping);
            this.MinimumSize = new System.Drawing.Size(800, 39);
            this.Name = "PortMappingView";
            this.Text = "Port Mapping";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMapping;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblCanYouSeeMe;
        private System.Windows.Forms.TextBox txtBoxMappingName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblExtPort;
        private System.Windows.Forms.TextBox txtBoxExternalPort;
        private System.Windows.Forms.Label lblIntPort;
        private System.Windows.Forms.TextBox txtBoxInternalPort;
        private System.Windows.Forms.Button btnDeleteMapping;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckedListBox checkBoxMappings;
    }
}
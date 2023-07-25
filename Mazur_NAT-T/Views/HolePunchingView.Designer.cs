
namespace Mazur_NAT_T.Views
{
    partial class HolePunchingView
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
            this.panelHP = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.txtBoxMessage = new System.Windows.Forms.TextBox();
            this.txtBoxOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.panelHP.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHP
            // 
            this.panelHP.BackColor = System.Drawing.Color.White;
            this.panelHP.Controls.Add(this.label3);
            this.panelHP.Controls.Add(this.btnSendMessage);
            this.panelHP.Controls.Add(this.txtBoxMessage);
            this.panelHP.Controls.Add(this.txtBoxOutput);
            this.panelHP.Controls.Add(this.label1);
            this.panelHP.Controls.Add(this.txtBoxKey);
            this.panelHP.Controls.Add(this.label2);
            this.panelHP.Controls.Add(this.btnConnect);
            this.panelHP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHP.Location = new System.Drawing.Point(0, 0);
            this.panelHP.Name = "panelHP";
            this.panelHP.Size = new System.Drawing.Size(888, 504);
            this.panelHP.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(21, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Zpráva:";
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.btnSendMessage.FlatAppearance.BorderSize = 0;
            this.btnSendMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSendMessage.ForeColor = System.Drawing.Color.White;
            this.btnSendMessage.Location = new System.Drawing.Point(471, 393);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(140, 61);
            this.btnSendMessage.TabIndex = 10;
            this.btnSendMessage.Text = "Odeslat zprávu";
            this.btnSendMessage.UseVisualStyleBackColor = false;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // txtBoxMessage
            // 
            this.txtBoxMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBoxMessage.Location = new System.Drawing.Point(84, 444);
            this.txtBoxMessage.MaximumSize = new System.Drawing.Size(381, 29);
            this.txtBoxMessage.MinimumSize = new System.Drawing.Size(381, 29);
            this.txtBoxMessage.Name = "txtBoxMessage";
            this.txtBoxMessage.Size = new System.Drawing.Size(381, 24);
            this.txtBoxMessage.TabIndex = 9;
            // 
            // txtBoxOutput
            // 
            this.txtBoxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxOutput.Location = new System.Drawing.Point(15, 69);
            this.txtBoxOutput.MaximumSize = new System.Drawing.Size(550, 300);
            this.txtBoxOutput.MinimumSize = new System.Drawing.Size(550, 300);
            this.txtBoxOutput.Multiline = true;
            this.txtBoxOutput.Name = "txtBoxOutput";
            this.txtBoxOutput.ReadOnly = true;
            this.txtBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxOutput.Size = new System.Drawing.Size(550, 300);
            this.txtBoxOutput.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(706, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Klíč:";
            // 
            // txtBoxKey
            // 
            this.txtBoxKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxKey.Location = new System.Drawing.Point(741, 367);
            this.txtBoxKey.Name = "txtBoxKey";
            this.txtBoxKey.Size = new System.Drawing.Size(100, 20);
            this.txtBoxKey.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.MaximumSize = new System.Drawing.Size(700, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(644, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tato demonstrace umožňuje navázat spojení mezi dvěma klienty pomocí metody Hole P" +
    "unching.\r\nZadejte u obou klientů stejný klíč (1-999), aby mohlo vzniknou peer-to" +
    "-peer spojení.";
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(173)))));
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(701, 393);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(140, 61);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Odeslat klíč";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // HolePunchingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 504);
            this.Controls.Add(this.panelHP);
            this.Name = "HolePunchingView";
            this.Text = "Hole Punching";
            this.panelHP.ResumeLayout(false);
            this.panelHP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHP;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxKey;
        internal System.Windows.Forms.TextBox txtBoxOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.TextBox txtBoxMessage;
    }
}
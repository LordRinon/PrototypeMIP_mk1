namespace PrototypeMIP_mk1
{
    partial class Form1
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
            this.btnSAVE = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.richtxtBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSAVE
            // 
            this.btnSAVE.Location = new System.Drawing.Point(70, 76);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(75, 23);
            this.btnSAVE.TabIndex = 1;
            this.btnSAVE.Text = "Save";
            this.btnSAVE.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(70, 298);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // richtxtBox
            // 
            this.richtxtBox.Location = new System.Drawing.Point(215, 65);
            this.richtxtBox.Name = "richtxtBox";
            this.richtxtBox.Size = new System.Drawing.Size(175, 126);
            this.richtxtBox.TabIndex = 3;
            this.richtxtBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richtxtBox);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSAVE);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSAVE;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.RichTextBox richtxtBox;
    }
}


namespace PrototypeMIP_mk1
{
    partial class AlphaEditor
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
            this.btnSAVE.Location = new System.Drawing.Point(35, 561);
            this.btnSAVE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(88, 28);
            this.btnSAVE.TabIndex = 1;
            this.btnSAVE.Text = "Save";
            this.btnSAVE.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(35, 620);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(88, 28);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // richtxtBox
            // 
            this.richtxtBox.Location = new System.Drawing.Point(188, 15);
            this.richtxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richtxtBox.Name = "richtxtBox";
            this.richtxtBox.Size = new System.Drawing.Size(436, 651);
            this.richtxtBox.TabIndex = 3;
            this.richtxtBox.Text = "";
            // 
            // AlphaEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(638, 682);
            this.Controls.Add(this.richtxtBox);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSAVE);
            this.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AlphaEditor";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "temp // folder opened";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSAVE;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.RichTextBox richtxtBox;
    }
}


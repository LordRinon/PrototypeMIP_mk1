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
            this.components = new System.ComponentModel.Container();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.richtxtBox = new System.Windows.Forms.RichTextBox();
            this.treeV = new System.Windows.Forms.TreeView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnSAVE
            // 
            this.btnSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSAVE.Location = new System.Drawing.Point(12, 636);
            this.btnSAVE.Margin = new System.Windows.Forms.Padding(4);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(167, 30);
            this.btnSAVE.TabIndex = 1;
            this.btnSAVE.Text = "Save";
            this.btnSAVE.UseVisualStyleBackColor = true;
            this.btnSAVE.Click += new System.EventHandler(this.btnSAVE_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(12, 468);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(168, 30);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // richtxtBox
            // 
            this.richtxtBox.Location = new System.Drawing.Point(188, 15);
            this.richtxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.richtxtBox.Name = "richtxtBox";
            this.richtxtBox.Size = new System.Drawing.Size(436, 651);
            this.richtxtBox.TabIndex = 3;
            this.richtxtBox.Text = "";
            this.richtxtBox.TextChanged += new System.EventHandler(this.richtxtBox_TextChanged);
            // 
            // treeV
            // 
            this.treeV.Location = new System.Drawing.Point(12, 15);
            this.treeV.Name = "treeV";
            this.treeV.Size = new System.Drawing.Size(169, 446);
            this.treeV.TabIndex = 4;
            this.treeV.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeV_NodeMouseDoubleClick);
            this.treeV.MouseMove += new System.Windows.Forms.MouseEventHandler(this.treeV_MouseMove);
            // 
            // AlphaEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(638, 682);
            this.Controls.Add(this.treeV);
            this.Controls.Add(this.richtxtBox);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSAVE);
            this.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AlphaEditor";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "temp // folder opened";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSAVE;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.RichTextBox richtxtBox;
        private System.Windows.Forms.TreeView treeV;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


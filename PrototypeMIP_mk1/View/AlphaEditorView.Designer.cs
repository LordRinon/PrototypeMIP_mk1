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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlphaEditor));
            this.btnSAVE = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.richtxtBox = new System.Windows.Forms.RichTextBox();
            this.treeV = new System.Windows.Forms.TreeView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnSAVE
            // 
            resources.ApplyResources(this.btnSAVE, "btnSAVE");
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.UseVisualStyleBackColor = true;
            this.btnSAVE.Click += new System.EventHandler(this.btnSAVE_Click);
            // 
            // btnUpdate
            // 
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // richtxtBox
            // 
            resources.ApplyResources(this.richtxtBox, "richtxtBox");
            this.richtxtBox.Name = "richtxtBox";
            this.richtxtBox.TextChanged += new System.EventHandler(this.richtxtBox_TextChanged);
            // 
            // treeV
            // 
            resources.ApplyResources(this.treeV, "treeV");
            this.treeV.Name = "treeV";
            this.treeV.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeV_NodeMouseDoubleClick);
            this.treeV.MouseMove += new System.Windows.Forms.MouseEventHandler(this.treeV_MouseMove);
            // 
            // AlphaEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.treeV);
            this.Controls.Add(this.richtxtBox);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSAVE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AlphaEditor";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
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


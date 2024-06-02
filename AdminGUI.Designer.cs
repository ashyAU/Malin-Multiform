namespace Malin_Multiform
{
    partial class AdminGUI
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
            textBoxAdminID = new TextBox();
            textBoxAdminName = new TextBox();
            groupBox1 = new GroupBox();
            lblAdminDelete = new Label();
            lblAdminAdd = new Label();
            lblAdminUpdate = new Label();
            lblClosePanel = new Label();
            lblAdminID = new Label();
            lblAdminName = new Label();
            adminStrip = new StatusStrip();
            adminStripLabel = new ToolStripStatusLabel();
            groupBox1.SuspendLayout();
            adminStrip.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxAdminID
            // 
            textBoxAdminID.Location = new Point(12, 46);
            textBoxAdminID.Name = "textBoxAdminID";
            textBoxAdminID.ReadOnly = true;
            textBoxAdminID.Size = new Size(250, 27);
            textBoxAdminID.TabIndex = 0;
            textBoxAdminID.TabStop = false;
            // 
            // textBoxAdminName
            // 
            textBoxAdminName.Location = new Point(12, 105);
            textBoxAdminName.Name = "textBoxAdminName";
            textBoxAdminName.Size = new Size(250, 27);
            textBoxAdminName.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblAdminDelete);
            groupBox1.Controls.Add(lblAdminAdd);
            groupBox1.Controls.Add(lblAdminUpdate);
            groupBox1.Controls.Add(lblClosePanel);
            groupBox1.Location = new Point(12, 150);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 136);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // lblAdminDelete
            // 
            lblAdminDelete.AutoSize = true;
            lblAdminDelete.Location = new Point(6, 113);
            lblAdminDelete.Name = "lblAdminDelete";
            lblAdminDelete.Size = new Size(191, 20);
            lblAdminDelete.TabIndex = 3;
            lblAdminDelete.Text = "Alt E - Delete Current Entry ";
            // 
            // lblAdminAdd
            // 
            lblAdminAdd.AutoSize = true;
            lblAdminAdd.Location = new Point(6, 83);
            lblAdminAdd.Name = "lblAdminAdd";
            lblAdminAdd.Size = new Size(159, 20);
            lblAdminAdd.TabIndex = 2;
            lblAdminAdd.Text = "Alt W - Add New Entry";
            // 
            // lblAdminUpdate
            // 
            lblAdminUpdate.AutoSize = true;
            lblAdminUpdate.Location = new Point(6, 52);
            lblAdminUpdate.Name = "lblAdminUpdate";
            lblAdminUpdate.Size = new Size(150, 20);
            lblAdminUpdate.TabIndex = 1;
            lblAdminUpdate.Text = "Alt Q - Update Name";
            // 
            // lblClosePanel
            // 
            lblClosePanel.AutoSize = true;
            lblClosePanel.Location = new Point(6, 23);
            lblClosePanel.Name = "lblClosePanel";
            lblClosePanel.Size = new Size(176, 20);
            lblClosePanel.TabIndex = 0;
            lblClosePanel.Text = "Alt L - Close Admin Panel";
            // 
            // lblAdminID
            // 
            lblAdminID.AutoSize = true;
            lblAdminID.Location = new Point(12, 23);
            lblAdminID.Name = "lblAdminID";
            lblAdminID.Size = new Size(59, 20);
            lblAdminID.TabIndex = 3;
            lblAdminID.Text = "Staff ID";
            // 
            // lblAdminName
            // 
            lblAdminName.AutoSize = true;
            lblAdminName.Location = new Point(12, 82);
            lblAdminName.Name = "lblAdminName";
            lblAdminName.Size = new Size(84, 20);
            lblAdminName.TabIndex = 4;
            lblAdminName.Text = "Staff Name";
            // 
            // adminStrip
            // 
            adminStrip.ImageScalingSize = new Size(20, 20);
            adminStrip.Items.AddRange(new ToolStripItem[] { adminStripLabel });
            adminStrip.Location = new Point(0, 294);
            adminStrip.Name = "adminStrip";
            adminStrip.Size = new Size(278, 24);
            adminStrip.TabIndex = 5;
            // 
            // adminStripLabel
            // 
            adminStripLabel.Name = "adminStripLabel";
            adminStripLabel.Size = new Size(0, 18);
            // 
            // AdminGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 318);
            Controls.Add(adminStrip);
            Controls.Add(lblAdminName);
            Controls.Add(lblAdminID);
            Controls.Add(groupBox1);
            Controls.Add(textBoxAdminName);
            Controls.Add(textBoxAdminID);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "AdminGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Panel";
            KeyDown += AdminGUI_KeyPress;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            adminStrip.ResumeLayout(false);
            adminStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAdminID;
        private TextBox textBoxAdminName;
        private GroupBox groupBox1;
        private Label lblAdminID;
        private Label lblAdminName;
        private Label lblAdminDelete;
        private Label lblAdminAdd;
        private Label lblAdminUpdate;
        private Label lblClosePanel;
        private StatusStrip adminStrip;
        private ToolStripStatusLabel adminStripLabel;
    }
}
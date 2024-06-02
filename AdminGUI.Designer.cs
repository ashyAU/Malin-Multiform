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
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBoxAdminID
            // 
            textBoxAdminID.Location = new Point(12, 46);
            textBoxAdminID.Name = "textBoxAdminID";
            textBoxAdminID.Size = new Size(250, 27);
            textBoxAdminID.TabIndex = 0;
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
            groupBox1.Location = new Point(12, 161);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // AdminGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 298);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(textBoxAdminName);
            Controls.Add(textBoxAdminID);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "AdminGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Panel";
            KeyDown += AdminGUI_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAdminID;
        private TextBox textBoxAdminName;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
    }
}
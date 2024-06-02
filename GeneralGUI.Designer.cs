namespace Malin_Multiform
{
    partial class GeneralGUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListboxCSV = new ListBox();
            ListBoxFiltered = new ListBox();
            textBoxFilterID = new TextBox();
            lblFilterID = new Label();
            groupBox1 = new GroupBox();
            lblCSV = new Label();
            lblResults = new Label();
            statusStrip1 = new StatusStrip();
            lblFilterName = new Label();
            textBoxFilterName = new TextBox();
            SuspendLayout();
            // 
            // ListboxCSV
            // 
            ListboxCSV.FormattingEnabled = true;
            ListboxCSV.Location = new Point(12, 32);
            ListboxCSV.Name = "ListboxCSV";
            ListboxCSV.Size = new Size(212, 384);
            ListboxCSV.TabIndex = 0;
            // 
            // ListBoxFiltered
            // 
            ListBoxFiltered.FormattingEnabled = true;
            ListBoxFiltered.Location = new Point(237, 172);
            ListBoxFiltered.Name = "ListBoxFiltered";
            ListBoxFiltered.Size = new Size(212, 244);
            ListBoxFiltered.TabIndex = 1;
            // 
            // textBoxFilterID
            // 
            textBoxFilterID.Location = new Point(237, 35);
            textBoxFilterID.Name = "textBoxFilterID";
            textBoxFilterID.Size = new Size(212, 27);
            textBoxFilterID.TabIndex = 2;
            textBoxFilterID.TextChanged += textBoxFilterID_TextChanged;
            // 
            // lblFilterID
            // 
            lblFilterID.AutoSize = true;
            lblFilterID.Location = new Point(237, 12);
            lblFilterID.Name = "lblFilterID";
            lblFilterID.Size = new Size(81, 20);
            lblFilterID.TabIndex = 3;
            lblFilterID.Text = "Filter by ID";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(468, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(212, 384);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // lblCSV
            // 
            lblCSV.AutoSize = true;
            lblCSV.Location = new Point(12, 12);
            lblCSV.Name = "lblCSV";
            lblCSV.Size = new Size(61, 20);
            lblCSV.TabIndex = 5;
            lblCSV.Text = "All Keys";
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Location = new Point(237, 149);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(109, 20);
            lblResults.TabIndex = 6;
            lblResults.Text = "Filtered Results";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Location = new Point(0, 446);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(724, 22);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblFilterName
            // 
            lblFilterName.AutoSize = true;
            lblFilterName.Location = new Point(237, 73);
            lblFilterName.Name = "lblFilterName";
            lblFilterName.Size = new Size(106, 20);
            lblFilterName.TabIndex = 9;
            lblFilterName.Text = "Filter by Name";
            // 
            // textBoxFilterName
            // 
            textBoxFilterName.Location = new Point(237, 96);
            textBoxFilterName.Name = "textBoxFilterName";
            textBoxFilterName.Size = new Size(212, 27);
            textBoxFilterName.TabIndex = 8;
            textBoxFilterName.TextChanged += textBoxFilterName_TextChanged;
            // 
            // GeneralGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 468);
            Controls.Add(lblFilterName);
            Controls.Add(textBoxFilterName);
            Controls.Add(statusStrip1);
            Controls.Add(lblResults);
            Controls.Add(lblCSV);
            Controls.Add(groupBox1);
            Controls.Add(lblFilterID);
            Controls.Add(textBoxFilterID);
            Controls.Add(ListBoxFiltered);
            Controls.Add(ListboxCSV);
            Name = "GeneralGUI";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListboxCSV;
        private ListBox ListBoxFiltered;
        private TextBox textBoxFilterID;
        private Label lblFilterID;
        private GroupBox groupBox1;
        private Label lblCSV;
        private Label lblResults;
        private StatusStrip statusStrip1;
        private Label lblFilterName;
        private TextBox textBoxFilterName;
    }
}

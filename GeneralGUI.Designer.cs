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
            groupBoxBinds = new GroupBox();
            lblOpenPanel = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblCSV = new Label();
            lblResults = new Label();
            statusStrip1 = new StatusStrip();
            lblFilterName = new Label();
            textBoxFilterName = new TextBox();
            groupBoxBinds.SuspendLayout();
            SuspendLayout();
            // 
            // ListboxCSV
            // 
            ListboxCSV.FormattingEnabled = true;
            ListboxCSV.Location = new Point(12, 32);
            ListboxCSV.Name = "ListboxCSV";
            ListboxCSV.Size = new Size(212, 384);
            ListboxCSV.TabIndex = 0;
            ListboxCSV.TabStop = false;
            // 
            // ListBoxFiltered
            // 
            ListBoxFiltered.FormattingEnabled = true;
            ListBoxFiltered.Location = new Point(237, 172);
            ListBoxFiltered.Name = "ListBoxFiltered";
            ListBoxFiltered.Size = new Size(212, 244);
            ListBoxFiltered.TabIndex = 2;
            ListBoxFiltered.KeyPress += ListBoxFiltered_KeyPress;
            // 
            // textBoxFilterID
            // 
            textBoxFilterID.Location = new Point(237, 35);
            textBoxFilterID.Name = "textBoxFilterID";
            textBoxFilterID.Size = new Size(212, 27);
            textBoxFilterID.TabIndex = 0;
            textBoxFilterID.TextChanged += TextBoxFilterID_TextChanged;
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
            // groupBoxBinds
            // 
            groupBoxBinds.Controls.Add(lblOpenPanel);
            groupBoxBinds.Controls.Add(label4);
            groupBoxBinds.Controls.Add(label3);
            groupBoxBinds.Controls.Add(label2);
            groupBoxBinds.Controls.Add(label1);
            groupBoxBinds.Location = new Point(468, 32);
            groupBoxBinds.Name = "groupBoxBinds";
            groupBoxBinds.Size = new Size(244, 191);
            groupBoxBinds.TabIndex = 4;
            groupBoxBinds.TabStop = false;
            groupBoxBinds.Text = "Keybinds";
            // 
            // lblOpenPanel
            // 
            lblOpenPanel.AutoSize = true;
            lblOpenPanel.Location = new Point(6, 126);
            lblOpenPanel.Name = "lblOpenPanel";
            lblOpenPanel.Size = new Size(185, 20);
            lblOpenPanel.TabIndex = 4;
            lblOpenPanel.Text = "Alt A - Opens Admin Panel";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 156);
            label4.Name = "label4";
            label4.Size = new Size(226, 20);
            label4.TabIndex = 3;
            label4.Text = "ID Field = 77 - Creates New Staff";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 94);
            label3.Name = "label3";
            label3.Size = new Size(189, 20);
            label3.TabIndex = 2;
            label3.Text = "Enter - Display in Text Field";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 64);
            label2.Name = "label2";
            label2.Size = new Size(187, 20);
            label2.TabIndex = 1;
            label2.Text = "Alt W - Selects Name Filter";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(159, 20);
            label1.TabIndex = 0;
            label1.Text = "Alt Q - Selects ID Filter";
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
            textBoxFilterName.TabIndex = 1;
            textBoxFilterName.TextChanged += TextBoxFilterName_TextChanged;
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
            Controls.Add(groupBoxBinds);
            Controls.Add(lblFilterID);
            Controls.Add(textBoxFilterID);
            Controls.Add(ListBoxFiltered);
            Controls.Add(ListboxCSV);
            ImeMode = ImeMode.Off;
            KeyPreview = true;
            Name = "GeneralGUI";
            Text = "General Panel";
            KeyDown += GeneralGUI_KeyPress;
            groupBoxBinds.ResumeLayout(false);
            groupBoxBinds.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListboxCSV;
        private ListBox ListBoxFiltered;
        private TextBox textBoxFilterID;
        private Label lblFilterID;
        private GroupBox groupBoxBinds;
        private Label lblCSV;
        private Label lblResults;
        private StatusStrip statusStrip1;
        private Label lblFilterName;
        private TextBox textBoxFilterName;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label lblOpenPanel;
    }
}

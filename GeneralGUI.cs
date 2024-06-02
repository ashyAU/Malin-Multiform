﻿using System.Text.RegularExpressions;

namespace Malin_Multiform
{
    public partial class GeneralGUI : Form
    {
        public GeneralGUI()
        {
            InitializeComponent();
            ListboxAddAll();
        }
        public static Dictionary<int, string> MasterFile = [];

        private static void ReadCSV()
        {
            using var reader = new StreamReader(@"MalinStaffNamesV3.csv");
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                if (line != null)
                {
                    var values = line.Split(',');
                    MasterFile.Add(int.Parse(values[0]), values[1]);
                }
            }
        }

        private void ListboxAddAll()
        {
            ReadCSV();
            foreach (var item in MasterFile)
            {
                ListboxCSV.Items.Add($"{item.Value}, {item.Key}");
            }
        }


        private void Filter(TextBox textBox)
        {
            var match = new List<KeyValuePair<int, string>>();
            ListBoxFiltered.Items.Clear();
            switch (textBox.Name)
            {
                case "textBoxFilterID":
                    match = MasterFile.Where(item => item.Key.ToString().StartsWith(textBox.Text)).ToList();
                    break;

                case "textBoxFilterName":
                    match = MasterFile.Where(item => item.Value.ToString().StartsWith(textBox.Text, StringComparison.CurrentCultureIgnoreCase)).ToList();
                    break;
            }

            if (textBox.Text != "")
            {
                foreach (var item in match)
                {
                    ListBoxFiltered.Items.Add($"{item.Value}, {item.Key}");
                }
            }


        }
        private void textBoxFilterID_TextChanged(object sender, EventArgs e)
        {
            Filter(textBoxFilterID);
        }
        private void textBoxFilterName_TextChanged(object sender, EventArgs e)
        {
            Filter(textBoxFilterName);
        }

        private void GeneralGUI_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.Alt)
            {
                if (e.KeyCode == Keys.Q)
                {
                    FocusIDTextbox();
                }
                if (e.KeyCode == Keys.W)
                {
                    FocusNameTextBox();
                }
            }
        }



        private void FocusIDTextbox()
        {
            textBoxFilterID.Clear();
            textBoxFilterID.Select();
        }
        private void FocusNameTextBox()
        {
            textBoxFilterName.Clear();
            textBoxFilterName.Select();
        }
        private void DisplayFilterData()
        {

            string? item = ListBoxFiltered.GetItemText(ListBoxFiltered.SelectedItem);

            if (item != null)
            {
                var data = item.Split(',');

                textBoxFilterName.Text = data[0];
                textBoxFilterID.Text = data[1];
            }
        }


        private void ListBoxFiltered_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                DisplayFilterData();
            }
        }
    }
}

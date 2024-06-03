using Microsoft.VisualBasic.FileIO;
using System.Net.Http.Headers;
using System.Globalization;
using System.Diagnostics;

namespace Malin_Multiform
{
    public partial class GeneralGUI : Form
    {

        public GeneralGUI()
        {
            InitializeComponent();
            ListboxAddAll();
            Cursor.Hide();
        }
        /*
         * 4.1.	Create a Dictionary data structure with a TKey of type integer and 
         * a TValue of type string, name the new data structure “MasterFile”.
         */
        public static Dictionary<int, string> MasterFile = [];

        /*
         * 4.2.	Create a method that will read the data from the .csv file into the 
         * Dictionary data structure when the GUI loads.
         */

        /*        private async void ReadCSV()
        {
            using StreamReader reader = new(@"MalinStaffNamesV3.csv");

            while (!reader.EndOfStream)
            {
                string? line = await reader.ReadLineAsync();
                if (line != null)
                {
                    var values = line.Split(',');
                    MasterFile.Add(int.Parse(values[0]), values[1]);
                }
            }
        }*/

        private void ReadCSV()
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

        /*
         * 4.3.	Create a method to display the Dictionary data into a non-selectable
         * display only list box (ie read only).
         */
        private void ListboxAddAll()
        {
            ReadCSV();
            foreach (var item in MasterFile)
            {
                ListboxCSV.Items.Add($"{item.Value}, {item.Key}");
            }
        }
        /*
         * 4.4 && 4.5. Create a method to filter the Staff Name data from the 
         * Dictionary into a second filtered and selectable list box. This method 
         * must use a text box input and update as each character is entered. The
         *  list box must reflect the filtered data in real time.
         */
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
        private void TextBoxFilterID_TextChanged(object sender, EventArgs e)
        {
            Filter(textBoxFilterID);
        }
        private void TextBoxFilterName_TextChanged(object sender, EventArgs e)
        {
            Filter(textBoxFilterName);
        }

        private void GeneralGUI_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.Alt)
            {
                if (e.KeyCode == Keys.L)
                {
                    this.Close();
                }
                if (e.KeyCode == Keys.Q)
                {
                    FocusIDTextbox();
                }
                if (e.KeyCode == Keys.W)
                {
                    FocusNameTextBox();
                }
                if (e.KeyCode == Keys.A)
                {
                    OpenAdminPanel();
                }
            }
        }
        /*
         * 4.9.	Create a method that will open the Admin GUI when the Alt + A keys 
         * are pressed. Ensure the General GUI sends the currently selected Staff 
         * ID and Staff Name to the Admin GUI for Update and Delete purposes and is 
         * opened as modal. 
         */
        private void OpenAdminPanel()
        {
            try
            {
                if (MasterFile.ContainsKey(int.Parse(textBoxFilterID.Text))
                    && MasterFile[int.Parse(textBoxFilterID.Text)] == textBoxFilterName.Text
                    || textBoxFilterID.Text == "77" && string.IsNullOrEmpty(textBoxFilterName.Text))
                {
                    AdminGUI adminGUI = new(textBoxFilterID.Text, textBoxFilterName.Text);
                    adminGUI.ShowDialog();

                    textBoxFilterID.Clear();
                    textBoxFilterName.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"Please ensure that you have selected an entry.");
            }
        }
        /*
         * 4.7.	Create a method for the Staff ID text box which will clear the 
         * contents and place the focus into the text box. Utilise a keyboard 
         * shortcut.
         */
        private void FocusIDTextbox()
        {
            textBoxFilterID.Clear();
            textBoxFilterID.Select();
        }
        /*
         * 4.6.	Create a method for the Staff Name text box which will clear the 
         * contents and place the focus into the Staff Name text box. Utilise a 
         * keyboard shortcut.
         */
        private void FocusNameTextBox()
        {
            textBoxFilterName.Clear();
            textBoxFilterName.Select();
        }
        /*
         * 4.8.	Create a method for the filtered and selectable list box which will 
         * populate the two text boxes when a staff record is selected. Utilise 
         * the Tab and keyboard keys.
         */
        private void DisplayFilterData()
        {
            string? item = ListBoxFiltered.GetItemText(ListBoxFiltered.SelectedItem);

            if (!string.IsNullOrEmpty(item) && ListBoxFiltered.SelectedIndex >= 0)
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

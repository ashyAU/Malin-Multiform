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

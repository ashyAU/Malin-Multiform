namespace Malin_Multiform
{
    public partial class AdminGUI : Form
    {
        /*
         * 5.1.	Create the Admin GUI with the following settings: GUI is model, 
         * all Control Box features are removed/hidden, then add two text boxes. 
         * The text box for the Staff ID should be read-only for Add, Update and 
         * Delete purposes.
         */
        public AdminGUI(string key, string value)
        {
            InitializeComponent();
            AdminTextFields(key, value);
        }

        /*
         * 5.2.	Create a method that will receive the Staff ID from the General 
         * GUI and then populate text boxes with the related data. 
         */
        private void AdminTextFields(string key, string value)
        {
            if (key == "77" && string.IsNullOrEmpty(value))
            {
                Random random = new();

                int newID = random.Next(100000, 999999);
                while (GeneralGUI.MasterFile.ContainsKey(newID))
                {
                    newID--;
                }
                textBoxAdminID.Text = $"{key}{newID}";
                textBoxAdminName.Text = "";
            }
            else
            {
                textBoxAdminID.Text = key;
                textBoxAdminName.Text = value;
            }
            SaveDictionary();
        }

        /*
         * 5.3.	Create a method that will create a new Staff ID and input the staff 
         * name from the related text box. The Staff ID must be unique starting with
         * 77xxxxxxx while the staff name may be duplicated. The new staff member 
         * must be added to the Dictionary data structure.
         */
        private void AddEntry()
        {
            if (!GeneralGUI.MasterFile.TryGetValue(int.Parse(textBoxAdminID.Text), out string? _))
            {
                GeneralGUI.MasterFile.Add(int.Parse(textBoxAdminID.Text), textBoxAdminName.Text);
                string success = $"{textBoxAdminID.Text} has been added.";
                adminStripLabel.Text = success;
                SaveDictionary();
            }
            else
            {
                adminStripLabel.Text = $"{textBoxAdminID.Text} already exists!";
                return;
            }
        }

        /*
         * 5.4.	Create a method that will Update the name of the current Staff ID.
         */
        private void UpdateEntry()
        {
            if (GeneralGUI.MasterFile.TryGetValue(int.Parse(textBoxAdminID.Text), out string? _))
            {
                GeneralGUI.MasterFile[int.Parse(textBoxAdminID.Text)] = textBoxAdminName.Text;
                SaveDictionary();
                adminStripLabel.Text = $"{textBoxAdminID.Text} has been updated!";
                return;
            }
            adminStripLabel.Text = "This ID does not Exist! Failed to update";
        }

        /*
         * 5.5.	Create a method that will Remove the current Staff ID and clear the
         * text boxes.
         */
        private void DeleteEntry()
        {
            GeneralGUI.MasterFile.Remove(int.Parse(textBoxAdminID.Text));
            SaveDictionary();

            adminStripLabel.Text = $"{textBoxAdminID.Text} has been removed.";
            ClearTextFields();
        }

        private void ClearTextFields()
        {
            textBoxAdminID.Clear();
            textBoxAdminName.Clear();
        }

        /*
         * 5.6.	Create a method that will save changes to the csv file, this method 
         * should be called as the Admin GUI closes.
         */
        private static void SaveDictionary()
        {
            using StreamWriter streamWriter = new(@"MalinStaffNamesV3.csv");
            {
                foreach (var line in GeneralGUI.MasterFile)
                {
                    streamWriter.WriteLine($"{line.Key},{line.Value}");
                }
            }
        }

        private void AdminGUI_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.Alt)
            {
                /*
                 * 5.7.	Create a method that will close the Admin GUI when the 
                 * Alt + L keys are pressed.
                 */
                if (e.KeyCode == Keys.L)
                {
                    this.Close();
                }
                if (e.KeyCode == Keys.Q)
                {
                    UpdateEntry();
                }
                if (e.KeyCode == Keys.W)
                {
                    AddEntry();
                }
                if (e.KeyCode == Keys.E)
                {
                    DeleteEntry();
                }
            }
        }
    }
}

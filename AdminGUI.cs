using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Malin_Multiform
{
    public partial class AdminGUI : Form
    {
        public AdminGUI(string key, string value)
        {
            InitializeComponent();
            AdminTextFields(key, value);
        }

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

        private void AddEntry()
        {

            // todo tomorrow
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

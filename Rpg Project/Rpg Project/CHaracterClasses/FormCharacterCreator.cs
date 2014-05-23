using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Rpg_Project.CHaracterClasses;

namespace Rpg_Project
{
    public partial class FormCharacterCreator : Form
    {
        public EntityClass eClass { get; set; }
        public EntityGender eGender { get; set; }

        private static string SettingsFolder
        {
            get
            {
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                folder = Path.Combine(folder, "RPG Project Saves");
                folder = Path.Combine(folder, "Players");
                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);
                return folder;
            }
        }

        private static string SettingsFile
        {
            get
            {
                return Path.Combine(SettingsFolder, "player.xml");
            }
        }
        private static Player DefaultSettings
        {
            get
            {
                return new Player
                {
                    Name = "",
                    Gender = EntityGender.Unknown,
                    CharacterClass = EntityClass.Unknown,
                    Strength = 0,
                    Dexterity = 0,
                    Wisdom = 0,
                    Intelligence = 0,
                };
            }
        }
        private void StoreCharacter(Player player)
        {
            using (Stream stream = File.Create(SettingsFile))
            {
                XmlSerializer ser = new XmlSerializer(player.GetType());
                ser.Serialize(stream, player);
            }
        }
        public FormCharacterCreator()
        {
            InitializeComponent();
        }

        private void FormCharacterCreator_Load(object sender, EventArgs e)
        {
            textBoxIntelligence.Text = "0";
            textBoxStrength.Text = "0";
            textBoxDexterity.Text = "0";
            textBoxWisdom.Text = "0";
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            //FORM VALIDATION
            #region Name validation
            //CHECK NAME
            string name;
            if (String.IsNullOrEmpty(textBoxName.Text) || textBoxName.Text[0] == ' ')
            {
                MessageBox.Show("You must name your character. " +
                    "\n Names must start with a letter.");
                return;
            }
            name = textBoxName.Text;
            #endregion

            #region Gender validation
            //CHECK GENDER
            if (this.radioButtonMale.Checked == false &&
                this.radioButtonFemale.Checked == false)
            {
                MessageBox.Show("You must choose a gender.");
                return;
            }
            string gender = (string)(this.radioButtonFemale.Checked ? "Female" : "Male");
            if (gender == "Male")
            {
                eGender = EntityGender.Male;
            }
            else
            {
                eGender = EntityGender.Female;
            }
            #endregion

            #region Stat allocation validation
            //CHECK ALLOCATION
            int str = Int32.Parse(textBoxStrength.Text);
            int dex = Int32.Parse(textBoxDexterity.Text);
            int wis = Int32.Parse(textBoxWisdom.Text);
            int intel = Int32.Parse(textBoxIntelligence.Text);
            int allocatedstats;

            allocatedstats = str + dex + wis + intel;

            if (allocatedstats == 15)
            {
            }
            else
            {
                MessageBox.Show("You must allocate exactly 15 attribute points.");
                return;
            }
            #endregion

            #region Class validation
            //CHECK CLASS
            ComboBox charclass = (comboBoxClass);
            if (charclass == null || charclass.Text == string.Empty || charclass.Items.Count <= 0)
            {
                MessageBox.Show("Please choose a class for your character.");
                return;
            }
            if (charclass.Text == "Warrior")
            {
                eClass = EntityClass.Warrior;
            }
            if (charclass.Text == "Rogue")
            {
                eClass = EntityClass.Rogue;
            }
            if (charclass.Text == "Cleric")
            {
                eClass = EntityClass.Cleric;
            }
            if (charclass.Text == "Mage")
            {
                eClass = EntityClass.Mage;
            }
            #endregion

            //Create the player

            Player player1 = new Player(name, eGender, eClass, str, dex, wis, intel);

            StoreCharacter(player1);
            
            MessageBox.Show("You have created your " + gender + " character named " + textBoxName.Text);
            
            this.Close();
            MessageBox.Show("Your Character has been saved in your %AppData% folder under RPG Project Saves");
        }
    }
}

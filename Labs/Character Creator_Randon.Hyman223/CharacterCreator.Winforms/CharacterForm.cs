/******************
 * Randon Hyman
 * ITSE 1430   
 * 4/1/2019  
 *****************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator.Winforms
{
    public partial class CharacterForm : Form
    {
        #region Construction
        public CharacterForm()
        {
            InitializeComponent();
        }
        #endregion

        public Character Character { get; set; }

        private void OnCancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OnSave(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            var character = new Character();
            character.Name = nameBox.Text;
            character.Race = raceBox.Text;
            character.Profession = professionBox.Text;
            character.Description = descriptionBox.Text;
            character.Strength = GetInt32(strengthBox);
            character.Intelligence = GetInt32(IntelBox);
            character.Agility = GetInt32(agilityBox);
            character.Charisma = GetInt32(charismaBox);
            character.Constitution = GetInt32(constBox);

            Character = character;
            DialogResult = DialogResult.OK;
            Close();
        }

        private int GetInt32 (TextBox textBox)
        {
            if (String.IsNullOrEmpty(textBox.Text))
                return -1;
            if (Int32.TryParse(textBox.Text, out var value))
                return value;
            return -1;
        }

        private void OnValidateName(object sender, CancelEventArgs e)
        {
            var control = sender as TextBox;
            if (String.IsNullOrEmpty(control.Text))
            {
                error.SetError(control, "Enter a name");
                e.Cancel = true;
            }
            else
                error.SetError(control, "");
        }

        private void OnValidateAttributes(object sender, CancelEventArgs e)
        {
            var control = sender as TextBox;
            var result = GetInt32(control);
            if (result < 1 || result > 100)
            {
                error.SetError(control, "Enter a value (1-100)");
                e.Cancel = true;
            } else
                error.SetError(control, "");
        }

        private void OnValidateComboBox(object sender, CancelEventArgs e)
        {
            var control = sender as ComboBox;
            if (control.SelectedIndex == -1)
            {
                error.SetError(control, "Make a selection.");
                e.Cancel = true;
            } else
                error.SetError(control, "");
        }

        private void CharacterForm_Load(object sender, EventArgs e)
        {
            if (Character != null)
            {
                nameBox.Text = Character.Name;
                raceBox.Text = Character.Race;
                professionBox.Text = Character.Profession;
                descriptionBox.Text = Character.Description;
                strengthBox.Text = Character.Strength.ToString();
                IntelBox.Text = Character.Intelligence.ToString();
                agilityBox.Text = Character.Agility.ToString();
                charismaBox.Text = Character.Charisma.ToString();
                constBox.Text = Character.Constitution.ToString();
            }

            ValidateChildren();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

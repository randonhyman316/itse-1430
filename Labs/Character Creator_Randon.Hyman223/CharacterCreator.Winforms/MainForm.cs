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
    public partial class MainForm : Form
    {

        private CharacterDatabase database = new CharacterDatabase();


        public MainForm()
        {
            InitializeComponent();
           
        }

        private void OnFileExit(object sender, EventArgs e)
        {
            Close();
        }

        private void OnHelpAbout(object sender, EventArgs e)
        {
            var form = new AboutForm();
            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            listBox.DisplayMember = "Name";
            RefreshCharacters();
        }

        private void RefreshCharacters()
        {
            var characters = database.GetAll();

            listBox.Items.Clear();
            listBox.Items.AddRange(characters);
        }

        private void OnCharacterAdd(object sender, EventArgs e)
        {
            var form = new CharacterForm();
            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;
            database.Add(form.Character);
            RefreshCharacters();
        }

        private void OnCharacterEdit(object sender, EventArgs e)
        {
            var item = GetSelectedCharacter();
            if (item == null)
                return;

            var form = new CharacterForm();
            form.Text = "Edit Character";
            form.Character = item;
            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            database.Edit(item.Name, form.Character);
            RefreshCharacters();
        }

        private void OnCharacterDelete(object sender, EventArgs e)
        {
            var item = GetSelectedCharacter();
            if (item == null)
                return;

            if (MessageBox.Show("Delete this Character?",
                      "Delete Character", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            database.Remove(item.Name);
            RefreshCharacters();
        }

        private Character GetSelectedCharacter()
        {
            return listBox.SelectedItem as Character;
        }

    }
}

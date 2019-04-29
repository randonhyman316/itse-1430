/******************
 * Randon Hyman
 * ITSE 1430   
 * 4/18/2019  
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
using ContactManager.Memory;

namespace ContactManager.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _listBoxContacts.DisplayMember = "Name";
            _listBoxSentMessages.DisplayMember = "Name";

            RefreshContacts();
            RefreshMessages();
        }

        private void OnFileExit(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit? Are you sure?",
                       "Close", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            Close();
        }

        private void OnHelpAbout(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Contact Manager\nRandon Hyman\nITSE 1430",
               "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OnContactAdd(object sender, EventArgs e)
        {
            var form = new ContactForm();
            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            _database.Add(form.Contact);
            RefreshContacts();
        }

        private void RefreshContacts()
        {
            var messages = from m in _database.GetAll()
                         orderby m.Name
                         select m;

            _listBoxContacts.Items.Clear();
            _listBoxContacts.Items.AddRange(messages.ToArray());
        }

        private void OnContactEdit(object sender, EventArgs e)
        {
            EditContact();
        }

        private void EditContact()
        {
            var item = GetSelectedContact();
            if (item == null)
                return;

            var form = new ContactForm
            {
                Text = "Edit Contact",
                Contact = item
            };
            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            _database.Edit(item.Name, form.Contact);
            RefreshContacts();
        }

        private Contact GetSelectedContact()
        {
            return _listBoxContacts.SelectedItem as Contact;
        }

        private void OnContactDoubleClick(object sender, EventArgs e)
        {
            EditContact();
        }

        private IMessage _sentMessages = new MemoryMessageDatabase();
        private IContactDatabase _database = new MemoryContactDatabase();

        private void OnContactDelete(object sender, EventArgs e)
        {
            DeleteContact();
        }

        private void DeleteContact()
        {
            var item = GetSelectedContact();
            if (item == null)
                return;

            if (MessageBox.Show("Delete " + item.Name + "? Are you sure?",
                     "Delete Contact", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            _database.Remove(item.Name);
            RefreshContacts();
        }

        private void OnListKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                DeleteContact();
            };
        }

        private void OnMessageSend(object sender, EventArgs e)
        {
            var item = GetSelectedContact();
            if (item == null)
                return;

            var form = new MessageForm
            {
                Contact = item
            };
            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            _sentMessages.Send(form.Message);
            RefreshMessages();
        }

        private void RefreshMessages()
        {
            var _names = from m in _sentMessages.GetAll()
                           select m.Name;

            var _subjects = from m in _sentMessages.GetAll()
                        select m.Subject;

            var _messages = from m in _sentMessages.GetAll()
                           select m.MessageText;

            _listBoxSentMessages.Items.Clear();
            
            for (int i = _names.Count() - 1; i >= 0 ; i--)
            {
                _listBoxSentMessages.Items.Add("Name: " +
                    _names.ElementAt(i).ToString());
                _listBoxSentMessages.Items.Add("Subject: " +
                    _subjects.ElementAt(i).ToString());
                _listBoxSentMessages.Items.Add("Message: " +
                    _messages.ElementAt(i).ToString());
                _listBoxSentMessages.Items.Add(" ");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameManager.Host.Winforms
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        public Game Game { get; set; }

        private void OnSave( object sender, EventArgs e )
        {
            Game = SaveData();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void OnCancel( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private decimal ReadDecimal( TextBox control )
        {
            if (Decimal.TryParse(control.Text, out var value))
                return value;

            return -1;
        }

        private Game SaveData()
        {
            var game = new Game();
            game.Name = txt_Name.Text;
            game.Publisher = txt_publisher.Text;
            game.Price = ReadDecimal(txt_Price);
            game.Owned = txt_Owned.Checked;
            game.Completed = txt_Completed.Checked;

            return game;
        }
    }
}

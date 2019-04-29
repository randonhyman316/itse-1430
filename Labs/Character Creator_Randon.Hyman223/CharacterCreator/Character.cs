/******************
 * Randon Hyman
 * ITSE 1430   
 * 4/1/2019  
 *****************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Character
    {
        #region Required
        private string _name = "";
        private string _profession;
        private string _race;

        // Attributes
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Agility { get; set; }
        public int Constitution { get; set; }
        public int Charisma { get; set; }

        public string Name
        {
            get { return _name ?? " "; }
            set { _name = value; }
        }

        public string Profession
        {
            get { return _profession ?? " "; }
            set { _profession = value; }
        }

        public string Race
        {
            get { return _race ?? " "; }
            set { _race = value; }
        }
        #endregion

        #region Optional
        public string _description;

        public string Description
        {
            get { return _description ?? " "; }
            set { _description = value; }
        }
        #endregion
    }
}

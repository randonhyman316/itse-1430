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
    public class CharacterDatabase
    {
        private Character[] allCharacters = new Character[100];

        public void Add(Character character)
        {
            var index = FindNextFreeIndex();
            if (index >= 0)
                allCharacters[index] = character;
        }

        public Character[] GetAll()
        {
            var count = 0;
            foreach (var character in allCharacters)
            {
                if (character != null)
                    ++count;
            };

            var temp = new Character[count];
            var index = 0;
            foreach (var character in allCharacters)
            {
                if (character != null)
                    temp[index++] = character;
            };

            return temp;
        }

        public void Edit(string name, Character character)
        {
            Remove(name);

            Add(character);
        }

        public void Remove(string name)
        {
            for (var index = 0; index < allCharacters.Length; ++index)
            {
                if (String.Compare(name, allCharacters[index]?.Name, true) == 0)
                {
                    allCharacters[index] = null;
                    return;
                };
            }
        }

        private int FindNextFreeIndex()
        {
            for (var index = 0; index < allCharacters.Length; ++index)
            {
                if (allCharacters[index] == null)
                    return index;
            };

            return -1;
        }
    }
}

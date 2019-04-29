/******************
 * Randon Hyman
 * ITSE 1430   
 * 4/18/2019  
 *****************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public interface IContactDatabase
    {
        void Add(Contact contact);

        void Edit(string name, Contact contact);

        void Remove(string name);

        IEnumerable<Contact> GetAll();
    }
}
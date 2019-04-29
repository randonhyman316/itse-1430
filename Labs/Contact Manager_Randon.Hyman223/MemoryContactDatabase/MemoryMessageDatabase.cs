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

namespace ContactManager.Memory
{
    public class MemoryMessageDatabase : MessageSendDatabase
    {
        protected override void SendCore(Message message)
        {
            _items.Add(message);
        }

        protected override IEnumerable<Message> GetAllCore()
        {
            return from item in _items
                   select new Message()
                   {
                       Name = item.Name,
                       EmailAddress = item.EmailAddress,
                       Subject = item.Subject,
                       MessageText = item.MessageText,
                   };
        }

        private List<Message> _items = new List<Message>();
    }
}
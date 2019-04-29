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
    public abstract class MessageSendDatabase : IMessage
    {
        public void Send(Message message)
        {
            if (message == null)
                return;
            SendCore(message);
        }

        public IEnumerable<Message> GetAll()
        {
            return GetAllCore();
        }

        protected abstract void SendCore(Message message);
        protected abstract IEnumerable<Message> GetAllCore();
    }
}
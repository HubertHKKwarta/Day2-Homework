using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday_reminder_application
{
    public class Friend
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        public Friend(string name, DateTime? birthday = null)
        {
            Name = name;
            Birthday = birthday ?? DateTime.Now;
        }

        public string GetFriendData()
        {
            return "Nazwisko: " + Name + ", data urodzenia: " + Birthday.ToString();
        }
    }
}

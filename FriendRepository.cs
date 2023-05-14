using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday_reminder_application
{
    public class FriendRepository
    {
        public List<Friend> Friends { get; set; } = new List<Friend> { };

        public void AddFriend(Friend friend)
        {
            Friends.Add(friend);
        }

        public Friend GetFriend(string fullName)
        {
            foreach (Friend friend1 in Friends)
                if (friend1.Name == fullName)
                    return friend1;
            return null;
        }

        public void EditFriend(Friend modifiedFriend)
        {
            Friend existingFriend = GetFriend(modifiedFriend.Name);

            if (existingFriend != null)
                existingFriend.Birthday = modifiedFriend.Birthday;
            else
            {
                if (existingFriend == null)
                {
                    AddFriend(modifiedFriend);
                }
            }
        }

        public bool DeleteFriend(string fullName)
        {
            Friend existingFriend = GetFriend(fullName);

            if (existingFriend != null)
                Friends.Remove(existingFriend);
            else
                return false;

            return true;
        }

        public List<Friend> GetFriendsWithUpcomingBirthday()
        {
            return Friends.Where(x => x.Birthday.Month == DateTime.Now.Month).ToList();
        }
    }
}

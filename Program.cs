using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday_reminder_application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FriendRepository friendRepository = new FriendRepository();
            friendRepository.AddFriend(new Friend("James January", new DateTime(1998, 1, 04)));
            friendRepository.AddFriend(new Friend("James February", new DateTime(1998, 2, 04)));
            friendRepository.AddFriend(new Friend("James March", new DateTime(1998, 3, 04)));
            friendRepository.AddFriend(new Friend("James Arpil", new DateTime(1998, 4, 04)));
            friendRepository.AddFriend(new Friend("James May", new DateTime(1998, 5, 04)));
            friendRepository.AddFriend(new Friend("James June", new DateTime(1998, 6, 04)));
            friendRepository.AddFriend(new Friend("James July", new DateTime(1998, 7, 04)));
            friendRepository.AddFriend(new Friend("James August", new DateTime(1998, 8, 04)));
            friendRepository.AddFriend(new Friend("James September", new DateTime(1998, 9, 04)));
            friendRepository.AddFriend(new Friend("James October", new DateTime(1998, 10, 04)));
            friendRepository.AddFriend(new Friend("James November", new DateTime(1998, 11, 04)));
            friendRepository.AddFriend(new Friend("James December", new DateTime(1998, 12, 04)));

            string result = string.Empty;
            while (true)
            {
                Console.WriteLine("Co chcesz zrobić? 1-dodaj przyjaciela, 2-edytuj, 3-wyświetl, 4-usuń, 5-sprawdź czy ktoś ma urodziny, 0-zakończ program");
                result = Console.ReadLine();

                if (result == "0")
                    break;
                if (result == "1")
                {
                    Console.WriteLine("Jestes w trakcie dodawnia przyjaciela. Podaj Imie i nazwisko:");
                    result = Console.ReadLine();
                    Friend f = new Friend(result);

                    Console.WriteLine("Jestes w trakcie dodawnia przyjaciela. Podaj datę urodzenia: (RRRR-MM-dd)");
                    result = Console.ReadLine();
                    f.Birthday = DateTime.ParseExact(result, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                    friendRepository.AddFriend(f);
                    Console.WriteLine("Dodano przjaciela");
                }
                else if (result == "2")
                {
                    Console.WriteLine("Jestes w trakcie edytowania przyjaciela. Podaj Imie i nazwisko o którego kaman:");
                    result = Console.ReadLine();
                    Friend f = new Friend(result);

                    Console.WriteLine("Jestes w trakcie edytowania przyjaciela. Podaj nową datę urodzin (RRRR-MM-dd)");
                    result = Console.ReadLine();
                    f.Birthday = DateTime.ParseExact(result, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                    friendRepository.EditFriend(f);
                    Console.WriteLine("Zmodyfikowano osobę");
                }
                else if (result == "3")
                {
                    Console.WriteLine("Jestes w trakcie pzreglądania listy wprowadzonych przyjacól:");
                    foreach (Friend f in friendRepository.Friends)
                        Console.WriteLine(f.GetFriendData());
                }
                else if (result == "4")
                {
                    Console.WriteLine("Jestes w trakcie usuwania przyjaciela. Podaj Imie i nazwisko o którego kaman:");
                    result = Console.ReadLine();

                    Console.WriteLine(friendRepository.DeleteFriend(result) ? "Usunięto osobę " : "Brak osoby o tym nazwisku do usunięcia");
                }
                else if (result == "5")
                {
                    Console.WriteLine("Jestes w trakcie sprawdzania czy ktoś nie ma urodzin. Urodziny w tym miesiącu obchodzą:");

                    List<Friend> freindWithBitrhday = friendRepository.GetFriendsWithUpcomingBirthday();

                    if (freindWithBitrhday.FirstOrDefault() != null)
                        foreach (Friend f in friendRepository.GetFriendsWithUpcomingBirthday())
                            Console.WriteLine(f.GetFriendData());
                    else
                        Console.WriteLine("Nikt nie obchodzi urodzin w tym miesiącu");
                }
                else
                    Console.WriteLine("Podano zły kod sterujący");
            }
        }
    }
}

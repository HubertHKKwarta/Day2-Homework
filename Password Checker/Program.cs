using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Checker
{
    public class PassChecker
    {
        public bool HasSymbol { get; set; }
        public bool HasDigit { get; set; }
        public bool HasUpper { get; set; }
        public bool HasLower { get; set; }
        public bool HasProperLen { get; set; }
        public string PassCandidate { get; set; }
        private int _checkResult;

        public PassChecker(string passCandidate)
        {
            PassCandidate = passCandidate;
        }

        public int Check()
        {
            int passStrength = 0; // 1 - sałbe, 5 bardzo silne.

            if (PassCandidate.Any(x => char.IsSymbol(x))) //  special characters / symbols ? 
            {
                passStrength++;
                HasSymbol = true;
            }
            else if (PassCandidate.Any(x => IsSymbol(x)))
            {
                passStrength++;
                HasSymbol = true;
            }
            if (PassCandidate.Any(x => char.IsDigit(x)))
            {
                passStrength++;
                HasDigit = true;
            }
            if (PassCandidate.Any(x => char.IsUpper(x)))
            {
                passStrength++;
                HasUpper = true;
            }
            if (PassCandidate.Any(x => char.IsLower(x)))
            {
                passStrength++;
                HasLower = true;
            }
            if (IsLengthSafeEnough(PassCandidate))
            {
                passStrength++;
                HasProperLen = true;
            }

            _checkResult = passStrength;
            return _checkResult;
        }

        public string GetSuggestions()
        {
            if (_checkResult == 5)
                return "nie ma nic do poprawy. hasło super mocne";

            string suggestionToImprove = string.Empty;
            if (!HasSymbol)
                suggestionToImprove = "Dodaj symbol. ";
            if (!HasDigit)
                suggestionToImprove += "Dodaj cyfrę. ";
            if (!HasUpper)
                suggestionToImprove += "Dodaj duża literę. ";
            if (!HasLower)
                suggestionToImprove += "Dodaj małą literę. ";
            if (!HasProperLen)
                suggestionToImprove += "Zwiększ długośc hasła ";

            return suggestionToImprove;
        }

        public static bool IsSymbol(char singleCharacter)//własna implementacja 
        {
            if (singleCharacter >= 33 && singleCharacter <= 47)
                return true;
            return false;
        }

        public static bool IsLengthSafeEnough(string inputStr)
        {
            return inputStr.Length > 8;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj haslo");
            string passCandidate = Console.ReadLine();

            PassChecker passChecker = new PassChecker(passCandidate);
            int resultStrength = passChecker.Check();
            Console.WriteLine("twój wynik hasła: (1 = słabe, 5 = bardzo mocne): " + passChecker.Check());

            Console.WriteLine(passChecker.GetSuggestions());

            Console.ReadKey();

        }
    }
}

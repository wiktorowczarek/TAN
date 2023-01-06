using System;

namespace LegacyApp
{
    public class User
    {
        public object Client { get; internal set; }
        public DateTime DateOfBirth { get; internal set; }
        public string EmailAddress { get; internal set; }
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public bool HasCreditLimit { get; internal set; }
        public int CreditLimit { get; internal set; }

        /// <summary>
        ///  Sprawdzenie poprawnosci danych uzytkownika
        /// </summary>
        public bool CheckData()
        {
            return (ChceckUserName() && CheckEmail() && ChceckAge());
        }

        /// <summary>
        ///  Sprawdzenie czy pola imienia i nazwiska nie sa puste lub czy nie sa nullem
        /// </summary>
        private bool ChceckUserName()
        {
            return (!string.IsNullOrEmpty(FirstName) || !string.IsNullOrEmpty(LastName));
        }

        /// <summary>
        ///  Sprwadzenie czy adres email zawiera @ i kropke
        /// </summary>
        private bool CheckEmail()
        {
            return (EmailAddress.Contains("@") && EmailAddress.Contains("."));
        }

        /// <summary>
        ///  Sprawdzenie czy wiek jest wiekszy niz 21 lat
        /// </summary>
        private bool ChceckAge()
        {
            var now = DateTime.Now;
            int age = now.Year - DateOfBirth.Year;
            if (now.Month < DateOfBirth.Month || (now.Month == DateOfBirth.Month && now.Day < DateOfBirth.Day)) age--;

            if (age < 21)
            {
                return false;
            }

            return true;
        }
    }
}
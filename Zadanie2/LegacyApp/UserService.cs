using System;

namespace LegacyApp
{
    public class UserService
    {
        //AddUser_ShouldAddUserCorrectly
        //AddUser_ShouldFail_IncorrectEmail

        //SOLID
        public bool AddUser(string firstName, string lastName, string email, DateTime dateOfBirth, int clientId)
        {
            //stwoerzenie nowego repozytorium klienta i przypisanie Id
            var clientRepository = new ClientRepository();
            var client = clientRepository.GetById(clientId);

            //Stworzenie nowego uzytkownika, wraz z przypisaniem wartosci do pól
            var user = new User
            {
                Client = client,
                DateOfBirth = dateOfBirth,
                EmailAddress = email,
                FirstName = firstName,
                LastName = lastName
            };

            //Walidacja znajduje sie w klasie user
            if (!user.CheckData())
            {
                return false;
            }

            //Przeniesie sprawdzenie credit limitu do oddzielnje funkcji
            CheckCreditLimit(client, user);

            //Sprawdzenie czy uzytkownik posiada limit kredytu oraz czy jest on mniejszy od 500
            if (user.HasCreditLimit && user.CreditLimit < 500)
            {
                return false;
            }

            //Dodanie uzytkownika
            UserDataAccess.AddUser(user);
            return true;
        }

        /// <summary>
        ///  Sprawdzenie limitu kredytu na podsatwie imienia klienta oraz limitu uzytkownika
        /// </summary>
        private void CheckCreditLimit(Client client, User user)
        {
            if (client.Name == "VeryImportantClient")
            {
                //Skip credit limit
                user.HasCreditLimit = false;
            }
            else if (client.Name == "ImportantClient")
            {
                using (var userCreditService = new UserCreditService())
                {
                    int creditLimit = userCreditService.GetCreditLimit(user.FirstName, user.LastName, user.DateOfBirth);
                    creditLimit = creditLimit * 2;
                    user.CreditLimit = creditLimit;
                }
            }
            else
            {
                //Do credit check
                user.HasCreditLimit = true;
                using (var userCreditService = new UserCreditService())
                {
                    int creditLimit = userCreditService.GetCreditLimit(user.FirstName, user.LastName, user.DateOfBirth);
                    user.CreditLimit = creditLimit;
                }
            }
        }
    }
}

using Agency.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Agency.Services
{
    public class BuyerService
    {
        private AgencyDbContext context = new();
        public List<Buyer> GetBuyers()
        {
            var buyers = context.Buyers.Include(buyers => buyers.Deals).Include(buyers => buyers.Requests).ToList();
            return buyers;
        }
        public Buyer GetBuyer(string Login)
        {
            return GetBuyers().FirstOrDefault(buyer => buyer.LoginBuyer == Login);
        }
        public Buyer GetBuyer(int id)
        {
            return GetBuyers().FirstOrDefault(buyer => buyer.IdBuyer == id);
        }
        public bool IsExist(string Login)
        {
            return GetBuyers().Any(x => x.LoginBuyer == Login);
        }
        public bool Add(string Surname, string Name, string Passport, string NomTel, string Login, string Password)
        {
            if (GetBuyers().Any(x => x.PassportNumBuyer == Passport) || Passport.Length > 11 || 
                GetBuyers().Any(x => x.NomTelBuyer == NomTel) || IsExist(Login))
            {
                return false;
            }
            Buyer buyer = new Buyer
            {
                SurnameBuyer = Surname,
                NameBuyer = Name,
                PassportNumBuyer = Passport,
                NomTelBuyer = NomTel,
                LoginBuyer = Login,
                PasswordBuyer = Password
            };
            context.Buyers.Add(buyer);
            context.SaveChanges();
            return true;
        }
        public bool Remove(int id)
        {
            var buyer = GetBuyer(id);
            if (buyer.Deals.Count != 0 || buyer.Requests.Count != 0)
            {
                return false;
            }
            context.Buyers.Remove(buyer);
            context.SaveChanges();
            return true;
        }
        public bool Change(int id, string newValue, string option)
        {
            var Buyer = GetBuyer(id);
            if (option == "Фамилия")
            {
                Buyer.SurnameBuyer = newValue;
            }
            if (option == "Имя")
            {
                Buyer.NameBuyer = newValue;
            }
            if (option == "Номер телефона")
            {
                if (GetBuyers().Any(x => x.NomTelBuyer == newValue))
                {
                    return false;
                }
                Buyer.NomTelBuyer = newValue;
            }
            if (option == "Логин")
            {
                if (IsExist(newValue))
                {
                    return false;
                }
                Buyer.LoginBuyer = newValue;
            }
            if (option == "Пароль")
            {
                Buyer.PasswordBuyer = newValue;
            }
            if (option == "Паспорт")
            {
                if (GetBuyers().Any(x => x.PassportNumBuyer == newValue) || newValue.Length > 11)
                {
                    return false;
                }
                Buyer.PassportNumBuyer = newValue;
            }
            context.SaveChanges();
            return true;
        }
    }
}

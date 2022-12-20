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
        public bool IsExist(string Login, string Password)
        {
            return GetBuyers().Any(x => x.LoginBuyer == Login && x.PasswordBuyer == Password);
        }
        public bool Add(string Fio, string Passport, string NomTel, string Login, string Password)
        {
            if (Passport.Length > 11)
            {
                MessageBox.Show("Неверный ввод паспортных данных.");
                return false;
            }
            Buyer buyer = new Buyer
            {
                FioBuyer = Fio,
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
            if (buyer == null)
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
            if (option == "ФИО")
            {
                Buyer.FioBuyer = newValue;
            }
            if (option == "Номер телефона")
            {
                Buyer.NomTelBuyer = newValue;
            }
            if (option == "Логин")
            {
                Buyer.LoginBuyer = newValue;
            }
            if (option == "Пароль")
            {
                Buyer.PasswordBuyer = newValue;
            }
            try
            {
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

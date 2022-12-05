using Agency.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency.Services
{
    public class OwnerService
    {
        private AgencyDbContext context = new();
        public List<Owner> GetOwners()
        {
            var owners = context.Owners.Include(owner => owner.Apartments).ToList();
            return owners;
        }
        public Owner GetOwner(string Login)
        {
            return GetOwners().FirstOrDefault(owner => owner.LoginOwner == Login);
        }
        public bool IsExist(string Login, string Password)
        {
            return GetOwners().Any(x => x.LoginOwner == Login && x.PasswordOwner == Password);
        }
        public bool Add(string Fio, string Passport, string NomTel, string Login, string Password)
        {
            if (Passport.Length > 11)
            {
                MessageBox.Show("Неверный ввод паспортных данных.");
                return false;
            }
            Owner owner = new Owner
            {
                FioOwner = Fio,
                PassportNumOwner = Passport,
                NomTelOwner = NomTel,
                LoginOwner = Login,
                PasswordOwner = Password
            };
            context.Owners.Add(owner);
            context.SaveChanges();
            return true;
        }
    }
}

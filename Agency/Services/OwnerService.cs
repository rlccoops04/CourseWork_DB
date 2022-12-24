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
        public Owner GetOwner(int id)
        {
            return GetOwners().FirstOrDefault(owner => owner.IdOwner == id);
        }
        public bool IsExist(string Login)
        {
            return GetOwners().Any(x => x.LoginOwner == Login);
        }
        public bool Add(string Fio, string Passport, string NomTel, string Login, string Password)
        {
            if (GetOwners().Any(x => x.PassportNumOwner == Passport) || Passport.Length > 11 ||
                GetOwners().Any(x => x.NomTelOwner == NomTel) || IsExist(Login)) 
            {
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
        public bool Remove(int id)
        {
            var owner = GetOwner(id);
            if (owner == null)
            {
                return false;
            }
            if (owner.Apartments.Count != 0)
            {
                return false;
            }
            context.Owners.Remove(owner);
            context.SaveChanges();
            return true;
        }
        public bool Change(int id, string newValue, string option)
        {
            var Owner = GetOwner(id);
            if (option == "ФИО")
            {
                Owner.FioOwner = newValue;
            }
            if (option == "Номер телефона")
            {
                if (GetOwners().Any(x => x.NomTelOwner == newValue))
                {
                    return false;
                }
                Owner.NomTelOwner = newValue;
            }
            if (option == "Логин")
            {
                Owner.LoginOwner = newValue;
            }
            if (option == "Пароль")
            {
                Owner.PasswordOwner = newValue;
            }
            if (option == "Паспорт")
            {
                if (GetOwners().Any(x => x.PassportNumOwner == newValue) || newValue.Length > 11)
                {
                    return false;
                }
                Owner.PassportNumOwner = newValue;
            }
            context.SaveChanges();
            return true;
        }
    }
}

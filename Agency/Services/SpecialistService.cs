using Agency.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency.Services
{
    public class SpecialistService
    {
        private AgencyDbContext context = new();
        public List<Specialist> GetSpecs()
        {
            var specs = context.Specialists.Include(spec => spec.Deals).ToList();
            return specs;
        }
        public Specialist GetSpecialist(string Login)
        {
            return GetSpecs().FirstOrDefault(spec => spec.LoginSpec == Login);
        }
        public Specialist GetSpecialist(int id)
        {
            return GetSpecs().FirstOrDefault(spec => spec.IdSpec == id);
        }
        public bool Add(string Fio, string Passport, string NomTel, string Login, string Password)
        {
            if (GetSpecs().Any(x => x.PassportNumSpec == Passport) || Passport.Length > 11 || 
                GetSpecs().Any(x => x.NomTelSpec == NomTel) || IsExist(Login))
            {
                return false;
            }
            Specialist specialist = new Specialist
            {
                FioSpec = Fio,
                PassportNumSpec = Passport,
                NomTelSpec = NomTel,
                LoginSpec = Login,
                PasswordSpec = Password,
                CountDeals = 0
            };
            context.Specialists.Add(specialist);
            context.SaveChanges();
            return true;
        }
        public bool IsExist(string Login)
        {
            return GetSpecs().Any(x => x.LoginSpec == Login);
        }
        public bool Remove(int id)
        {
            var specialist = GetSpecialist(id);
            if (specialist == null)
            {
                MessageBox.Show("Пользователь не найден");
                return false;
            }
            if (specialist.Deals.Count != 0)
            {
                MessageBox.Show("У специалиста найдены сделки. Сначала удалите их.");
                return false;
            }
            context.Specialists.Remove(specialist);
            context.SaveChanges();
            return true;
        }
        public bool Change(int id, string newValue, string option)
        {
            var Spec = GetSpecialist(id);
            if (option == "ФИО")
            {
                Spec.FioSpec = newValue;
            }
            if (option == "Номер телефона")
            {
                if (GetSpecs().Any(x => x.NomTelSpec == newValue))
                {
                    return false;
                }
                Spec.NomTelSpec = newValue;
            }
            if (option == "Логин")
            {
                Spec.LoginSpec = newValue;
            }
            if (option == "Пароль")
            {
                Spec.PasswordSpec = newValue;
            }
            if (option == "Паспорт")
            {
                if (GetSpecs().Any(x => x.PassportNumSpec == newValue) || newValue.Length > 11)
                {
                    return false;
                }
                Spec.PassportNumSpec = newValue;
            }
            context.SaveChanges();
            return true;
        }
    }
}

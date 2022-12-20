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
            if (Passport.Length > 11)
            {
                MessageBox.Show("Неверный ввод паспортных данных.");
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
        public bool Remove(int id)
        {
            var specialist = GetSpecialist(id);
            if (specialist == null)
            {
                MessageBox.Show("Пользователь не найден");
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

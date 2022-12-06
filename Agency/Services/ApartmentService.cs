using Agency.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency.Services
{
    public class ApartmentService
    {
        private AgencyDbContext context = new();
        public List<Apartment> GetApartments()
        {
            var apartments = context.Apartments.Include(apartments => apartments.LoginOwnerNavigation).ToList();
            return apartments;
        }
        public Apartment GetApartment(string KadastrNom)
        {
            return GetApartments().FirstOrDefault(apartment => apartment.KadastrNom == KadastrNom);
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
    }
}

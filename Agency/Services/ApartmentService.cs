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
            var apartments = context.Apartments.Include(apartments => apartments.LoginOwnerNavigation).Include(apartments => apartments.Deals).ToList();
            return apartments;
        }
        public Apartment GetApartment(string KadastrNom)
        {
            return GetApartments().FirstOrDefault(apartment => apartment.KadastrNom == KadastrNom);
        }
        public bool Add(string KadastrNom, string Adress, double LiveSpace, double GeneralSpace, int CountRooms,
            int Floor, string TypePostr, int YearPostr, string? Metro,
            string? Furniture, decimal Price, string LoginOwner)
        {
            if (LiveSpace > GeneralSpace || CountRooms <= 0 || Floor <= 0 || YearPostr <= 0 || Price <= 0)
            {
                MessageBox.Show("Неверный ввод данных.");
                return false;
            }
            Apartment apartment = new Apartment
            {

                KadastrNom = KadastrNom,
                Adress = Adress,
                LiveSpace = LiveSpace,
                GeneralSpace = GeneralSpace,
                CountRooms = CountRooms,
                NumFloor = Floor,
                TypeBuild = TypePostr,
                YearBuild = YearPostr,
                Metro = Metro,
                Furniture = Furniture,
                Price = Price,
                LoginOwner = LoginOwner
    };
            context.Apartments.Add(apartment);
            context.SaveChanges();
            return true;
        }
        public bool isFree(Apartment apartment)
        {
            if (apartment.Deals.Count == 0)
            {
                return true;
            }
            return false;
        }
        public List<Apartment> GetFreeAparts()
        {
            List<Apartment> apartments = new List<Apartment>();
            foreach (Apartment apartment in GetApartments())
            {
                if (isFree(apartment))
                {
                    apartments.Add(apartment);
                }
            }
            return apartments;
        }
        public List<Apartment> GetApartments(int minSpace, int maxSpace)
        {
            List<Apartment> apartments = new List<Apartment>();
            foreach (Apartment apartment in GetFreeAparts())
            {
                if (apartment.GeneralSpace > minSpace && apartment.GeneralSpace < maxSpace)
                {
                    apartments.Add(apartment);
                }
            }
            return apartments;
        }
    }
}

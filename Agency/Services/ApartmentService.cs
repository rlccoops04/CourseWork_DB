using Agency.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Agency.Services
{
    public class ApartmentService
    {
        private AgencyDbContext context = new();
        public List<Apartment> GetApartments()
        {
            var apartments = context.Apartments.Include(apartments => apartments.IdOwnerNavigation).
                Include(apartments => apartments.Deals).Include(apartments => apartments.IdAdresNavigation).
                Include(apartments => apartments.Requests).ToList();
            return apartments;
        }
        public Apartment GetApartment(string KadastrNom)
        {
            return GetApartments().FirstOrDefault(apartment => apartment.KadastrNom == KadastrNom);
        }
        public Apartment GetApartment(Request request)
        {
            return GetApartments().FirstOrDefault(apartment => apartment.Requests.Contains(request));
        }
        public bool Add(string KadastrNom, string Adress, double LiveSpace, 
            double GeneralSpace, int CountRooms, int Floor, string TypePostr, 
            int YearPostr, string Metro, string Furniture, decimal Price, int ID_owner)
        {
            if (LiveSpace > GeneralSpace || CountRooms <= 0 || Floor <= 0 || YearPostr <= 0 || Price <= 0)
            {
                MessageBox.Show("Неверный ввод данных.");
                return false;
            }
            Adre adres = new Adre()
            {
                Adress = Adress,
                Metro = Metro
            };
            context.Adres.Add(adres);
            context.SaveChanges();

            Apartment apartment = new Apartment
            {

                KadastrNom = KadastrNom,
                IdAdres = adres.IdAdres,
                LiveSpace = LiveSpace,
                GeneralSpace = GeneralSpace,
                CountRooms = CountRooms,
                NumFloor = Floor,
                TypeBuild = TypePostr,
                YearBuild = YearPostr,
                Furniture = Furniture,
                Price = Price,
                IdOwner = ID_owner
            };
            context.Apartments.Add(apartment);
            context.SaveChanges();
            return true;
        }
        public bool IsAvailable(Apartment apartment)
        {
            if (apartment.Deals.Count == 0 && apartment.Requests.Count == 0)
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
                if (IsAvailable(apartment))
                {
                    apartments.Add(apartment);
                }
            }
            return apartments;
        }
        public bool Remove(Apartment apartment)
        {
            if (apartment.Requests.Count == 0 && apartment.Deals.Count == 0)
            {
                context.Apartments.Remove(apartment);
                context.SaveChanges();
                return true;
            }
            else
            {
                MessageBox.Show("На квартиру найдены сделки или запросы. Удаление невозможно.");
                return false;
            }
        }
    }
}

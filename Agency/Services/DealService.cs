using Agency.Models;
using Azure.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency.Services
{
    public class DealService
    {
        private AgencyDbContext context = new();
        public List<Deal> GetDeals()
        {
            return context.Deals.Include(d => d.IdBuyerNavigation).Include(d => d.IdSpecNavigation).
                Include(d => d.KadastrNomNavigation.IdAdresNavigation).ToList();
        }
        public List<Deal> GetDeals(Buyer buyer)
        {
            List<Deal> deals = new List<Deal>();
            foreach (Deal deal in GetDeals())
            {
                if (deal.IdBuyer == buyer.IdBuyer)
                {
                    deals.Add(deal);
                }
            }
            return deals;
        }
        public List<Deal> GetDeals(Specialist spec)
        {
            List<Deal> deals = new List<Deal>();
            foreach (Deal deal in GetDeals())
            {
                if (deal.IdSpec == spec.IdSpec)
                {
                    deals.Add(deal);
                }
            }
            return deals;
        }
        public bool Add(int id,string KadastrNom, int IdBuyer, int IdSpec)
        {
            try
            {
                Deal deal = new Deal()
                {
                    KodDeal=id,
                    KadastrNom = KadastrNom,
                    IdBuyer = IdBuyer,
                    IdSpec = IdSpec,
                    DataDeal = DateTime.Now
                };
                context.Deals.Add(deal);
                context.SaveChanges();
                MessageBox.Show("Успешно");
                return true;
            }
            catch
            {
                MessageBox.Show("Ошибка");
                return false;
            }
        }
    }
}

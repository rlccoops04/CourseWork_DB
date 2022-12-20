using Agency.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency.Services
{
    public class RequestService
    {
        private AgencyDbContext context = new();
        public List<Request> GetRequests()
        {
            return context.Requests.Include(request => request.KadastrNomNavigation.IdAdresNavigation).
                Include(request => request.IdBuyerNavigation).ToList();
        }
        public List<Request> GetRequests(Buyer buyer)
        {
            List<Request> requests = new List<Request>();
            foreach (Request request in GetRequests())
            {
                if (request.IdBuyerNavigation.LoginBuyer == buyer.LoginBuyer)
                {
                    requests.Add(request);
                }
            }
            return requests;
        }
        public List<Request> GetRequests(int id_user)
        {
            List<Request> requests = new List<Request>();
            foreach (Request request in GetRequests())
            {
                if (request.IdBuyerNavigation.IdBuyer == id_user)
                {
                    requests.Add(request);
                }
            }
            return requests;
        }
        public Request GetRequest(string KadastrNom)
        {
            return GetRequests().FirstOrDefault(request => request.KadastrNom == KadastrNom);
        }
        public bool Add(string KadastrNom, int IdBuyer)
        {
            try
            {
                Request request = new Request()
                {
                    DataReq = DateTime.Now,
                    KadastrNom = KadastrNom,
                    IdBuyer = IdBuyer
                };
                context.Requests.Add(request);
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
        public bool Remove(string KadastrNom)
        {
            try
            {
                context.Requests.Remove(GetRequest(KadastrNom));
                context.SaveChanges();
                return true;
            }
            catch
            {
                MessageBox.Show("Ошибка");
                return false;
            }
        }
        public bool Remove(Request request)
        {
            try
            {
                context.Requests.Remove(request);
                context.SaveChanges();
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

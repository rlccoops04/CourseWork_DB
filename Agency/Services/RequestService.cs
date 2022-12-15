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
            return context.Requests.Include(request => request.KadastrNomNavigation).
                Include(request => request.LoginBuyerNavigation).ToList();
        }
        public List<Request> GetRequests(Buyer buyer)
        {
            List<Request> requests = new List<Request>();
            foreach (Request request in context.Requests.Include(request => request.KadastrNomNavigation.IdAdresNavigation).
                Include(request => request.LoginBuyerNavigation).ToList())
            {
                if (request.LoginBuyer == buyer.LoginBuyer)
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
        public bool Add(string KadastrNom, string LoginBuyer)
        {
            try
            {
                Request request = new Request()
                {
                    DataReq = DateTime.Now,
                    KadastrNom = KadastrNom,
                    LoginBuyer = LoginBuyer
                };
                context.Requests.Add(request);
                context.SaveChanges();
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

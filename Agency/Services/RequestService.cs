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
        BuyerService buyerService = new BuyerService();
        public bool Add(double LiveSpaceReq, double GeneralSpaceReq, int CountRoomsReq, 
            int FloorReq, string TypePostrReq, int YearPostrReq, string? MetroReq, 
            string? FurnitureReq, decimal MaxPriceReq, string LoginBuyer)
        {
            if (LiveSpaceReq > GeneralSpaceReq || CountRoomsReq <= 0 || FloorReq <= 0 || YearPostrReq <= 0 || MaxPriceReq <= 0)
            {
                MessageBox.Show("Неверный ввод паспортных данных.");
                return false;
            }
            Request request = new Request
            {
                DataReq = DateTime.Now,
                LiveSpaceReq = LiveSpaceReq,
                GeneralSpaceReq = GeneralSpaceReq,
                CountRoomsReq = CountRoomsReq,
                FloorReq = FloorReq,
                TypePostrReq = TypePostrReq,
                YearPostrReq = YearPostrReq,
                MetroReq = MetroReq,
                FurnitureReq = FurnitureReq,
                MaxPriceReq = MaxPriceReq,
                LoginBuyer = LoginBuyer
            };
            context.Requests.Add(request);
            buyerService.GetBuyer(LoginBuyer).Requests.Add(request);
            context.SaveChanges();
            return true;
        }
    }
}

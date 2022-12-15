using Agency.Models;
using Agency.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agency.Forms.User_Controls
{
    public partial class UCApartmentWithReq : UserControl
    {
        private Apartment apartment;
        private string LoginBuyer;
        private RequestService reqService = new();
        public UCApartmentWithReq(Apartment apartment, string LoginBuyer)
        {
            this.LoginBuyer = LoginBuyer;
            this.apartment = apartment;
            InitializeComponent();
        }

        private void UCApartmentWithReq_Load(object sender, EventArgs e)
        {
            lblMainInfo.Text += apartment.CountRooms + "-к. квартира, " + apartment.GeneralSpace + " м2, " + apartment.NumFloor + " эт.";
            lblPrice.Text += String.Format("{0:N}", Convert.ToInt64(apartment.Price)) + " ₽";
            lblAdress.Text += apartment.IdAdresNavigation.Adress;
            lblLivespace.Text += apartment.LiveSpace;
            lblType.Text += apartment.TypeBuild;
            lblYear.Text += apartment.YearBuild;
            lblMetro.Text += apartment.IdAdresNavigation.Metro;
            lblFurniture.Text += apartment.Furniture;
        }

        private void btnAddReq_Click(object sender, EventArgs e)
        {
            reqService.Add(apartment.KadastrNom, LoginBuyer);
            btnAddReq.Enabled = false;
        }
    }
}

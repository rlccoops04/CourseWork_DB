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
    public partial class UCRemoveApartment : UserControl
    {
        private Apartment apartment;
        private ApartmentService apartService = new();
        public UCRemoveApartment(Apartment apartment)
        {
            this.apartment = apartment;
            InitializeComponent();
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            apartService.Remove(apartment);
            btnRemove.Enabled = false;
        }

        private void UCRemoveApartment_Load(object sender, EventArgs e)
        {
            lblMainInfo.Text += apartment.CountRooms + "-к. квартира, " + apartment.GeneralSpace + " м2, " + apartment.NumFloor + " эт.";
            lblPrice.Text += String.Format("{0:N}", Convert.ToInt64(apartment.Price)) + " ₽";
            lblAdress.Text += apartment.IdAdresNavigation.City + ", " + apartment.IdAdresNavigation.Street +
                ", " + apartment.IdAdresNavigation.HomeNom + ", " + apartment.IdAdresNavigation.ApartNom;
            lblLivespace.Text += apartment.LiveSpace;
            lblType.Text += apartment.TypeBuild;
            lblYear.Text += apartment.YearBuild;
            lblMetro.Text += apartment.IdAdresNavigation.Metro;
            lblFurniture.Text += apartment.Furniture;
        }
    }
}

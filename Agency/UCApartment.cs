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

namespace Agency
{
    public partial class UCApartment : UserControl
    {
        private Apartment apartment = new();
        public UCApartment(Apartment apartment)
        {
            this.apartment = apartment;
            InitializeComponent();
        }

        private void UCApartment_Load(object sender, EventArgs e)
        {
            lblMainInfo.Text += apartment.CountRooms + "-к. квартира, " + apartment.GeneralSpace + " м2, " + apartment.NumFloor + " эт.";
            //lblPrice.Text += Convert.ToInt64(apartment.Price).ToString().Insert(1, " ").Insert(5, " ") + " ₽";
            lblPrice.Text += String.Format("{0:N}", Convert.ToInt64(apartment.Price)) + " ₽";
            lblAdress.Text += apartment.Adress;
            lblLivespace.Text += apartment.LiveSpace;
            lblType.Text += apartment.TypeBuild;
            lblYear.Text += apartment.YearBuild;
        }
    }
}

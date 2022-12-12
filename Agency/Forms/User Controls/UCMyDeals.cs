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
    public partial class UCMyDeals : UserControl
    {
        private Buyer buyer;
        private ApartmentService apartService = new();
        private UCApartment ucApartment;
        public UCMyDeals(Buyer buyer)
        {
            this.buyer = buyer;
            InitializeComponent();
        }

        private void UCMyDeals_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Deal deal in buyer.Deals)
            {
                ucApartment = new(apartService.GetApartment(deal.KadastrNom));
                ucApartment.Location = new Point(0, i);
                pnlAparts.Controls.Add(ucApartment);
                i += 240;
            }
            lblfound.Text += buyer.Deals.Count.ToString();
        }
    }
}

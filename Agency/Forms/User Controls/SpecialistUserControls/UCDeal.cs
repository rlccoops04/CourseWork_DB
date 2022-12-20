using Agency.Models;
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
    public partial class UCDeal : UserControl
    {
        private Deal deal;
        public UCDeal(Deal deal)
        {
            this.deal = deal;
            InitializeComponent();
        }

        private void UCDeal_Load(object sender, EventArgs e)
        {
            lblNumDeal.Text += deal.KodDeal;
            lblBuyer.Text += deal.IdBuyerNavigation.FioBuyer + "(id: " +deal.IdBuyerNavigation.IdBuyer + ")";
            lblSpec.Text += deal.IdSpecNavigation.FioSpec + "(id: " + deal.IdSpecNavigation.IdSpec + ")";
            lblDate.Text += deal.DataDeal;
            UCApartment ucApartment = new(deal.KadastrNomNavigation);
            ucApartment.Location = new Point(12, 190);
            this.Controls.Add(ucApartment);
        }
    }
}

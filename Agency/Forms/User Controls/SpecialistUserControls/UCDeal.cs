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
            lblBuyer.Text += deal.IdBuyerNavigation.FioBuyer + "(id: " + deal.IdBuyerNavigation.IdBuyer + ")";
            lblSpec.Text += deal.IdSpecNavigation.FioSpec + "(id: " + deal.IdSpecNavigation.IdSpec + ")";
            lblDate.Text += DateTime.Parse(deal.DataDeal.ToString()).ToShortDateString();
            Label lblAdres = new Label();
            lblAdres.Location = new Point(130, 14);
            lblAdres.Font = new Font(lblAdres.Font.Name,11,FontStyle.Bold);
            lblAdres.Text = deal.KadastrNomNavigation.IdAdresNavigation.Adress;
            lblAdres.Size = new Size(1000 ,lblAdres.Height);
            this.Controls.Add(lblAdres);
            Label lblPrice = new Label();
            lblPrice.Location = new Point(130, 39);
            lblPrice.Font = new Font(lblPrice.Font.Name, 11, FontStyle.Bold);
            lblPrice.Text = String.Format("{0:N}", Convert.ToInt64(deal.KadastrNomNavigation.Price)) + " ₽";
            lblPrice.Size = new Size(1000, lblPrice.Height);
            this.Controls.Add(lblPrice);
        }
    }
}

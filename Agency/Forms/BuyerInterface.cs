using Agency.Forms.User_Controls;
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
    public partial class BuyerInterface : Form
    {
        private Buyer buyer;
        private UCProfile ucProfile;
        private UCKatalog ucKatalog;
        private UCSearchApartments ucSearchApartments;
        private UCRequests ucRequests;
        private UCAddRequest ucAddRequest;
        private UCMyDeals ucDeals;
        public BuyerInterface(Buyer buyer)
        {
            this.buyer = buyer;
            InitializeComponent();
        }

        private void BuyerInterface_Load(object sender, EventArgs e)
        {
            lblCurrUserName.Text += buyer.FioBuyer;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void HideAll()
        {
            if (this.Controls.Contains(ucProfile))
            {
                ucProfile.Hide();
            }
            if (this.Controls.Contains(ucKatalog))
            {
                ucKatalog.Hide();
            }
            if (this.Controls.Contains(ucSearchApartments))
            {
                ucSearchApartments.Hide();
            }
            if (this.Controls.Contains(ucRequests))
            {
                ucRequests.Hide();
            }
            if (this.Controls.Contains(ucAddRequest))
            {
                ucAddRequest.Hide();
            }
            if (this.Controls.Contains(ucDeals))
            {
                ucDeals.Hide();
            }
        }
        private void btnProfile_Click(object sender, EventArgs e)
        {
            HideAll();
            ucProfile = new(buyer.LoginBuyer, "Buyer");
            ucProfile.Location = new Point(350, 177);
            this.Controls.Add(ucProfile);
            lblCurrPage.Text = btnProfile.Text;
        }

        private void btnKatalog_Click(object sender, EventArgs e)
        {
            HideAll();
            ucKatalog = new();
            ucKatalog.Location = new Point(220, 83);
            this.Controls.Add(ucKatalog);
            lblCurrPage.Text = btnKatalog.Text;
        }

        private void btnSearchAparts_Click(object sender, EventArgs e)
        {
            HideAll();
            ucSearchApartments = new();
            ucSearchApartments.Location = new Point(220, 83);
            this.Controls.Add(ucSearchApartments);
            lblCurrPage.Text = btnSearchAparts.Text;
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            HideAll();
            ucRequests = new(buyer);
            ucRequests.Location = new Point(220, 83);
            this.Controls.Add(ucRequests);
            lblCurrPage.Text = btnRequest.Text;
        }

        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            HideAll();
            ucAddRequest = new(buyer);
            ucAddRequest.Location = new Point(220, 83);
            this.Controls.Add(ucAddRequest);
            lblCurrPage.Text = btnAddRequest.Text;
            //buyer = buyerService.GetBuyer(buyer.LoginBuyer);
        }

        private void btnMyDeals_Click(object sender, EventArgs e)
        {
            HideAll();
            ucDeals = new(buyer);
            ucDeals.Location = new Point(220, 83);
            this.Controls.Add(ucDeals);
            lblCurrPage.Text = btnMyDeals.Text;
        }
    }
}

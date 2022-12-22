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
        private int id_user;
        private UCProfile ucProfile;
        private UCKatalog ucKatalog;
        private UCSearchApartments ucSearchApartments;
        private UCRequests ucRequests;
        private UCAddRequest ucAddRequest;
        private UCMyDeals ucDeals;
        public BuyerInterface(int id_user)
        {
            this.id_user = id_user;
            InitializeComponent();
        }

        private void BuyerInterface_Load(object sender, EventArgs e)
        {
            HideAll();
            ucSearchApartments = new();
            ucSearchApartments.Location = new Point(0, 43);
            this.Controls.Add(ucSearchApartments);
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
        private void lblProfile_Click(object sender, EventArgs e)
        {
            HideAll();
            ucProfile = new(id_user, "Buyer");
            ucProfile.Location = new Point(0, 43);
            this.Controls.Add(ucProfile);
        }

        private void lblAparts_Click(object sender, EventArgs e)
        {
            HideAll();
            ucSearchApartments = new();
            ucSearchApartments.Location = new Point(0, 43);
            this.Controls.Add(ucSearchApartments);
        }

        private void lblMyReqs_Click(object sender, EventArgs e)
        {
            HideAll();
            ucRequests = new(id_user);
            ucRequests.Location = new Point(0, 43);
            this.Controls.Add(ucRequests);
        }

        private void lblAddReq_Click(object sender, EventArgs e)
        {
            HideAll();
            ucAddRequest = new(id_user);
            ucAddRequest.Location = new Point(0, 43);
            this.Controls.Add(ucAddRequest);
        }

        private void lblMyDeals_Click(object sender, EventArgs e)
        {
            HideAll();
            ucDeals = new(id_user);
            ucDeals.Location = new Point(0, 43);
            this.Controls.Add(ucDeals);
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

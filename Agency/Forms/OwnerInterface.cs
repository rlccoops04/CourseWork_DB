using Agency.Forms.User_Controls;
using Agency.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agency.Forms
{
    public partial class OwnerInterface : Form
    {
        private Owner owner;
        private UCProfile ucProfile;
        private UCKatalog ucKatalog;
        private UCSearchApartments ucSearchApartments;
        private UCMyAparts ucMyAparts;
        private UCAddApartment ucAddApartment;
        private UCRequests ucRequests;
        private UCAddRequest ucAddRequest;
        private UCMyDeals ucDeals;

        public OwnerInterface(Owner owner)
        {
            this.owner = owner;
            InitializeComponent();
        }
        private void OwnerInterface_Load(object sender, EventArgs e)
        {
            lblCurrUserName.Text += owner.FioOwner;
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
            if (this.Controls.Contains(ucMyAparts))
            {
                ucMyAparts.Hide();
            }
            if (this.Controls.Contains(ucAddApartment))
            {
                ucAddApartment.Hide();
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
            ucProfile = new(owner.LoginOwner, "Owner");
            ucProfile.Location = new Point(350, 177);
            this.Controls.Add(ucProfile);
            lblCurrPage.Text = btnProfile.Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnMyAparts_Click(object sender, EventArgs e)
        {
            HideAll();
            ucMyAparts = new(owner);
            ucMyAparts.Location = new Point(220, 83);
            this.Controls.Add(ucMyAparts);
            lblCurrPage.Text = btnMyAparts.Text;
        }

        private void btnAddApartment_Click(object sender, EventArgs e)
        {
            HideAll();
            ucAddApartment = new(owner);
            ucAddApartment.Location = new Point(220, 83);
            this.Controls.Add(ucAddApartment);
            lblCurrPage.Text = btnAddApartment.Text;
        }
    }
}

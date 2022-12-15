using Agency.Models;
using Agency.Services;
using Microsoft.EntityFrameworkCore;
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
    public partial class UCMyAparts : UserControl
    {
        private Owner owner;
        private AgencyDbContext context = new();
        private ApartmentService apartService = new();
        private UCApartment ucApartment;
        public UCMyAparts(Owner owner)
        {
            this.owner = owner;
            InitializeComponent();
        }
        private void UCMyAparts_Load(object sender, EventArgs e)
        {
            int i = 0;
            int count = 0;
            foreach (Apartment apartment in apartService.GetApartments())
            {
                if (apartment.LoginOwner == owner.LoginOwner)
                {
                    Label label = new Label();
                    label.Location = new Point(10, i);
                    label.Size = new Size(label.Width + 50, label.Height);
                    label.Font = new Font(label.Font.Name, 9, label.Font.Style);
                    pnlAparts.Controls.Add(label);

                    if (apartment.Deals.Count != 0)
                    {
                        label.Text = "Продана";
                        label.ForeColor = Color.Red;
                    }
                    else if (apartment.Requests.Count != 0)
                    {
                        label.Text = "Забронирована";
                        label.ForeColor = Color.DarkOrange;
                    }
                    else
                    {
                        label.Text = "На продаже";
                        label.ForeColor = Color.Green;
                    }
                    i += 30;

                    ucApartment = new(apartment);
                    ucApartment.Location = new Point(0, i);
                    pnlAparts.Controls.Add(ucApartment);
                    i += 240;
                    count++;
                }
            }
            lblfound.Text += count;
        }
    }
}

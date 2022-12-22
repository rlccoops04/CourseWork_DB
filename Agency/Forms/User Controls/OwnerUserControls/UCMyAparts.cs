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
        private int id_user;
        private ApartmentService apartService = new();
        private UCApartment ucApartment;
        private UCRemoveApartment ucRemoveApart;
        public UCMyAparts(int id_user)
        {
            this.id_user = id_user;
            InitializeComponent();
        }
        private void UCMyAparts_Load(object sender, EventArgs e)
        {
            int i = 0;
            int count = 0;
            foreach (Apartment apartment in apartService.GetApartments())
            {
                if (apartment.IdOwnerNavigation.IdOwner == id_user)
                {
                    Label label = new Label();
                    label.Location = new Point(10, i);
                    label.Size = new Size(label.Width + 50, label.Height);
                    label.Font = new Font(label.Font.Name, 9, FontStyle.Bold);
                    pnlAparts.Controls.Add(label);
                    i += 30;
                    if (apartment.Deals.Count != 0)
                    {
                        ucApartment = new(apartment);
                        ucApartment.Location = new Point(10, i);
                        pnlAparts.Controls.Add(ucApartment);
                        label.Text = "Продана";
                        label.ForeColor = Color.Red;
                    }
                    else if (apartment.Requests.Count != 0)
                    {
                        ucApartment = new(apartment);
                        ucApartment.Location = new Point(10, i);
                        pnlAparts.Controls.Add(ucApartment);
                        label.Text = "Забронирована";
                        label.ForeColor = Color.DarkOrange;
                    }
                    else
                    {
                        ucRemoveApart = new(apartment);
                        ucRemoveApart.Location = new Point(10, i);
                        pnlAparts.Controls.Add(ucRemoveApart);
                        label.Text = "На продаже";
                        label.ForeColor = Color.Green;
                    }
                    i += 240;
                    count++;
                }
            }
            lblfound.Text += count;
        }
    }
}

using Agency.Models;
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
            foreach (Apartment apartment in context.Apartments.ToList())
            {
                if (apartment.LoginOwner == owner.LoginOwner)
                {
                    Label label = new Label();
                    label.Location = new Point(10, i);
                    pnlAparts.Controls.Add(label);
                    label.Font = new Font(label.Font.Name, 9, label.Font.Style);
                    if (context.Deals.ToList().Any(x => x.KadastrNom == apartment.KadastrNom))
                    {
                        label.Text = "Продана";
                        label.ForeColor = Color.Red;
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

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
    public partial class UCKatalog : UserControl
    {
        private ApartmentService apartmentServ = new();
        private UCApartment ucApartment;
        public UCKatalog()
        {
            InitializeComponent();
        }

        private void UCKatalog_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Apartment apartment in apartmentServ.GetFreeAparts())
            {
                ucApartment = new(apartment);
                ucApartment.Location = new Point(0, i);
                pnlAparts.Controls.Add(ucApartment);
                i += 240;
            }
            lblfound.Text += apartmentServ.GetFreeAparts().Count.ToString();
        }
    }
}


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

namespace Agency.Forms.User_Controls.DirectorUserControls
{

    public partial class UCRemoveApartments : UserControl
    { 
        private ApartmentService apartServ = new();
        private UCRemoveApartment ucRemoveApart;
        public UCRemoveApartments()
        {
            InitializeComponent();
        }

        private void UCRemoveApartments_Load(object sender, EventArgs e)
        {
            int i = 0;
            int count = 0;
            foreach (Apartment apartment in apartServ.GetFreeAparts())
            {
                ucRemoveApart = new(apartment);
                ucRemoveApart.Location = new Point(10, i);
                pnlAparts.Controls.Add(ucRemoveApart);
                i += 240;
                count++;
            }
            lblfound.Text += count;
        }
    }
}

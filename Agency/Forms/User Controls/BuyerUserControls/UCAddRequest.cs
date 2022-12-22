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

namespace Agency.Forms.User_Controls
{
    public partial class UCAddRequest : UserControl
    {
        private int id_user;
        private ApartmentService apartmentServ = new();
        private UCApartmentWithReq ucApartment;
        public UCAddRequest(int id_user)
        {
            this.id_user = id_user;
            InitializeComponent();
        }

        private void UCAddRequest_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Apartment apartment in apartmentServ.GetFreeAparts())
            {
                ucApartment = new(apartment, id_user);
                ucApartment.Location = new Point(10, i);
                pnlAparts.Controls.Add(ucApartment);
                i += 240;
            }
            lblfound.Text += apartmentServ.GetFreeAparts().Count.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}

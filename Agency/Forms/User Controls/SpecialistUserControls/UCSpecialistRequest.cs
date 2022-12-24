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
    public partial class UCSpecialistRequest : UserControl
    {
        private Request request;
        private UCApartment ucApartment;
        private RequestService reqService = new();
        private DealService dealService = new();
        private int id_spec;
        public UCSpecialistRequest(Request request, int id_spec)
        {
            this.request = request;
            this.id_spec = id_spec;
            InitializeComponent();
        }

        private void UCSpecialistRequest_Load(object sender, EventArgs e)
        {
            lblDate.Text = request.DataReq.ToString();
            lblReqID.Text += request.IdReq.ToString();
            ucApartment = new(request.KadastrNomNavigation);
            ucApartment.Location = new Point(0, 50);
            this.Controls.Add(ucApartment);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (dealService.Add(request.IdReq, request.KadastrNom, request.IdBuyer, id_spec))
            {
                reqService.Remove(request);
                btnConfirm.Enabled = false;
                btnCancel.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnConfirm.Enabled = false;
            btnCancel.Enabled = false;
            reqService.Remove(request);
        }
    }
}

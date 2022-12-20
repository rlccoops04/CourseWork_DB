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
    public partial class UCRequest : UserControl
    {
        private Request request;
        private UCApartment ucApartment;
        private ApartmentService apartService = new();
        private RequestService reqService = new();
        public UCRequest(Request request)
        {
            this.request = request;
            InitializeComponent();
        }

        private void UCRequest_Load(object sender, EventArgs e)
        {
            lblDate.Text = request.DataReq.ToString();
            lblReqID.Text += request.IdReq.ToString();
            ucApartment = new(request.KadastrNomNavigation);
            ucApartment.Location = new Point(0, 50);
            this.Controls.Add(ucApartment);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reqService.Remove(request);
            button1.Enabled = false;
        }
    }
}

using Agency.Models;
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
        public UCRequest(Request request)
        {
            this.request = request;
            InitializeComponent();
        }

        private void UCRequest_Load(object sender, EventArgs e)
        {
            lblDate.Text = request.DataReq.ToString();
            lblReqID.Text += request.IdReq.ToString();
            lblCountRooms.Text += request.CountRoomsReq.ToString();
            lblFloor.Text += request.FloorReq.ToString();
            lblLiveSpace.Text += request.LiveSpaceReq.ToString();
            lblYearBld.Text += request.YearPostrReq.ToString();
            lblTypeBld.Text += request.TypePostrReq.ToString();
            lblMaxPrice.Text += request.MaxPriceReq.ToString();
            if (request.MetroReq == "рядом")
            {
                cbMetro.Checked = true;
            }
            if (request.FurnitureReq == "есть")
            {
                cbFurniture.Checked = true;
            }
        }
    }
}

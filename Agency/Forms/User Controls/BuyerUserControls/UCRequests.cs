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
    public partial class UCRequests : UserControl
    {
        private int id_user;
        private RequestService reqService = new();
        public UCRequests(int id_user)
        {
            this.id_user = id_user;
            InitializeComponent();
        }

        private void UCRequests_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Request request in reqService.GetRequests(id_user))
            {
                UCRequest ucRequest = new UCRequest(request);
                ucRequest.Location = new Point(10, i);
                i += 280;
                panelReqs.Controls.Add(ucRequest);
            }
            lblCountReqs.Text += reqService.GetRequests(id_user).Count();
        }
    }
}

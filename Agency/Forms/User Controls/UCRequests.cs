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

namespace Agency.Forms.User_Controls
{
    public partial class UCRequests : UserControl
    {
        private Buyer currBuyer;
        private AgencyDbContext context = new();
        public UCRequests(Buyer buyer)
        {
            currBuyer = buyer;
            InitializeComponent();
        }

        private void UCRequests_Load(object sender, EventArgs e)
        {
            int i = 10;
            int count = 0;
            foreach (Request request in context.Requests.ToList())
            {
                if (request.LoginBuyer == currBuyer.LoginBuyer)
                {
                    UCRequest ucRequest = new UCRequest(request);
                    ucRequest.Location = new Point(0, i);
                    i += 200;
                    panelReqs.Controls.Add(ucRequest);
                    count++;
                }
            }
            lblCountReqs.Text += count;
        }
    }
}

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
    public partial class UCSpecialistRequests : UserControl
    {
        private RequestService reqService = new();
        private int id_spec;
        public UCSpecialistRequests(int id_spec)
        {
            this.id_spec = id_spec;
            InitializeComponent();
        }

        private void UCSpecialistRequests_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Request request in reqService.GetRequests())
            {
                UCSpecialistRequest ucRequest = new UCSpecialistRequest(request, id_spec);
                ucRequest.Location = new Point(10, i);
                i += 280;
                panelReqs.Controls.Add(ucRequest);
            }
            lblCountReqs.Text += reqService.GetRequests().Count();
        }
    }
}

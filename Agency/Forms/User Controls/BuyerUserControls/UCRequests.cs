using Agency.Models;
using Agency.Services;

namespace Agency.Forms.User_Controls
{
    public partial class UCRequests : UserControl
    {
        private readonly int id_buyer;
        private RequestService reqService;
        public UCRequests(int id_buyer)
        {
            this.id_buyer = id_buyer;
            reqService = new();
            InitializeComponent();
        }
        private void UCRequests_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Request request in reqService.GetRequests(id_buyer))
            {
                UCRequest ucRequest = new UCRequest(request);
                ucRequest.Location = new Point(10, i);
                i += 280;
                panelReqs.Controls.Add(ucRequest);
            }
            lblCountReqs.Text += reqService.GetRequests(id_buyer).Count();
        }
    }
}

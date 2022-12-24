using Agency.Models;
using Agency.Services;

namespace Agency
{
    public partial class UCRequest : UserControl
    {
        private Request request;
        private UCApartment ucApartment;
        private RequestService reqService;
        public UCRequest(Request request)
        {
            this.request = request;
            reqService = new();
            InitializeComponent();
        }

        private void UCRequest_Load(object sender, EventArgs e)
        {
            lblDate.Text += request.DataReq.ToString();
            lblReqID.Text += request.IdReq.ToString();
            ucApartment = new(request.KadastrNomNavigation);
            ucApartment.Location = new Point(0, 38);
            Controls.Add(ucApartment);
        }
        private void RemoveRequest_Click(object sender, EventArgs e)
        {
            reqService.Remove(request);
            btnRemoveRequest.Enabled = false;
        }
    }
}

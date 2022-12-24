using Agency.Models;
using Agency.Services;

namespace Agency.Forms.User_Controls
{
    public partial class UCAddRequest : UserControl
    {
        private readonly int id_buyer;
        private ApartmentService apartmentServ;
        private UCApartmentWithReq ucApartment;
        public UCAddRequest(int id_buyer)
        {
            apartmentServ = new();
            this.id_buyer = id_buyer;
            InitializeComponent();
        }

        private void UCAddRequest_Load(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Apartment apartment in apartmentServ.GetFreeAparts())
            {
                ucApartment = new(apartment, id_buyer);
                ucApartment.Location = new Point(10, i);
                pnlAparts.Controls.Add(ucApartment);
                i += 240;
            }
            lblfound.Text += apartmentServ.GetFreeAparts().Count.ToString();
        }
    }
}

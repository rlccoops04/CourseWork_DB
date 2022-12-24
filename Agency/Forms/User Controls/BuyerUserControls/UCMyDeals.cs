using Agency.Models;
using Agency.Services;

namespace Agency.Forms.User_Controls
{
    public partial class UCMyDeals : UserControl
    {
        private readonly int id_buyer;
        private ApartmentService apartService;
        private BuyerService buyerService;
        private UCApartment ucApartment;
        public UCMyDeals(int id_buyer)
        {
            this.id_buyer = id_buyer;
            apartService = new();
            buyerService = new();
            InitializeComponent();
        }

        private void UCMyDeals_Load(object sender, EventArgs e)
        {
            var buyer = buyerService.GetBuyer(id_buyer);
            int i = 0;
            foreach (Deal deal in buyer.Deals)
            {
                ucApartment = new(apartService.GetApartment(deal.KadastrNom));
                ucApartment.Location = new Point(10, i);
                pnlAparts.Controls.Add(ucApartment);
                i += 240;
            }
            lblfound.Text += buyer.Deals.Count.ToString();
        }
    }
}

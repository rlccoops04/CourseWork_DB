using Agency.Models;
using Agency.Services;

namespace Agency.Forms.User_Controls
{
    public partial class UCApartmentWithReq : UserControl
    {
        private readonly int id_buyer;
        private Apartment apartment;
        private RequestService reqService;
        public UCApartmentWithReq(Apartment apartment, int id_buyer)
        {
            this.id_buyer = id_buyer;
            this.apartment = apartment;
            reqService = new();
            InitializeComponent();
        }
        private void UCApartmentWithReq_Load(object sender, EventArgs e)
        {
            lblMainInfo.Text += apartment.CountRooms + "-к. квартира, " + apartment.GeneralSpace + " м2, " + apartment.NumFloor + " эт.";
            lblPrice.Text += String.Format("{0:N}", Convert.ToInt64(apartment.Price)) + " ₽";
            lblAdress.Text += apartment.IdAdresNavigation.City + ", " + apartment.IdAdresNavigation.Street +
                ", " + apartment.IdAdresNavigation.HomeNom + ", " + apartment.IdAdresNavigation.ApartNom;
            lblLivespace.Text += apartment.LiveSpace;
            lblType.Text += apartment.TypeBuild;
            lblYear.Text += apartment.YearBuild;
            lblMetro.Text += apartment.IdAdresNavigation.Metro;
            lblFurniture.Text += apartment.Furniture;
        }
        private void AddRequest_Click(object sender, EventArgs e)
        {
            reqService.Add(apartment.KadastrNom, id_buyer);
            btnAddReq.Enabled = false;
        }
    }
}

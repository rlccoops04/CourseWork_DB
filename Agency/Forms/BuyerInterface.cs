using Agency.Forms.User_Controls;

namespace Agency
{
    public partial class BuyerInterface : Form
    {
        private int id_buyer;
        private UserControl ucProfile, ucSearchApartments, ucRequests, ucAddRequest, ucDeals;
        public BuyerInterface(int id_buyer)
        {
            this.id_buyer = id_buyer;
            InitializeComponent();
        }

        private void BuyerInterface_Load(object sender, EventArgs e)
        {
            ucSearchApartments = new UCSearchApartments();
            AddControl(ucSearchApartments);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void DisposeAll()
        {
            if (this.Controls.Contains(ucProfile))
            {
                ucProfile.Dispose();
            }
            if (this.Controls.Contains(ucSearchApartments))
            {
                ucSearchApartments.Dispose();
            }
            if (this.Controls.Contains(ucRequests))
            {
                ucRequests.Dispose();
            }
            if (this.Controls.Contains(ucAddRequest))
            {
                ucAddRequest.Dispose();
            }
            if (this.Controls.Contains(ucDeals))
            {
                ucDeals.Dispose();
            }
        }
        private void AddControl(UserControl userControl)
        {
            DisposeAll();
            userControl.Location = new Point(0, 43);
            Controls.Add(userControl);
        }
        private void ShowAparts_Click(object sender, EventArgs e)
        {
            ucSearchApartments = new UCSearchApartments();
            AddControl(ucSearchApartments);
        }
        private void MyProfile_Click(object sender, EventArgs e)
        {
            ucProfile = new UCProfile(id_buyer, "Buyer");
            AddControl(ucProfile);
        }
        private void ShowMyDeals_Click(object sender, EventArgs e)
        {
            ucDeals = new UCMyDeals(id_buyer);
            AddControl(ucDeals);
        }
        private void AddRequest_Click(object sender, EventArgs e)
        {
            ucAddRequest = new UCAddRequest(id_buyer);
            AddControl(ucAddRequest);
        }
        private void ShowMyRequests_Click(object sender, EventArgs e)
        {
            ucRequests = new UCRequests(id_buyer);
            AddControl(ucRequests);
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

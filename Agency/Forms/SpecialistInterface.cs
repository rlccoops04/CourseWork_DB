using Agency.Forms.User_Controls;

namespace Agency
{
    public partial class SpecialistInterface : Form
    {
        private readonly int id_spec;
        private UserControl ucProfile, ucDeals, ucReqs, ucSearchAparts;
        public SpecialistInterface(int id_spec)
        {
            this.id_spec = id_spec;
            InitializeComponent();
        }
        private void DisposeAll()
        {
            if (this.Controls.Contains(ucProfile))
            {
                ucProfile.Dispose();
            }
            if (this.Controls.Contains(ucDeals))
            {
                ucDeals.Dispose();
            }
            if (this.Controls.Contains(ucReqs))
            {
                ucReqs.Dispose();
            }
            if (this.Controls.Contains(ucSearchAparts))
            {
                ucSearchAparts.Dispose();
            }
        }
        private void AddControl(UserControl userControl)
        {
            DisposeAll();
            userControl.Location = new Point(0, 43);
            Controls.Add(userControl);
        }
        private void SpecialistInterface_Load(object sender, EventArgs e)
        {
            ucSearchAparts = new UCSearchApartments();
            AddControl(ucSearchAparts);
        }
        private void ShowAparts_Click(object sender, EventArgs e)
        {
            ucSearchAparts = new UCSearchApartments();
            AddControl(ucSearchAparts);
        }
        private void ShowRequests_Click(object sender, EventArgs e)
        {
            ucReqs = new UCSpecialistRequests(id_spec);
            AddControl(ucReqs);
        }
        private void ShowMyDeals_Click(object sender, EventArgs e)
        {
            ucDeals = new UCSpecialistDeals(id_spec);
            AddControl(ucDeals);
        }
        private void MyProfile_Click(object sender, EventArgs e)
        {
            ucProfile = new UCProfile(id_spec, "Spec");
            AddControl(ucProfile);
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

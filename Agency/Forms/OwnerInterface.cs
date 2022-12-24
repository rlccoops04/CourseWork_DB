using Agency.Forms.User_Controls;

namespace Agency.Forms
{
    public partial class OwnerInterface : Form
    {
        private readonly int id_owner;
        private UserControl ucProfile, ucSearchApartments, ucMyAparts, ucAddApartment;
        public OwnerInterface(int id_owner)
        {
            this.id_owner = id_owner;
            InitializeComponent();
        }
        private void OwnerInterface_Load(object sender, EventArgs e)
        {
            ucSearchApartments = new UCSearchApartments();
            AddControl(ucSearchApartments);
        }
        private void DisposeAll()
        {
            if (Controls.Contains(ucProfile))
            {
                ucProfile.Dispose();
            }
            if (Controls.Contains(ucSearchApartments))
            {
                ucSearchApartments.Dispose();
            }
            if (Controls.Contains(ucMyAparts))
            {
                ucMyAparts.Dispose();
            }
            if (Controls.Contains(ucAddApartment))
            {
                ucAddApartment.Dispose();
            }
        }
        private void AddControl(UserControl userControl)
        {
            DisposeAll();
            userControl.Location = new Point(0, 43);
            this.Controls.Add(userControl);
        }
        private void ShowAparts_Click(object sender, EventArgs e)
        {
            ucSearchApartments = new UCSearchApartments();
            AddControl(ucSearchApartments);
        }
        private void ShowMyAparts_Click(object sender, EventArgs e)
        {
            ucMyAparts = new UCMyAparts(id_owner);
            AddControl(ucMyAparts);
        }
        private void AddApart_Click(object sender, EventArgs e)
        {
            ucAddApartment = new UCAddApartment(id_owner);
            AddControl(ucAddApartment);
        }
        private void MyProfile_Click(object sender, EventArgs e)
        { 
            ucProfile = new UCProfile(id_owner, "Owner");
            AddControl(ucProfile);
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

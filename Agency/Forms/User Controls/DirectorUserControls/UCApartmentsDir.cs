using Agency.Models;
using Agency.Services;

namespace Agency.Forms.User_Controls.DirectorUserControls
{
    public partial class UCApartmentsDir : UserControl
    {
        private UserControl ucAparts, ucAddApart, ucRemoveAparts;
        private OwnerService ownerServ;
        public UCApartmentsDir()
        {
            ownerServ = new();
            InitializeComponent();
        }
        private void DisposeAll()
        {
            if (this.Controls.Contains(ucAparts)) { ucAparts.Dispose(); }
            if (this.Controls.Contains(ucAddApart)) { ucAddApart.Dispose(); }
            if (this.Controls.Contains(ucRemoveAparts)) { ucRemoveAparts.Dispose(); }
        }
        private void AddControl(UserControl userControl)
        {
            DisposeAll();
            userControl.Location = new Point(0, 37);
            Controls.Add(userControl);
        }
        private void lblApartsList_Click(object sender, EventArgs e)
        {
            ucAparts = new UCSearchApartments();
            AddControl(ucAparts);
        }

        private void lblAddNewApart_Click(object sender, EventArgs e)
        {
            if (cbOwners.Text == "")
            {
                MessageBox.Show("Выберите владельца на чье имя будет добавлена квартира");
                return;
            }
            ucAddApart = new UCAddApartment(cbOwners.Text[cbOwners.Text.Length - 2] - '0');
            AddControl(ucAddApart);
        }

        private void UCAllApartments_Load(object sender, EventArgs e)
        {
            var owners = ownerServ.GetOwners();
            foreach (Owner owner in owners)
            {
                cbOwners.Items.Add(owner.FioOwner + "(id: " + owner.IdOwner + ")");
            }
        }

        private void lblRemoveApart_Click(object sender, EventArgs e)
        {
            ucRemoveAparts = new UCRemoveApartments();
            AddControl(ucRemoveAparts);
        }
    }
}

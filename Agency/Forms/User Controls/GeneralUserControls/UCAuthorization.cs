using Agency.Forms;
using Agency.Forms.User_Controls;
using Agency.Services;

namespace Agency
{
    public partial class UCAuthorization : UserControl
    {

        private BuyerService buyerServ;
        private OwnerService ownerServ;
        private SpecialistService specServ;
        public UCAuthorization()
        {
            buyerServ = new();
            ownerServ = new();
            specServ = new();
            InitializeComponent();
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (tbLogin.Text == "admin" && tbPassword.Text == "admin")
            {
                this.Hide();
                this.Parent.Hide();
                DirectorInterface directorInterface = new();
                directorInterface.Show();
            }
            else if (buyerServ.IsExist(tbLogin.Text))
            {
                var buyer = buyerServ.GetBuyer(tbLogin.Text);
                if (tbPassword.Text == buyer.PasswordBuyer)
                {
                    this.Hide();
                    this.Parent.Hide();
                    BuyerInterface buyerInterface = new(buyer.IdBuyer);
                    buyerInterface.Show();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
            else if (ownerServ.IsExist(tbLogin.Text))
            {
                var owner = ownerServ.GetOwner(tbLogin.Text);
                if (tbPassword.Text == owner.PasswordOwner)
                {
                    this.Hide();
                    this.Parent.Hide();
                    OwnerInterface ownerInterface = new(owner.IdOwner);
                    ownerInterface.Show();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
            else if (specServ.IsExist(tbLogin.Text))
            {
                var spec = specServ.GetSpecialist(tbLogin.Text);
                if (tbPassword.Text == spec.PasswordSpec)
                {
                    this.Hide();
                    this.Parent.Hide();
                    SpecialistInterface specialistInterface = new(spec.IdSpec);
                    specialistInterface.Show();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка");
            }

        }
        private void btnRegistration_Click(object sender, EventArgs e)
        {
            UCRegistration ucReg = new();
            ucReg.Location = new Point(0, 10);
            this.Parent.Controls.Add(ucReg);
            this.Parent.Size = new Size(380, 500);
            this.Dispose();
            ucReg.Show();
        }
    }
}

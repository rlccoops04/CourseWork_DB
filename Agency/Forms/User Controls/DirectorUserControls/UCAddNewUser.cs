using Agency.Services;

namespace Agency.Forms.User_Controls.DirectorUserControls
{
    public partial class UCAddNewUser : UserControl
    {
        private BuyerService buyerServ;
        private OwnerService ownerServ;
        private SpecialistService specServ;
        public UCAddNewUser()
        {
            buyerServ = new();
            ownerServ = new();
            specServ = new();
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (tbLogin.Text == "" || tbPassword.Text == "" || tbPassport.Text == "" || tbSurname.Text == "" || tbNomTel.Text == "")
            {
                MessageBox.Show("Заполнены не все поля", "Ошибка");
                return;
            }

            if (rbBuyer.Checked)
            {
                if (buyerServ.IsExist(tbLogin.Text) || ownerServ.IsExist(tbLogin.Text) || specServ.IsExist(tbLogin.Text))
                {
                    MessageBox.Show("Данный логин уже используется.", "Ошибка");
                    return;
                }
                var result = buyerServ.Add(tbSurname.Text,tbName.Text, tbPassport.Text, tbNomTel.Text, tbLogin.Text, tbPassword.Text);
                if (!result)
                {
                    MessageBox.Show("Ошибка при регистрации", "Ошибка");
                    return;
                }
                MessageBox.Show("Покупатель успешно зарегистрирован");
            }
            else if (rbOWNER.Checked)
            {
                if (buyerServ.IsExist(tbLogin.Text) || ownerServ.IsExist(tbLogin.Text) || specServ.IsExist(tbLogin.Text))
                {
                    MessageBox.Show("Данный логин уже используется.", "Ошибка");
                    return;
                }
                var result = ownerServ.Add(tbSurname.Text, tbName.Text, tbPassport.Text, tbNomTel.Text, tbLogin.Text, tbPassword.Text);
                if (!result)
                {
                    MessageBox.Show("Ошибка", "Ошибка");
                    return;
                }
                MessageBox.Show("Продавец успешно зарегистрирован");
            }
            else if (rbSpecialist.Checked)
            {
                if (buyerServ.IsExist(tbLogin.Text) || ownerServ.IsExist(tbLogin.Text) || specServ.IsExist(tbLogin.Text))
                {
                    MessageBox.Show("Данный логин уже используется.", "Ошибка");
                    return;
                }
                var result = specServ.Add(tbSurname.Text, tbName.Text, tbPassport.Text, tbNomTel.Text, tbLogin.Text, tbPassword.Text);
                if (!result)
                {
                    MessageBox.Show("Ошибка при регистрации", "Ошибка");
                    return;
                }
                MessageBox.Show("Покупатель успешно зарегистрирован");
            }
            else
            {
                MessageBox.Show("Выберите назначение аккаунта.", "Ошибка ввода");
            }
        }
    }
}

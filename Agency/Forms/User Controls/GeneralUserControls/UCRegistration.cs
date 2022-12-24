using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agency.Forms;
using Agency.Services;

namespace Agency
{
    public partial class UCRegistration : UserControl
    {
        private readonly BuyerService buyerServ = new();
        private readonly OwnerService ownerServ = new();
        private readonly SpecialistService specServ = new();
        public UCRegistration()
        {
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
                this.Hide();
                this.Parent.Hide();
                BuyerInterface buyerInterface = new BuyerInterface(buyerServ.GetBuyer(tbLogin.Text).IdBuyer);
                buyerInterface.Show();
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
                this.Hide();
                this.Parent.Hide();
                OwnerInterface ownerInterface = new OwnerInterface(ownerServ.GetOwner(tbLogin.Text).IdOwner);
                ownerInterface.Show();
            }
            else
            {
                MessageBox.Show("Выберите назначение аккаунта.", "Ошибка ввода");
            }
        }
    }
}

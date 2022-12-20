using Agency.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agency.Forms.User_Controls.DirectorUserControls
{
    public partial class UCAddNewUser : UserControl
    {
        private BuyerService buyerServ = new();
        private OwnerService ownerServ = new();
        private SpecialistService specServ = new();
        public UCAddNewUser()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (tbLogin.Text == "" || tbPassword.Text == "" || tbPassport.Text == "" || tbName.Text == "" || tbNomTel.Text == "")
            {
                MessageBox.Show("Заполнены не все поля", "Ошибка");
                return;
            }
            if (rbBuyer.Checked)
            {
                var result = buyerServ.Add(tbName.Text, tbPassport.Text, tbNomTel.Text, tbLogin.Text, tbPassword.Text);
                if (!result)
                {
                    MessageBox.Show("Ошибка", "Ошибка");
                    return;
                }
                MessageBox.Show("Покупатель успешно зарегистрирован");
                this.Hide();
                this.Parent.Show();
            }
            else if (rbOWNER.Checked)
            {
                var result = ownerServ.Add(tbName.Text, tbPassport.Text, tbNomTel.Text, tbLogin.Text, tbPassword.Text);
                if (!result)
                {
                    MessageBox.Show("Ошибка", "Ошибка");
                    return;
                }
                MessageBox.Show("Продавец успешно зарегистрирован");
                this.Hide();
                this.Parent.Show();
            }
            else if (rbSpecialist.Checked)
            {
                var result = specServ.Add(tbName.Text, tbPassport.Text, tbNomTel.Text, tbLogin.Text, tbPassword.Text);
                if (!result)
                {
                    MessageBox.Show("Ошибка", "Ошибка");
                    return;
                }
                MessageBox.Show("Специалист успешно зарегистрирован");
                this.Hide();
                this.Parent.Show();
            }

            else
            {
                MessageBox.Show("Выберите назначение аккаунта.", "Ошибка ввода");
            }
        }
    }
}

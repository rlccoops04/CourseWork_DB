using Agency.Models;
using Agency.Services;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agency
{
    public partial class UCProfile : UserControl
    {
        private AgencyDbContext context = new();
        private BuyerService buyerService;
        private OwnerService ownerService;
        private SpecialistService specService;
        private int id_user;
        private string role;
        public UCProfile(int id_user, string role)
        {
            this.id_user = id_user;
            this.role = role;
            InitializeComponent();
        }

        private void UCBuyerProfile_Load(object sender, EventArgs e)
        {
            if (role == "Buyer")
            {
                buyerService = new();
                var buyer = buyerService.GetBuyer(id_user);
                lblFio.Text += buyer.FioBuyer;
                lblPassport.Text += buyer.PassportNumBuyer;
                lblNomTel.Text += buyer.NomTelBuyer;
                lblLogin.Text += buyer.LoginBuyer;
                lblPassword.Text += buyer.PasswordBuyer;
                lblRole.Text += "Покупатель";
            }
            if (role == "Owner")
            {
                ownerService = new();
                var owner = ownerService.GetOwner(id_user);
                lblFio.Text += owner.FioOwner;
                lblPassport.Text += owner.PassportNumOwner;
                lblNomTel.Text += owner.NomTelOwner;
                lblLogin.Text += owner.LoginOwner;
                lblPassword.Text += owner.PasswordOwner;
                lblRole.Text += "Продавец";
            }
            if (role == "Spec")
            {
                specService = new();
                var specialist = specService.GetSpecialist(id_user);
                lblFio.Text += specialist.FioSpec;
                lblPassport.Text += specialist.PasswordSpec;
                lblNomTel.Text += specialist.NomTelSpec;
                lblLogin.Text += specialist.LoginSpec;
                lblPassword.Text += specialist.PasswordSpec;
                lblRole.Text += "Специалист";
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (role == "Buyer")
            {
                buyerService.Change(id_user, tbNewValue.Text, cbOption.Text);
            }
            if (role == "Owner")
            {
                ownerService.Change(id_user, tbNewValue.Text, cbOption.Text);
            }
            if (role == "Spec")
            {
                specService.Change(id_user, tbNewValue.Text, cbOption.Text);
            }
            MessageBox.Show("Данные успешно изменены");
        }
    }
}

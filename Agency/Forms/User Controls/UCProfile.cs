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
        private BuyerService buyerService;
        private OwnerService ownerService;
        private string login;
        private string role;
        public UCProfile(string login, string role)
        {
            this.login = login;
            this.role = role;
            buyerService = new();
            ownerService = new();
            InitializeComponent();
        }

        private void UCBuyerProfile_Load(object sender, EventArgs e)
        {
            if (role == "Buyer")
            {
                lblPassport.Text += buyerService.GetBuyer(login).PassportNumBuyer;
                lblNomTel.Text += buyerService.GetBuyer(login).NomTelBuyer;
                lblLogin.Text += buyerService.GetBuyer(login).LoginBuyer;
                lblPassword.Text += buyerService.GetBuyer(login).PasswordBuyer;
            }
            if (role == "Owner")
            {
                lblPassport.Text += ownerService.GetOwner(login).PassportNumOwner;
                lblNomTel.Text += ownerService.GetOwner(login).NomTelOwner;
                lblLogin.Text += ownerService.GetOwner(login).LoginOwner;
                lblPassword.Text += ownerService.GetOwner(login).PasswordOwner;
            }
        }
    }
}

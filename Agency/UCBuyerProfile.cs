using Agency.Models;
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
    public partial class UCBuyerProfile : UserControl
    {
        private Buyer buyer = new();
        public UCBuyerProfile(Buyer buyer)
        {
            this.buyer = buyer;
            InitializeComponent();
        }

        private void UCBuyerProfile_Load(object sender, EventArgs e)
        {
            lblPassport.Text += buyer.PassportNumBuyer;
            lblNomTel.Text += buyer.NomTelBuyer;
            lblLogin.Text += buyer.LoginBuyer;
            lblPassword.Text += buyer.PasswordBuyer;
        }
    }
}

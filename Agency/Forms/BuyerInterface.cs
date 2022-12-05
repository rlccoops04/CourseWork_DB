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
    public partial class BuyerInterface : Form
    {
        private Buyer buyer;
        public BuyerInterface(Buyer buyer)
        {
            this.buyer = buyer;
            InitializeComponent();
        }

        private void BuyerInterface_Load(object sender, EventArgs e)
        {
            lblCurrUserName.Text += buyer.FioBuyer;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}

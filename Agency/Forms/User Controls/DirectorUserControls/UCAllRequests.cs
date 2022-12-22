using Agency.Models;
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
    public partial class UCAllRequests : UserControl
    {
        private UCSpecialistRequests ucSpecReqs;
        private SpecialistService specServ = new();
        private BuyerService buyerServ = new();
        public UCAllRequests()
        {
            InitializeComponent();
        }

        private void btnReqs_Click(object sender, EventArgs e)
        {
            cbChoiceSpec.Visible = true;
        }

        private void UCAllRequests_Load(object sender, EventArgs e)
        {
            foreach (Buyer buyer in buyerServ.GetBuyers())
            {
                cbChoiceBuyer.Items.Add(buyer.FioBuyer + "(id: " + buyer.IdBuyer + ")");
            }
            foreach (Specialist specialist in specServ.GetSpecs())
            {
                cbChoiceSpec.Items.Add(specialist.FioSpec + "(id: " + specialist.IdSpec + ")");
            }
        }

        private void cbChoiceSpec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

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

namespace Agency.Forms.User_Controls
{
    public partial class UCRequestsDir : UserControl
    {
        private BuyerService buyerServ = new();
        private SpecialistService specServ = new();
        private UCSpecialistRequests ucReqs;
        private UCAddRequest ucAddReq;
        public UCRequestsDir()
        {
            InitializeComponent();
        }

        private void UCRequestsDir_Load(object sender, EventArgs e)
        {
            var buyers = buyerServ.GetBuyers();
            foreach (Buyer buyer in buyers)
            {
                cbBuyer.Items.Add(buyer.SurnameBuyer + " " + buyer.NameBuyer + "(id: " + buyer.IdBuyer + ")");
            }
            var specialists = specServ.GetSpecs();
            foreach (Specialist specialist in specialists)
            {
                cbSpecs.Items.Add(specialist.SurnameSpec + " " + specialist.SurnameSpec + "(id: " + specialist.IdSpec + ")");
            }
        }
        private void HideAll()
        {
            if (this.Controls.Contains(ucReqs))
            {
                ucReqs.Hide();
            }
            if (this.Controls.Contains(ucAddReq))
            {
                ucAddReq.Hide();
            }
        }

        private void lblReqs_Click(object sender, EventArgs e)
        {
            HideAll();
            if (cbSpecs.Text == "")
            {
                MessageBox.Show("Для просмотра и изменения заявок выберите специалиста.");
                return;
            }
            ucReqs = new(cbSpecs.Text[cbSpecs.Text.Length - 2] - '0');
            ucReqs.Location = new Point(0, 37);
            this.Controls.Add(ucReqs);
        }

        private void lblAddNewReq_Click(object sender, EventArgs e)
        {
            HideAll();
            if (cbBuyer.Text == "")
            {
                MessageBox.Show("Для просмотра и изменения заявок выберите покупателя на чье имя будет добавлена заявка.");
                return;
            }
            ucAddReq = new(cbBuyer.Text[cbBuyer.Text.Length - 2] - '0');
            ucAddReq.Location = new Point(0, 37);
            this.Controls.Add(ucAddReq);
        }
    }
}

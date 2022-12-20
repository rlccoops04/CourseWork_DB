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

namespace Agency.Forms.User_Controls
{
    public partial class UCSpecialistDeals : UserControl
    {
        private int id_spec;
        private SpecialistService specService = new();
        private DealService dealService = new();
        private UCDeal ucDeal;
        public UCSpecialistDeals(int id_spec)
        {
            this.id_spec = id_spec;
            InitializeComponent();
        }

        private void UCSpecialistDeals_Load(object sender, EventArgs e)
        {
            int i = 10;
            foreach (Deal deal in dealService.GetDeals(specService.GetSpecialist(id_spec)))
            {
                ucDeal = new(deal);
                ucDeal.Location = new Point(10, i);
                panel.Controls.Add(ucDeal);
                i += 450;
            }
            lblfound.Text += dealService.GetDeals(specService.GetSpecialist(id_spec)).Count().ToString();
        }
    }
}

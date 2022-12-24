using Agency.Forms.User_Controls.DirectorUserControls;
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
    public partial class UCDealsDir : UserControl
    {
        private DealService dealService = new();
        private UCDealWithDelete ucDeal;
        public UCDealsDir()
        {
            InitializeComponent();
        }

        private void UCDealsDir_Load(object sender, EventArgs e)
        {
            int i = 0;
            int count = 0;
            foreach (Deal deal in dealService.GetDeals())
            {
                ucDeal = new(deal);
                ucDeal.Location = new Point(10, i);
                panel.Controls.Add(ucDeal);
                i += 120;
                count++;
            }
            lblfound.Text += count;
        }
    }
}

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
    public partial class UCAddRequest : UserControl
    {
        private RequestService reqService;
        private Buyer currBuyer;
        public UCAddRequest(Buyer buyer)
        {
            reqService = new();
            currBuyer = buyer;
            InitializeComponent();
        }

        private void UCAddRequest_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string metro, furn;
            if(cbMetro.Checked) { metro = "рядом"; } else { metro = "не рядом"; };
            if(cbFurniture.Checked) { furn = "есть"; } else { furn = "нет"; }
            try
            {
                var result = reqService.Add(Convert.ToDouble(tbSpace1.Text), Convert.ToDouble(tbSpace2.Text), Convert.ToInt32(tbRoomsMax.Text),
                    Convert.ToInt32(tbFloorMax.Text), cbType.Text, Convert.ToInt32(tbYear.Text), metro, furn,
                    Convert.ToInt64(tbPriceMax.Text), currBuyer.LoginBuyer);
                if (result)
                {
                    tbSpace1.Text = "";
                    tbSpace2.Text = "";
                    tbRoomsMax.Text = "";
                    tbFloorMax.Text = "";
                    cbType.Text = "";
                    tbYear.Text = "";
                    tbPriceMax.Text = "";
                    cbMetro.Checked = false;
                    cbFurniture.Checked = false;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка ввода", "Ошибка");
            }
        }
    }
}

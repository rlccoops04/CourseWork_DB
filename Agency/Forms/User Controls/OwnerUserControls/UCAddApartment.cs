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
    public partial class UCAddApartment : UserControl
    {
        private int id_user;
        private ApartmentService apartService;
        public UCAddApartment(int id_user)
        {
            this.id_user = id_user;
            apartService = new();
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string metro, furn;
            if (cbMetro.Checked) { metro = "рядом"; } else { metro = "не рядом"; };
            if (cbFurniture.Checked) { furn = "есть"; } else { furn = "нет"; }

            try
            {
                apartService.Add(tbKadastrNom.Text, tbCity.Text, tbStreet.Text,tbHomeNom.Text,tbApartNom.Text, Convert.ToDouble(tbLiveSpace.Text),
                    Convert.ToDouble(tbSpace.Text), Convert.ToInt32(tbRoomsMax.Text), Convert.ToInt32(tbFloorMax.Text),
                    cbType.Text, Convert.ToInt32(tbYear.Text), metro, furn, Convert.ToDecimal(tbPriceMax.Text),
                    id_user);

                tbKadastrNom.Text = "";
                tbCity.Text = "";
                tbStreet.Text = "";
                tbHomeNom.Text = "";
                tbApartNom.Text = "";
                tbLiveSpace.Text = "";
                tbSpace.Text = "";
                tbRoomsMax.Text = "";
                tbFloorMax.Text = "";
                cbType.Text = "";
                tbYear.Text = "";
                tbPriceMax.Text = "";
                cbMetro.Checked = false;
                cbFurniture.Checked = false;

                lblResult.Text = "Успешно";
                lblResult.ForeColor = Color.Green;
            }
            catch
            {
                lblResult.Text = "Ошибка";
                lblResult.ForeColor = Color.Red;
            }
        }
    }
}

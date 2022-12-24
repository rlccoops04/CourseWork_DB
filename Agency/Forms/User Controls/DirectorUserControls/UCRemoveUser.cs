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
    public partial class UCRemoveUser : UserControl
    {
        private BuyerService buyerServ = new();
        private OwnerService ownerServ = new();
        private SpecialistService specServ = new();
        public UCRemoveUser()
        {
            InitializeComponent();
        }

        private void cbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = cbUser.SelectedIndex != -1;
        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbUser.Items.Clear();
            if (cbRole.Text == "Покупатель")
            {
                var buyers = buyerServ.GetBuyers();
                foreach (Buyer buyer in buyers)
                {
                    cbUser.Items.Add(buyer.SurnameBuyer + " " + buyer.NameBuyer + "(id: " + buyer.IdBuyer + ")");
                }
            }
            else if (cbRole.Text == "Продавец")
            {
                var owners = ownerServ.GetOwners();
                foreach (Owner owner in owners)
                {
                    cbUser.Items.Add(owner.SurnameOwner + " " + owner.NameOwner + "(id: " + owner.IdOwner + ")");
                }
            }
            else if (cbRole.Text == "Специалист")
            {
                var specialists = specServ.GetSpecs();
                foreach (Specialist specialist in specialists)
                {
                    cbUser.Items.Add(specialist.SurnameSpec + " " + specialist.NameSpec + "(id: " + specialist.IdSpec + ")");
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            bool result = false;
            if (cbRole.Text == "Покупатель")
            {
                result = buyerServ.Remove(cbUser.Text[cbUser.Text.Length - 2] - '0');
            }
            else if (cbRole.Text == "Продавец")
            {
                result = ownerServ.Remove(cbUser.Text[cbUser.Text.Length - 2] - '0');
            }
            else if (cbRole.Text == "Специалист")
            {
                result = specServ.Remove((cbUser.Text[cbUser.Text.Length - 2]) - '0');
            }
            if (result)
            {
                MessageBox.Show("Пользователь успешно удален");
            }
            else
            {
                MessageBox.Show("У пользователя найдены связи с объектами в Базе данных.", "Ошибка");
            }
            cbRole.Text = "";
            cbUser.Items.Clear();
        }
    }
}

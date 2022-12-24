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

namespace Agency.Forms.User_Controls.DirectorUserControls
{
    public partial class UCUsersList : UserControl
    {
        private List<Buyer> buyers;
        private List<Owner> owners;
        private List<Specialist> specialists;
        private BuyerService buyerService;
        private OwnerService ownerService;
        private SpecialistService specService;
        private UCProfile ucProfile;
        public UCUsersList()
        {
            buyerService = new();
            ownerService = new();
            specService = new();
            InitializeComponent();
        }
        private void UCUsersList_Load(object sender, EventArgs e)
        {
            GetAllUsers();
            ShowUsers();
        }
        private void GetAllUsers()
        {
            buyers = buyerService.GetBuyers();
            owners = ownerService.GetOwners();
            specialists = specService.GetSpecs();
        }
        private void ShowUsers()
        {
            foreach (Control control in panel1.Controls)
            {
                control.Hide();
            }
            int i = 0;
            foreach (Buyer buyer in buyers)
            {
                ucProfile = new(buyer.IdBuyer, "Buyer");
                ucProfile.Location = new Point(10, i);
                panel1.Controls.Add(ucProfile);
                i += 343;
            }
            foreach (Owner owner in owners)
            {
                ucProfile = new(owner.IdOwner, "Owner");
                ucProfile.Location = new Point(10, i);
                panel1.Controls.Add(ucProfile);
                i += 343;
            }
            foreach (Specialist specialist in specialists)
            {
                ucProfile = new(specialist.IdSpec, "Spec");
                ucProfile.Location = new Point(10, i);
                panel1.Controls.Add(ucProfile);
                i += 343;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetAllUsers();
            if (tbID.Text != "")
            {
                try
                {
                    buyers.Clear();
                    owners.Clear();
                    specialists.Clear();
                    if (buyerService.GetBuyer(Convert.ToInt32(tbID.Text)) != null)
                    {
                        buyers.Add(buyerService.GetBuyer(Convert.ToInt32(tbID.Text)));
                    }
                    if (ownerService.GetOwner(Convert.ToInt32(tbID.Text)) != null)
                    {
                        owners.Add(ownerService.GetOwner(Convert.ToInt32(tbID.Text)));
                    }
                    if (specService.GetSpecialist(Convert.ToInt32(tbID.Text)) != null)
                    {
                        specialists.Add(specService.GetSpecialist(Convert.ToInt32(tbID.Text)));
                    }
                }
                catch
                {
                    MessageBox.Show("Ошибка ввода идентификатора");
                }
            }
            if (tbFio.Text != "")
            {
                foreach (Buyer buyer in buyerService.GetBuyers())
                {
                    if (buyer.FioBuyer != tbFio.Text)
                    {
                        buyers.Remove(buyer);
                    }
                }
                foreach (Owner owner in ownerService.GetOwners())
                {
                    if (owner.FioOwner != tbFio.Text)
                    {
                        owners.Remove(owner);
                    }
                }
                foreach (Specialist specialist in specService.GetSpecs())
                {
                    if (specialist.FioSpec != tbFio.Text)
                    {
                        specialists.Remove(specialist);
                    }
                }
            }
            if (tbPassport.Text != "")
            {
                foreach (Buyer buyer in buyerService.GetBuyers())
                {
                    if (buyer.PassportNumBuyer != tbPassport.Text)
                    {
                        buyers.Remove(buyer);
                    }
                }
                foreach (Owner owner in ownerService.GetOwners())
                {
                    if (owner.PassportNumOwner != tbPassport.Text)
                    {
                        owners.Remove(owner);
                    }
                }
                foreach (Specialist specialist in specService.GetSpecs())
                {
                    if (specialist.PassportNumSpec != tbPassport.Text)
                    {
                        specialists.Remove(specialist);
                    }
                }
            }
            if (tbNomTel.Text != "")
            {
                foreach (Buyer buyer in buyerService.GetBuyers())
                {
                    if (buyer.NomTelBuyer != tbNomTel.Text)
                    {
                        buyers.Remove(buyer);
                    }
                }
                foreach (Owner owner in ownerService.GetOwners())
                {
                    if (owner.NomTelOwner != tbNomTel.Text)
                    {
                        owners.Remove(owner);
                    }
                }
                foreach (Specialist specialist in specService.GetSpecs())
                {
                    if (specialist.NomTelSpec != tbNomTel.Text)
                    {
                        specialists.Remove(specialist);
                    }
                }
            }
            if (tbLogin.Text != "")
            {
                foreach (Buyer buyer in buyerService.GetBuyers())
                {
                    if (buyer.LoginBuyer != tbLogin.Text)
                    {
                        buyers.Remove(buyer);
                    }
                }
                foreach (Owner owner in ownerService.GetOwners())
                {
                    if (owner.LoginOwner != tbLogin.Text)
                    {
                        owners.Remove(owner);
                    }
                }
                foreach (Specialist specialist in specService.GetSpecs())
                {
                    if (specialist.LoginSpec != tbLogin.Text)
                    {
                        specialists.Remove(specialist);
                    }
                }
            }
            if (cbRole.Text != "")
            {
                if (cbRole.Text == "Продавец")
                {
                    buyers.Clear();
                    specialists.Clear();
                }
                if (cbRole.Text == "Покупатель")
                {
                    specialists.Clear();
                    owners.Clear();
                }
                if (cbRole.Text == "Специалист")
                {
                    buyers.Clear();
                    owners.Clear();
                }
            }
            ShowUsers();
        }
    }
}

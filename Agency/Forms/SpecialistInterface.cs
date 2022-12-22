using Agency.Forms.User_Controls;
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
    public partial class SpecialistInterface : Form
    {
        private UCProfile ucProfile;
        private UCSpecialistDeals ucDeals;
        private UCSpecialistRequests ucReqs;
        private UCSearchApartments ucSearchAparts;
        private int id_spec;
        public SpecialistInterface(int id_spec)
        {
            this.id_spec = id_spec;
            InitializeComponent();
        }
        private void HideAll()
        {
            if (this.Controls.Contains(ucProfile))
            {
                ucProfile.Hide();
            }
            if (this.Controls.Contains(ucDeals))
            {
                ucDeals.Hide();
            }
            if (this.Controls.Contains(ucReqs))
            {
                ucReqs.Hide();
            }
            if (this.Controls.Contains(ucSearchAparts))
            {
                ucSearchAparts.Hide();
            }
        }
        private void lblMyProfile_Click(object sender, EventArgs e)
        {
            HideAll();
            ucProfile = new(id_spec, "Spec");
            ucProfile.Location = new Point(0, 43);
            this.Controls.Add(ucProfile);
        }
        private void lblMyDeals_Click(object sender, EventArgs e)
        {
            HideAll();
            ucDeals = new(id_spec);
            ucDeals.Location = new Point(0, 43);
            this.Controls.Add(ucDeals);
        }
        private void lblReqs_Click(object sender, EventArgs e)
        {
            HideAll();
            ucReqs = new(id_spec);
            ucReqs.Location = new Point(0, 43);
            this.Controls.Add(ucReqs);
        }
        private void lblAparts_Click(object sender, EventArgs e)
        {
            HideAll();
            ucSearchAparts = new();
            ucSearchAparts.Location = new Point(0, 43);
            this.Controls.Add(ucSearchAparts);
        }
        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SpecialistInterface_Load(object sender, EventArgs e)
        {
            HideAll();
            ucSearchAparts = new();
            ucSearchAparts.Location = new Point(0, 43);
            this.Controls.Add(ucSearchAparts);
        }
    }
}

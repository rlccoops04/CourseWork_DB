using Agency.Forms.User_Controls.DirectorUserControls;
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
    public partial class DirectorInterface : Form
    {
        private UserControl ucUsers, ucReqs, ucAparts, ucDeals;
        public DirectorInterface()
        {
            InitializeComponent();
        }
        private void DisposeAll()
        {
            if (this.Controls.Contains(ucUsers))
            {
                ucUsers.Dispose();
            }
            if (this.Controls.Contains(ucReqs))
            {
                ucReqs.Dispose();
            }
            if (this.Controls.Contains(ucAparts))
            {
                ucAparts.Dispose();
            }
            if (this.Controls.Contains(ucDeals))
            {
                ucDeals.Dispose();
            }
        }
        private void AddControl(UserControl userControl)
        {
            userControl.Location = new Point(0, 43);
            Controls.Add(userControl);
        }
        private void Apartments_Click(object sender, EventArgs e)
        {
            DisposeAll();
            ucAparts = new UCApartmentsDir();
            AddControl(ucAparts);
        }
        private void Users_Click(object sender, EventArgs e)
        {
            DisposeAll();
            ucUsers = new UCUsersDir();
            AddControl(ucUsers);
        }
        private void Requests_Click(object sender, EventArgs e)
        {
            DisposeAll();
            ucReqs = new UCRequestsDir();
            AddControl(ucReqs);
        }
        private void Deals_Click(object sender, EventArgs e)
        {
            DisposeAll();
            ucDeals = new UCDealsDir();
            AddControl(ucDeals);
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

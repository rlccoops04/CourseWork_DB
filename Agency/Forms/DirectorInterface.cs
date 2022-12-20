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
        private UCAllUsers ucUsers;
        public DirectorInterface()
        {
            InitializeComponent();
        }
        private void HideAll()
        {
            if (this.Controls.Contains(ucUsers))
            {
                ucUsers.Hide();
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            HideAll();
            ucUsers = new();
            ucUsers.Location = new Point(173, 12);
            this.Controls.Add(ucUsers);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

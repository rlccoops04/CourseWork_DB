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
    public partial class UCAllUsers : UserControl
    {
        private UCUsersList ucUsers;
        private UCAddNewUser ucAddNewUser;
        private UCRemoveUser ucRemoveUser;
        public UCAllUsers()
        {
            InitializeComponent();
        }
        private void HideAll()
        {
            if (this.Controls.Contains(ucUsers)) { ucUsers.Hide(); }
            if (this.Controls.Contains(ucAddNewUser)) { ucAddNewUser.Hide(); }
            if (this.Controls.Contains(ucRemoveUser)) { ucRemoveUser.Hide(); }

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            HideAll();
            ucUsers = new();
            ucUsers.Location = new Point(3, 38);
            this.Controls.Add(ucUsers);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            HideAll();
            ucAddNewUser = new();
            ucAddNewUser.Location = new Point(3, 38);
            this.Controls.Add(ucAddNewUser);
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            HideAll();
            ucRemoveUser = new();
            ucRemoveUser.Location = new Point(3, 38);
            this.Controls.Add(ucRemoveUser);
        }
    }
}

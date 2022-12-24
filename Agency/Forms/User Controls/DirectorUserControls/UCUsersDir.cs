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
    public partial class UCUsersDir : UserControl
    {
        private UCUsersList ucUsers;
        private UCAddNewUser ucAddNewUser;
        private UCRemoveUser ucRemoveUser;
        public UCUsersDir()
        {
            InitializeComponent();
        }
        private void HideAll()
        {
            if (this.Controls.Contains(ucUsers)) { ucUsers.Hide(); }
            if (this.Controls.Contains(ucAddNewUser)) { ucAddNewUser.Hide(); }
            if (this.Controls.Contains(ucRemoveUser)) { ucRemoveUser.Hide(); }

        }
        private void lblUsersList_Click(object sender, EventArgs e)
        {
            HideAll();
            ucUsers = new();
            ucUsers.Location = new Point(0, 37);
            this.Controls.Add(ucUsers);
        }

        private void lblAddNewUser_Click(object sender, EventArgs e)
        {
            HideAll();
            ucAddNewUser = new();
            ucAddNewUser.Location = new Point(0, 37);
            this.Controls.Add(ucAddNewUser);
        }

        private void lblRemoveUser_Click(object sender, EventArgs e)
        {
            HideAll();
            ucRemoveUser = new();
            ucRemoveUser.Location = new Point(0, 37);
            this.Controls.Add(ucRemoveUser);
        }
    }
}

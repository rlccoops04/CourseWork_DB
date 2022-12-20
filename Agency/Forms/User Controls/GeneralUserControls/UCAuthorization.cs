﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agency.Forms;
using Agency.Forms.User_Controls;
using Agency.Services;

namespace Agency
{
    public partial class UCAuthorization : UserControl
    {

        private BuyerService buyerServ = new();
        private OwnerService ownerServ = new();
        public UCAuthorization()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Parent.Hide();
            DirectorInterface directorInterface = new();
            directorInterface.Show();
/*            SpecialistInterface specialistInterface = new(2);
            specialistInterface.Show();
            BuyerInterface buyerInterface = new(buyerServ.GetBuyer("test124").IdBuyer);
            buyerInterface.Show();
            OwnerInterface ownerInterface = new(1);
            ownerInterface.Show();*/
            /*            if (buyerServ.IsExist(tbLogin.Text, tbPassword.Text))
                        {
                            this.Hide();
                            this.Parent.Hide();
                            BuyerInterface buyerInterface = new(buyerServ.GetBuyer(tbLogin.Text));
                            buyerInterface.Show();

                            return;
                        }*/
            MessageBox.Show("Неверный логин или пароль", "Ошибка");

        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            UCRegistration ucReg = new();
            ucReg.Location = new Point(0, 10);
            this.Hide();
            this.Parent.Controls.Add(ucReg);
            this.Parent.Size = new Size(380, 450);
            ucReg.Show();
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agency.Services;

namespace Agency
{
    public partial class UCAuthorization : UserControl
    {

        private BuyerService buyerServ = new();
        public UCAuthorization()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (buyerServ.IsExist(tbLogin.Text, tbPassword.Text))
            {
                this.Hide();
                this.Parent.Hide();
                BuyerInterface buyerInterface = new(buyerServ.GetBuyer(tbLogin.Text));
                return;
            }
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
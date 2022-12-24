﻿using Agency.Models;
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

namespace Agency
{
    public partial class UCProfile : UserControl
    {
        private AgencyDbContext context = new();
        private BuyerService buyerService;
        private OwnerService ownerService;
        private SpecialistService specService;
        private int id_user;
        private string role;
        public UCProfile(int id_user, string role)
        {
            this.id_user = id_user;
            this.role = role;
            InitializeComponent();
        }

        private void UCBuyerProfile_Load(object sender, EventArgs e)
        {
            if (role == "Buyer")
            {
                buyerService = new();
                var buyer = buyerService.GetBuyer(id_user);
                lblFio.Text += buyer.FioBuyer;
                lblPassport.Text += buyer.PassportNumBuyer;
                lblNomTel.Text += buyer.NomTelBuyer;
                lblLogin.Text += buyer.LoginBuyer;
                lblPassword.Text += buyer.PasswordBuyer;
                lblId.Text += buyer.IdBuyer;
                lblRole.Text += "Покупатель";
            }
            if (role == "Owner")
            {
                ownerService = new();
                var owner = ownerService.GetOwner(id_user);
                lblFio.Text += owner.FioOwner;
                lblPassport.Text += owner.PassportNumOwner;
                lblNomTel.Text += owner.NomTelOwner;
                lblLogin.Text += owner.LoginOwner;
                lblPassword.Text += owner.PasswordOwner;
                lblId.Text += owner.IdOwner;
                lblRole.Text += "Продавец";
            }
            if (role == "Spec")
            {
                specService = new();
                var specialist = specService.GetSpecialist(id_user);
                lblFio.Text += specialist.FioSpec;
                lblPassport.Text += specialist.PasswordSpec;
                lblNomTel.Text += specialist.NomTelSpec;
                lblLogin.Text += specialist.LoginSpec;
                lblPassword.Text += specialist.PasswordSpec;
                lblId.Text += specialist.IdSpec;
                lblRole.Text += "Специалист";
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (cbOption.Text == "Логин")
            {
                if (buyerService.IsExist(tbNewValue.Text) || ownerService.IsExist(tbNewValue.Text) || specService.IsExist(tbNewValue.Text))
                {
                    MessageBox.Show("Данный логин уже используется.", "Ошибка");
                    return;
                }
            }
            if (role == "Buyer")
            {
                if (!buyerService.Change(id_user, tbNewValue.Text, cbOption.Text))
                {
                    MessageBox.Show("Ошибка ввода");
                    return;
                }
            }
            if (role == "Owner")
            {
                ownerService.Change(id_user, tbNewValue.Text, cbOption.Text);
                if (!ownerService.Change(id_user, tbNewValue.Text, cbOption.Text))
                {
                    MessageBox.Show("Ошибка ввода");
                    return;
                }
            }
            if (role == "Spec")
            {
                specService.Change(id_user, tbNewValue.Text, cbOption.Text);
                if (!specService.Change(id_user, tbNewValue.Text, cbOption.Text))
                {
                    MessageBox.Show("Ошибка ввода");
                    return;
                }
            }
            MessageBox.Show("Данные успешно изменены");
        }
    }
}

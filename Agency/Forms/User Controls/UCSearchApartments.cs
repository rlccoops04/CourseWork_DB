using Agency.Models;
using Agency.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agency
{
    public partial class UCSearchApartments : UserControl
    {
        private List<Apartment> searchedApartments;
        private ApartmentService apartmentServ;
        private UCApartment ucApartment;
        public UCSearchApartments()
        {
            searchedApartments = new();
            apartmentServ = new();
            InitializeComponent();
        }
        private void DuplicateList()
        {
            foreach (Apartment apartment in apartmentServ.GetFreeAparts())
            {
                searchedApartments.Add(apartment);
            }
        }
        private void HideAparts()
        {
            foreach (Control control in panel.Controls)
            {
                control.Hide();
            }
        }
        private void ShowAparts()
        {
            int i = 0;
            foreach (Apartment apartment in searchedApartments)
            {
                ucApartment = new(apartment);
                ucApartment.Location = new Point(0, i);
                panel.Controls.Add(ucApartment);
                i += 240;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            HideAparts();
            searchedApartments.Clear();
            DuplicateList();

            //Фильтр площади
            if (tbSpace1.Text != "" && tbSpace2.Text != "")
            {
                try
                {
                    foreach (Apartment apartment in apartmentServ.GetFreeAparts())
                    {
                        if (apartment.GeneralSpace < Convert.ToDouble(tbSpace1.Text) || apartment.GeneralSpace > Convert.ToDouble(tbSpace2.Text))
                        {
                            searchedApartments.Remove(apartment);
                        }
                    }
                }
                catch { MessageBox.Show("Неверный ввод площади.", "Ошибка ввода"); }
            }
            else if (tbSpace1.Text == "" && tbSpace2.Text != "")
            {
                MessageBox.Show("Неверный ввод площади.", "Ошибка ввода");
            }
            else if (tbSpace1.Text != "" && tbSpace2.Text == "")
            {
                MessageBox.Show("Неверный ввод площади.", "Ошибка ввода");
            }

            //Фильтр этажа
            if (tbFloorMin.Text != "" && tbFloorMax.Text != "")
            {
                try
                {
                    foreach (Apartment apartment in apartmentServ.GetFreeAparts())
                    {
                        if (apartment.NumFloor < Convert.ToInt32(tbFloorMin.Text) || apartment.NumFloor > Convert.ToInt32(tbFloorMax.Text))
                        {
                            searchedApartments.Remove(apartment);
                        }
                    }
                }
                catch { MessageBox.Show("Неверный ввод номера этажа.", "Ошибка ввода"); }
            }
            else if (tbFloorMin.Text == "" && tbFloorMax.Text != "")
            {
                MessageBox.Show("Неверный ввод номера этажа.", "Ошибка ввода");
            }
            else if (tbFloorMin.Text != "" && tbFloorMax.Text == "")
            {
                MessageBox.Show("Неверный ввод номера этажа.", "Ошибка ввода");
            }

            //Фильтр комнат
            if (tbRoomsMin.Text != "" && tbRoomsMax.Text != "")
            {
                try
                {
                    foreach (Apartment apartment in apartmentServ.GetFreeAparts())
                    {
                        if (apartment.CountRooms < Convert.ToInt32(tbRoomsMin.Text) || apartment.CountRooms > Convert.ToInt32(tbRoomsMax.Text))
                        {
                            searchedApartments.Remove(apartment);
                        }
                    }
                }
                catch { MessageBox.Show("Неверный ввод комнатности.", "Ошибка ввода"); }
            }
            else if (tbRoomsMin.Text == "" && tbRoomsMax.Text != "")
            {
                MessageBox.Show("Неверный ввод комнатности.", "Ошибка ввода");
            }
            else if (tbRoomsMin.Text != "" && tbRoomsMax.Text == "")
            {
                MessageBox.Show("Неверный ввод комнатности.", "Ошибка ввода");
            }

            //Тип постройки
            if (cbType.Text != "")
            {
                foreach (Apartment apartment in apartmentServ.GetFreeAparts())
                {
                    if (apartment.TypeBuild != cbType.Text)
                    {
                        searchedApartments.Remove(apartment);
                    }
                }
            }

            //Фильтр цены
            if (tbPriceMin.Text != "" && tbPriceMax.Text != "")
            {
                try
                {
                    foreach (Apartment apartment in apartmentServ.GetFreeAparts())
                    {
                        if (apartment.CountRooms < Convert.ToInt32(tbPriceMin.Text) || apartment.CountRooms > Convert.ToInt32(tbPriceMax.Text))
                        {
                            searchedApartments.Remove(apartment);
                        }
                    }
                }
                catch { MessageBox.Show("Неверный ввод цены.", "Ошибка ввода"); }
            }
            else if (tbPriceMin.Text == "" && tbPriceMax.Text != "")
            {
                MessageBox.Show("Неверный ввод цены.", "Ошибка ввода");
            }
            else if (tbPriceMin.Text != "" && tbPriceMax.Text == "")
            {
                MessageBox.Show("Неверный ввод цены.", "Ошибка ввода");
            }

            //Метро
            if (cbMetro.Checked)
            {
                foreach (Apartment apartment in apartmentServ.GetFreeAparts())
                {
                    if (apartment.IdAdresNavigation.Metro != "рядом")
                    {
                        searchedApartments.Remove(apartment);
                    }
                }
            }

            //Мебель
            if (cbFurniture.Checked)
            {
                foreach (Apartment apartment in apartmentServ.GetFreeAparts())
                {
                    if (apartment.Furniture != "есть")
                    {
                        searchedApartments.Remove(apartment);
                    }
                }
            }

            ShowAparts();
        }
    }
}

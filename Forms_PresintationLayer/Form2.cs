using ConsoleBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_PresintationLayer
{
    public partial class Form2 : Form
    {
        enum enMode { AddMode = 0 ,UpdateMode = 1};

        enMode _Mode;
        int _ContactID;
        clsContacts _Contacts;
        public Form2( int contactid )
        {
            InitializeComponent();

            _ContactID = contactid;

            if (_ContactID == -1)
                _Mode = enMode.AddMode;
            else
                _Mode = enMode.UpdateMode;
        }

        private void _LoadCountriesInComboBox()
        {
            DataTable dt = clsCountries.GetListCountries();

            foreach(DataRow dr in dt.Rows)
            {
                cmbCountry.Items.Add((string)dr["CountryName"]);
            }
        }
        private void _LoadData()
        {
            _LoadCountriesInComboBox();
            cmbCountry.SelectedIndex = 0;

            if( _Mode == enMode.AddMode )
            {
                _Contacts = new clsContacts();
                lblMode.Text = "Adding Contact";
                return;
            }

            if(_Mode == enMode.UpdateMode )
            {
                _Contacts = clsContacts.Find(_ContactID);

                if (_Contacts == null)
                {
                    MessageBox.Show("This Contact doesnt exist");
                    return;
                }

                lblContactID.Text = _Contacts.ContactID.ToString();
                txtFirstname.Text = _Contacts.FirstName;
                txtLastname.Text = _Contacts.LastName;
                txtEmail.Text = _Contacts.Email;
                txtPhone.Text = _Contacts.Phone;
                dateTimePicker1.Value = _Contacts.DateOfBirth;
                txtAddress.Text = _Contacts.Address;

                if(_Contacts.ImagePath != null)
                {
                    ppContactImage.ImageLocation = _Contacts.ImagePath;
                }
                if(_Contacts.ImagePath == "")
                    LinkDelete.Visible = false;
                else
                    LinkDelete.Visible = true;



                lblMode.Text = "Edit Contact ";
                clsCountries country = clsCountries.Find(_Contacts.CountryID);
                cmbCountry.SelectedIndex = cmbCountry.FindString(country.CountryName);

            }
        }

        private void _SaveData()
        {
            _Contacts.FirstName = txtFirstname.Text;
            _Contacts.LastName = txtLastname.Text;
            _Contacts.Email = txtEmail.Text;
            _Contacts.Phone = txtPhone.Text;
            _Contacts.Address = txtAddress.Text;
            _Contacts.ContactID = _ContactID;

            if (!string.IsNullOrEmpty(ppContactImage.ImageLocation))
                _Contacts.ImagePath = ppContactImage.ImageLocation;
            else
                _Contacts.ImagePath = "";

            int countryid = clsCountries.Find(cmbCountry.Text).CountryID;
            _Contacts.CountryID = countryid;

            if(_Contacts.Save())
            {
                if (_Mode == enMode.AddMode)
                {
                    if ((MessageBox.Show("Contact Added Successfully", "Adding", MessageBoxButtons.OK) == DialogResult.OK))
                    {
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("Contact Updated Successfully");

                _Mode = enMode.UpdateMode;
                lblMode.Text = "Edit Contact ";
                lblContactID.Text = _Contacts.ContactID.ToString();
            }
                 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _SaveData();
           
        }

        private void LinkSet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = ("FileData |*.jpg;*.jpeg;*.png");
            openFileDialog1.FilterIndex = 0;
            
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ppContactImage.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void LinkDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ppContactImage.ImageLocation = null;
            _Contacts.ImagePath = "";
            LinkDelete.Visible = false;
        }

     
    }
}

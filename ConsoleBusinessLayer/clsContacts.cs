using ConsoleDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleBusinessLayer
{
    public class clsContacts
    {
        public enum enMode {enUpdateMode = 0,enAddMode = 1 };
        enMode Mode;
        public int ContactID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int CountryID { get; set; }

        public string ImagePath {  get; set; }

        

        private clsContacts (int contactid, string firstname, string lastname,
            string email,string phone,string address , DateTime dateofbirth , int countryid, string imagepath)
        {
            Mode = enMode.enUpdateMode;

            this.ContactID = contactid;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Email = email;
            this.Phone = phone;
            this.Address = address;
            this.DateOfBirth = dateofbirth;
            this.CountryID = countryid;
            this.ImagePath = imagepath;
        }

        public clsContacts()
        {
            this.ContactID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.Email = "";
            this.Phone = "";
            this.Address ="";
            this.DateOfBirth = DateTime.Now;
            this.CountryID = -1;
            this.ImagePath = "";

            Mode = enMode.enAddMode;
        }
        
        public static clsContacts Find(int contactid)
        {
            string firstname = "", lastname = "", email = "", phone = "", address = "", imagePath = "";
            DateTime dateofbirth = DateTime.Now;
            int countryid = 0;

            if (clsContactsDataLayer.GetContactInfoByID(ref contactid, ref firstname, ref lastname,ref email,
                ref phone, ref address,ref dateofbirth,ref countryid, ref imagePath)) 
            {
                return new clsContacts(contactid, firstname, lastname, email, phone, address, dateofbirth, countryid, imagePath);
            }
            else
                return null;
        }

        private  bool _AddNewContact()
        {
            this.ContactID = clsContactsDataLayer.AddNewContact(this.FirstName, this.LastName, this.Email,
                this.Phone, this.Address, this.DateOfBirth, this.CountryID, this.ImagePath);

            return (this.ContactID != -1);

        }

        private bool _UpdateContact()
        {
            return clsContactsDataLayer.UpdateContact(this.ContactID, this.FirstName, this.LastName, this.Email, this.Address,this.Phone,
                this.DateOfBirth, this.CountryID, this.ImagePath);
        }

        public static bool DeleteContact(int contactid)
        {
            return clsContactsDataLayer.DeleteContact(contactid);
        }
        public static DataTable ListContacts()
        {
            return clsContactsDataLayer.GetListData();
        }

        public static bool isContactExist(int contactid)
        {
            return clsContactsDataLayer.IsContactExist(contactid);
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.enAddMode:
                    if(_AddNewContact())
                    {
                        Mode = enMode.enUpdateMode;
                        return true;
                    }
                    else
                        return false;

                case enMode.enUpdateMode:
                    if (_UpdateContact())
                    {
                        Mode = enMode.enUpdateMode;
                        return true;
                    }
                    else return false;

            }
            return false;
        }
    }
}

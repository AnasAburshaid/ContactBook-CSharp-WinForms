using ConsoleDataAccessLayer;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBusinessLayer
{
    public class clsCountries
    {
        public enum enMode {enUpdateMode = 0,enAddMode = 1 };
        enMode Mode;
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        public string Code { get; set; }
        public string PhoneCode { get; set; }

        private clsCountries(int countryid , string countryname , string code , string phonecode)
        {
            Mode = enMode.enUpdateMode;
            this.CountryID = countryid;
            this.CountryName = countryname;
            this.Code = code;
            this.PhoneCode = phonecode;
        }

        public clsCountries()
        {
            Mode = enMode.enAddMode;
            this.CountryID = -1;
            this.CountryName="";
            this.Code = "";
            this.PhoneCode = "";
            
        }
        public static clsCountries Find(int countryid)
        {
            string countryname = "", code = "", phonecode = "";

            if(clsCountriesDataLayer.GetCountryInfoByID(ref countryid,ref countryname, ref code,ref phonecode))
            {
                return new clsCountries(countryid,countryname,code,phonecode);
            }
            return null;
        }
        public static clsCountries Find(string countryname)
        {
            int countryid = -1;
            string code = "", phonecode = "";

            if (clsCountriesDataLayer.GetCountryInfoByName(ref countryid, ref countryname, ref code, ref phonecode))
            {
                return new clsCountries(countryid, countryname, code, phonecode);
            }
            return null;
        }



        private bool _AddNewCountry()
        {
            this.CountryID = clsCountriesDataLayer.AddNewCountry(this.CountryName,this.Code,this.PhoneCode);
            return (this.CountryID > -1);
        }

        public static bool isCountryExist(int countryid)
        {
            return clsCountriesDataLayer.IsCountryExist(countryid);
        }

        public static bool isCountryExistByName(string  countryname)
        {
            return clsCountriesDataLayer.IsCountryExist(countryname);
        }

        public static bool deleteCountry(int countryid)
        {
            if (clsCountriesDataLayer.IsCountryExist(countryid))
                return clsCountriesDataLayer.DeleteCountry(countryid);
            else
                return false;
        }

        private bool _UpdateCountry()
        {
            return clsCountriesDataLayer.UpdateContact(this.CountryID, this.CountryName,this.Code,this.PhoneCode);
        }

        public static DataTable GetListCountries()
        {
            return clsCountriesDataLayer.GetAllCountries();
        }
        public bool Save()
        {
            switch(Mode)
            {
                case enMode.enAddMode:
                    {
                        if(_AddNewCountry())
                        {
                            Mode = enMode.enUpdateMode;
                            return true;
                        }
                        else
                            return false; 
                    }
                case enMode.enUpdateMode:
                    {
                        if (_UpdateCountry())
                        {
                            Mode = enMode.enUpdateMode;
                            return true;
                        }
                        else
                            return false;
                    }
            }
            return false;
        }

    }
}

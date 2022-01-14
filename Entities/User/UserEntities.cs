using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.User
{
    public class UserEntities
    {
        #region=====local variable and constant declaration=====
        /// <summary>
        /// user variables
        /// </summary>
        private int _id;
        private string _name;
        private string _email;
        private string _password;
        private string _profile;
        private string _type;
        private string _phone;
        private string _address;
        private DateTime _dateofbirth;
        private int _createuserid;
        private int _updateduserid;
        private int _deleteduserid;
        private DateTime _createdat;
        private DateTime _updatedat;
        private DateTime _deletedat;
        private int _isdelete;
        private string @email;
        private string @password;
        #endregion

        #region=====constructor and destructor=====
        /// <summary>
        /// constructor and destructor for user variable
        /// </summary>
        public void UserData()
        {
            _id = 0;
            _name = String.Empty;
            _email = String.Empty;
            _password = String.Empty;
            _profile = String.Empty;
            _type = String.Empty;
            _phone = String.Empty;
            _address = String.Empty;
            _dateofbirth = DateTime.Now;
            _createuserid = 1;
            _updateduserid = 1;
            _deleteduserid = 1;
            _createdat = DateTime.Now;
            _updatedat = DateTime.Now;
            _deletedat = DateTime.Now;
            _isdelete = 0;
            @email = String.Empty;
            password = String.Empty;

        }

        public void UserData(int id, string name, string email, string password, string profile, string type, string phone, string address, DateTime dateofbirth, int createduserid, int updateduserid, int deleteduserid, DateTime createdat, DateTime updatedat, DateTime deletedat, int is_delete)
        {
            _id = id;
            _name = name;
            _email = email;
            _password = password;
            _profile = profile;
            _type = type;
            _phone = phone;
            _address = address;
            _dateofbirth = DateTime.Now;
            _createuserid = 1;
            _updateduserid = 1;
            _deleteduserid = 1;
            _createdat = DateTime.Now;
            _updatedat = DateTime.Now;
            _deletedat = DateTime.Now;
            _isdelete = 0;
        }
        #endregion

        #region=====properties assigning and retrieving
        /// <summary>
        /// get or set the id attribute value
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        /// <summary>
        /// get or set the name attribute value
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        /// <summary>
        /// get or set the email attribute value
        /// </summary>
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        /// <summary>
        /// get or set the password attribute value
        /// </summary>
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }
        /// <summary>
        /// get or set the profile attribute value
        /// </summary>
        public string Profile
        {
            get
            {
                return _profile;
            }
            set
            {
                _profile = value;
            }
        }
        /// <summary>
        /// get or set the type attribute value
        /// </summary>
        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }
        /// <summary>
        /// get or set the phone attribute value
        /// </summary>
        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                _phone = value;
            }
        }
        /// <summary>
        /// get or set the address attribute value
        /// </summary>
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }
        /// <summary>
        /// get or set the dateofbirth attribute value
        /// </summary>
        public DateTime Dateofbirth
        {
            get
            {
                return _dateofbirth;
            }
            set
            {
                _dateofbirth = value;
            }
        }
        /// <summary>
        /// get or set the Createuserid attribute value
        /// </summary>
        public int Createuserid
        {
            get
            {
                return _createuserid;
            }
            set
            {
                _createuserid = value;
            }
        }
        /// <summary>
        /// get or set the Updateduserid attribute value
        /// </summary>
        public int Updateduserid
        {
            get
            {
                return _updateduserid;
            }
            set
            {
                _updateduserid = value;
            }
        }
        /// <summary>
        /// get or set the Deleteduserid attribute value
        /// </summary>
        public int Deleteduserid
        {
            get
            {
                return _deleteduserid;
            }
            set
            {
                _deleteduserid = value;
            }
        }
        /// <summary>
        /// get or set the Createdat attribute value
        /// </summary>
        public DateTime Createdat
        {
            get
            {
                return _createdat;
            }
            set
            {
                _createdat = value;
            }
        }
        /// <summary>
        /// get or set the Updatedat attribute value
        /// </summary>
        public DateTime Updatedat
        {
            get
            {
                return _updatedat;
            }
            set
            {
                _updatedat = value;
            }
        }
        /// <summary>
        /// get or set the Deletedat attribute value
        /// </summary>
        public DateTime Deletedat
        {
            get
            {
                return _deletedat;
            }
            set
            {
                _deletedat = value;
            }
        }
        /// <summary>
        ///  get or set the Isdelete attribute value
        /// </summary>
        public int Isdelete
        {
            get
            {
                return _isdelete;
            }
            set
            {
                _isdelete = value;
            }
        }
        #endregion
    }
}

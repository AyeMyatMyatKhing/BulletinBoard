using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.User
{
    public class UserEntities
    {
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

    }
}

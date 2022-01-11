using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Post
{
    public class PostEntities
    {
        private int id;
        private string title;
        private string description;
        private int status;
        private int createuserid;
        private int updateduserid;
        private int deleteduserid;
        private DateTime createdat;
        private DateTime updatedat;
        private DateTime deletedat;


        public void PostData(int id, string title, string description, int status, int createuserid, int updateduserid, int deleteduserid, DateTime createdat, DateTime updatedat, DateTime deletedat)
        {
            id = id;
            title = title;
            description = description;
            status = status;
            createuserid = createuserid;
            updateduserid = updateduserid;
            deleteduserid = deleteduserid;
            createdat = createdat;
            updatedat = updatedat;
            deletedat = deletedat;
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public int Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }


        public int Createuserid
        {
            get
            {
                return createuserid;
            }
            set
            {
                createuserid = value;
            }
        }

        public int Updateduserid
        {
            get
            {
                return updateduserid;
            }
            set
            {
                updateduserid = value;
            }
        }

        public int Deleteduserid
        {
            get
            {
                return deleteduserid;
            }
            set
            {
                deleteduserid = value;
            }
        }

        public DateTime Createdat
        {
            get
            {
                return createdat;
            }
            set
            {
                createdat = value;
            }
        }

        public DateTime Updatedat
        {
            get
            {
                return updatedat;
            }
            set
            {
                updatedat = value;
            }
        }

        public DateTime Deletedat
        {
            get
            {
                return deletedat;
            }
            set
            {
                deletedat = value;
            }
        }
    }
}

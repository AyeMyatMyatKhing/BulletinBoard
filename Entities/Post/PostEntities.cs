using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Post
{
    public class PostEntities
    {
        #region=====local variable and constant declaration=====
        /// <summary>
        /// post variables
        /// </summary>
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
        #endregion

        #region=====Constructor and destructor=====
        /// <summary>
        /// constructor and destructor for post variable
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="status"></param>
        /// <param name="createuserid"></param>
        /// <param name="updateduserid"></param>
        /// <param name="deleteduserid"></param>
        /// <param name="createdat"></param>
        /// <param name="updatedat"></param>
        /// <param name="deletedat"></param>
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
        #endregion

        #region=====properties assigning retrieveing=====
        /// <summary>
        /// get and set the ID attribute value
        /// </summary>
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
        /// <summary>
        /// get and set the Title attribute value
        /// </summary>
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
        /// <summary>
        /// get and set the description attribute value
        /// </summary>
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
        /// <summary>
        /// get and set the status attribute value
        /// </summary>
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

        /// <summary>
        /// get and set the Createuserid attribute value
        /// </summary>
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
        /// <summary>
        /// get and set the Updateduserid attribute value
        /// </summary>
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
        /// <summary>
        /// get and set the Deleteduserid attribute value
        /// </summary>
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
        /// <summary>
        /// get and set the Createdat attribute value
        /// </summary>
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
        /// <summary>
        /// get and set the Updatedat attribute value
        /// </summary>
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
        /// <summary>
        /// get and set the Deletedat attribute value
        /// </summary>
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
        #endregion
    }
}

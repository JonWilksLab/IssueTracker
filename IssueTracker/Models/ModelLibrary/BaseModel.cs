using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLibrary
{
    public class BaseModel
    {
        /// <summary>
        /// ID used as the key value for the underlying data store
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Identifies the user who created the item
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// Identifies the user who last updated the item
        /// </summary>
        public string ModifiedBy { get; set; }
        /// <summary>
        /// Date when the item was created
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Date when the item was last modified
        /// </summary>
        public DateTime ModifiedDate { get; set; }


    }
}

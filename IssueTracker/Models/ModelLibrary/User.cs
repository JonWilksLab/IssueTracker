using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLibrary 
{
    public class User : BaseModel
    {
        /// <summary>
        /// User ID based on the Authentication provider
        /// </summary>
        public string UserID { get; set; }

        /// <summary>
        /// Full users name for display purposes
        /// </summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// Identifies a user as having access to administration facilities.
        /// </summary>
        public bool IsAdmin { get; set; }
    }
}

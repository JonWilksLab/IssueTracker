using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLibrary
{
    public class Issue : BaseModel
    {
        /// <summary>
        /// We will use a seperate key from the ID to provide a formatted code for user reference purposes
        /// </summary>
        public string IssueCode { get; set; }
        /// <summary>
        /// Title to display on the summary
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Full description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Assigned user (will be a copy of the username to ensure deleted users are still managed)
        /// </summary>
        public string Assignee { get; set; }
        /// <summary>
        /// Current bug status
        /// </summary>
        public IssueStatus Status { get; set; }
    }
}

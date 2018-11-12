using ModelLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceLibrary
{
    /// <summary>
    /// Defines a common interface for Issue management
    /// </summary>
    public interface IIssues
    {
        List<Issue> GetIssues();
        Issue CreateIssue(Issue issue);
        Issue UpdateIssue(Issue issue);   
    }
}

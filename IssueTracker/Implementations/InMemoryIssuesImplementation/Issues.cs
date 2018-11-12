using InterfaceLibrary;
using ModelLibrary;
using System;
using System.Collections.Generic;

namespace InMemoryIssuesImplementation
{
    public class Issues : IIssues
    {
        private List<Issue> _issues = new List<Issue>();

        public Issues()
        {
            _issues.Add(new Issue() {
                Id = 1,
                Title = "Test issue 1"
             });
            _issues.Add(new Issue()
            {
                Id = 2,
                Title = "Test issue 2"
            });
        }
        public Issue CreateIssue(Issue issue)
        {
            throw new NotImplementedException();
        }

        public List<Issue> GetIssues()
        {
            return _issues; 
        }

        public Issue UpdateIssue(Issue issue)
        {
            throw new NotImplementedException();
        }
    }
}

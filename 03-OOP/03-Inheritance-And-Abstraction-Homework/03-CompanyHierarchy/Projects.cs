using System;

namespace _03_CompanyHierarchy
{
    class Project
    {
        //A project holds project name, project start date, details and a state (Open or Closed). A project can be Closed through the method CloseProject().
        private string projectName;
        private DateTime startDate;
        private string details;
        private State projectState;

        public Project(string projectName, DateTime startDate, string details)
        {
            this.ProjectName = projectName;
            this.StartDate = startDate;
            this.Details = details;
            this.ProjectState = State.Open;
        }

        public void CloseProject()
        {
            
        }

        public string ProjectName
        {
            get { return projectName; }
            set { projectName = value; }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public string Details
        {
            get { return details; }
            set { details = value; }
        }

        public State ProjectState
        {
            get { return projectState; }
            private set { projectState = value; }
        }
    }
}

using System;

namespace InfinityLibrary.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string Manager { get; set; }
        public string FrontEndDev { get; set; }
        public string BackEndDev { get; set; }
        public string Tester { get; set; }
        public string Priority { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}

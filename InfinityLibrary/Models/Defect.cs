using System;

namespace InfinityLibrary.Models
{
    public class Defect
    {
        public int DefectId { get; set; }
        public string ProjectName { get; set; }
        public string ModuleName { get; set; }
        public string Description { get; set; }
        public string StepsToRepeat { get; set; }
        public string RaisedBy { get; set; }
        public string AssignedTo { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public DateTime DateRaised { get; set; }
        public DateTime? DateClosed { get; set; }
        public int DRR { get; set; }
        public int DRE { get; set; }
    }
}

namespace InfinityLibrary.Models
{
    public class Module
    {
        public int ModuleId { get; set; }
        public int ProjectId { get; set; }
        public string ModuleName { get; set; }
        public string ModuleFunction { get; set; }
        public string AddedBy { get; set; }
        public virtual Project Project { get; set; }
    }
}

namespace ComplianceProject.Models
{
    public class ComplianceModel
    {
        public int Id { get; set; }
        public string RetentionPeriod { get; set; }
        public string DataExportOrDeletionRequest { get; set; }
        public string ComplianceReport { get; set; }
    }
}
namespace TP.Data.EntityFramework.Entities.Workflow
{
    public enum ApplicationStatus : int
    {
        Draft = 0,
        
        Submitted = 1,
        
        Completed = 2,
        
        Rejected = 3,
        
        Cancelled = 4,
        
        Deleted = 5
    }
}

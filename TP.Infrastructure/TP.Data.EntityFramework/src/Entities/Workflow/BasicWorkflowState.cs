namespace TP.Data.EntityFramework.Entities.Workflow
{
    public class BasicWorkflowState : WorkflowState
    {
        public BasicWorkflowState()
        {
            Type = WorkflowStateType.Basic;
        }

        public string CheckerId { get; set; }

        public virtual ApplicationUser Checker { get; set; }
    }
}

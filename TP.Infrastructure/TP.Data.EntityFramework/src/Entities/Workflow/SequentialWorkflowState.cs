namespace TP.Data.EntityFramework.Entities.Workflow
{
    public class SequentialWorkflowState : WorkflowState
    {
        public SequentialWorkflowState()
        {
            Type = WorkflowStateType.Sequential;
        }
    }
}

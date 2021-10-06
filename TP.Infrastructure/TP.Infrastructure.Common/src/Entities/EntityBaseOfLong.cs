namespace TP.Infrastructure.Common.Entities
{
    public class EntityBaseOfLong : EntityBase<long>
    {
        public EntityBaseOfLong()
        {
            this.Id = IdWorker.Instance.NextId();
        }
    }
}

namespace TP.Infrastructure.Common.Model
{
    public class SelectListItemModel<TValue>
    {
        public string Text { get; set; }

        public TValue Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}

namespace TP.WL.ERP.Model.Utilities
{
    public class ClientTokenEditModel
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Secret { get; set; }

        public bool IsActive { get; set; }

        public int RefreshTokenLifeTime { get; set; }
    }
}

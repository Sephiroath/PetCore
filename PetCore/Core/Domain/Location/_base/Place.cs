namespace Core.Domain.Location._base
{
    public abstract class Place
    {
        #region Identification

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Grade { get; set; }
        
        #endregion

        #region Price

        public long MinValue { get; set; }
        public long MaxValue { get; set; }

        #endregion

    }
}
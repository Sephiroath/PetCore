namespace Core.Domain.Location
{
    using _base;

    public class Park : Place 
    {
        public bool ArePetsAllowed { get; set; }
    }
}
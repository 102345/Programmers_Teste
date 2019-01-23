namespace Programmers.Domain.Entities
{
    public class Price : BaseEntity
    {
        public int idEvent { get; set; }
        public int audience { get; set; }
        public decimal value { get; set; }
       

    }
}

namespace MyMvc.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CustomerTypeId { get; set; }


        public virtual CustomerType CustomerType { get; set; }
    }
}
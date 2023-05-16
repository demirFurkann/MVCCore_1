namespace MVCCore_1.Models.Entities
{
    public class Order:BaseEntity
    {
        public string ShippingAdress { get; set; }

        //Relational Properties


        public virtual AppUser AppUser { get; set; }
        public virtual List<OrderDetail> OrderDetails{ get; set; }
    }
}

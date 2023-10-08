namespace ExceptionProject
{
    public class Deleviry
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        

        public DateTime OrderDate=DateTime.Now;
        public DateTime? ShippedDate =DateTime.TryParse("2021-10-12", out DateTime date) ? date : (DateTime?)null;
        public DateTime? DeliveredDate = DateTime.TryParse("2021-10-14", out DateTime date) ? date : (DateTime?)null;

        public DateTime? ShippingDate =DateTime.TryParse("2021-10-11", out DateTime date) ? date : (DateTime?)null;
        public DateTime? InTransitDate=DateTime.TryParse("2021-10-13", out DateTime date) ? date : (DateTime?)null;
        public DeleviryStatus Status { get; set; }

        public override string ToString()
        {
           
            return $"{{\n   ID:{Id}, \n   CustomerName:{CustomerName}, \n   Address:{Address}, \n   OrderDate:{OrderDate}, \n   ShippingDate:{ShippingDate}, \n   shippedDate:{ShippedDate}, \n   InTransitDate:{InTransitDate}, \n   DeliveredDate:{DeliveredDate}, \n   Status:{Status} \n}}";
              
        }


    }
}
namespace Shop.Models
{
    public class ProductModel
    {
        public int id { get; set; }
        public string name{ get; set; }
        public float price { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public int userId { get; set; }
        public UserModel User { get; set; }
    }
}

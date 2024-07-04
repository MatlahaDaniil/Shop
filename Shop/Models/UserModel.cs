using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
	public class UserModel
	{
		public int id { get; set; }

		[Display(Name = "Введіть ім'я")]
		public string name { get; set; }

		[Display(Name = "Введіть пошту")]
		public string email { get; set; }

        [Display(Name = "Введіть пароль")]
        public string password { get; set; }

        [Display(Name = "Введіть номер телефону")]
		[StringLength(15, ErrorMessage = "номер телефону занадто довгий")]
        public string numOfPhone { get; set; }
        public ICollection<ProductModel> favouriteProducts { get; set; }
    }
}

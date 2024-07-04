using Shop.Models;
using System.Security.Cryptography.Xml;

namespace Shop
{
    public class DbObjects
    {
        public static void Initial(ref AppDbContent db)
        {
            DbObjects.db = db;

            if (db.product.Any())
            {
                Products = db.product.ToList();
            }

            if (db.user.Any())
            {
                Users = db.user.ToList();
            }

        }

        public static List<ProductModel> Products { get; set; }
        public static List<UserModel> Users { get; set; }
        public static AppDbContent db { get; set; }
        public static UserModel currentUser { get; set; }
        public static ProductModel selectedProduct{ get; set; }

        public static void AddUser(UserModel user)
        {
            db.user.Add(user);
            db.SaveChanges();
            UpdateLists();
		}
        public static void AddProduct(ProductModel product)
        {
            db.product.Add(product);
            db.SaveChanges();
            UpdateLists();
		}

		public static void UpdateLists()
        {
            if(Products != null)
                Products.Clear();

            if (Users != null)
                Users.Clear();

			Products = db.product.ToList();
			Users = db.user.ToList();
		}



		//public static void SaveData()
  //      {
  //          if (db.user.Count() != Users.Count())
  //          {
  //              for (int i = Users.Count(); i < db.user.Count(); --i)
  //              {
  //                  db.user.Add(Users.ElementAt(i));
  //              }
  //          }

  //          if (db.product.Count() != Products.Count())
  //          {
  //              for (int i = Products.Count(); i < db.product.Count(); --i)
  //              {
  //                  db.product.Add(Products.ElementAt(i));
  //              }
  //          }

  //          db.SaveChanges();
  //      }
    }
}

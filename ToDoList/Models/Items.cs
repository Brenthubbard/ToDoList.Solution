namespace ToDoList.Models
{
  public class Item
  {
    public int ItemId { get; set; }
    public string Description { get; set; }
    public int CategoryId { get; set; }
    public virtual Category Category { get; set; }
  }
}


// using System.Collections.Generic;
// using MySql.Data.MySqlClient;


// namespace ToDoList.Models
// {
//   public class Item
//   {
//     public string Description { get; set; }
//     public int Id { get; }
//     // private static List<Item> _instances = new List<Item> { };

//     public Item(string description, int id)
//     {
//       Description = description;
//       Id = id;
//     }
//     public override bool Equals(System.Object otherItem)
//     {
//       if (!(otherItem is Item))
//       {
//         return false;
//       }
//       else
//       {
//         Item newItem = (Item)otherItem;
//         bool descriptionEquality = (this.Description == newItem.Description);
//         return descriptionEquality;
//       }
//     }
//     public void Save()
//     {
//     }
//     public static List<Item> GetAll()

//     {
//       List<Item> allItems = new List<Item> { };
//       MySqlConnection conn = DB.Connection();
//       conn.Open();
//       MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
//       cmd.CommandText = @"SELECT * FROM items;";
//       MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
//       while (rdr.Read())
//       {
//         int itemId = rdr.GetInt32(0);
//         string itemDescription = rdr.GetString(1);
//         Item newItem = new Item(itemDescription, itemId);
//         allItems.Add(newItem);
//       }
//       conn.Close();
//       if (conn != null)
//       {
//         conn.Dispose();
//       }
//       return allItems;
//     }

//     public override bool Equals(System.Object otherItem)
//     {
//       if (!(otherItem is Item))
//       {
//         return false;
//       }
//       else
//       {
//         Item newItem = (Item)otherItem;
//         bool descriptionEquality = (this.Description == newItem.Description);
//         return descriptionEquality;
//       }
//     }
//     public static void ClearAll()
//     {
//       MySqlConnection conn = DB.Connection();
//       conn.Open();
//       var cmd = conn.CreateCommand() as MySqlCommand;
//       cmd.CommandText = @"INSERT INTO items (description) VALUES (@ItemDescription);";
//       MySqlParameter description = new MySqlParameter();
//       description.ParameterName = "@ItemDescription";
//       description.Value = this.Description;
//       cmd.Parameters.Add(description);
//       // cmd.CommandText = @"DELETE FROM items;";
//       cmd.ExecuteNonQuery();
//       conn.Close();
//       if (conn != null)
//       {
//         conn.Dispose();
//       }
//     }
//     public static Item Find(int searchId)
//     {
//       // return _instances[searchId - 1];
//       Item placeholderItem = new Item("placeholder item");
//       return placeholderItem;
//     }

//   }
// }


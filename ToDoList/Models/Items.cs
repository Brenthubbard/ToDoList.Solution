using System.Collections.Generic;
using MySql.Data.MySqlClient;


namespace ToDoList.Models
{
  public class Item
  {
    public string Description { get; set; }
    public int Id { get; }
    // private static List<Item> _instances = new List<Item> { };

    public Item(string description)
    {
      Description = description;
      // _instances.Add(this);
      // Id = _instances.Count;
    }
    public static List<Item> GetAll()

    {
      List<Item> allItems = new List<Item> { };
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM items;";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      while (rdr.Read())
      {
        int itemId = rdr.GetInt32(0);
        string itemDescription = rdr.GetString(1);
        Item newItem = new Item(itemDescription, itemId);
        allItems.Add(newItem);
      }
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
      return allItems;
    }

    // {
      // return _instances;
    // }
    public static void ClearAll()
    {
      // _instances.Clear();
    }
    public static Item Find(int searchId)
    {
      // return _instances[searchId - 1];
      Item placeholderItem = new Item("placeholder item");
      return placeholderItem;
    }

    // public static void DeleteOne(string description)
    // {
    //   _instances.RemoveAll(todo => todo.Description == description);
    // }
    // public class Item
    // {
    //   public string Description { get; set; }
    //   public int Id { get; }
    //   private static List<Item> _instances = new List<Item> { };
    }
  }
// }

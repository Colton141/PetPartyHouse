using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;

namespace PetPartyHouse.Models
{
  public class Pet
  {
    public int Id { get; set;}
    public string AnimalType { get; set;}
    public string Name { get; set;}
    public string Sex { get; set;}
    public DateTime DateOfAddmittance { get; set;}
    public string Breed { get; set;}

    public Pets (int id = 0, string animalType, string name, string sex, DateTime dateOfAddmittance, string breed)
    {

      public static List<Item> GetAll()
      {
        List<Item> allItems = new List<Item> {};
        MySqlConnection conn = DB.Connection();
        conn.Open();
        //need separate for each property (animalType, name)
        MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
        cmd.CommandText = @"SELECT * From AnimalType;";

        MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
        cmd.CommandText = @"SELECT * From Name;";

        MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
        cmd.CommandText = @"SELECT * From Sex;";

        MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
        cmd.CommandText = @"SELECT * From DateOfAddmittance;";

        MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
        cmd.CommandText = @"SELECT * From Breed;";

        
        //create Data Reader Object, repsonsible for reading data returned by DB
        MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
        //must call build in .Read() method to make rdr do Something
        while(rdr.Read())
        {
          //call methods on rdr to retrieve Item information from DB
          int itemId = rdr.GetInt32(0);
          string itemDescription = rdr.GetString(1);
          //once data collected we can use it to instantiate new Item objects and add them to out allItems list. must reconstruct data into c# object with constructor
          Item newItem = new Item(itemDescription, itemId);
          allItems.Add(newItem);
        }





      }

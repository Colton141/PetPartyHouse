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
    public DateTime AdmittanceDate { get; set;}
    public string Breed { get; set;}

    public Pets (int id = 0, string animalType, string name, string sex, DateTime AdmittanceDate, string breed)
    {





    }

using Microsoft.AspNetCore.Mvc;
using PetPartyHouse.Models;
using System.Collections.Generic;

namespace PetPartyHouse.Controllers
{
  public class PetsController : Controller
  {

    [HttpGet("/pets")]
      public ActionResult Index()
      {
        List<Pets> allPets = Pets.GetAll();
        return View(allPets);
      }

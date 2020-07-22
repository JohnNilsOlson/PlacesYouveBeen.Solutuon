using Microsoft.AspNetCore.Mvc;
using PlacesYouveBeen.Models;
using System.Collections.Generic;

namespace PlacesYouveBeen.Controllers
{
  public class PlacesController : Controller
  {
    [HttpGet("/places")]
    public ActionResult Index()
    {
      List<Place> allPlaces = Place.GetAll();
      return View(allPlaces);
    }
    [HttpGet("/places/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/places")]
    public ActionResult New(string cityName)
    {
      Place newPlace = new Place(cityName);
      return RedirectToAction("Index");
    }
    [HttpGet("/places/{Id}")]
    public ActionResult Show(int Id)
    {
      Place foundPlace = Place.Find(Id);
      return View(foundPlace);
    }
  }
}
using System;
using System.Collections.Generic;

namespace Dealership.Models 
{
  public class Car 
  {
    public string MakeModel {get; set;}
    public string Price {get; set;}
    public string Miles {get; set;}

    private static List<Car> _cars = new List<Car> {};

    public static List<Car> GetAll()
    {
      return _cars;
    }

    public static void ClearList()
    {
      _cars.Clear();
    }
    public Car (string makeModel, string price, string miles )
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      _cars.Add(this);
    }
  }
}
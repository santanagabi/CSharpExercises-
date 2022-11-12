using System;

namespace Structs // Note: actual namespace depends on the project name.
{
  class Program
  {
    static void Main(string[] args)
    {

    }
  }
  struct Product
  {
    public int Id;
    public string Name;
    public double Price;

    public double PriceInDolar(double dolar)
    {
      return Price * dolar;
    }

  }
}
using System;

class Program
{  
  static void Main(string[] args)
  {
    
    
    if (args.Length == 0)
    {
    Console.WriteLine("Please write an English postcode in order to check distance to Heathrow airport");
    return;
    }

    if(args.Length > 1)
    {
    Console.WriteLine("Please enter only one client postcode.");
    return;
    }
 
    ClientLocation clientLocation = new ClientLocation(args[0]);
    Console.WriteLine(clientLocation.getClientDistanceFromHeathrow());
    }

}
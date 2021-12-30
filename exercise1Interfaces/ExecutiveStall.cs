using System;

namespace exercise1Interfaces
{
  class ExecutiveStall : IStall
  {
    private string stallName { get; set; }
    private int cost { get; set; }
    private string ownerName { get; set; }
    private int screen { get; set; }
    public ExecutiveStall(string stallName, int cost, string ownerName, int screen)
    {
      this.stallName = stallName;
      this.cost = cost;
      this.ownerName = ownerName;
      this.screen = screen;
    }
    public void display()
    {
      Console.WriteLine($"Stall Name :{stallName}");
      Console.WriteLine($"Cost :{cost}");
      Console.WriteLine($"Owner Name :{ownerName}");
      Console.WriteLine($"Number of screens :{screen}");
    }
  }
}
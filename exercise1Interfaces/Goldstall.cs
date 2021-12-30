using System;
namespace exercise1Interfaces
{
  class GoldStall : IStall
  {
    private string stallName { get; set; }
    private int cost { get; set; }
    private string ownerName { get; set; }
    private int tvSet { get; set; }
    public GoldStall(string stallName, int cost, string ownerName, int tvSet)
    {
      this.stallName = stallName;
      this.cost = cost;
      this.ownerName = ownerName;
      this.tvSet = tvSet;
    }
    public void display()
    {
      Console.WriteLine($"Stall Name :{stallName}");
      Console.WriteLine($"Cost :{cost}");
      Console.WriteLine($"Owner Name :{ownerName}");
      Console.WriteLine($"Number of tv sets :{tvSet}");
    }
  }
}
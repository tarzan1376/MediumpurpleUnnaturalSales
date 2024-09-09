using System;

class MoveEstimator {
  public static void Main (string[] args) {

    Console.WriteLine("Please enter The estimated amount of Hours required: ");
    var x = Console.ReadLine();
    Console.WriteLine("Please enter The estimated amount of Miles required: ");
    var y = Console.ReadLine();

    
    int baseRate = 200;
    int requiredHours;
    int requiredMiles;
    if (int.TryParse(x, out requiredHours) && int.TryParse(y, out requiredMiles)) {

    Console.WriteLine("The total cost is {0} ", baseRate+requiredHours*150+requiredMiles*2);

    
    }
  }
}
// See https://aka.ms/new-console-template for more information {
while (true)
{            
  Console.WriteLine("Enter a date (YYYY-MM-DD) or type 'exit' to quit:");
  string input = Console.ReadLine();
            
  if (input.ToLower() == "exit")
  {
      break;
  }

  DateTime enteredDate;
  if (!DateTime.TryParse(input, out enteredDate))
  {
      Console.WriteLine("Invalid date. Try again.");
      continue; 
  }

  DateTime currentDate = DateTime.Now;

  TimeSpan difference = enteredDate - currentDate;

  if (difference.Days == 0)
  {
      Console.WriteLine("The date is today.");
  }
  else if (difference.Days > 0)
  {
      Console.WriteLine($"The date is {difference.Days} days in the future.");
  }
  else
  {
      Console.WriteLine($"The date was {-difference.Days} days ago.");
  }
}

Console.WriteLine("Program exited.");
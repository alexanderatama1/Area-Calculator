// Declare the variables
int length, width;

// Prompt for length
Console.Write("Please enter length: ");
length = int.Parse (Console.ReadLine());

// Prompt for width
Console.Write("Please enter width: ");
width = int.Parse (Console.ReadLine());

//Output area to the Console
Console.WriteLine("A rectangle with dimensions of " + length + "x" + width + " has an area of " + length*width + ".");
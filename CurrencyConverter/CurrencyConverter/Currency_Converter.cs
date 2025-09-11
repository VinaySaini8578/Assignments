// user-input for rupees
Console.Write("Enter the amount in Rupees (INR) : ");
// Conversion required : as string is returned by ReadLine
double rupees = Convert.ToDouble(Console.ReadLine());

// amount must be greater than 0
if (rupees > 0)
{
    // Conversions 
    double USD  = rupees * (11e-3);
    double Euro = rupees * (97e-4);
    double CAD  = rupees * (16e-3);
    double GBP  = rupees * (84e-4);
    // Limiting decimal places upto 2
    Console.WriteLine("Amount in USD  : {0}", Math.Round(USD,  2));
    Console.WriteLine("Amount in Euro : {0}", Math.Round(Euro, 2));
    Console.WriteLine("Amount in CAD  : {0}", Math.Round(CAD,  2));
    Console.WriteLine("Amount in GBP  : {0}", Math.Round(GBP,  2));
}
// Invalid case : negative amount
else
{
    Console.WriteLine("Invalid Amount");
}
static string TempConvert(double temperature, string unit)
{

    switch (unit)
    {
        case "C":
            return String.Format("{0:0.##}", temperature * 9 / 5 + 32) + " F";

        case "F":
            return String.Format("{0:0.##}", (temperature - 32) * 5 / 9) + " C";

        default:
            throw new Exception("\t Invalid scale. Please enter 'C' for Celsius or 'F' for Fahrenheit.");
    }
}

while (true)
{
    try
    {
        Console.Write("\n Enter a temperature and its unit (C or F), or type 'Quit' to exit: ");
        string[] inputs = Console.ReadLine().Split(" ");


        if (inputs[0].ToUpper() == "QUIT")
        {
            Console.WriteLine(" Program terminated. \n");
            break;
        }

        if (inputs.Length < 2) throw new Exception("\t Invalid inout. Missing one or more arguments.");

        if (!inputs[0].All(char.IsNumber)) throw new Exception("\t Invalid input. Please enter a numeric temperature.");


        double temperature = Convert.ToDouble(inputs[0]);
        string unit = inputs[1].ToUpper();

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"\t Converted : {temperature} {unit} = " + TempConvert(temperature, unit));
        Console.ForegroundColor = ConsoleColor.White;
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(ex.Message);
        Console.ForegroundColor = ConsoleColor.White;
    }
}
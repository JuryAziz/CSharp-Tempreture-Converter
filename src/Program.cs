static string TempConvert(double temperature, string unit){

    switch (unit.ToUpper()){
        case "C":
            return String.Format("{0:0.##}", temperature * 9 / 5 + 32) + " F";

        case "F":
            return String.Format("{0:0.##}", (temperature - 32) * 5 / 9) + " C";

        default:
            return "Oops something went wrong";
    }
}

Console.Write("Enter a temperature and its unit (C or F): ");
string[] inputs = Console.ReadLine().Split(" ");

double temperature = Convert.ToDouble(inputs[0]);
string unit = Convert.ToString(inputs[1]);

Console.WriteLine($"Converted : {temperature} {unit} = " + TempConvert(temperature, unit));


static string TempConvert(double temp, string unit)
{

    switch (unit.ToUpper())
    {
        case "C":
            return temp * 9/5 + 32 + " F";

        case "F":
            return  (temp - 32) * 5 / 9 + " C";

        default:
            return "Oops something went wrong";
    }
}

Console.WriteLine(TempConvert(32, "F"));
Console.WriteLine(TempConvert(100, "C"));


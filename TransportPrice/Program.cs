
int kilometers = int.Parse(Console.ReadLine());
if (kilometers <= 20)
{
    string time = Console.ReadLine();
    //The kilometers are bellow 20, so the cheapest way is by taxi.
    const double StartingPrice = 0.70;
    switch (time)
    {
        case "day":
            //The tarrif while using taxi
            const double TarrifDayTaxi = 0.79;
            Console.WriteLine($"{StartingPrice + (kilometers *  TarrifDayTaxi) :f2}");
            break;
        case "night":
            double TarrifNightTaxi = 0.90;
            Console.WriteLine($"{StartingPrice + (kilometers *  TarrifNightTaxi):f2}");
            break;
    }
}
else if (kilometers > 20 && kilometers < 100)
{
    //The kilometers are more than 20, so the cheapest way is by bus.
    //The tarrif while using bus.
    double TarrifDayNightBus = 0.09;
    Console.WriteLine($"{(kilometers *  TarrifDayNightBus) :f2}");
            
}
else if (kilometers > 100)
{
    //The kilometers are more than 100, so the cheapest way is by train.
    //The tarrif while using train.
    double TarrifDayNightTrain = 0.06;
    Console.WriteLine($"{(kilometers *  TarrifDayNightTrain) :f2}");
            
}

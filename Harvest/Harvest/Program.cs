
//Yield in sq kilometers. 
int x = int.Parse(Console.ReadLine()); 
//Exctraction per square kilometer.
double y = double.Parse(Console.ReadLine()); 
//Wine needed.
int z = int.Parse(Console.ReadLine()); 
//Workers hired.
int workers = int.Parse(Console.ReadLine());
double  wine = (0.4*(x * y)) / 2.5;
int surplus = (int)Math.Abs(wine - z);
int winePerPerson = surplus / workers;

if (wine < z)
{
    Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", surplus);
}
else
{
    Console.WriteLine("Good harvest this year! Total wine: {0} liters.\n {1} liters left -> {2} liters per person.", wine, surplus, winePerPerson);
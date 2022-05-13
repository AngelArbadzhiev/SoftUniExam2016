
//Reading the time from the Console.
int n = int.Parse(Console.ReadLine());
int work = 365 - n;
int totalplaydays = work * 63 + n * 127;
int totalMins = 30000 - totalplaydays;
int hours = Math.Abs(totalMins / 60);
int mins = Math.Abs(totalMins % 60);
           
if (30000 < totalplaydays)
{
               
    Console.WriteLine("Tom will run away");
    Console.WriteLine("{0} hours and {1} minutes more for play", hours, mins);

}
else
{
    Console.WriteLine("Tom sleeps well");
    Console.WriteLine("{0} hours and {1} minutes less for play", hours, mins);
}

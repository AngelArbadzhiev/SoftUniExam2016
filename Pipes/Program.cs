
//The volume of the pool.
int volume = int.Parse(Console.ReadLine());
//Гow much water the pipes put in.
int pipe1 = int.Parse(Console.ReadLine());
int pipe2 = int.Parse(Console.ReadLine());
//Hours active.
double hours = double.Parse(Console.ReadLine());
//Water for all the hours active.
double water = (pipe1 + pipe2) * hours;
 
if (water <= volume)
{
    Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",
    Math.Truncate(water / volume * 100),
    Math.Truncate(pipe1 * hours / water * 100),
    Math.Truncate(pipe2 * hours / water * 100));
}
else
{
    Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hours, water - volume);
}
 

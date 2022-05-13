
//The hour that the exam starts.
int examHour = int.Parse(Console.ReadLine());
//The minute that the exam starts.
int examMinute = int.Parse(Console.ReadLine());
//The hour that the student arrived.
int arriveHour = int.Parse(Console.ReadLine());
//The minute that the student arrived.
int arriveMinute = int.Parse(Console.ReadLine());
int examTime = (examHour * 60) + examMinute;
int arriveTime = (arriveHour * 60) + arriveMinute;
int totalMinutesDifference = arriveTime - examTime;
string late = "Late";
string onTime = "On Time";
string early = "Early";
 
if(arriveTime + 30 < examTime)
        { 
        if(totalMinutesDifference / 60 == 0)
            {
                Console.WriteLine(early);
                Console.WriteLine("{0} minutes before the exam.", Math.Abs(totalMinutesDifference % 60));
 
            }
        else
            {	
                Console.WriteLine(early);
                Console.WriteLine("{0}:{1} hours before the exam.", Math.Abs(totalMinutesDifference) / 60, Math.Abs(totalMinutesDifference % 60));
            }
 
        }
else if((arriveTime <= examTime) && (arriveTime >= examTime - 30))
        {
        if(arriveTime == examTime)
            {
                Console.WriteLine(onTime);
            }
        else if(totalMinutesDifference / 60 == 0)
            {
                Console.WriteLine(onTime);
                Console.WriteLine("{0} minutes before start", Math.Abs(totalMinutesDifference % 60));
            }
        else
            {
                Console.WriteLine(onTime);
                Console.WriteLine("{0} minutes before start", Math.Abs(totalMinutesDifference % 60) );
            }
        }
else
        { 
        if(totalMinutesDifference / 60 == 0)
            {
                Console.WriteLine(late);
                Console.WriteLine("{0} minutes after the start.",Math.Abs(totalMinutesDifference % 60));
            }
        else
            {
                Console.WriteLine(late);
                Console.WriteLine("{0}:{1} hours after the start.", Math.Abs(totalMinutesDifference) / 60, Math.Abs(totalMinutesDifference % 60));
            }
        }
 

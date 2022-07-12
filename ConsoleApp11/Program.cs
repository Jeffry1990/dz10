using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int grandmotherCount;  
            int grandmotherTime = 10;    
            int hourWaitCount;         
            int minutesWaitCount;      
            int timeWait;
            int minutesPerHour = 60;


            Console.Write("Введите кол-во старушек: ");
            grandmotherCount = Convert.ToInt32(Console.ReadLine());

            timeWait = grandmotherCount * grandmotherTime;
            hourWaitCount = timeWait / minutesPerHour;
            minutesWaitCount = timeWait % minutesPerHour;

            Console.WriteLine("Вы должны отстоять в очереди " + hourWaitCount + " часа и " + minutesWaitCount + " минут.");
        }
    }
}

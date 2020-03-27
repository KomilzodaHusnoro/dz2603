using System;

namespace homework2603
{
    class Program
    {
        static void Main(string[] args)
        {  // ex #2   
        Console.Write("Enter prise of your purchase:");
        decimal purchase = int.Parse(Console.ReadLine());
        decimal konechnayaSumma;
        if (purchase >= 500 && purchase < 1000){
            konechnayaSumma = purchase - purchase*0.03m;
            Console.WriteLine(konechnayaSumma);
        } else if (purchase >= 1000){
            konechnayaSumma = purchase - purchase*0.05m;
            Console.WriteLine(konechnayaSumma);
        }
        {//ex #3
            Console.Write("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter  third number: ");
            int thirdNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter fourth number: ");
            int fourthNumber = int.Parse(Console.ReadLine());

            if (firstNumber<secondNumber && secondNumber<thirdNumber && thirdNumber<fourthNumber){
                Console.WriteLine("The numbers are in ascending order.");
            } else if (firstNumber==secondNumber && secondNumber==thirdNumber && thirdNumber==fourthNumber){
                Console.WriteLine(firstNumber*secondNumber*thirdNumber*fourthNumber);
            } else {
                if (firstNumber < secondNumber && firstNumber<thirdNumber && firstNumber<fourthNumber) {
                    Console.WriteLine("First number is min!");
                }
                 if (secondNumber<firstNumber && secondNumber<thirdNumber && secondNumber<fourthNumber) {
                    Console.WriteLine("Second number is min!");
                }
                if (thirdNumber<firstNumber && thirdNumber<secondNumber&& thirdNumber<fourthNumber) {
                    Console.WriteLine("Third number is min!");
                }
                if (fourthNumber<firstNumber && fourthNumber<secondNumber&& fourthNumber<thirdNumber) {
                    Console.WriteLine("Fourth number is min!");
                    }

                }

             }
             {// #4 не совсем поняла, что требуется в задании 
             Console.Write("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter  third number: ");
            int thirdNumber = int.Parse(Console.ReadLine());
            int promej;
            
            if (firstNumber>=secondNumber && secondNumber>=thirdNumber){
                Console.WriteLine($"{firstNumber}>={secondNumber}>={thirdNumber}");
            } else {
                if(firstNumber<=secondNumber && secondNumber<=thirdNumber && firstNumber<=thirdNumber){
                    promej = firstNumber;
                    firstNumber = thirdNumber;
                    thirdNumber = promej;
                } if(firstNumber>=secondNumber && secondNumber<=thirdNumber && thirdNumber>=firstNumber){
                    promej = thirdNumber;
                    thirdNumber = secondNumber;
                    secondNumber = firstNumber;
                    firstNumber = promej;
                } if(firstNumber>=secondNumber && secondNumber<=thirdNumber && firstNumber>=secondNumber){
                    promej = secondNumber;
                    secondNumber = thirdNumber;
                    thirdNumber = promej;
                } if(secondNumber>=firstNumber && firstNumber>=thirdNumber){
                    promej = firstNumber;
                    firstNumber = secondNumber;
                    secondNumber = promej;
                } if (secondNumber >= thirdNumber && thirdNumber >= firstNumber){
                    promej = firstNumber;
                    firstNumber = secondNumber;
                    secondNumber = thirdNumber;
                    thirdNumber = promej;
                }
                  Console.WriteLine($"{firstNumber}>={secondNumber}>={thirdNumber}");
                }
             }

        }
    }
}


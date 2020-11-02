using System;

namespace Buehring_Week03Homework_Problem1
{
    class Program
    {
        static void Main(string[] args)
        {   //My group that helped me on this assignment was myself (Joseph Buehring), Hayden Jones, and Vince Cabahug
            //This first portion is entirely for cosmetic purposes. I used ASCII Art
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("BMI Calculator");
            Console.WriteLine("===============");
            Console.WriteLine(@"
                  #####,
                 #_   _#
                 |a` `a|
                 |  u  |
                 \  =  /
                 |\___/|
        ___ ____/:     :\____ ___
      .'   `.-===-\   /-===-.`   '.
     /      .- -.- -.-.--.--.      \
    /'             =:=             '\
  .'  ' .:    o   -=:=-   o    :. '  `.
  (.'   /'. '-.....-'-.....-' .\   '. )
  /' ._/   .     -- :--      .  \_. ' \
 |  .'|      .  --- :---   .     |'.  |
 |  : |       |  ---:---  |      | :  |
  \ : |       |_____._____|      | : /
  /   (       |---- |-----|      )   \
 /... .|      |     |     |      |. ...\
|::::/''     /      |      \     ''\::::|
            / .L_      `    \       
           /'-.,__/` `\__..-'\
          ;      /     \      ;
          :     /       \     |
          |    /         \.   |
          |`../           |  ,/
          ( _ )           |  _)
          |   |           |   |
          |___|           \___|
          :===|            |==|
           \  /            |__|
           /\/\           /----`8.__
           |oo|           \__.//___)
           |==|
           \__/ ");
            Console.WriteLine();
            //Prompts the user to enter their weight in lbs
            Console.WriteLine("Please enter your weight in (lb): ");
            //Here I needed to convert the input from the user from a string value to a double value to prepare it for a number value
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your height in (in): ");
            double height = Convert.ToDouble(Console.ReadLine());
            //Here I defined the equation and ran my defined variables for height and weight from the user to determine BMI.
            double BMI = weight / (height * height) * 703;
            //I placed the result within a concatenated expression in Console.WriteLine with a math expression that allowed me to round the resulting BMI number to two decimal places.
            Console.WriteLine("Your BMI is " + Math.Round(BMI, 2));

            //Here I created an if statement that returned the condition of the user's weight based on the method's calculation for BMI
            if (BMI < 18.5)
                Console.WriteLine("You are underweight");
            else
                if (BMI >= 18.5 && BMI <= 25)
                Console.WriteLine("You are at the optimal weight");
            else
                if (BMI > 25)
                Console.WriteLine("You are overweight");

        }
    }
}

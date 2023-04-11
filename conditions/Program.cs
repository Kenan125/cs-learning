namespace conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            askTemperature:
            Console.WriteLine("pleas enter the temperature:");
            string UserTempInput = Console.ReadLine();

            try
            {
                int temperature = int.Parse(UserTempInput);
                if (temperature < 0)
                {
                    Console.WriteLine("it is below 0 celciusoutside. It is freezing do not go outside");
                }
                else if (temperature == 0)
                {
                    Console.WriteLine("it is 0 celcius outside");
                }
                else if (temperature > 0 && temperature < 20)
                {
                    Console.WriteLine("It is a bit cold take coat");

                }else if (temperature >= 40)
                {
                    Console.WriteLine("It is hot outside do not go outside");
                }
                else
                {
                    Console.WriteLine("It is nice weather lets go outside");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception, please enter the correct type next time.");
                Console.WriteLine("Please try again");
                goto askTemperature;
                
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception, the number was too long or too short for an int32");
                Console.WriteLine("Please try again");
                goto askTemperature;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException, the value was empty(null)");
                Console.WriteLine("Please try again");
                goto askTemperature;
            }
            finally
            {
                Console.WriteLine("code worked normal");
            }


           /* if (temperature < 0)
            {
                Console.WriteLine("it is below 0 celciusoutside. It is freezing do not go outside");
            } else if (temperature == 0) 
            {
                Console.WriteLine("it is 0 celcius outside");
            }else if (temperature >0 && temperature < 20) 
            {
                Console.WriteLine("It is a bit cold take coat");

            }
            else
            {
                Console.WriteLine("It is nice weather lets go outside");
            }*/
            Console.Read();
        }
    }
}
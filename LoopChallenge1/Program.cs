namespace LoopChallenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "0";
            int count = 0;
            int total = 0;
            int currentNumber = 0;
            scoreinput:
            try
            {
                while (currentNumber != -1)
                {
                    Console.WriteLine("Last number was {0}", currentNumber);
                    Console.WriteLine("Please enter the next score");
                    Console.WriteLine("Current amount of entries {0}", count);
                    Console.WriteLine("Please enter -1 once you are ready to calculate the average");

                    input = Console.ReadLine();
                    currentNumber = int.Parse(input);

                    if (currentNumber == -1)
                    {
                        Console.WriteLine("-------------------------------------------------------------------------------");
                        double average = (double)total / (double)count;
                        Console.WriteLine("Average score of students is {0}", average);
                    }
                    if (currentNumber > 0 && currentNumber < 21)
                    {
                        total += currentNumber;

                    }
                    else if(currentNumber != -1)
                    {
                        Console.WriteLine("Please enter a value between 1 and 20!");
                        continue;
                    }

                    count++;


                }
            }
            catch (IOException)
            {
                Console.WriteLine("something went wrong");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number given is too large for this type");
                goto scoreinput;
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong format used please try again");
                goto scoreinput;

            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException, the value was empty(null)");
                goto scoreinput;
            }

            Console.ReadLine();

        }
    }
}
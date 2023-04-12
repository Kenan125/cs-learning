namespace forloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double scoreOFStundents = 0;
            double numberOfStudents = 0;

        scoreinput:
               try
               {

                   do
                   {
                       Console.WriteLine("Please enter scores");
                       string scores = Console.ReadLine();
                       scoreOFStundents += double.Parse(scores);
                       numberOfStudents++;


                   } while (numberOfStudents < 10);
                   {
                       double averageScore = scoreOFStundents / numberOfStudents;
                       Console.WriteLine("average score of students are {0}", averageScore);

                   }
               } catch (IOException) 
               {
                   Console.WriteLine("something went wrong");
               }catch (OverflowException) {
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
               finally
               {
                   Console.WriteLine("I think code worked normal");
               }
            
        }
    }
}
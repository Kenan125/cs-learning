namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human kenan = new Human("Kenan", "Ismayilzade","brown",21);

            Human natalie = new Human("natalie","portman","blue");

            natalie.IntroduceMyself();
           
            kenan.IntroduceMyself();



        }
    }
}
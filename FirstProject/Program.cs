using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("------------------------------");
            DateTime date = Tools.ConvertStrToDate("", "");
            Console.WriteLine(date);
            DateTime date2 = Tools.ConvertStrToDate("10-10-1985");
            Console.WriteLine(date2);
         
            //----

            string name = "name";
            int age = 15;
            Console.WriteLine("Hello World!" + name + "-"  + age);
            Console.ReadLine();
            //data  types
            string aString = "string";
            char aChar = 'c';//'' instead of ""
            int aInt = 5;
            double aDouble = 20.5;
            bool aBoolean = false;
            //float, double, decimal(for money)


            Console.Write("Enter your name: ");
            string cName = Console.ReadLine();
            Console.Write("Enter your age: ");
            string cAge = Console.ReadLine();           

            Console.Write("Hello " + name);
            Console.ReadLine();

            int fromString = Convert.ToInt32(cAge);


            //-------------
            string color, pluralNoun, celebrity;
            Console.Write("Enter color: ");
            color = Console.ReadLine();
            Console.Write("Enter noun: ");
            pluralNoun = Console.ReadLine();
            Console.Write("Enter celebrity: ");
            celebrity = Console.ReadLine();

            Console.Write("-->" + color + pluralNoun + celebrity);

            Console.ReadLine();

            //-------------> ARRAYS
            int[] anArray = {4,8,5,6 };

            string[] friends = new string[5];//array of 5 empty elements
            friends[0] = "No";

            //---------> METHODS
            SayHi("TEST");

            int r = cube(3);
            Console.WriteLine(r);


            //-------->
            bool isMale = true;
            if (isMale)
            {
                Console.WriteLine("true");
            }
            else{
                Console.WriteLine("false");
            }
            int number = 0;

            switch (number)
            {
                case 0: break;
            }

            //2D arrays
            int[,] grid= {
                {1,2 },
                {3,4 }
            };

            Console.WriteLine(grid[0, 1]);


            //Execptions
            try
            {
                Console.WriteLine("Number with exception: ");
                string strNumber = Console.ReadLine();
                int n = Convert.ToInt32(strNumber);

                Console.WriteLine("Enter d another number with exception: ");
                int n2  = Convert.ToInt32(Console.ReadLine());               
                Console.WriteLine(n / n2);//fails
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Errror" + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Errror" + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Errror" + e.Message);
            }
            finally
            {
                //always executed
                Console.WriteLine("final block");
            }



            //Objects --> instance of a class
            /*Book book1 = new Book("book1");
            book1.title = "b1-title";
            book1.author = "b1-author";
            book1.pages = 1;

            Book book2 = new Book("book2");
            book2.title = "b2-title";
            book2.author = "b2-author";
            book2.pages = 2;*/

            Book book1 = new Book("book1", "author-1",1);
            //Console.WriteLine(book1.author + book2.author);

            book1.HasPages();
            book1.Pages = 5;//using g/setters


            //STATIC METHODS
            Song song1 = new Song("s1", "s1", 1);
            Song song2 = new Song("s2", "s2", 2);


            Console.WriteLine(song2.artist + song1.title);
            Console.WriteLine(Song.songCount);


            Tools.Printer(song1.artist);

            //Inheritance

            Chef chef = new Chef();
            chef.MakeChichen();
            chef.MakeSpecialDish();
            ItalianChef ItalianChef = new ItalianChef();
            ItalianChef.MakeChichen();
            ItalianChef.MakePasta();
            ItalianChef.MakeSpecialDish();

            
        }

        static void SayHi(string name)
        {
            Console.WriteLine("HELLO USER" + name);
        }

        static int cube(int n)
        {
            return n * n * n;
        }

       
    }
}

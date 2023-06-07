namespace switch_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter number of month");
            string month = Console.ReadLine();
            int monthNum = int.Parse(month);

            switch (monthNum)
            {
                case 1:
                    Console.WriteLine("JAN");
                    break;
                case 2:
                    Console.WriteLine("FAB");
                    break;
                case 3:
                    Console.WriteLine("MAR");
                    break;
                case 4:
                    Console.WriteLine("APRIL");
                    break;
                case 5:
                    Console.WriteLine("MAY");
                    break;
                case 6:

                    Console.WriteLine("JUN");
                    break;
                case 7:
                    Console.WriteLine("JUL");
                    break;
                case 8:
                    Console.WriteLine("AUG");
                    break;
                case 9:
                    Console.WriteLine("SEP");
                    break;
                case 10:
                    Console.WriteLine("OCT");
                    break;
                case 11:
                    Console.WriteLine("NOV");
                    break;
                case 12:
                    Console.WriteLine("DEC");
                    break;

                default:
                    Console.WriteLine("wrong number of month");
                    break;
            }





            Console.WriteLine("please enter one letter to check");
            string letterChar = Console.ReadLine();
            char letterChar1 = Convert.ToChar(letterChar);


            switch (letterChar1)
            {
                case 'a':
                    Console.WriteLine("this letter is vowel");
                    break;

                case 'e':
                    Console.WriteLine("this letter is vowel");
                    break;
                case 'u':
                    Console.WriteLine("this letter is vowel");
                    break;
                case 'i':
                    Console.WriteLine("this letter is vowel");
                    break;
                case 'o':
                    Console.WriteLine("this letter is vowel");
                    break;

                default:
                    Console.WriteLine("this letter is consonant");
                    break;
            }



            Console.WriteLine("please enter your grade");
            string grade = Console.ReadLine();
            char gradeChar1 = Convert.ToChar(grade);

            switch (gradeChar1)
            {
                case 'A':
                    Console.WriteLine("EXCELENT");
                    break;

                case 'B':
                    Console.WriteLine("VERY GOOD");
                    break;

                case 'C':
                    Console.WriteLine("GOOD");
                    break;

                case 'D':
                    Console.WriteLine("ACCEPTABLE");
                    break;

                default:
                    Console.WriteLine("you're failure");
                    break;
            }

        }

    }
}
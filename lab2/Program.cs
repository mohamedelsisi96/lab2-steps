namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {

         
            #region prob 1
            /*
            Console.WriteLine("Please Enter your Result");
            double grade=Convert.ToDouble(Console.ReadLine());
            if (grade > 0 && grade < 50)
            {
                Console.WriteLine("you failed");
            }
            else if (grade > 50 && grade < 65)
            {
                Console.WriteLine("your Grade is Pass");
            }
            else if (grade >= 65 && grade < 75)
            {
                Console.WriteLine("your Grade is Good");
            }
            else if (grade >= 75 && grade < 85)
            {
                Console.WriteLine("your Grade is Very Good");
            }
            else if (grade >= 85 && grade <= 100)
            {
                Console.WriteLine("your Grade is Excelent");
            }
            else
            {
                Console.WriteLine("please enter correct Result ");
            }*/
            #endregion

            #region prob 2
            bool flag=true;
            do
            {
                Console.WriteLine("Do You Want to Continue (y/n)");
                char cont=Convert.ToChar(Console.ReadLine());
              
                if(cont == 'y')
                {
                  flag = true;
                }else if (cont == 'n')
                {
                    flag=false;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
                    continue;
                }

                Console.WriteLine($"Please enter your choice " +
                    $"1) Good Morning" +
                    $" 2) Good Evening" +
                    $" 3) Good Afternoon" +
                    $" 4) Good Night");
                int num=int.Parse( Console.ReadLine() );
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Good Morning");
                        break;
                    case 2:
                        Console.WriteLine("Good Evening");
                        break;
                    case 3:
                        Console.WriteLine("Good Afternoon");
                        break;
                    case 4:
                        Console.WriteLine("Good Night");
                        break;
                    default:
                        Console.WriteLine("Please enter Correct Choice");
                        break;
                }


            } while (flag);

            #endregion
        }
    }
}

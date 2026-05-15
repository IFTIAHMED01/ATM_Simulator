namespace CreatingATM
{
   class ATM
   {
        static void Main(string[] args){

            Console.Write("Please put your 4 digit Pin: "); 
            int pin = Convert.ToInt32(Console.ReadLine());   
            int actualpin = 1990;
            int balance = 10000;

            string c;
            do{
            
                if (pin == actualpin)
                {
                 Console.WriteLine("1. Check Balance ");
                 Console.WriteLine("2. Deposit Money ");
                 Console.WriteLine("3. Withdraw Money ");

                 Console.Write("Please choose from on of the following options above: ");
                 string options = Console.ReadLine();

                    switch (options)
                    {
            
                    case "1":
                     Console.WriteLine("Your Balance is: $" + balance);
                     break;

                    case "2":
                     Console.Write("How much you want to deposit: ");
                     int NewBalnce = Convert.ToInt32(Console.ReadLine());
                     balance += NewBalnce;
                     Console.WriteLine("Your Current Balance is : $"+ balance);
                     break;

                    case "3":
                     Console.Write("How much you want to take out: $");
                     int newbalnce = Convert.ToInt32(Console.ReadLine());
                     balance -= newbalnce;
                     Console.WriteLine("Your Current Balance is : $"+ balance);
                     break;

                    default:
                     Console.WriteLine("Wrong input!");
                     break;  
                    }

                }

                else
                {
                 Console.WriteLine("Wrong Pin. Please try again.");
                 Console.Write("Please put your 4 digit Pin: "); 
                 pin = Convert.ToInt32(Console.ReadLine()); 
                }

                Console.WriteLine("Do you want to continue(y/n): ");
                c = Console.ReadLine(); 


            }
            while (c =="y"|| c =="Y");
        }
    }
}
        
    




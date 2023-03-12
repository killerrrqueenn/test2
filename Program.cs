class Program {
    static void Main(string[] args) {

        Console.WriteLine("Please input number 1 : ");
        int number1 = int.Parse (Console.ReadLine());
         Console.WriteLine("Please input number 2 : ");
        int number2 = int.Parse (Console.ReadLine());
         Console.WriteLine("Please input number 3 : ");
        int number3 = int.Parse (Console.ReadLine());
        int sum = number1 + number2 + number3;

        Console.WriteLine("sum {0} + {1} + {2} = {3}",number1,number2,number3,sum);
    }
}

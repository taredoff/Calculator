namespace program
{
    class Program
    {
        static void Action(double a, double b)
        {
            Console.WriteLine("Выберите действие");
            Console.WriteLine("1. Сложение\n2. Вычитание\n3. Умножение\n4. Деление\n");
            string action = Console.ReadLine();
            action = action.ToLower();
            switch (action)
            {
                case "1":
                    Methods.Add(a, b);
                    Console.WriteLine(Methods.answer);
                    break;
                case "сложение":
                    Methods.Add(a, b);
                    Console.WriteLine(Methods.answer);
                    break;
                case "2":
                    Methods.Sub(a, b);
                    Console.WriteLine(Methods.answer);
                    break;
                case "вычитание":
                    Methods.Sub(a, b);
                    Console.WriteLine(Methods.answer);
                    break;
                case "3":
                    Methods.Mult(a, b);
                    Console.WriteLine(Methods.answer);
                    break;
                case "умножение":
                    Methods.Mult(a, b);
                    Console.WriteLine(Methods.answer);
                    break;
                case "4":
                    Methods.Div(a, b);
                    Console.WriteLine(Methods.answer);
                    break;
                case "деление":
                    Methods.Div(a, b);
                    Console.WriteLine(Methods.answer);
                    break;
            }
            Console.WriteLine("Вы хотите продолжить работу программы?");
            string action2 =Console.ReadLine();
            action2 = action2.ToLower();
            switch (action2)
            {
                case "да":
                    Console.WriteLine("Вы хотите использовать вышедший результат?");
                    string action3 = Console.ReadLine();
                    action3 = action3.ToLower();
                    switch (action3)
                    {
                        case "да":
                            Console.WriteLine("Выберите новое второе слагаемое:");
                            double second = Convert.ToDouble(Console.ReadLine());
                            Action(Methods.answer, second);
                            break;
                        case "нет":
                            Start();
                            break;
                    }
                    break;
                case "нет":
                    break;
            }
        }
        static void Start()
        {
            Console.WriteLine("Введите первое слагаемое: ");
            double first = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе слагаемое: ");
            double second = Convert.ToDouble(Console.ReadLine());
            Action(first, second);
            
        }
        static void Main()
        {
            Start();
        }
    }
}
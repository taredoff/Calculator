namespace program
{
    class Methods
    { 
        public static double answer = 0;
        
        public static void Add(double a, double b)
        {
            answer =  a + b;
        }
        
        public static void Sub(double a, double b)
        {
            answer = a - b;
        }
       
        public static void Mult(double a, double b)
        {
            answer = a * b;
        }
        
        public static void Div(double a, double b)
        {
            answer = a / b;
        }
        
        public static void Calc(double a, double b)
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
            string action2 = Console.ReadLine();
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
                            Calc(Methods.answer, second);
                            break;
                        case "нет":
                            Program.Start();
                            break;
                    }
                    break;
                case "нет":
                    break;
            }
        }
        
        public static void Action_Choose()
        {
            Console.WriteLine("Выберите действие, которое хотите выполнить:\n\n1. Определение вида треугольника\n2. Вычисление");
            double first;
            double second;
            double third;
            string action = Console.ReadLine();
            switch (action)
            {
                case "1":
                    Console.WriteLine("Введите первую сторону: ");
                    first = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите вторую сторону: ");
                    second = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите третью сторону: ");
                    third = Convert.ToDouble(Console.ReadLine());
                    triangle(first, second, third);
                    break;
                case "2":
                    Console.WriteLine("Введите первое слагаемое: ");
                    first = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе слагаемое: ");
                    second = Convert.ToDouble(Console.ReadLine());
                    Calc(first, second);
                    break;
            }
        }

        public static void triangle(double first, double second, double third)
        {

            if (first == second && first == third)
            {
                Console.WriteLine("Ваш треугольник равносторонний\n");
                Action_Choose();
            }
            
            if (first == second || first == third || second == third)
            {
                Console.WriteLine("Ваш треугольник равнобедренный\n");
                Action_Choose();
            }
            first = Math.Pow(first, 2);
            second = Math.Pow(second, 2);
            third = Math.Pow(third, 2);
            if (first + second == third || first + third == second || second + third == first)
            {
                Console.WriteLine("Ваш треугольник прямоугольный\n");
                Action_Choose();
            }
        }
    }
}
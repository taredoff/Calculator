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
            Console.WriteLine("�������� ��������");
            Console.WriteLine("1. ��������\n2. ���������\n3. ���������\n4. �������\n");
            string action = Console.ReadLine();
            action = action.ToLower();
            switch (action)
            {
                case "1":
                    Methods.Add(a, b);
                    Console.WriteLine(Methods.answer);
                    break;
                case "��������":
                    Methods.Add(a, b);
                    Console.WriteLine(Methods.answer);
                    break;
                case "2":
                    Methods.Sub(a, b);
                    Console.WriteLine(Methods.answer);
                    break;
                case "���������":
                    Methods.Sub(a, b);
                    Console.WriteLine(Methods.answer);
                    break;
                case "3":
                    Methods.Mult(a, b);
                    Console.WriteLine(Methods.answer);
                    break;
                case "���������":
                    Methods.Mult(a, b);
                    Console.WriteLine(Methods.answer);
                    break;
                case "4":
                    Methods.Div(a, b);
                    Console.WriteLine(Methods.answer);
                    break;
                case "�������":
                    Methods.Div(a, b);
                    Console.WriteLine(Methods.answer);
                    break;
            }
            Console.WriteLine("�� ������ ���������� ������ ���������?");
            string action2 = Console.ReadLine();
            action2 = action2.ToLower();
            switch (action2)
            {
                case "��":
                    Console.WriteLine("�� ������ ������������ �������� ���������?");
                    string action3 = Console.ReadLine();
                    action3 = action3.ToLower();
                    switch (action3)
                    {
                        case "��":
                            Console.WriteLine("�������� ����� ������ ���������:");
                            double second = Convert.ToDouble(Console.ReadLine());
                            Calc(Methods.answer, second);
                            break;
                        case "���":
                            Program.Start();
                            break;
                    }
                    break;
                case "���":
                    break;
            }
        }
        
        public static void Action_Choose()
        {
            Console.WriteLine("�������� ��������, ������� ������ ���������:\n\n1. ����������� ���� ������������\n2. ����������");
            double first;
            double second;
            double third;
            string action = Console.ReadLine();
            switch (action)
            {
                case "1":
                    Console.WriteLine("������� ������ �������: ");
                    first = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("������� ������ �������: ");
                    second = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("������� ������ �������: ");
                    third = Convert.ToDouble(Console.ReadLine());
                    triangle(first, second, third);
                    break;
                case "2":
                    Console.WriteLine("������� ������ ���������: ");
                    first = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("������� ������ ���������: ");
                    second = Convert.ToDouble(Console.ReadLine());
                    Calc(first, second);
                    break;
            }
        }

        public static void triangle(double first, double second, double third)
        {

            if (first == second && first == third)
            {
                Console.WriteLine("��� ����������� ��������������\n");
                Action_Choose();
            }
            
            if (first == second || first == third || second == third)
            {
                Console.WriteLine("��� ����������� ��������������\n");
                Action_Choose();
            }
            first = Math.Pow(first, 2);
            second = Math.Pow(second, 2);
            third = Math.Pow(third, 2);
            if (first + second == third || first + third == second || second + third == first)
            {
                Console.WriteLine("��� ����������� �������������\n");
                Action_Choose();
            }
        }
    }
}
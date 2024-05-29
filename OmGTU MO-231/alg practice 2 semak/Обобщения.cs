class Menu<T>
{
    public T ChooseOperation()
    {
        T a = (T)(object)0;
        T b = (T)(object)0;

        if (typeof(T) == typeof(int))
        {
            Console.WriteLine("первое число: ");
            a = (T)Convert.ChangeType(Convert.ToDouble(Console.ReadLine()), typeof(T));
            Console.WriteLine("второе число: ");
            b = (T)Convert.ChangeType(Convert.ToDouble(Console.ReadLine()), typeof(T));
        }

        if (typeof(T) == typeof(double))
        {
            Console.WriteLine("первое число: ");
            a = (T)Convert.ChangeType(Convert.ToDouble(Console.ReadLine()), typeof(T));
            Console.WriteLine("второе число: ");
            b = (T)Convert.ChangeType(Convert.ToDouble(Console.ReadLine()), typeof(T));
        }

        Console.WriteLine("1. +");
        Console.WriteLine("2. -");
        Console.WriteLine("3. *");
        Console.WriteLine("4. /");
        string vibor2 = Console.ReadLine();
        switch (vibor2)
        {
            case "1":
                dynamic a_dyn_pl = a;
                dynamic b_dyn_pl = b;
                return a_dyn_pl + b_dyn_pl;
            case "2":
                dynamic a_dyn_mi = a;
                dynamic b_dyn_mi = b;
                return a_dyn_mi - b_dyn_mi;
            case "3":
                dynamic a_dyn_um = a;
                dynamic b_dyn_um = b;
                return a_dyn_um * b_dyn_um;
            case "4":
                object zero = 0;
                dynamic dynamic_a_del = a;
                dynamic dynamic_b_del = b;
                if ((object)b == zero)
                {
                    Console.WriteLine("деление на ноль");
                    return (T)zero;
                }
                else return dynamic_a_del / dynamic_b_del;
        }
        return (T)(object)0;
    }
}
class Program
{

    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. работа с целыми числами");
            Console.WriteLine("2. работа с вещественными числами");
            Console.WriteLine("3. выход");

            string vibor = Console.ReadLine();
            switch (vibor)
            {
                case "1":
                    Menu<int> menu_int = new Menu<int>();
                    Console.WriteLine(menu_int.ChooseOperation());
                    break;
                case "2":
                    Menu<double> menu_double = new Menu<double>();
                    Console.WriteLine(menu_double.ChooseOperation());
                    break;
                case "3":
                    return;
            }
        }
    }
}

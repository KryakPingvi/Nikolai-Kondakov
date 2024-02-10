using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication23
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Aud> list = new List<Aud>();
            bool ZZZZ = true;
            while (ZZZZ)
            {
                Menu menu = new Menu(); 
                menu.Menu_show();
                int a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Console.WriteLine("Номер аудитории:");
                        int a1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Номер этажа:");
                        int a2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Кол-во мест:");
                        int a3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Есть ли проектор?: (1 - есть, 0 - нет)");
                        bool a4 = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("Есть ли ПК?: (1 - есть, 0 - нет)");
                        bool a5 = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));
                        list.Add(new Aud(a1,a2,a3,a4,a5));
                        break;
                    case 2:
                        Console.WriteLine("Номер аудитории которую нужно изменить: ");
                        int num_auditory = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < list.Count(); i++)
                        {
                            if (list[i].num_aud == num_auditory)
                            {
                                Console.WriteLine("Номер этажа:");
                                list[i].num_floor = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Кол-во мест:");
                                list[i].num_mest = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Есть ли проектор?: (1 - есть, 0 - нет)");
                                list[i].pc = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));
                                Console.WriteLine("Есть ли ПК?: (1 - есть, 0 - нет)");
                                list[i].proektor = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));
                            }
                        }
                            break;
                    case 3:
                            Console.WriteLine("Аудитории с кол вом посадочных мест больше или равно:");
                            int b3 = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < list.Count(); i++ )
                            {
                                if (list[i].num_mest>=b3)
                                {
                                    list[i].Aud_get();
                                }
                            }
                            break;
                    case 4:
                            for (int i = 0; i < list.Count(); i++ )
                            {
                                if (list[i].proektor==true)
                                {
                                    list[i].Aud_get();
                                }
                            }
                            break;
                    case 5:
                            Console.WriteLine("Аудитории с ПК и кол вом посадочных мест:");
                            int b5 = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < list.Count(); i++ )
                            {
                                if (list[i].num_mest == b5 && list[i].pc)
                                {
                                    list[i].Aud_get();
                                }
                            }
                            break;
                    case 6:
                        Console.WriteLine("Аудитории на этаже:");
                            int b6 = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < list.Count(); i++ )
                            {
                                if (list[i].num_floor==b6)
                                {
                                    list[i].Aud_get();
                                }
                            }
                            break;
                    case 7:
                        Console.WriteLine("Все аудитории: ");
                            for (int i = 0; i < list.Count(); i++ )
                            {
                                    list[i].Aud_get();
                            }
                            break;
                    case 8:
                        ZZZZ = false;
                        break;
                }
            }
           

        }
    }
    class Menu
    {
        public void Menu_show()
        {
            Console.WriteLine("Выберите пункт меню:\n1.  Добавление в базу\n2.  Изменение данных аудитории по заданному номеру\n3.  Выборка аудиторий с кол-вом посадочных мест больше равным заданного \n4.  Выборка аудиторий с проектором \n5.  Выборка аудиторий с пк и заданным кол-вом посадочных мест\n6.  Выборка аудиторий по номеру этажа\n7.  Вывод всех данных по аудиториям\n8.  Выход");
        }
}
    class Aud
    {
        public int num_aud = 0;
        public int num_floor = 0;
        public int num_mest = 0;
        public bool proektor = false;
        public bool pc = false;
        public Aud(int a, int b, int c, bool d, bool f)
        {
            num_aud = a;
            num_floor = b;
            num_mest = c;
            proektor = d;
            pc = f;
        }
        public void Aud_get()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Номер аудитории: {0}",num_aud);

            Console.WriteLine("Номер этажа: {0}",num_floor );
            
            Console.WriteLine("Кол-во мест: {0}", num_mest);
            
            Console.WriteLine("Есть ли проектор?: {0}", proektor);
            
            Console.WriteLine("Есть ли ПК?: {0}", pc);
            Console.WriteLine("------------------------------------------");
        }
    }
}
using MyFitnessApp.BL.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFitnessApp.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует приложение MyFitnessApp");

            Console.WriteLine("Введите имя пользователя");
            var name = Console.ReadLine();

            //Console.WriteLine("Введите пол");
            //var gender = Console.ReadLine();

            //Console.WriteLine("Введите дату рождения");
            //var birthdate=DateTime.Parse(Console.ReadLine()); //TODO: переписать tryparse

            //Console.WriteLine("Введите вес");
            //var weight = Double.Parse(Console.ReadLine());

            //Console.WriteLine("Введите рост");
            //var height = Double.Parse(Console.ReadLine());

            var userController = new UserController(name);
            if(userController.IsNewUser)
            {
                Console.Write("Введите пол: ");
                var gender = Console.ReadLine();
                var birthDate = ParseDateTime();
                var weigth = ParseDouble("вес");
                var height = ParseDouble("рост");
                
                Console.WriteLine("Введите вес");

                userController.SetNewUserData(gender, birthDate, weigth, height);

            }

            Console.WriteLine(userController.CurrentUser);
            Console.ReadLine();


            
        }

        private static DateTime ParseDateTime()
        {
            DateTime birthDate;
            while (true)
            {
                Console.WriteLine("Введите дату рождения (dd.mm.yyyy): ");
                if (DateTime.TryParse(Console.ReadLine(), out birthDate))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный формат даты рождения.");
                }
            }

            return birthDate;
        }

        private static double ParseDouble(string name)
        {
            while (true)
            {
                Console.WriteLine($"Введите {name}: ");
                if (double.TryParse(Console.ReadLine(), out double value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine($"Неверный формат {name}.");
                }
            }
        }
    }
}

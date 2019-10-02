using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFitnessApp.BL.Model
{
    [Serializable]
    public class Food
    {        
        public string Name { get; }

        /// <summary>
        /// Белки
        /// </summary>
        public double Proteins { get; }

        /// <summary>
        /// Жиры
        /// </summary>
        public double Fats { get; }

        /// <summary>
        /// Углеводы
        /// </summary>
        public double Carbohydrates { get; }

        /// <summary>
        /// Калории за 100 грамм продукта
        /// </summary>
        public double Calories { get; }

        public Food(string name) : this(name, 0, 0, 0, 0) { }
            
        public Food(string name, double calories, double proteins, double fats, double carbohydrates)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Название еды не может быть пустым.", nameof(name));
            }

            if(calories<=0)
            {
                throw new ArgumentException("Калорийность не может быть меньше либо равной нулю.", nameof(calories));
            }

            if (proteins <= 0)
            {
                throw new ArgumentException("Содержание белков не может быть меньше либо равно нулю.", nameof(proteins));
            }

            if (fats <= 0)
            {
                throw new ArgumentException("Содержание жиров не может быть меньше либо равно нулю.", nameof(fats));
            }

            if (carbohydrates <= 0)
            {
                throw new ArgumentException("Содержание углеводов не может быть меньше либо равно нулю.", nameof(carbohydrates));
            }

            Name = name;
            Calories = calories / 100.0;
            Proteins = proteins / 100.0;
            Fats = fats / 100.0;
            Carbohydrates = carbohydrates / 100.0;
        }

        public override string ToString()
        {
            return Name;
        }

    }
}

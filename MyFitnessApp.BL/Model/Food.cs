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

        //private double CaloriesPerGramm { get { return Calories / 100.0; } }
        //private double ProteinsPerGramm { get { return Proteins / 100.0; } }
        //private double FatsPerGramm { get { return Fats / 100.0; } }
        //private double CarbohydratesPerGramm { get { return Carbohydrates / 100.0; } }

        public Food(string name) : this(name, 0, 0, 0, 0) { }
            
        public Food(string name, double calories, double proteins, double fats, double carbohydrates)
        {
            /// TODO: проверка
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

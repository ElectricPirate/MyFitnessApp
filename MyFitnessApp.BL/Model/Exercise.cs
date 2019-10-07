using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFitnessApp.BL.Model
{
    [Serializable]
    public class Exercise
    {
        public int Id { get; set; }
        public DateTime Start{ get; set; }
        public DateTime Finish{ get; set; }
        public int ActivityId { get; set; }
        public virtual Activity Activity { get; set; }
        public int UserId { get; set; }        
        public virtual User User { get; set; }
        public Exercise() { }


        public Exercise(DateTime start, DateTime finish, Activity activity, User user)
        {
            if(start ==null) 
            {
                throw new ArgumentNullException("Время не может быть пустым", nameof(start));
            }

            if (finish == null)
            {
                throw new ArgumentNullException("Время не может быть пустым", nameof(finish));
            }

            if (activity == null)
            {
                throw new ArgumentNullException("Упражнение не может быть пустым", nameof(activity));
            }

            if (user == null)
            {
                throw new ArgumentNullException("Время не может быть пустым", nameof(user));
            }

            Start = start;
            Finish = finish;
            Activity = activity;
            User = user;
        }
    }
}

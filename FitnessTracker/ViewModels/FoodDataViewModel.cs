using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessTracker.Models;

namespace FitnessTracker.ViewModels
{
    public class FoodDataViewModel : Food
    {
        public bool isFromToday
        {
            get
            {
                var nowDate = DateTime.Now;
                if (this.DateAdded > nowDate.AddHours(-24) && this.DateAdded <= nowDate)
                {
                    return true;
                }

                return false;
            }
        }
    }
}

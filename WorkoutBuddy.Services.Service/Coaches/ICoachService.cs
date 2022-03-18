using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutBuddy.Services.Service.Coaches
{
    interface ICoachService
    {
        public void GET();
        public void POST();
        public void DELETE();
        public void PUT();
    }
}

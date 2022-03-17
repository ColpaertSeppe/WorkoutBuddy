using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutBuddy.Services.Service.Athletes
{
    public interface IAthleteService
    {
        public void GET();
        public void POST();
        public void DELETE();
        public void PUT();
    }
}

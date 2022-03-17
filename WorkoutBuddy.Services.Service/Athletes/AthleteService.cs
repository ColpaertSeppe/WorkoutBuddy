using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutBuddy.Services.Service.Athletes.DeleteAthletes;
using WorkoutBuddy.Services.Service.Athletes.GetAthletes;
using WorkoutBuddy.Services.Service.Athletes.PostAthletes;
using WorkoutBuddy.Services.Service.Athletes.PutAthletes;

namespace WorkoutBuddy.Services.Service.Athletes
{
    public class AthleteService : IAthleteService
    {
        private IGetAthletesService _getService;
        private IDeleteAthletesService _deleteService;
        private IPostAtheltesService _postService;
        private IPutAthletesService _putService;

        public AthleteService(IGetAthletesService getAthletesService, IDeleteAthletesService deleteAthletesService, IPostAtheltesService postAtheltesService, IPutAthletesService putAthletesService)
        {
            _getService = getAthletesService;
            _deleteService = deleteAthletesService;
            _postService = postAtheltesService;
            _putService = putAthletesService;
        }

        public void DELETE()
        {
            _deleteService.DELETE();
        }

        public void GET()
        {
            _getService.GET();
        }

        public void POST()
        {
            _postService.POST();
        }

        public void PUT()
        {
            _putService.PUT();
        }

    }
}

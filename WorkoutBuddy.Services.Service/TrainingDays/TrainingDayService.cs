using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutBuddy.Services.Service.Athletes.PostAthletes;
using WorkoutBuddy.Services.Service.TrainingDays.DeleteTrainingDays;
using WorkoutBuddy.Services.Service.TrainingDays.GetTrainingDays;
using WorkoutBuddy.Services.Service.TrainingDays.PutTrainingDays;

namespace WorkoutBuddy.Services.Service.TrainingDays
{
    public class TrainingDayService : ITrainingDayService
    {
        private IGetTrainingDaysService _getService;
        private IDeleteTrainingDaysService _deleteService;
        private IPostAtheltesService _postService;
        private IPutTrainingDaysService _putService;

        public TrainingDayService(IGetTrainingDaysService getTrainingDaysService, IDeleteTrainingDaysService deleteTrainingDaysService, IPostAtheltesService postAtheltesService, IPutTrainingDaysService putTrainingDaysService)
        {
            _getService = getTrainingDaysService;
            _deleteService = deleteTrainingDaysService;
            _postService = postAtheltesService;
            _putService = putTrainingDaysService;
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

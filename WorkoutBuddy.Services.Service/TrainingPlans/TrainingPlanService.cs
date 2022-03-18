using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutBuddy.Services.Service.TrainingPlans.DeleteTrainingPlans;
using WorkoutBuddy.Services.Service.TrainingPlans.GetTrainingPlans;
using WorkoutBuddy.Services.Service.TrainingPlans.PostTrainingPlans;
using WorkoutBuddy.Services.Service.TrainingPlans.PutTrainingPlans;

namespace WorkoutBuddy.Services.Service.TrainingPlans
{
    internal class TrainingPlanService : ITrainingPlanService
    {
        private readonly IGetTrainingPlansService _getService;
        private readonly IPutTrainingPlansService _putService;
        private readonly IPostTrainingPlansService _postService;
        private readonly IDeleteTrainingPlansService _deleteService;

        public TrainingPlanService(IGetTrainingPlansService getService, IPutTrainingPlansService putService, IPostTrainingPlansService postService, IDeleteTrainingPlansService deleteService)
        {
            _getService = getService;
            _putService = putService;
            _postService = postService;
            _deleteService = deleteService;
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

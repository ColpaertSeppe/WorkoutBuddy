using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutBuddy.Services.Service.Coaches.DeleteCoaches;
using WorkoutBuddy.Services.Service.Coaches.GetCoaches;
using WorkoutBuddy.Services.Service.Coaches.PostCoaches;
using WorkoutBuddy.Services.Service.Coaches.PutCoaches;

namespace WorkoutBuddy.Services.Service.Coaches
{
    class CoachService : ICoachService
    {
        private readonly IPostCoachesService _postService;
        private readonly IDeleteCoachesService _deleteService;
        private readonly IPutCoachesService _putService;
        private readonly IGetCoachesService _getService;
        public CoachService(IPutCoachesService putService, IPostCoachesService postService, IDeleteCoachesService deleteService, IGetCoachesService getService )
        {
            _putService = putService;
            _postService = postService;
            _deleteService = deleteService;
            _getService = getService;
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

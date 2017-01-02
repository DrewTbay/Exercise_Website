using Exercise_Website.Models;
using Exercise_Website.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Exercise_Website.Controllers
{
    public class WorkoutController : ApiController
    {
		private WorkoutRespository workoutRespository;

		public WorkoutController()
		{
			this.workoutRespository = new WorkoutRespository();
		}

		public Workout[] Get()
		{
			return this.workoutRespository.GetAllContacts();
		}
	}
}

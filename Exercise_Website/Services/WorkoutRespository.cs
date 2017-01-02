using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Exercise_Website.Models;

namespace Exercise_Website.Services
{
	public class WorkoutRespository
	{

		private const string CacheKey = "ContactStore";

		public WorkoutRespository()
		{
			var ctx = HttpContext.Current;

			if (ctx != null)
			{
				if (ctx.Cache[CacheKey] == null)
				{
					var contacts = new Workout[]
					{
						new Workout
						{
							Id = 1, Name = "Total Synergistics"
						},
						new Workout
						{
							Id = 2, Name = "Agility X"
						},
						new Workout
						{
							Id = 3, Name = "The Challenge"
						},
						new Workout
						{
							Id = 4, Name = "X3 Yoga"
						},
						new Workout
						{
							Id = 5, Name = "CVX"
						},
						new Workout
						{
							Id = 6, Name = "The Warrior"
						},
						new Workout
						{
							Id = 7, Name = "Isometrix"
						},
						new Workout
						{
							Id = 8, Name = "Dynamix"
						},
						new Workout
						{
							Id = 9, Name = "Accelerator"
						},
						new Workout
						{
							Id = 10, Name = "Pilates X"
						},
						new Workout
						{
							Id = 11, Name = "Incenerator"
						},
						new Workout
						{
							Id = 12, Name = "Triometrics"
						},
						new Workout
						{
							Id = 13, Name = "MMX"
						},
						new Workout
						{
							Id = 14, Name = "Eccentric Upper"
						},
						new Workout
						{
							Id = 15, Name = "Eccentric Lower"
						},
						new Workout
						{
							Id = 16, Name = "Decelerator"
						},
						new Workout
						{
							Id = 17, Name = "Cold Start"
						},
						new Workout
						{
							Id = 18, Name = "Complex Upper"
						},
						new Workout
						{
							Id = 19, Name = "Complex Lower"
						},
						new Workout
						{
							Id = 20, Name = "X3 Ab Ripper"
						}
					};

					ctx.Cache[CacheKey] = contacts;
				}
			}
		}

		public Workout[] GetAllContacts()
		{
			var ctx = HttpContext.Current;

			if (ctx != null)
			{
				return (Workout[])ctx.Cache[CacheKey];
			}

			return new Workout[]
				{
					new Workout
					{
						Id = 0,
						Name = "Placeholder"
					}
				};
		}

		public bool SaveContact(Workout contact)
		{
			var ctx = HttpContext.Current;

			if (ctx != null)
			{
				try
				{
					var currentData = ((Workout[])ctx.Cache[CacheKey]).ToList();
					currentData.Add(contact);
					ctx.Cache[CacheKey] = currentData.ToArray();

					return true;
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.ToString());
					return false;
				}
			}

			return false;
		}
	}
}
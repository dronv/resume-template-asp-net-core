// Projects.cshtml.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Resume_Templater.Models;

namespace Resume_Templater.Pages
{
	public class ProjectsModel : PageModel
	{
		public string GithubUsername { get; set; }
		public List<Project> Projects { get; set; }


		public void OnGet()
		{
			GithubUsername = "dronv";
			Projects = new List<Project> {
				new Project()
				{
					Title = "Covid-19 Severity Predictor",
					Description = "Built a web application using the Flask framework for predicting the risk severity of the patient according to the symptoms and \r\npatient’s medical history. Used tools like Juptyer notebook to write the code in Python and random forest classifier method to train \r\nthe ML model",
					Year = 2023,
					Technologies = new List<string>
					{
						new string("Machine Learning"),
						new string("Python"),
						new string("Flask")
					}
					
				},
				new Project()
				{
					Title = "Employee Directory Web App",
					Description = "Developed a full stack web application using ReactJS as frontend and AWS as backend. Implemented CRUD functionality in the \r\napplication allowing users to create data for their employees",
					Year = 2022,
					Technologies = new List<string>
					{
						new string("ReactJs"),
						new string("Amazon Web Services(AWS)")
						
					}
				},
				new Project()
				{
					Title = "Image Stitching",
					Description = "Built an Image stitching web application, allowing users to upload 3 images from the web app and creating a panorama image. The \r\nfrontend was built using the ReactJS and backend using Amazon Web Services. AWS services like EC2 Instance, S3 bucket, Lambda\r\nFunction and Trigger functions were used in this project",
					Year = 2021,
					Technologies = new List<string>
					{
						new string("ReactJs"),
						new string("Python"),
						new string("Amazon Web Services")
					}
				}
			};
		}
	}
}

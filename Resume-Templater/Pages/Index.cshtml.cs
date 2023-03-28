// Index.cshtml.cs
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Resume_Templater.Pages
{
	public class IndexModel : PageModel
	{
		public string FullName { get; set; }
		public string LinkedInUsername { get; set; }
		public int YearsOfExperience { get; set; }
		public List<string> Languages { get; set; }
		public void OnGet()
		{
			FullName = "Dron Vyas";
			LinkedInUsername = "dronvyas";
			YearsOfExperience = 3;
			Languages = new List<string>
			{
				new string("C/C++"),
				new string("Python"),
				new string("Javascript"),
				new string("ReactJs"),
				new string("GIT/GitHub"),
				new string("C#"),
				new string("ASP.NET"),
				new string("HTML"),
				new string("CSS"),
				new string("Bootstrap")
			};
		}
	}
}

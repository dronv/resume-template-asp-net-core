using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Resume_Templater.Pages
{
	public class AboutMeModel : PageModel
	{
		public string Email { get; set; }
		public string Description { get; set; }
		public void OnGet()
		{
			Description = "Hello! I'm Dron, a Software Engineer based in Canada, who enjoys building things that live on the internet. I focus on developing web apps that provide intuitive, user interfaces with efficient and modern backends.";
			Email = "dronvyas4454@gmail.com";
		}
	}
}


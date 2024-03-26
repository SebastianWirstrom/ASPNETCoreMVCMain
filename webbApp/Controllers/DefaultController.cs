using Microsoft.AspNetCore.Mvc;
using webbapp.ViewModels.Sections;
using webbApp.ViewModels.Sections;
using webbApp.ViewModels.Views;

namespace webbApp.Controllers;

public class DefaultController : Controller
{
    [Route("/")]
    public IActionResult Home() 
    {
        var viewModel = new DefaultIndexViewModel
        {
            Title = "Ultimate Task Manager Assistant",
            Showcase = new ShowcaseViewModel
            {
                ShowcaseImage = new() { ImageUrl = "images/showcase/showcase-image.svg", AltText = "Showcase Task Manager" },
                Title = "Task Management Assistant You Gonna Love",
                Text = "We offer you a new generation of task management system. Plan, manage & track all your tasks in one flexible tool.",
                Link = new() { ControllerName = "Downloads", ActionName = "Index", Text = "Get started for free" },
                BrandsText = "Largest companies use our tool to work efficiently",
                Brands =
                [
                    new() { ImageUrl = "images/showcase/sc-logo1.svg", AltText = "Brand Name 1" },
                    new() { ImageUrl = "images/showcase/sc-logo2.svg", AltText = "Brand Name 2" },
                    new() { ImageUrl = "images/showcase/sc-logo3.svg", AltText = "Brand Name 3" },
                    new() { ImageUrl = "images/showcase/sc-logo4.svg", AltText = "Brand Name 4" }
                ]
            },

            Features = new FeaturesViewModel
            {
                Title = "What Do You Get With Our Tool?",
                Text = "Make sure all your tasks are organized so you can set the priorities and focus on important."
            },

            SwitchBetween = new SwitchBetweenViewModel
            {
                Title1 = "Switch Between",
                Title2 = "Light & Dark Mode",
                ImageUrl = new() { ImageUrl = "/images/switch-between/mockup.svg", AltText = "Image of light and dark mode on laptop, side by side" },
            },

            ManageYourWork = new ManageYourWorkViewModel
            {
                Title = "Manage Your Work",
                Text1 = "Powerful project management",
                Text2 = "Transparent work management",
                Text3 = "Manage work & focus on the most important tasks",
                Text4 = "Track your progress with interactive charts",
                Text5 = "Easiest way to track time spent on tasks",
                Image = new() { ImageUrl = "/images/manage-your-work/manage-your-work.svg", AltText = "Taskmanager with dashboard" },
                Link = new() { ControllerName = "Downloads", ActionName = "Index", Text = "Learn More" }
            },

            DownloadOurApp = new DownloadOurAppViewModel
            {
                Title = "Download Our App For Any Device",
                MainImageBottom = new() { ImageUrl = "/images/download-our-app/phone-bottom.svg", AltText = "Example of taskmanager app on phone" },
                MainImageTop = new() { ImageUrl = "/images/download-our-app/phone-top.svg", AltText = "Example of taskmanager app on phone" }
            },

            TopWorkTools = new TopWorkToolsViewModel
            {
                Title = "Integrate Top Work Tools",
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin volutpat mollis egestas. Nam luctus facilisis ultrices. Pellentesque volutpat ligula est. Mattis fermentum, at nec lacus.",
                Tools = [
                    new() { ImageUrl = "/images/top-work-tools/tools-icon-google.svg", AltText = "", BoxText = "Lorem magnis pretium sed curabitur nunc facilisi nunc cursus sagittis." },
                    new() { ImageUrl = "/images/top-work-tools/tools-icon-zoom.svg", AltText = "", BoxText = "In eget a mauris quis. Tortor dui tempus quis integer est sit natoque placerat dolor." },
                    new() { ImageUrl = "/images/top-work-tools/tools-icon-slack.svg", AltText = "", BoxText = "Id mollis consectetur congue egestas egestas suspendisse blandit justo." },
                    new() { ImageUrl = "/images/top-work-tools/tools-icon-mail.svg", AltText = "", BoxText = "Rutrum interdum tortor, sed at nulla. A cursus bibendum elit purus cras praesent." },
                    new() { ImageUrl = "/images/top-work-tools/tools-icon-trello.svg", AltText = "", BoxText = "Congue pellentesque amet, viverra curabitur quam diam scelerisque fermentum urna." },
                    new() { ImageUrl = "/images/top-work-tools/tools-icon-MailChimp.svg", AltText = "", BoxText = "A elementum, imperdiet enim, pretium etiam facilisi in aenean quam mauris." },
                    new() { ImageUrl = "/images/top-work-tools/tools-icon-dropbox.svg", AltText = "", BoxText = "Ut in turpis consequat odio diam lectus elementum. Est faucibus blandit platea." },
                    new() { ImageUrl = "/images/top-work-tools/tools-icon-evernote.svg", AltText = "", BoxText = "Faucibus cursus maecenas lorem cursus nibh. Sociis sit risus id. Sit facilisis dolor arcu." }
                ]
            },

            Newsletter = new NewsletterViewModel
            {
                Title = "Don't Want to Miss Anything?",
                Image = new() { ImageUrl = "/images/newsletter/newsletter-arrow.svg" },
                LinkTerms = new() { ControllerName = "Downloads", ActionName = "Index", Text = "terms" },
                LinkPrivacy = new() { ControllerName = "Downloads", ActionName = "Index", Text = "privacy policy." },
                Link = new() { ControllerName = "Downloads", ActionName = "Index", Text = "Subscribe*" }
            }
        };
        
        return View(viewModel);
    } 
    
    [Route("/error")]
    public IActionResult Error404(int statusCode) => View();
}

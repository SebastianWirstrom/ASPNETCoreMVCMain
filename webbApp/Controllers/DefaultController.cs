using Infrastructure.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using webbApp.ViewModels.Subscribers;
using webbApp.ViewModels.Views;

namespace webbApp.Controllers;

public class DefaultController(HttpClient httpClient) : Controller
{
    private readonly HttpClient _httpClient = httpClient;

    [Route("/")]
    public IActionResult Home() 
    {
        var viewModel = new DefaultIndexViewModel(); 
        return View(viewModel);
    }


    //ska vara kvar? kolla igen
    [Route("/details")]
    public async Task<IActionResult> Details()
    {
        using var http = new HttpClient();
        var response = await http.GetAsync("https://localhost:7267/api/courses/1");
        var json = await response.Content.ReadAsStringAsync();
        var data = JsonConvert.DeserializeObject<CourseEntity>(json);

        return View(data);
    }

    [Route("/error")]
    public IActionResult Error404(int statusCode) => View();

    [HttpPost]
    public async Task<IActionResult> Subscribe(SubscribeViewModel model)
    {
        if (ModelState.IsValid)
        {
            var content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("https://localhost:7238/api/subscribers", content);
            if (response.IsSuccessStatusCode)
            {
                TempData["StatusMessage"] = "You are now subscribed to the newsletter!";
            }

            else if (response.StatusCode == System.Net.HttpStatusCode.Conflict)
            {
                TempData["StatusMessage"] = "You are already subscribed with this E-mail";
            }
        }
        else
        {
            TempData["StatusMessage"] = "Invalid E-mail address";
        }
        return RedirectToAction("Home", "Default", "subscribe");
    }

}

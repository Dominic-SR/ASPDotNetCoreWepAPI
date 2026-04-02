namespace ASPDotNetCoreWepAPI.Controllers;

using Microsoft.AspNetCore.Mvc;
using ASPDotNetCoreWepAPI.Models;

[ApiController]
[Route("api/[controller]")]
public class JobsController:ControllerBase
{
    [HttpGet]
    public IActionResult GetJobs()
    {
        var jobs = new List<Job>
        {
            new Job { Id = 1, Title = "Software Engineer", Description = "Develop and maintain software applications.", Salary = 80000 },
            new Job { Id = 2, Title = "Data Scientist", Description = "Analyze and interpret complex data to help make informed decisions.", Salary = 90000 },
            new Job { Id = 3, Title = "Product Manager", Description = "Oversee the development and delivery of products.", Salary = 85000 }
        };
        return Ok(jobs);

    }
}
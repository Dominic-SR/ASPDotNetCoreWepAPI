namespace ASPDotNetCoreWepAPI.Controllers;
using Microsoft.AspNetCore.Mvc;
using ASPDotNetCoreWepAPI.Models;
using ASPDotNetCoreWepAPI.Data;

[ApiController]
[Route("api/[controller]")]
public class JobsController:ControllerBase
{
    private readonly AppDbContext _context;
    
    public JobsController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetJobs()
    {
        var jobs = _context.Jobs.ToList();
        return Ok(jobs);

    }
}
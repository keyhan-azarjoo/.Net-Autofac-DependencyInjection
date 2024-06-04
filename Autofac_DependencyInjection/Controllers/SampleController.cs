using Autofac_DependencyInjection.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Autofac_DependencyInjection.Controllers;

[ApiController]
[Route("[controller]")]
public class SampleController : ControllerBase
{
    private readonly ISampleService _sampleService;
    // You can use your dependencies anyware you like. juat like MyLoggingFilter or the Controller
    public SampleController(ISampleService sampleService)
    {
        _sampleService = sampleService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var message = _sampleService.GetMessage();
        return Ok(message);
    }



    [HttpPut]
    public IActionResult Put()
    {
        var message = _sampleService.GetMessage();
        return Ok(message);
    }


}

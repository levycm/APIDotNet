using APIDotNet.Services.Task;
using APIDotNet.ViewModel.Request;
using APIDotNet.ViewModel.Response;
using Microsoft.AspNetCore.Mvc;

namespace APIDotNet.Controllers;

[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
public class TaskController : ControllerBase
{
    //standard .net log. displays in container console
    private readonly ILogger<TaskController> _logger;
    private readonly TaskSearchService _taskSearchService;
    private readonly TaskSaveService _taskSaveService;
    private readonly TaskDeleteService _taskDeleteService;
    private readonly TaskUpdateService _taskUpdateService;

    //for dependency injection
    public TaskController(ILogger<TaskController> logger, TaskSearchService taskSearchService, TaskSaveService taskSaveService, TaskDeleteService taskDeleteService, TaskUpdateService taskUpdateService)
    {
        _logger = logger;
        _taskSearchService = taskSearchService;
        _taskSaveService = taskSaveService;
        _taskDeleteService = taskDeleteService;
        _taskUpdateService = taskUpdateService;
    }

    [HttpGet("{id}")]
    public async Task<TaskResponse> FindTaskById(int id)
    {
        return await _taskSearchService.FindById(id);
    }

    [HttpPost]
    public async Task<TaskResponse> Save(TaskRequest request)
    {
        return await _taskSaveService.Save(request);
    }

    [HttpDelete("{id}")]
    public async Task<TaskResponse> Delete(int id)
    {
        return await _taskDeleteService.Delete(id);
    }

    [HttpPut("{id}")]
    public async Task<TaskResponse> Update(int id, TaskRequest request)
    {
        return await _taskUpdateService.Update(id, request);
    }
}

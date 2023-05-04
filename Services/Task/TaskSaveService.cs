using APIDotNet.ViewModel.Request;
using APIDotNet.ViewModel.Response;

namespace APIDotNet.Services.Task
{
    public class TaskSaveService
    {
        public async Task<TaskResponse> Save(TaskRequest taskRequest)
        {
            return new TaskResponse { Id = taskRequest.Id, Title = taskRequest.Title, Description = taskRequest.Description, Date = taskRequest.Date, Active = taskRequest.Active };
        }
    }
}

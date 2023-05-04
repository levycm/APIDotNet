using APIDotNet.ViewModel.Request;
using APIDotNet.ViewModel.Response;

namespace APIDotNet.Services.Task
{
    public class TaskUpdateService
    {
        public async Task<TaskResponse> Update(int id, TaskRequest taskRequest)
        {
            return new TaskResponse { Id = id, Title = taskRequest.Title, Description = taskRequest.Description, Date = taskRequest.Date, Active = taskRequest.Active };
        }
    }
}

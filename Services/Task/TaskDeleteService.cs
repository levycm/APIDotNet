using APIDotNet.ViewModel.Response;

namespace APIDotNet.Services.Task
{
    public class TaskDeleteService
    {

        public async Task<TaskResponse> Delete(int id)
        {
            return new TaskResponse { Id = id, Title = "Task Deleted", Description = "Description from Task Deleted", Date = DateTime.Now, Active = true };
        }

    }
}

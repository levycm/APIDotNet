using APIDotNet.ViewModel.Response;

namespace APIDotNet.Services.Task
{
    public class TaskSearchService
    {

        public async Task<TaskResponse> FindById(int id)
        {
            return new TaskResponse { Id = id, Title = "Test FindById Task", Description = "Description from Test FindById Task", Date = DateTime.Now, Active = true }; ;
        }

    }
}

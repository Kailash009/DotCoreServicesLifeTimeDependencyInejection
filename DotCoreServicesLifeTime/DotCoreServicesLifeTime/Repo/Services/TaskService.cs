using DotCoreServicesLifeTime.Repo.Contract;

namespace DotCoreServicesLifeTime.Repo.Services
{
    public class TaskService : ISingletonService, IScopedService, ITransientService
    {
        private readonly string _guid;
        public TaskService()
        {
            _guid = Guid.NewGuid().ToString();
        }
        public string GetGuid()
        {
            return _guid;
        }
    }
}

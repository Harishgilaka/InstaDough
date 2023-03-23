using InstaDough.Core.Repository;

namespace InstaDough.Repository
{
    public static class RepositoryFactory
    {
        private static Dictionary<object, object> _repository = new Dictionary<object, object>();
        public static IRepository<T> GetInstance<T>()
        {
            IRepository<T> repo = (IRepository<T>)_repository[typeof(T)];
            ((IDBContext)repo).LoadGlobalConnection();
            return repo;
        }

        public static void Register<T>(IRepository<T> repo)
        {
            _repository.Add(typeof(T), repo);
        }
    }
}

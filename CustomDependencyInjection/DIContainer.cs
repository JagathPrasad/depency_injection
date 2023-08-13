namespace Dependency_Injection.CustomDependencyInjection
{
    public class DIContainer
    {
        List<ServiceInstanceCreator> creators;
        public DIContainer(List<ServiceInstanceCreator> _creators)
        {
            creators = _creators;
        }
        public T GetService<T>()
        {
            var service = creators.SingleOrDefault(x => x.Type == (typeof(T)));
            if (service == null)
            {
                throw new Exception("No instance");
            }
            if (service.Implementation != null && service.serviceType == ServiceTypes.Singleton)
            {
                return (T)service.Implementation;
            }
            var actualType = service.ImplementationType ?? service.Type;
            if (actualType.IsAbstract || actualType.IsInterface)
            {
                throw new Exception("No instance");
            }
            var instance = (T)Activator.CreateInstance(actualType);
            service.Implementation = instance;
            return instance;
        }


    }
}

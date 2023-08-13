using Microsoft.AspNetCore.Identity;

namespace Dependency_Injection.CustomDependencyInjection
{
    public class ServiceInstanceCreator
    {

        public Type Type { get; set; }
        public Type ImplementationType { get; set; }
        public object Implementation { get; set; }

        public ServiceTypes serviceType { get; internal set; }
        public record Ctor(Type Type, object Implementation);

        public ServiceInstanceCreator(object _Implementation, ServiceTypes _serviceType)
        {
            Type = _Implementation.GetType();
            Implementation = _Implementation;
            serviceType = _serviceType;
        }

        public ServiceInstanceCreator(Type type, ServiceTypes _serviceType)
        {
            Type = type;
            serviceType = _serviceType;
        }


        public ServiceInstanceCreator(Type type, Type implementationType, ServiceTypes _serviceType)
        {
            Type = type;
            ImplementationType = implementationType;
            serviceType = _serviceType;
        }
    }
}

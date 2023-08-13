namespace Dependency_Injection.CustomDependencyInjection
{
    public class DIServiceCollection
    {

        private List<ServiceInstanceCreator> creators = new List<ServiceInstanceCreator>();
        public DIServiceCollection()
        {

        }


        public DIContainer GenerateContainer()
        {
            return new DIContainer(creators);
        }





        public void AddSingleton()
        {

        }

        public void AddScoped()
        {

        }


        public void AddTransient()
        {

        }



        public void AddSingleton<T>(T t)
        {
            //if (!creators.Contains(t.GetType()))
            {
                creators.Add(new ServiceInstanceCreator(t, ServiceTypes.Singleton));
            }

        }

        public void AddSingleton<T>()
        {
            // if (!creators.Contains(typeof(T)))
            {
                creators.Add(new ServiceInstanceCreator(typeof(T), ServiceTypes.Singleton));
            }
        }
        public void AddSingleton<TInterface, TImplementation>()
        {
            {
                creators.Add(new ServiceInstanceCreator(typeof(TInterface), typeof(TImplementation), ServiceTypes.Singleton));
            }

        }
        public void AddScoped<T>(T t)
        {

        }

        public void AddTransient<T>(T t)
        {
            {
                creators.Add(new ServiceInstanceCreator(typeof(T), ServiceTypes.Transient));
            }

        }
        public void AddTransient<T>()
        {
            {
                creators.Add(new ServiceInstanceCreator(typeof(T), ServiceTypes.Transient));
            }

        }

        public void AddTransient<TInterface, TImplementation>()
        {
            {
                creators.Add(new ServiceInstanceCreator(typeof(TInterface), typeof(TImplementation), ServiceTypes.Transient));
            }

        }
    }
}

namespace DI.Console
{
    public class Container
    {
        // IOC контейнер
        private static readonly Dictionary<Type, Type> _container = new Dictionary<Type, Type>();
        // Регистрация типов
        public static void Register<TFrom, TTo>()
        {
            _container.Add(typeof(TFrom), typeof(TTo));
        }
        // Резолвинг типов
        public static TFrom Resolve<TFrom>()
        {
            return (TFrom)Resolve(typeof(TFrom));
        }
        // Резолвинг типов
        private static object Resolve(Type type)
        {
            Type resolvedType;
            if (_container.TryGetValue(type, out resolvedType))
            {
                var constructor = resolvedType.GetConstructors().First();
                var parameters = constructor.GetParameters();
                if (parameters.Any())
                {
                    var parametersInstances = parameters.Select(parameter => Resolve(parameter.ParameterType)).ToArray();
                    return constructor.Invoke(parametersInstances);
                }
                else
                {
                    return Activator.CreateInstance(resolvedType);
                }
            }
            else
            {
                throw new Exception("Type not registered");
            }
        }
    }
}

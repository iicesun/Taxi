using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Taxi.Service;

namespace Taxi.Helpers
{
    public class ServiceLocator
    {
        private IDictionary<object, object> _services;
        private static ServiceLocator _serviceLocatorPropertes;

        public static ServiceLocator ServiceLocatorPropertes
        {
            get
            {
                return _serviceLocatorPropertes =_serviceLocatorPropertes ??  new ServiceLocator();
            }
        }

        internal ServiceLocator()
        {
            _services = new Dictionary<object, object>();

            _services.Add(typeof(ITaxiService),new TaxiService());
        }

        public T GetService<T>()
        {
            if (!_services.ContainsKey(typeof (T)))
            {
              throw new Exception("Не удалось найти тип " + typeof(T));
            }
            else  return (T) _services[typeof (T)];
        }

    }
}
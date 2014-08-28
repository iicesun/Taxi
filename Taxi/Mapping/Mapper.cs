using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace Taxi.Mapping
{
    public static class Mapper 
    {
        private static IDictionary<object, object> _mapper; 
        static Mapper()
        {
            _mapper = new Dictionary<object, object>();
        }

        public static T MapTo<T>(this IMapper convertType, object from)
        {
            T destinationType = (T) _mapper[from.GetType()];
            return 
        }

        /// <summary>
        /// Регистрация мапинга
        /// </summary>
        /// <typeparam name="TInto">класс, в который нужно преобразовать</typeparam>
        /// <typeparam name="TFrom">класс, с которым нужно провести преобразование</typeparam>
        /// <param name="registerMapping">регистрируемый маппинг</param>
        /// <param name="from"></param>
        /// <param name="into"></param>
        public static void RegisterMapper<TInto, TFrom>()
        {
            _mapper.Add(typeof(TInto),typeof(TFrom));
        }
    }

    public interface IMapper
    {
    }
}
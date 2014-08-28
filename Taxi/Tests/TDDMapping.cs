using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Framework;
using Taxi.Mapping;

namespace Taxi.Test
{

    public class TddMapping
    {
        [Test]
        public void TestMethod()
        {
            Mapper.RegisterMapper<TypeFrom, TypeTo>().FromTo(from => from.Properties1, to => to.Properties1);
            var destination = FromObject.MapTo<TypeTo>;
        }
    }
}
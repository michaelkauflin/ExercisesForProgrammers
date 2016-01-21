using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fixie;

namespace TipCalculator.Tests.Fixie
{
    public class CustomConvention : Convention
    {
        public CustomConvention()
        {
            Classes
                .Has<TestFixtureAttribute>();

            Methods
                .HasOrInherits<TestAttribute>();
        }
    }

    [AttributeUsage(AttributeTargets.Method)]
    public class TestAttribute : Attribute { }

    [AttributeUsage(AttributeTargets.Class)]
    public class TestFixtureAttribute : Attribute { }
}

using System;
using System.Reflection;

namespace Faker
{
    public class Faker : IFaker
    {
        public T create<T>()
        {
            Type type = typeof(T);
            return (T) Activator.CreateInstance(type);
        }
    }
}
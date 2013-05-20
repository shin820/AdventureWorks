using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.Infrastructure
{
    /// <summary>
    /// Singleton Helper Class
    /// </summary> 
    /// <typeparam name="T">The type of the object which need to be a singleton ,it must has a default no paramters construction </typeparam> 
    public abstract class Singleton<T>
    {
        private static T _instatnce;
        private static Object lockHelper = new object();

        public static T Instance
        {
            get
            {
                if (_instatnce == null)
                {
                    lock (lockHelper)
                    {
                        if (_instatnce == null)
                        {
                            _instatnce = (T) Activator.CreateInstance(typeof (T), true);
                        }
                    }
                }

                return _instatnce;
            }

        }
    }

    /// <summary>
    /// Laze singleton provider
    /// </summary>
    /// <typeparam name="T">>The type of the object which need to be a singleton</typeparam>
    public class SingletonProvider<T> where T : new()
    {
        private SingletonProvider()
        {
        }

        public static T Instance
        {
            get { return SingletonCreator.instance; }
        }

        private class SingletonCreator
        {
            static SingletonCreator()
            {
            }

            internal static readonly T instance = new T();
        }
    }
}

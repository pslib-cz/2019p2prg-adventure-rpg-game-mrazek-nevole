using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Helpers
{
    public interface ISessionStorage<T>
    {
        public T LoadOrCreate(string key);
        public void Save(string key, T data);
    }
}

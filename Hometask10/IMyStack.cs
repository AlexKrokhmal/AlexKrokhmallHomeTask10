using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask10
{
    public interface IMyStack<T>
    {
        void Push(T valueToAdd);
        T Pop();
    }
}

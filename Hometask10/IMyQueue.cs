﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask10
{
    public interface IMyQueue<T>
    {
        void Enqueue(T valueToAdd);
        T Dequeue();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairyTale
{
    interface IHungry<T>
    {
        T satiety { get; set; }
        void Hungry();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders.Core
{
    public interface IDice
    {
        int LastNumber { get; }

        int Roll();
    }
}

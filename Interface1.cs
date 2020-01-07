using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace CLI_Doge
{
    public interface IAnimal
    { string Name { get; }
        int Age { get; }
        void Pet();
            }
}

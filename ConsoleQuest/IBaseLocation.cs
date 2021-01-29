using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleQuest
{
    interface IBaseLocation
    {
        void StartDialog();
        void Variant(byte Option);
    }
}

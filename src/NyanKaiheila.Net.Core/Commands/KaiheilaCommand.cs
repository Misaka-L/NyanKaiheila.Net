using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyanKaiheila.Net.Core.Commands
{
    public class KaiheilaCommand<T>
    {
        public string Command;
        public virtual Task Invoke(T arg) => throw new NotImplementedException();
    }
}
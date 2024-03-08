using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dot_Net_Master
{
    public class AwaitableClass : INotifyCompletion
    {
        public void OnCompleted(Action continuation)
        {
            throw new NotImplementedException();
        }
    }
}

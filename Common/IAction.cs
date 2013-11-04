using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface IAction
    {
        string Recipient { get; set; }
        void SendNotification(string message);
    }
}

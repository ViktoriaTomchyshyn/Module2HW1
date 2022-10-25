using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2hw1
{
    public class Actions
    {
        public static Result InfoMethod()
        {
            Logger.GetInstance().AddLog(Type.Info, "Start method: " + new StackFrame().GetMethod().Name.ToString());
            return new Result(true);
        }

        public static Result WarningMethod()
        {
            Logger.GetInstance().AddLog(Type.Warning, "Skipped logic in method: " + new StackFrame().GetMethod().Name.ToString());
            return new Result(true);
        }

        public static Result ErrorMethod()
        {
            return new Result(false, "I broke a logic.");
        }
    }
}

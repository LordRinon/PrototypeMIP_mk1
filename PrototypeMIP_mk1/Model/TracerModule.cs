using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrototypeMIP_mk1.Model
{
    // WIP
    public class TracerModule
    {
        Thread thread;
        private BooleanSwitch sw;
        public TracerModule()
        {
            thread = new Thread(this.run);
            sw = new BooleanSwitch("Switch", "Trace Switch");
            //FileStream traceLog = new FileStream("Trace.txt", FileMode.Append);
            //TextWriterTraceListener traceListener = new TextWriterTraceListener(traceLog);
            //Trace.Listeners.Add(traceListener);
            Trace.AutoFlush = true;
        }

        private void run()
        {
            throw new NotImplementedException();
        }

        public void TraceWrite(string message)
        {
            Trace.WriteLine($"{DateTime.Now} : {message}");
        }
    }
}

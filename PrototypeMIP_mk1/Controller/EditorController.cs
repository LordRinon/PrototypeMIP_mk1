using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrototypeMIP_mk1.Controller
{
    public class EditorController
    {
        private Thread thread;
        private int timer = 100;
        public EditorController()
        {
            thread = new Thread(this.run);
        }

        private void run()
        {
            timer--;
            Thread.Sleep(100);
            // Send signal to save text
        }

        public void Text_Update()
        {
            timer = 100;
        }
    }
}

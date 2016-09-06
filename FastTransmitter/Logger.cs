using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastTransmitter
{
    class Logger
    {
        private ListBox logBox;

        public Logger(ListBox logBox)
        {
            this.logBox = logBox;
        }
        
        public void log(string log, int level)
        {
            switch (level)
            {
                case 1: this.logBox.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss.fff") + "] [WARNING] " + log); break;
                case 2: this.logBox.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss.fff") + "] [ERROR] " + log); break;
                default: this.logBox.Items.Add("[" + DateTime.Now.ToString("HH:mm:ss.fff") + "] [INFO] " + log); break;
            }
            this.logBox.TopIndex = this.logBox.Items.Count - 1;
        }
    }
}

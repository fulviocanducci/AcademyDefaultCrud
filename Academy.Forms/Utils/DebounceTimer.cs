using System;
using System.Windows.Forms;

namespace Academy.Forms.Utils
{
    public class DebounceTimer
    {
        private readonly Timer _timer;

        public DebounceTimer(int interval, EventHandler action)
        {
            _timer = new Timer
            {
                Interval = interval
            };
            _timer.Tick += (s, e) =>
            {
                _timer.Stop();
                action(s, e);
            };
        }

        public void Execute()
        {
            _timer.Stop();
            _timer.Start();
        }
    }
}

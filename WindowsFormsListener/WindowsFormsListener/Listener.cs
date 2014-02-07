using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsListener
{
    /// <summary>
    /// Listener
    /// </summary>
    public class Listener
    {
        private int counter;

        public Listener()
        {
            counter = 0;
        }

        /// <summary>
        /// Subscribe
        /// </summary>
        /// <param name="control">The Form Control to update</param>
        /// <param name="metronome">The metronome</param>
        public void Subscribe(Control control, Metronome metronome)
        {
            metronome.Tick += (obj, args) => {
                control.Invoke(new MethodInvoker(() => control.Text = counter++.ToString()));
            };
        }
    }
}

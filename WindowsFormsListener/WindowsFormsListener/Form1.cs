using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsListener
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartListening();
        }

        /// <summary>
        /// Start Listening
        /// </summary>
        private void StartListening()
        {
            // Listen in a new thread.
            Task t = Task.Factory.StartNew(() =>
            {
                Metronome m = new Metronome();
                Listener l = new Listener();

                // Subscribe will update the label label1
                l.Subscribe(this.Controls["label1"], m);

                // Start listening
                m.Start();
            });
        }
    }
}

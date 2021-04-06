using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ClotureDesFichesWinService
{
    public partial class ClotureDesFichesWinService : ServiceBase
    {
        //création d'une variable timer
        private Timer syncTimer = null;

        //création d'une variable path
        string filepath = Path.Combine(Path.GetDirectoryName
                          (new Uri(Assembly.GetExecutingAssembly()
                            .CodeBase).LocalPath), "Clôture des fiches.exe");


        public ClotureDesFichesWinService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            syncTimer = new Timer();
            this.syncTimer.Interval = 600000; //10 min
            this.syncTimer.Elapsed +=
                new System.Timers.
                   ElapsedEventHandler(this.syncTimerTicker);
            syncTimer.Enabled = true;
        }

        protected override void OnStop()
        {
            syncTimer.Enabled = false;
        }

        
        private void syncTimerTicker(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(filepath);
        }
    }
}

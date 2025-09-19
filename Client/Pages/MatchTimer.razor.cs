using Microsoft.AspNetCore.Components;
using System.Timers;
using Timer = System.Timers.Timer;

namespace BlazorApp.Client.Pages
{
    public partial class MatchTimer
    {
        private System.Timers.Timer timer = null!;
        private DateTime timestarted = new();
        private DateTime timepaused = new();
        private TimeSpan timerunning = new TimeSpan();
        private bool isrunning = false;
        
        [Parameter]
        public string TimeRunning{ get; set; } = "00:00:00";

        public void Start()
        {
            if (isrunning is false)
            {
                timestarted = DateTime.Now;
                isrunning = true;
                timer = new Timer(1000);
                timer.Elapsed += OnTimedEvent;
                timer.AutoReset = true;
                timer.Start();
            } 
           
        }
        
        private async void OnTimedEvent(object? sender, ElapsedEventArgs e)
        {
            if (isrunning is true)
            {

                await InvokeAsync(() =>
                {
                    timerunning = e.SignalTime - timestarted;
                    TimeRunning = timerunning.ToString(@"hh\:mm\:ss");
                    StateHasChanged();
                });
            }
        }

        public void Pause()
        {
            if (isrunning is true)
            {
                isrunning = false;
                timepaused = DateTime.Now;
            }
        }

        public void Restart()
        {
            if (isrunning is false)
            {
                isrunning = true;
                timerunning = timepaused - timestarted;
            }
        }

        public void Stop()
        {
            if (isrunning is true)
            {
                timer.Stop();
                isrunning = false;
            }
        }

    }
}

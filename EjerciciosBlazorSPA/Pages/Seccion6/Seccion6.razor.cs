using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;

namespace EjerciciosBlazorSPA.Pages.Seccion6
{
    public partial class Seccion6: IDisposable
    {
        private Timer miTimer = new Timer();
        private int contador;

        protected override void OnInitialized()
        {
            miTimer.Interval = 1000;
            miTimer.Elapsed += MetodoTimer;
            contador = 0;
        }
        private void MetodoTimer(object senter, ElapsedEventArgs e)
        {
            contador++;
            InvokeAsync(StateHasChanged);
        }
        private void Arrancar()
        {
            miTimer.Start();
        }
        private void Parar()
        {
            miTimer.Stop();
        }
        public void Dispose()
        {
            miTimer.Dispose();
        }
    }
}

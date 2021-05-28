using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;

namespace EjerciciosBlazorSPA.Pages.Seccion7
{
    public class Seccion7Base:ComponentBase
    {
        public Timer miTimer = new Timer();
        public int contador;

        protected override void OnInitialized()
        {
            miTimer.Interval = 1000;
            miTimer.Elapsed += MetodoTimer;
            contador = 0;
        }
        public void MetodoTimer(object senter, ElapsedEventArgs e)
        {
            contador++;
            InvokeAsync(StateHasChanged);
        }
        protected void Arrancar()
        {
            miTimer.Start();
        }
        protected void Parar()
        {
            miTimer.Stop();
        }
        protected void Dispose()
        {
            miTimer.Dispose();
        }
    }
}

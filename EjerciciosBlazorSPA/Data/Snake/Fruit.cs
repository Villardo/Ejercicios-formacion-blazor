using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjerciciosBlazorSPA.Data.Snake
{
    public class Fruit
    {
        private Coordinate CoordenadasFruta = new();
        private bool estaEnTablero= false;
        public void generar()
        {
            Random rnd = new Random();
            int x = rnd.Next(1, 65);
            int y = rnd.Next(1, 65);

            CoordenadasFruta.posX = x;
            CoordenadasFruta.posY = y;

            estaEnTablero = true;
        }

    }

}

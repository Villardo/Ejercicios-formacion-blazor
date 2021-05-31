using System;
using EjerciciosBlazorSPA.Data;
using System.Timers;

namespace EjerciciosBlazorSPA.Pages.JuegoSnake
{
    public partial class JuegoSnake : IDisposable
    {
        private Board MyBoard;
        private Snake MySnake;
        private Apple MyApple;
        private Timer MyTimer;
        private Random RandNum;
        private Direction Dir;
        private bool GameOver;

        protected override void OnInitialized()
        {
            GameOver = false;
            MyBoard = new(20, 20);
            MySnake = new(0,0);
            MyApple = new(10, 10);
            RandNum = new();
            MyTimer = new();
            MyTimer.Interval = 1000;
            MyTimer.Elapsed += TimerEvent;
            Dir = Direction.RIGHT;
        }

        private void CreateApple()
        {
            MyApple.PosX = RandNum.Next(0, MyBoard.TabX);
            MyApple.PosY = RandNum.Next(0, MyBoard.TabY);
        }

        private void TimerStart()
        {
            if (MySnake.GameOver)
            {
                refreshPage();
            }
            else
            {
                MyTimer.Start();
                focusOnControls();
                MySnake.GameOver = false;
                MySnake.Points = 0;
            }
        }

        private void TimerStop()
        {
            MyTimer.Stop();
        }

        private void TimerEvent(object senter, ElapsedEventArgs e)
        {
            MySnake.Move(Dir);
            InvokeAsync(StateHasChanged);
        }

        public void Dispose()
        {
            MyTimer.Dispose();
        }

        public void updateDifficulty(int DifficultyValue)
        {
            MyTimer.Interval = DifficultyValue;
            focusOnControls();
        }
    }
}

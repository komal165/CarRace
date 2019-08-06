using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRace
{
    class Car
    {
        public int startPosition { get; set; }
        public int finishPosition { get; set; }
        public PictureBox carImg { get; set; }
        private Random rand = new Random();

        public bool AccelerateCar()
        {
            Point currentPosition = carImg.Location;
            currentPosition.X += rand.Next(1, 6);
            carImg.Location = currentPosition;

            if (currentPosition.X >= finishPosition)
                return true;
            else
                return false;
        }

        public void BackToStart()
        {
            carImg.Left = startPosition;
        }
    }
}

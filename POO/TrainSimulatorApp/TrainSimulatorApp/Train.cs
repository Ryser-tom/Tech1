using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainSimulatorApp
{
    public class Train
    {
        private Point startPosition;
        private string direction;
        private RailButton[] wagons; 
        private int speed;
        private Color color;

        public Train(Point startPosition, string direction, int length, int speed, Color color)
        {
            this.startPosition = startPosition;            
            this.direction = direction;
            wagons = new RailButton[length];
            this.speed = speed;
            this.color = color;
        }

        public Point getStartPosition()
        {
            return startPosition;        
        }

        public string getDirection()
        {
            return direction;
        }

        public RailButton getCurrentPosition()
        {
            return wagons[0];
        }     
        
        public void move(RailButton p)
        {
            wagons[wagons.Length - 1].removeTrain();
            for (int i = wagons.Length - 2; i >= 0; i--)
            {
                wagons[i + 1] = wagons[i];
            }
            wagons[0] = p;
            p.setTrain(this);
        }
        public void addWagon(RailButton wagon)
        {
            for (int i = 0; i < wagons.Length; i++)
            {
                if (wagons[i] == null)
                {
                    wagons[i] = wagon;
                    return;
                }
            }
            throw new Exception("Train is full");
        }

        public int getSpeed()
        {
            return speed;
        }

        public int getLength()
        {
            return wagons.Length;
        }

        public Color getColor()
        {
            return color;
        }
    }
}

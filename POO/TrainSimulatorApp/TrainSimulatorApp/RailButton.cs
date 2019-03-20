using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace TrainSimulatorApp
{
    public class RailButton : Button
    {
        private Point point;

        private Train train;

        public RailButton(int x, int y)
        {
            point = new Point(x, y);
        }

        public bool isRailAvailable()
        {
            return train == null && Text != "";
        }

        public bool hasTrain(Train train)
        {
            return train == this.train;
        }

        public void setTrain(Train train)
        {
            this.train = train;
            BackColor = train.getColor();
        }

        public void removeTrain()
        {
            train = null;
            BackColor = Color.Transparent;
        }

        public Point getPoint()
        {
            return point;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;

namespace TrainSimulatorApp
{
    public class TrainSimulatorMgr
    {
        private RailButton[,] grid;

        private List<Train> trains = new List<Train>();

        private int time = 0;

        private static Semaphore _pool;
        private bool locked = false;
        private string trainLocked;
        private int lockingSize;

        public TrainSimulatorMgr(RailButton[,] grid)
        {
            this.grid = grid;
        }

        public async Task ProcessTasksAsync()
        {
            Task[] asyncCalls = new Task[trains.Count()];
            _pool = new Semaphore(1, 1);

            //HERE
            for (int i = 0; i < asyncCalls.Length; i++) {
                asyncCalls[i] = DoSomething(trains[i]);
            }
            //END
            await Task.WhenAll(asyncCalls);
        }

        async Task DoSomething(Train train)
        {
            while (true) {
                try {
                    RailButton next = getNextRail(train.getCurrentPosition(), train);
                    string trainColor = train.getColor().ToString();

                    await Task.Delay(train.getSpeed() * 10);
                    if (next.Text == "+") {
                        Console.WriteLine("intersection");
                        locking(train, true);

                        if (trainLocked == trainColor) {
                            move(train);
                        }
                    } else {
                        locking(train, false);
                        move(train);
                    }
                    
                } catch (Exception e) {
                    Console.WriteLine(e);
                }
            }
        }
        public void locking(Train train ,bool status)
        {
            if (!locked && status) {
                Console.WriteLine("locking");
                locked = true;
                trainLocked = train.getColor().ToString();
                lockingSize = train.getLength();
            } else if(trainLocked == train.getColor().ToString()) {
                Console.WriteLine("counting : {0}", lockingSize);
                //_pool.WaitOne(train.getSpeed());
                lockingSize--;
            }
            if (lockingSize==0) {
                //_pool.Release();
                locked = false;
                trainLocked = "none";
            }

        }

        public void addTrain(Train train)
        {
            RailButton rail = getRail(train.getStartPosition());
            if (rail == null)
            {
                throw new Exception("No railway at " + train.getStartPosition());
            }

            for (int i = 0; i < train.getLength(); i++)
            {
                if (!rail.isRailAvailable())
                {
                    throw new Exception("Rail at " + rail.getPoint() + " is already used or doesn't contain a rail");
                }
                rail.setTrain(train);
                train.addWagon(rail);
                rail = getPreviousRail(rail, train);
            }

            trains.Add(train);
        }

        public void move(Train train)
        {
            RailButton head = train.getCurrentPosition();
            RailButton nextRail = getNextRail(head, train);
            if (!nextRail.isRailAvailable())
            {
                throw new Exception("Rail at " + nextRail.getPoint() + " is already used or doesn't contain a rail");
            }            
            train.move(nextRail);
        }

        private RailButton getPreviousRail(RailButton rail, Train train)
        {
            if (rail.Text == "-")
            {
                RailButton west = grid[rail.getPoint().X - 1, rail.getPoint().Y];
                RailButton east = grid[rail.getPoint().X + 1, rail.getPoint().Y];
                
                if (west.isRailAvailable() && east.isRailAvailable())
                {
                    return train.getDirection().Contains("E") ? west : east;
                }
                return west.isRailAvailable() ? west : east;                
            }
            if (rail.Text == "|")
            {
                RailButton north = grid[rail.getPoint().X, rail.getPoint().Y - 1];
                RailButton south = grid[rail.getPoint().X, rail.getPoint().Y + 1];

                if (north.isRailAvailable() && south.isRailAvailable())
                {
                    return train.getDirection().Contains("S") ? north : south;
                }
                return north.isRailAvailable() ? north : south;                
            }
             if (rail.Text == "+")
            {
                RailButton west = grid[rail.getPoint().X - 1, rail.getPoint().Y];
                RailButton east = grid[rail.getPoint().X + 1, rail.getPoint().Y];
                RailButton north = grid[rail.getPoint().X, rail.getPoint().Y - 1];
                RailButton south = grid[rail.getPoint().X, rail.getPoint().Y + 1];

                if (east.isRailAvailable() && west.isRailAvailable() && north.isRailAvailable() && south.isRailAvailable())
                {
                    if (train.getDirection().Contains("S"))
                    {
                        return north;
                    }
                    if (train.getDirection().Contains("N"))
                    {
                        return south;
                    }
                    if (train.getDirection().Contains("W"))
                    {
                        return east;
                    }
                    return west;
                }
                
                if (east.hasTrain(train))
                {
                    return west;
                }
                if (west.hasTrain(train))
                {
                    return east;
                }
                if (north.hasTrain(train))
                {
                    return south;
                }
                return north;
            }
             if (rail.Text == "˪")
            {                
                RailButton east = grid[rail.getPoint().X + 1, rail.getPoint().Y];
                RailButton north = grid[rail.getPoint().X, rail.getPoint().Y - 1];

                if (north.isRailAvailable() && east.isRailAvailable())
                {
                    return train.getDirection().Contains("S") ? north : east;
                }
                return north.isRailAvailable() ? north : east;
            }
             if (rail.Text == "¬")
            {
                RailButton west = grid[rail.getPoint().X - 1, rail.getPoint().Y];                               
                RailButton south = grid[rail.getPoint().X, rail.getPoint().Y + 1];

                if (west.isRailAvailable() && south.isRailAvailable())
                {
                    return train.getDirection().Contains("E") ? west : south;
                }
                return west.isRailAvailable() ? west : south;
            }
             if (rail.Text == "r")
            {                
                RailButton east = grid[rail.getPoint().X + 1, rail.getPoint().Y];               
                RailButton south = grid[rail.getPoint().X, rail.getPoint().Y + 1];

                if (east.isRailAvailable() && south.isRailAvailable())
                {
                    return train.getDirection().Contains("W") ? east : south;
                }
                return east.isRailAvailable() ? east : south;
            }
             if (rail.Text == "j")
            {
                RailButton west = grid[rail.getPoint().X - 1, rail.getPoint().Y];
                RailButton north = grid[rail.getPoint().X, rail.getPoint().Y - 1];

                if (north.isRailAvailable() && west.isRailAvailable())
                {
                    return train.getDirection().Contains("S") ? north : west;
                }
                return north.isRailAvailable() ? north : west;
            }

            return null;                   
        }

        private RailButton getNextRail(RailButton rail, Train train)
        {
            if (rail.Text == "-")
            {
                RailButton west = grid[rail.getPoint().X - 1, rail.getPoint().Y];
                RailButton east = grid[rail.getPoint().X + 1, rail.getPoint().Y];

                return east.hasTrain(train) ? west : east;
            }
            if (rail.Text == "|")
            {
                RailButton north = grid[rail.getPoint().X, rail.getPoint().Y - 1];
                RailButton south = grid[rail.getPoint().X, rail.getPoint().Y + 1];
               
                return south.hasTrain(train) ? north : south;
            }
            if (rail.Text == "+")
            {
                RailButton west = grid[rail.getPoint().X - 1, rail.getPoint().Y];
                RailButton east = grid[rail.getPoint().X + 1, rail.getPoint().Y];
                RailButton north = grid[rail.getPoint().X, rail.getPoint().Y - 1];
                RailButton south = grid[rail.getPoint().X, rail.getPoint().Y + 1];            

                if (east.hasTrain(train))
                {
                    return west;
                }
                if (west.hasTrain(train))
                {
                    return east;
                }
                if (north.hasTrain(train))
                {
                    return south;
                }
                return north;
            }
            if (rail.Text == "˪")
            {
                RailButton east = grid[rail.getPoint().X + 1, rail.getPoint().Y];
                RailButton north = grid[rail.getPoint().X, rail.getPoint().Y - 1];
                
                return east.hasTrain(train) ? north : east;
            }
            if (rail.Text == "¬")
            {
                RailButton west = grid[rail.getPoint().X - 1, rail.getPoint().Y];
                RailButton south = grid[rail.getPoint().X, rail.getPoint().Y + 1];
                
                return south.hasTrain(train) ? west : south;
            }
            if (rail.Text == "r")
            {
                RailButton east = grid[rail.getPoint().X + 1, rail.getPoint().Y];
                RailButton south = grid[rail.getPoint().X, rail.getPoint().Y + 1];
                
                return south.hasTrain(train) ? east : south;
            }
            if (rail.Text == "j")
            {
                RailButton west = grid[rail.getPoint().X - 1, rail.getPoint().Y];
                RailButton north = grid[rail.getPoint().X, rail.getPoint().Y - 1];

                return west.hasTrain(train) ? north : west;
            }

            return null;
        }

        private bool containsRail(RailButton btn)
        {
            return btn.Text != "";
        }

        private RailButton getRail(Point p)
        {
            RailButton rail = grid[p.X, p.Y];
            return containsRail(rail) ? rail : null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MeasuringDevice
{
    // TODO: Implement the MeasureDataDevice abstract class.
    public abstract class MeasureDataDevice : IMeasuringDevice
    {
        public int[] GetRawData()
        {
            throw new NotImplementedException();
        }

        public abstract decimal ImperialValue();

        public abstract decimal MetricValue();

        public void StartCollecting()
        {

        }

        public void StopCollecting()
        {
            throw new NotImplementedException();
        }
        
    }
}

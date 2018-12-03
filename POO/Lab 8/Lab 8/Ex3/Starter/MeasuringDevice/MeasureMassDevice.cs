using DeviceControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MeasuringDevice
{
    // TODO: Implement the MeasureMassDevice class.
    public class MeasureMassDevice : IMeasuringDevice
    {
        private Units unitsToUse;
        private int[] dataCaptured;
        private int mostRecentMeasure;
        private DeviceController controller;
        private const DeviceType measurementType = DeviceType.LENGTH;

        public int[] GetRawData()
        {
            return dataCaptured;
        }

        public decimal ImperialValue()
        {
            if (unitsToUse == Units.Imperial) {
                return mostRecentMeasure;
            } else {
                double v = mostRecentMeasure * 2.2046;
                return (decimal)v;
            }
        }

        public decimal MetricValue()
        {
            if (unitsToUse == Units.Metric) {
                return mostRecentMeasure;
            } else {
                double v = mostRecentMeasure * 0.4536;
                return (decimal)v;
            }
        }

        public void StartCollecting()
        {
            controller = DeviceController.StartDevice(measurementType);
            GetMeasurements();
        }

        public void StopCollecting()
        {
            if (controller != null) {
                controller.StopDevice();
                controller = null;
            }
        }

        private void GetMeasurements()
        {
            dataCaptured = new int[10];
            System.Threading.ThreadPool.QueueUserWorkItem((dummy) => {
                int x = 10;
                Random timer = new Random();
                while (controller != null) {
                    System.Threading.Thread.Sleep(timer.Next(1000, 5000));
                    dataCaptured[x] = controller != null ?
                        controller.TakeMeasurement() : dataCaptured[x];
                    mostRecentMeasure = dataCaptured[x];

                    x++;
                    if (x == 10) {
                        x = 0;
                    }
                }
            });
        }
    }
}

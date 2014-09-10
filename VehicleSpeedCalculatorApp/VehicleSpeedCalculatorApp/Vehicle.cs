using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSpeedCalculatorApp
{
    class Vehicle
    {
        public string name = "";
        public string regNo = "";
        private double minSpeed = 0;
        private double maxSpeed = 0;
        private double avgSpeed = 0;
        private double sumOfSpeeds = 0;
        private double numOfSpeeds = 0;

        public Vehicle()
        {
            sumOfSpeeds = 0;
            numOfSpeeds = 0;
        }

        public void SetSpeed(double speed)
        {
            if (numOfSpeeds == 0)
            {
                minSpeed = speed;
                maxSpeed = speed;
            }
            else
            {
                if (speed < minSpeed)
                {
                    minSpeed = speed;
                }

                if (speed > maxSpeed)
                {
                    maxSpeed = speed;
                }
            }

            sumOfSpeeds += speed;
            numOfSpeeds++;
        }

        public double GetMinSpeed()
        {
            return minSpeed;
        }

        public double GetMaxSpeed()
        {
            return maxSpeed;
        }

        public double GetAvgSpeed()
        {
            return sumOfSpeeds / numOfSpeeds;
        }
    }
}

﻿
   public class CasualRace : Race
    {
        public CasualRace(int length, string route, int prizePool) : base(length, route, prizePool)
        {
        }


        public override string PerformancePoints(Car car)
        {           
               return $"{(car.Horsepower / car.Acceleration) + (car.Suspension + car.Durability)}";                          
        }
    }


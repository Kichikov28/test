﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P13_CryptoMiningSystem
{
    public class VideoCard : Components
    {
        private readonly double minedMoneyPerHour;

        public virtual int Ram { get; set; }
        public virtual double MinedMoneyPerHour
        {
            get
            {
                return Ram * Generation / 10;
            }
        }
        public override int LifeWorkingHours
        {
            get { return Ram * Generation / 10; }
        }
    }
}

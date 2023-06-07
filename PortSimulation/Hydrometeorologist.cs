﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortSimulation
{
	internal class Hydrometeorologist
	{
		public bool WeatherIsClear { get; private set; } = true;
		public Dispatcher? Dispatcher { get; set; }
		private Random random = new Random();

		public void Forecast() 
		{
			WeatherIsClear = random.Next(2) == 0;
			Dispatcher!.WeatherIsClear = WeatherIsClear;
		}
		
	}
}

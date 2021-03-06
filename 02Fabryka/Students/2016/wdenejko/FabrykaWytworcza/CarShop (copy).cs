﻿using System;
namespace FabrykaWytworcza
{
	public abstract class CarShop
	{
		public abstract Car CreateCar(string item);

		public Car OrderCar(string type)
		{
			Car car = CreateCar(type);
			Console.WriteLine(string.Format("Creating car of type {0}", type.GetType()));
			car.Prepare();

			return car;
		}
	}
}

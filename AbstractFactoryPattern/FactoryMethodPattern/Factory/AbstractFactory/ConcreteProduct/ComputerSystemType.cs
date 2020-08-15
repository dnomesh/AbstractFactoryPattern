using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static FactoryMethodPattern.Factory.AbstractFactory.Enumarations;

namespace FactoryMethodPattern.Factory.AbstractFactory
{
    public class Laptop : ISystemType
    {
        public string GetSystemType()
        {
            return ComputerTypes.Laptop.ToString();
        }
    }

    public class Desktop : ISystemType
    {
        public string GetSystemType()
        {
            return ComputerTypes.Desktop.ToString();
        }
    }
}
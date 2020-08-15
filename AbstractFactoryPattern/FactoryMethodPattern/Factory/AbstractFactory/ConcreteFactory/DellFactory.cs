using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryMethodPattern.Factory.AbstractFactory
{
    public class DellFactory : IComputerFactory
    {
        public IBrand Brand()
        {
            return new MAC();
        }

        public IProcessor Processor()
        {
            return new I5();
        }

        public virtual ISystemType SystemType()
        {
            return new Desktop();
        }
    }

    public class DellLaptopFactory : DellFactory
    {
        public override ISystemType SystemType()
        {
            return new Laptop();
        }
    }
}
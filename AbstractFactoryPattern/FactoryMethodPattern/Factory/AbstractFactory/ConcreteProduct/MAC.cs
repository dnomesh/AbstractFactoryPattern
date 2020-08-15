using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static FactoryMethodPattern.Factory.AbstractFactory.Enumarations;

namespace FactoryMethodPattern.Factory.AbstractFactory
{
    public class MAC : IBrand
    {
        public string GetBrand()
        {
            return Brands.APPLE.ToString();
        }
    }
}
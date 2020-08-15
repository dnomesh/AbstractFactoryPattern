using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static FactoryMethodPattern.Factory.AbstractFactory.Enumarations;

namespace FactoryMethodPattern.Factory.AbstractFactory
{
    public class DELL : IBrand
    {
        public string GetBrand()
        {
            return Brands.DELL.ToString();
        }
    }
}
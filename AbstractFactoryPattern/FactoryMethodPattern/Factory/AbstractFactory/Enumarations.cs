﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryMethodPattern.Factory.AbstractFactory
{
    public class Enumarations
    {
        public enum ComputerTypes
        {
            Laptop,
            Desktop
        }

        public enum Brands
        {
            APPLE,
            DELL
        }

        public enum Processors
        {
            I3,
            I5,
            I7
        }
    }
}
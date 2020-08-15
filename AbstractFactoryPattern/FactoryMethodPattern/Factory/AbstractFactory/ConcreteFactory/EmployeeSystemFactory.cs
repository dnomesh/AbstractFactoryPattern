using FactoryMethodPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryMethodPattern.Factory.AbstractFactory
{
    public class EmployeeSystemFactory
    {
        public IComputerFactory Create(Employee emp)
        {
            IComputerFactory returnValue = null;
            if(emp.EmployeeType == 1)
            {
                if(emp.JobDescription == "Manager")
                {
                    returnValue = new MACLaptopFactory();
                }
                else
                {
                    returnValue = new MACFactory();
                }
            }
            else if(emp.EmployeeType == 2)
            {
                if(emp.JobDescription == "Manager")
                {
                    returnValue = new DellLaptopFactory();
                }
                else
                {
                    returnValue = new DellFactory();
                }
            }
            return returnValue;
        }
    }
}
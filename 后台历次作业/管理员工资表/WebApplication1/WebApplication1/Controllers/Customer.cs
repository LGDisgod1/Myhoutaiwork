using System;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    internal class Customer
    {
        public Customer()
        {
        }

        public string Address { get; internal set; }
        public string CustomerNmae { get; internal set; }

        public static implicit operator Customer(Cusromer v)
        {
            throw new NotImplementedException();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;


namespace Supermarket.Infrastructure
{
    public class InstanceLocator
    {
        public class InstanceLocator
        {
            public InstanceLocator()
            {
                Main = new MainViewModel();
            }
            public MainViewModel Main { get; set; }
        }
}

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace CodeShare.Examples
{
    public abstract class InterfaceExample : HttpClient
    {
        public abstract void IWantToForcePeopleToImplementMeBase()
        {
            this.IWantToForcePeopleToImplementMe();
        }

        public void IWantToForcePeopleToImplementMe()
        {
            Console.WriteLine("Dow something");
        }
    }
}

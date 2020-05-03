using System;
using System.Collections.Generic;
using System.Text;

namespace CodeShare.Examples
{
    public class InherntFromInterface : InterfaceExample
    {
        public void IWantToForcePeopleToImplementMe()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerRelationshipProject.Interface
{
    public interface IOrder
    {
        DateTime Purchased { get; }
        decimal Cost { get; }
    }
}

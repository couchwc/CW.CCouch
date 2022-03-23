using CW.CCouch.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW.CCouch.SharedKernel.Base
{

    /// <summary>
    /// 
    /// </summary>
    public abstract class Entity :
        IEntity
    {

        public Guid Id
        { get; set; }

        public long Index
        { get; set; }

    }

}

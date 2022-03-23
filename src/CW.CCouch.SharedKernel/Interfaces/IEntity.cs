using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW.CCouch.SharedKernel.Interfaces
{

    /// <summary>
    /// 
    /// </summary>
    public interface IEntity
    {

        /// <summary>
        /// Unique identifier.
        /// </summary>
        Guid Id 
        { get; set; }

        /// <summary>
        /// Index in the database.
        /// </summary>
        long Index
        { get; set; }

    }

}

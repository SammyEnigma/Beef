/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beef;
using Beef.Business;
using Beef.Data.Database;
using Beef.Data.EntityFrameworkCore;
using Beef.Entities;
using Beef.Mapper;
using Beef.Mapper.Converters;
using My.Hr.Common.Entities;
using RefDataNamespace = My.Hr.Common.Entities;

namespace My.Hr.Business.Data
{
    /// <summary>
    /// Provides the <see cref="TerminationDetail"/> data access.
    /// </summary>
    public partial class TerminationDetailData
    {

        /// <summary>
        /// Provides the <see cref="TerminationDetail"/> property and database column mapping.
        /// </summary>
        public partial class DbMapper : DatabaseMapper<TerminationDetail, DbMapper>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="DbMapper"/> class.
            /// </summary>
            public DbMapper()
            {
                Property(s => s.Date, "TerminationDate");
                Property(s => s.ReasonSid, "TerminationReasonCode");
                AddStandardProperties();
                DbMapperCtor();
            }
            
            partial void DbMapperCtor(); // Enables the DbMapper constructor to be extended.
        }

        /// <summary>
        /// Provides the <see cref="TerminationDetail"/> and Entity Framework <see cref="EfModel.Employee"/> property mapping.
        /// </summary>
        public partial class EfMapper : EfDbMapper<TerminationDetail, EfModel.Employee, EfMapper>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="EfMapper"/> class.
            /// </summary>
            public EfMapper()
            {
                Property(s => s.Date, d => d.TerminationDate);
                Property(s => s.ReasonSid, d => d.TerminationReasonCode);
                AddStandardProperties();
                EfMapperCtor();
            }
            
            partial void EfMapperCtor(); // Enables the EfMapper constructor to be extended.
        }
    }
}

#pragma warning restore
#nullable restore
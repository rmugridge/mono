//
// System.Data.Mapping.IDomainField
//
// Author:
//   Tim Coleman (tim@timcoleman.com)
//
// Copyright (C) Tim Coleman, 2003
//

#if NET_2_0

namespace System.Data.Mapping {
        public interface IDomainField
        {
		#region Properties

		IDomainStructure DomainStructure { get; }
		string Name { get; }

		#endregion // Properties
        }
}

#endif // NET_2_0

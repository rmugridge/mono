//
// System.Data.IDbAsyncConnection.cs
//
// Author:
//   Tim Coleman (tim@timcoleman.com)
//
// Copyright (C) Tim Coleman, 2003
//

#if NET_2_0

namespace System.Data {
	public interface IDbAsyncConnection
	{
		#region Methods

		IAsyncResult BeginOpen (AsyncCallback callback, object stateObject);
		void EndOpen (IAsyncResult result);

		#endregion // Methods
	}
}

#endif // NET_2_0

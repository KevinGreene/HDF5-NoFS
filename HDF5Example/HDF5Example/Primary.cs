using System;
using HDF5DotNet;
namespace HDF5Example
{
	public class Primary
	{
		public static void Main ()
		{
			//          H5.CheckLibraryVersion(H5.Version);
					H5F.create("dataset.h5", H5F.CreateMode.ACC_CREAT);
			long[] dimensions = new long[2];
			dimensions[0] = (long)4;
			dimensions[1] = 6;
			//			H5S.create_simple(10, dimensions);
		}
	}
}
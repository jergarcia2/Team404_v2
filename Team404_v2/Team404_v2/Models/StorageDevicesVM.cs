using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team404_v2.Models
{
    public class StorageDevicesVM
    {
		public List<AStorageDevices> AStorageDevices { get; set; }

		public StorageDevicesVM()
		{
			AStorageDevices = new List<AStorageDevices>();
		}
	}
}

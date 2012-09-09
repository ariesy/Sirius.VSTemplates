using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;

namespace $rootnamespace$
{
	// 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“$safeitemrootname$”。
	[ServiceContract]
	public interface $safeitemrootname$
	{

		[OperationContract]
		string GetData(int value);

	}
}

using System;
using System.Collections.Generic;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;
$endif$using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace $rootnamespace$
{
	// 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“$safeitemrootname$”。
	public class $safeitemrootname$ : $contractName$
	{
		public void DoWork()
		{
		}
	}
}

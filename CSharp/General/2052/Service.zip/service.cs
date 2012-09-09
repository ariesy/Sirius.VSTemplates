using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;
$endif$using System.ServiceProcess;
using System.Text;

namespace $rootnamespace$
{
	partial class $safeitemrootname$: ServiceBase
	{
		public $safeitemrootname$()
		{
			InitializeComponent();
		}

		protected override void OnStart(string[] args)
		{
			// TODO: 在此处添加代码以启动服务。
		}

		protected override void OnStop()
		{
			// TODO: 在此处添加代码以执行停止服务所需的关闭操作。
		}
	}
}

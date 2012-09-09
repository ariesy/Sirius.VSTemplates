using System;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;
$endif$using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;

[ServiceContract(Namespace = "")]
[SilverlightFaultBehavior]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
public class $safeitemrootname$
{
	[OperationContract]
	public void DoWork()
	{
		// 在此处添加操作实现
		return;
	}

	// 在此处添加更多操作并使用 [OperationContract] 标记它们
}

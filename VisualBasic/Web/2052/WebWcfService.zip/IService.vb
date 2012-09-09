Imports System.ServiceModel

' 注意: 使用上下文菜单上的“重命名”命令可以同时更改代码和配置文件中的接口名“$safeitemrootname$”。
<ServiceContract()>$if$ ($targetframeworkversion$ <= 3.5) _$endif$
Public Interface $safeitemrootname$

    <OperationContract()>$if$ ($targetframeworkversion$ <= 3.5) _$endif$
    Sub DoWork()

End Interface

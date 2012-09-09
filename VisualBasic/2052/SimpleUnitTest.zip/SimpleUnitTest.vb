Imports System.Text

<TestClass()>
Public Class $safeitemname$

    Private testContextInstance As TestContext

    '''<summary>
    '''获取或设置测试上下文，该上下文提供
    '''有关当前测试运行及其功能的信息。
    '''</summary>
    Public Property TestContext() As TestContext
        Get
            Return testContextInstance
        End Get
        Set(ByVal value As TestContext)
            testContextInstance = Value
        End Set
    End Property

#Region "附加测试特性"
    '
    ' 编写测试时，可以使用以下附加特性:
    '
    ' 在运行类中的第一个测试之前使用 ClassInitialize 运行代码
    ' <ClassInitialize()> Public Shared Sub MyClassInitialize(ByVal testContext As TestContext)
    ' End Sub
    '
    ' 在类中的所有测试都已运行之后使用 ClassCleanup 运行代码
    ' <ClassCleanup()> Public Shared Sub MyClassCleanup()
    ' End Sub
    '
    ' 在运行每个测试之前，使用 TestInitialize 来运行代码
    ' <TestInitialize()> Public Sub MyTestInitialize()
    ' End Sub
    '
    ' 在每个测试运行完之后，使用 TestCleanup 来运行代码
    ' <TestCleanup()> Public Sub MyTestCleanup()
    ' End Sub
    '
#End Region

    <TestMethod()>
    Public Sub TestMethod1()
        ' TODO: 在此处添加测试逻辑
    End Sub

End Class

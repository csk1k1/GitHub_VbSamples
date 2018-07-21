Imports System.Globalization
Public Class Form1
    Public Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        '    Version1:End    可以将 End 语句放在过程中任意处， 以强制整个应用程序停止运行。
        'End 关闭用 Open 语句打开的所有文件， 并清除所有应用程序的变量。
        '    只要其他程序没有引用应用程序的对象并且应用程序的代码当前都未运行， 该应用程序就会立即关闭。
        '    说明
        'End 语句会突然停止代码的执行，而不调用 Dispose、Finalize 方法或任何其他 Visual Basic 代码。
        '    这将使其他程序所持有的对象引用无效。 
        '    如果在 Try 或 Catch 块中遇到 End 语句， 控制不会传递到对应的 Finally 块。
        '    Stop 语句中止执行，但与 End 不同，它不关闭任何文件或清除任何变量，除非在已编译的可执行 (.exe) 文件中遇到它。
        '    由于 End 会立即终止应用程序， 而不顾及任何可能已打开的资源， 因此在使用该语句前， 应尝试彻底关闭所有资源。
        '    例如， 如果应用程序中还有打开的窗体， 应该先关闭这些窗体， 然后再将控制传递给 End 语句。
        '    尽量少用 End， 只有在需要立即停止时才使用该语句。 
        '    终止过程的正常方式（ Return 语句 (Visual Basic) 和 Exit 语句 (Visual Basic)）不仅彻底关闭过程，
        '    而且允许彻底关闭调用代码。 例如，控制台应用程序即可直接从 Main 过程 Return。
        End

        '   Version2: Form.Close 方法
        Me.Close()

        '   Version3: Application.Exit()
        '   Exit方法的所有线程上停止所有正在运行消息循环， 并关闭所有窗口的应用程序。 
        '    此方法不一定是强制退出该应用程序。 Exit通常从调用方法中， 消息循环， 并强制 Run返回。
        Application.Exit()

        '   version4: 结束线程
        '   使用此方法以退出当前线程的消息循环。 此方法将导致对调用 Run当前线程，以返回。 
        '   若要退出整个应用程序， 请调用 Exit。
        Application.ExitThread()

        '   version5: System.Environment.Exit(exitcode As Integer)
        '   有关 exitCode 参数，使用非零数字表示出现错误。 
        '   在您的应用程序， 可以在枚举中， 定义您自己的错误代码， 并返回基于方案的相应的错误代码。
        '   例如， 返回的值为 1 以指示所需的文件不存在和值为 2， 以指示该文件位于错误的格式。 
        '    有关使用 Windows 操作系统的退出代码的列表， 请参阅 联机System Error Codes Windows 文档中。
        System.Environment.Exit(0)


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim value As Double = 1234567890
        Console.WriteLine(value.ToString("#,#", CultureInfo.InvariantCulture))
        Console.WriteLine(String.Format(CultureInfo.InvariantCulture,
                                "{0:#,#}", value))
        ' Displays 1,234,567,890      

        Console.WriteLine(value.ToString("#,##0,,", CultureInfo.InvariantCulture))
        Console.WriteLine(String.Format(CultureInfo.InvariantCulture,
                                "{0:#,##0,,}", value))
        ' Displays 1,235
        Console.WriteLine(value.ToString("#,###,,", CultureInfo.InvariantCulture))
        Dim x As Integer
        x = 3 And 7
        Console.WriteLine(x)

        Dim bool1 As Boolean = CBool(x)
        Console.WriteLine("CBool(3) = " + bool1.ToString)
        Console.WriteLine("True强制转换为数字: " + CDbl(True).ToString)
        Console.WriteLine("False强制转换为数字: " + CDbl(False).ToString)

    End Sub
End Class

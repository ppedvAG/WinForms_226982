Imports System.ServiceModel


Public Module Module1

    Dim host As ServiceHost

    Sub New()
        Dim uri = New Uri("net.tcp://localhost:1")
        host = New ServiceHost(GetType(TestService), uri)
        host.AddServiceEndpoint(GetType(ITestService), New NetTcpBinding(), "")

        'Dim smdb As New ServiceMetadataBehavior()
        'smdb.HttpGetEnabled = True
        'smdb.HttpGetUrl = New Uri("http://localhost:2")
        'host.Description.Behaviors.Add(smdb)
    End Sub

    Sub Start()
        host.Open()
    End Sub

    Sub Ende()
        host.Close()
    End Sub

    Sub Main()

        Console.WriteLine("*** WCF Server ***")

        Start()
        Console.WriteLine("Host wurde gestartet")
        Console.ReadKey(False)
        Ende()
        Console.WriteLine("Host wurde beendet")


        Console.WriteLine("Ende")
        Console.ReadKey(False)
    End Sub

End Module




Public Class TestService
    Implements ITestService

    Public Function Sum(a As Integer, b As Integer) As Integer Implements ITestService.Sum
        Dim result = a + b + 2

        Console.WriteLine($"a:{a} b:{b} = {result}")

        Return result
    End Function

End Class

<ServiceContract>
Public Interface ITestService

    <OperationContract>
    Function Sum(a As Integer, b As Integer) As Integer


End Interface

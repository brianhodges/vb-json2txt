Public Class Person
    Private fname, lname, mail, btc, ip As String
    Private guid As Integer

    Public Sub New(ByVal ID As Integer, FirstName As String, LastName As String,
                   Email As String, BTCAddress As String, IPAddress As String)
        Me.ID = ID
        Me.FirstName = FirstName
        Me.LastName = LastName
        Me.Email = Email
        Me.BTCAddress = BTCAddress
        Me.IPAddress = IPAddress
    End Sub

    Public Property ID() As String
        Get
            Return guid
        End Get
        Set(ByVal Value As String)
            guid = Value
        End Set
    End Property

    Public Property FirstName() As String
        Get
            Return fname
        End Get
        Set(ByVal Value As String)
            fname = Value
        End Set
    End Property

    Public Property LastName() As String
        Get
            Return lname
        End Get
        Set(ByVal Value As String)
            lname = Value
        End Set
    End Property

    Public Property Email() As String
        Get
            Return mail
        End Get
        Set(ByVal Value As String)
            mail = Value
        End Set
    End Property

    Public Property BTCAddress() As String
        Get
            Return btc
        End Get
        Set(ByVal Value As String)
            btc = Value
        End Set
    End Property

    Public Property IPAddress() As String
        Get
            Return ip
        End Get
        Set(ByVal Value As String)
            ip = Value
        End Set
    End Property

    Public Function FullName() As String
        Return String.Format("{0} {1}", FirstName, LastName)
    End Function
End Class

Imports System
Imports System.IO
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Module Module1

    Sub Main()
        Dim json As String = File.ReadAllText("data.json")
        Dim jsonResult = JsonConvert.DeserializeObject(json)
        Dim fs As FileStream = File.Create("log.txt")

        For Each obj As JObject In jsonResult
            Dim p As New Person(obj.Item("id"), obj.Item("first_name"), obj.Item("last_name"),
                                obj.Item("email"), obj.Item("btc_address"), obj.Item("ip_address"))

            Dim id As Byte() = New UTF8Encoding(True).GetBytes("ID: " + p.ID + Environment.NewLine)
            fs.Write(id, 0, id.Length)
            Dim fn As Byte() = New UTF8Encoding(True).GetBytes("Full Name: " + p.FullName + Environment.NewLine)
            fs.Write(fn, 0, fn.Length)
            Dim em As Byte() = New UTF8Encoding(True).GetBytes("Email: " + p.Email + Environment.NewLine)
            fs.Write(em, 0, em.Length)
            Dim btc As Byte() = New UTF8Encoding(True).GetBytes("BTC Address: " + p.BTCAddress + Environment.NewLine)
            fs.Write(btc, 0, btc.Length)
            Dim ip As Byte() = New UTF8Encoding(True).GetBytes("IP Address: " + p.IPAddress + Environment.NewLine + Environment.NewLine)
            fs.Write(ip, 0, ip.Length)
        Next

        fs.Close()
    End Sub

End Module

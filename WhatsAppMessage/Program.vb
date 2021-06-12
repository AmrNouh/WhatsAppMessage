Imports System
Imports Twilio
Imports Twilio.Types
Imports Twilio.Rest.Api.V2010.Account


Module Program
    Sub Main(args As String())
        Const accountSid As String = "AC08bf023861498f8454e086ff38f9b76d"
        Const authToken As String = "c9834fb934fe630880d1e7c87665b2a5"
        TwilioClient.Init(accountSid, authToken)
            Dim message = MessageResource.Create([to] := New twilio.Types.PhoneNumber("whatsapp:+20106002777"),from := New twilio.Types.PhoneNumber("whatsapp:+18645015300"),body := $"Hello From DEXEF")
            Console.WriteLine(message.Sid)
        
        
    End Sub
End Module

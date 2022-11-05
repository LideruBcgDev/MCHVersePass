Imports Newtonsoft.Json

<JsonObject()>
Public Class VerseData

    Public HolderList As New List(Of HolderData)
    Public LandList As New List(Of LandData)

End Class

<JsonObject()>
Public Class HolderData

    Public Property tokneId As String = String.Empty
    Public Property address As String = String.Empty
    Public Property ens As String = String.Empty
    Public Property uid As String = String.Empty
    Public Property name As String = String.Empty

    <JsonIgnore>
    Public ReadOnly Property disp_name As String
        Get
            If uid = "" Then Return String.Empty
            Return $"{name}#{uid}"
        End Get
    End Property

    Public Property land_type As String = String.Empty

    <JsonIgnore>
    Public ReadOnly Property land_name As String
        Get
            Select Case land_type
                Case "0" : Return "無所属"
                Case "1" : Return "Ocean"
                Case "2" : Return "ファオ帝国"
                Case "3" : Return "Tangerine"
                Case "4" : Return "Dragon"
                Case "5" : Return "Graphite"
                Case "6" : Return "Grape"
                Case "7" : Return "Sage"
                Case "8" : Return "チキン海賊団"
                Case "9" : Return "流星街"
            End Select
            Return "非公開"
        End Get
    End Property

    Public Property memo As String = String.Empty

End Class

<JsonObject()>
Public Class LandData

    Public Property land_type As String = String.Empty

    <JsonIgnore>
    Public ReadOnly Property land_name As String
        Get
            Select Case land_type
                Case "0" : Return "無所属"
                Case "1" : Return "Ocean"
                Case "2" : Return "ファオ帝国"
                Case "3" : Return "Tangerine"
                Case "4" : Return "Dragon"
                Case "5" : Return "Graphite"
                Case "6" : Return "Grape"
                Case "7" : Return "Sage"
                Case "8" : Return "チキン海賊団"
                Case "9" : Return "流星街"
            End Select
            Return "非公開"
        End Get
    End Property

    Public Property count As Integer = 0

End Class

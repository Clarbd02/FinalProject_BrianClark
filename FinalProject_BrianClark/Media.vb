Public Class Media

    'fields

    Public Property Title As String
    Public Property Format As String
    Public Property Catergory As String
    Public Property InitialValue As Double
    Public Property CurrentValue As Double
    Public Property ReleaseDate As Date

    Public Sub New(ByVal pTitle As String,
                   ByVal pFormat As String,
                   ByVal pCategory As String,
                   ByVal pInitialValue As Double,
                   ByVal pCurrentValue As Double,
                   ByVal pReleaseDate As Date)
        Title = pTitle
        Format = pFormat
        pCategory = pCategory
        InitialValue = pInitialValue
        CurrentValue = pCurrentValue
        ReleaseDate = pReleaseDate
    End Sub

End Class

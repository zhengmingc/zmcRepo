Imports System.Windows.Forms
Imports CommonSnappableTypes

<CompanyInfo(CompanyName:="VB Wenwen", CompanyUrl:="wenwenvb.com")>
Public Class VbSnapIn
    Implements IAppFunctionality

    Public Sub DoIt() Implements CommonSnappableTypes.IAppFunctionality.DoIt
        MessageBox.Show("You have just used vb application")
    End Sub

End Class

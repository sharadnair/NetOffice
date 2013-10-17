﻿Imports ExampleBase
Imports NetOffice
Imports PowerPoint = NetOffice.PowerPointApi
Imports NetOffice.PowerPointApi.Enums
Imports NetOffice.OfficeApi.Enums

Public Class Example01
    Implements IExample

    Dim _hostApplication As ExampleBase.IHost

#Region "IExample Member"

    Public Sub RunExample() Implements ExampleBase.IExample.RunExample

        ' start powerpoint
        Dim powerApplication As PowerPoint.Application = New PowerPoint.Application()

        ' add a new presentation with one new slide
        Dim presentation As PowerPoint.Presentation = powerApplication.Presentations.Add(MsoTriState.msoTrue)
        presentation.Slides.Add(1, PpSlideLayout.ppLayoutClipArtAndVerticalText)

        ' save the document 
        Dim fileExtension As String = GetDefaultExtension(powerApplication)
        Dim documentFile As String = String.Format("{0}\\Example01{1}", _hostApplication.RootDirectory, fileExtension)
        presentation.SaveAs(documentFile)

        ' close power point and dispose reference
        powerApplication.Quit()
        powerApplication.Dispose()

        ' show dialog for the user(you!)
        _hostApplication.ShowFinishDialog(Nothing, documentFile)

    End Sub

    Public ReadOnly Property Caption As String Implements ExampleBase.IExample.Caption
        Get
            Return IIf(_hostApplication.LCID = 1033, "Example01", "Beispiel01")
        End Get
    End Property

    Public ReadOnly Property Description As String Implements ExampleBase.IExample.Description
        Get
            Return IIf(_hostApplication.LCID = 1033, "Create a presentation with 1 empty slide", "Eine neue Präsentation erstellen")
        End Get
    End Property

    Public Sub Connect(ByVal hostApplication As ExampleBase.IHost) Implements ExampleBase.IExample.Connect

        _hostApplication = hostApplication

    End Sub

    Public ReadOnly Property Panel As System.Windows.Forms.UserControl Implements ExampleBase.IExample.Panel
        Get
            Return Nothing
        End Get
    End Property

#End Region

#Region "Helper"

    ''' <summary>
    ''' returns the valid file extension for the instance. for example ".ppt" or ".pptx"
    ''' </summary>
    ''' <param name="application">the instance</param>
    ''' <returns>the extension</returns>
    ''' <remarks></remarks>
    Private Function GetDefaultExtension(ByVal application As PowerPoint.Application) As String

        Dim version As Double = Convert.ToDouble(application.Version, CultureInfo.InvariantCulture)
        If (version >= 12.0) Then
            Return ".pptx"
        Else
            Return ".ppt"
        End If

    End Function

#End Region

End Class
Imports System
Imports System.Data
Imports System.Text
Imports System.Drawing
Imports System.Windows.Forms
Imports System.ComponentModel
Imports DevExpress.XtraScheduler
Imports System.Collections.Generic
Imports DevExpress.XtraScheduler.Drawing

Namespace QueryResourceColorSchema
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            AddResources()

            ' Get copies of color schemas that are curremnty used to paint resources.
            PrepareResourceColorSchemas()

            AddHandler schedulerControl1.LookAndFeel.StyleChanged, AddressOf LookAndFeel_StyleChanged
        End Sub

        Private Sub LookAndFeel_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
            ' Get copies of color schemas to be used to paint resources
            ' after the active skin has been changed.
            PrepareResourceColorSchemas()

            schedulerControl1.ActiveView.LayoutChanged()
        End Sub
        Private resourceColorSchemas As New Dictionary(Of Object, SchedulerColorSchema)()
        Protected ReadOnly Property Storage() As SchedulerStorage
            Get
                Return schedulerControl1.Storage
            End Get
        End Property
        Protected ReadOnly Property Resources() As ResourceStorage
            Get
                Return Storage.Resources
            End Get
        End Property

        Private Sub AddResources()
            Storage.BeginUpdate()
            For i As Integer = 0 To 9
                AddResource(i, "Resource_" & i.ToString())
            Next i
            Storage.EndUpdate()
        End Sub

        Private Sub AddResource(ByVal index As Integer, ByVal caption As String)
            Dim r As Resource = Storage.CreateResource(index.ToString())
            r.Caption = caption
            Resources.Add(r)
        End Sub

        Private Sub PrepareResourceColorSchemas()
            Me.resourceColorSchemas.Clear()
            Dim count As Integer = Resources.Count
            Dim currentColorSchemas As SchedulerColorSchemaCollection = schedulerControl1.GetResourceColorSchemasCopy()
            Dim schemaCount As Integer = currentColorSchemas.Count
            For i As Integer = 0 To count - 1
                Dim resource As Resource = schedulerControl1.Storage.Resources(i)
                Me.resourceColorSchemas.Add(resource.Id, currentColorSchemas(i Mod schemaCount))
            Next i
        End Sub
        Private Sub schedulerControl1_QueryResourceColorSchema(ByVal sender As Object, ByVal e As QueryResourceColorSchemaEventArgs) Handles schedulerControl1.QueryResourceColorSchema
            Dim key As Object = e.Resource.Id
            If Me.resourceColorSchemas.ContainsKey(key) Then
                e.ResourceColorSchema = Me.resourceColorSchemas(key)
            End If

            ' Specify the custom color schema for the selected resource 
            ' if there are more than one visible resources.
            If ShouldHighlightResource(e.Resource) Then
                e.ResourceColorSchema = New SchedulerColorSchema(Color.LightCyan)
            End If
        End Sub
        Protected Function ShouldHighlightResource(ByVal resource As Resource) As Boolean
            If schedulerControl1.ActiveView.GetResources().Count <= 1 Then
                Return False
            End If

            Return schedulerControl1.SelectedResource.Equals(resource)
        End Function
        Private selectedResource As Resource = ResourceEmpty.Resource
        Private Sub schedulerControl1_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles schedulerControl1.SelectionChanged
            If Not selectedResource.Equals(schedulerControl1.SelectedResource) Then
                selectedResource = schedulerControl1.SelectedResource
                schedulerControl1.ActiveView.LayoutChanged()
            End If

        End Sub
        Private Sub UpdateSkin(ByVal skinName As String)
            schedulerControl1.LookAndFeel.SkinName = skinName
        End Sub

        Private Sub radioButton2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbCaramel.CheckedChanged
            If DirectCast(sender, RadioButton).Checked Then
                UpdateSkin("Office 2010 Blue")
            End If
        End Sub

        Private Sub radioButton1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbDXStyle.CheckedChanged
            If DirectCast(sender, RadioButton).Checked Then
                UpdateSkin("DevExpress Style")
            End If
        End Sub
    End Class
End Namespace
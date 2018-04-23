Imports DevExpress.XtraScheduler
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SchedulerStorage1.Resources.Items.Add(1, "Resource One")
        Me.SchedulerStorage1.Resources.Items.Add(2, "Resource Two")
        Me.SchedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource
    End Sub


    Private Sub SchedulerControl1_EditAppointmentFormShowing(sender As Object, e As AppointmentFormEventArgs) Handles SchedulerControl1.EditAppointmentFormShowing
        Dim scheduler As DevExpress.XtraScheduler.SchedulerControl = CType(sender, DevExpress.XtraScheduler.SchedulerControl)
        Dim curCulture As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentUICulture
        System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("de")

        Dim form As SchedulerLocalizationExample_VB.OutlookAppointmentForm = New SchedulerLocalizationExample_VB.OutlookAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm)
        Try
            e.DialogResult = form.ShowDialog
            e.Handled = True
        Finally
            form.Dispose()
        End Try
        System.Threading.Thread.CurrentThread.CurrentUICulture = curCulture

    End Sub
End Class


'#Region "#MySchedulerLocalizer"
Friend Class MySchedulerLocalizer
    Inherits DevExpress.XtraScheduler.Localization.SchedulerLocalizer

    Public Overrides Function GetLocalizedString(ByVal id As DevExpress.XtraScheduler.Localization.SchedulerStringId) As String
        If id = DevExpress.XtraScheduler.Localization.SchedulerStringId.DateTimeAutoFormat_WithoutYear Then
            Return MyBase.GetLocalizedString(id)
        End If
        Return System.Enum.GetName(GetType(DevExpress.XtraScheduler.Localization.SchedulerStringId), id)
    End Function
End Class
'#End Region ' #MySchedulerLocalizer

'#Region "#MyDateNavigatorLocalizer"
Public Class MyDateNavigatorLocalizer
    Inherits DevExpress.XtraEditors.Controls.Localizer

    Public Overrides Function GetLocalizedString(ByVal id As DevExpress.XtraEditors.Controls.StringId) As String
        If id = DevExpress.XtraEditors.Controls.StringId.DateEditToday Then
            Return "Heute"
        End If
        If id = DevExpress.XtraEditors.Controls.StringId.DateEditClear Then
            Return "Löschen"
        End If
        Return MyBase.GetLocalizedString(id)
    End Function
End Class
'#End Region ' #MyDateNavigatorLocalizer
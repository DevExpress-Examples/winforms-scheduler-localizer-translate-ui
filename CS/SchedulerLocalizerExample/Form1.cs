using System;

namespace SchedulerStringIdExample {
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm {
        public Form1() {
            #region #ProgramRunLocalizer
            DevExpress.XtraScheduler.Localization.SchedulerLocalizer.Active = new MySchedulerLocalizer();
            DevExpress.XtraEditors.Controls.Localizer.Active = new MyDateNavigatorLocalizer();
            #endregion #ProgramRunLocalizer

            InitializeComponent();
            this.schedulerStorage1.Resources.Items.Add(1, "Resource One");
            this.schedulerStorage1.Resources.Items.Add(2, "Resource Two");
            this.schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource;
        }

        private void schedulerControl1_EditAppointmentFormShowing(object sender, DevExpress.XtraScheduler.AppointmentFormEventArgs e) {
            DevExpress.XtraScheduler.SchedulerControl scheduler = ((DevExpress.XtraScheduler.SchedulerControl)(sender));
            System.Globalization.CultureInfo curCulture = System.Threading.Thread.CurrentThread.CurrentUICulture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("de");
            SchedulerStringIdExample.OutlookAppointmentForm form = new SchedulerStringIdExample.OutlookAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm);
            try {
                e.DialogResult = form.ShowDialog();
                e.Handled = true;
            }
            finally {
                form.Dispose();
            }
            System.Threading.Thread.CurrentThread.CurrentUICulture = curCulture;
        }

    }
    #region #MySchedulerLocalizer
    class MySchedulerLocalizer : DevExpress.XtraScheduler.Localization.SchedulerLocalizer {
        public override string GetLocalizedString(DevExpress.XtraScheduler.Localization.SchedulerStringId id) {
            if (id == DevExpress.XtraScheduler.Localization.SchedulerStringId.DateTimeAutoFormat_WithoutYear) {
                return base.GetLocalizedString(id);
            }
            return Enum.GetName(typeof(DevExpress.XtraScheduler.Localization.SchedulerStringId), id);
        }
    }
    #endregion #MySchedulerLocalizer

    #region #MyDateNavigatorLocalizer
    public class MyDateNavigatorLocalizer : DevExpress.XtraEditors.Controls.Localizer {
        public override string GetLocalizedString(DevExpress.XtraEditors.Controls.StringId id) {
            if (id == DevExpress.XtraEditors.Controls.StringId.DateEditToday)
                return "Heute";
            if (id == DevExpress.XtraEditors.Controls.StringId.DateEditClear)
                return "Löschen";
            return base.GetLocalizedString(id);
        }
    }
    #endregion #MyDateNavigatorLocalizer
}

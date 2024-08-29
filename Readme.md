<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128635532/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T391865)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms Scheduler - Localize UI using the Localizer object

This example shows how to create a custom localizer object ([SchedulerLocalizer](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraScheduler.Localization.SchedulerLocalizer) descendant) to display custom resource strings. The example displays resource identifiers ([SchedulerStringId](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraScheduler.Localization.SchedulerStringId) enumeration members) instead of corresponding strings. This technique allows you to easily translate or rename our shipping resources on the fly (for example, titles, menu commands, messages, etc.).

![WinForms Scheduler - Localize UI using the Localizer object](https://raw.githubusercontent.com/DevExpress-Examples/how-to-localize-winforms-scheduler-ui-using-the-localizer-class-descendant-t391865/17.1.3+/media/f2d821dd-fe35-41ce-b343-03af26e3da38.png)


> **Note**
>
> Captions of UI elements displayed within built-in forms and dialogs (for example, an appointment edit form) cannot be localized with Localizer objects. This example creates a custom form to translate default captions to German.


## Files to Review

* [Form1.cs](./CS/SchedulerLocalizerExample/Form1.cs)


## Documentation

* [WinForms Localization](https://docs.devexpress.com/WindowsForms/2405/build-an-application/localization)
* [Localizing WinForms Controls with Localizer Objects](https://docs.devexpress.com/WindowsForms/1866/build-an-application/localization/localizing-winforms-controls-via-localizer-objects)
* [Localizing WinForms Controls with Satellite Resource Assemblies](https://docs.devexpress.com/WindowsForms/5755/build-an-application/localization/localizing-winforms-controls-via-satellite-resource-assemblies)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-scheduler-localizer-translate-ui&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-scheduler-localizer-translate-ui&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->

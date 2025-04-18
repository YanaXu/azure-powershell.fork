// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    public partial class MaterializationSettings :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMaterializationSettings,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMaterializationSettingsInternal
    {

        /// <summary>Internal Acessors for Notification</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.INotificationSetting Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMaterializationSettingsInternal.Notification { get => (this._notification = this._notification ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.NotificationSetting()); set { {_notification = value;} } }

        /// <summary>Internal Acessors for RecurrenceSchedule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IRecurrenceSchedule Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMaterializationSettingsInternal.RecurrenceSchedule { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IRecurrenceTriggerInternal)Schedule).Schedule; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IRecurrenceTriggerInternal)Schedule).Schedule = value; }

        /// <summary>Internal Acessors for Resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMaterializationComputeResource Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMaterializationSettingsInternal.Resource { get => (this._resource = this._resource ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.MaterializationComputeResource()); set { {_resource = value;} } }

        /// <summary>Internal Acessors for Schedule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IRecurrenceTrigger Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMaterializationSettingsInternal.Schedule { get => (this._schedule = this._schedule ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.RecurrenceTrigger()); set { {_schedule = value;} } }

        /// <summary>Backing field for <see cref="Notification" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.INotificationSetting _notification;

        /// <summary>Specifies the notification details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.INotificationSetting Notification { get => (this._notification = this._notification ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.NotificationSetting()); set => this._notification = value; }

        /// <summary>
        /// This is the email recipient list which has a limitation of 499 characters in total concat with comma separator
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public string[] NotificationEmail { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.INotificationSettingInternal)Notification).Email; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.INotificationSettingInternal)Notification).Email = value ?? null /* arrayOf */; }

        /// <summary>Send email notification to user on specified notification type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.EmailNotificationEnableType[] NotificationEmailOn { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.INotificationSettingInternal)Notification).EmailOn; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.INotificationSettingInternal)Notification).EmailOn = value ?? null /* arrayOf */; }

        /// <summary>
        /// Send webhook callback to a service. Key is a user-provided name for the webhook.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.INotificationSettingWebhooks NotificationWebhook { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.INotificationSettingInternal)Notification).Webhook; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.INotificationSettingInternal)Notification).Webhook = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="Resource" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMaterializationComputeResource _resource;

        /// <summary>Specifies the compute resource settings</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMaterializationComputeResource Resource { get => (this._resource = this._resource ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.MaterializationComputeResource()); set => this._resource = value; }

        /// <summary>Specifies the instance type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public string ResourceInstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMaterializationComputeResourceInternal)Resource).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMaterializationComputeResourceInternal)Resource).InstanceType = value ?? null; }

        /// <summary>Backing field for <see cref="Schedule" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IRecurrenceTrigger _schedule;

        /// <summary>Specifies the schedule details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IRecurrenceTrigger Schedule { get => (this._schedule = this._schedule ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.RecurrenceTrigger()); set => this._schedule = value; }

        /// <summary>
        /// Specifies end time of schedule in ISO 8601, but without a UTC offset. Refer https://en.wikipedia.org/wiki/ISO_8601.
        /// Recommented format would be "2022-06-01T00:00:01"
        /// If not present, the schedule will run indefinitely
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public string ScheduleEndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ITriggerBaseInternal)Schedule).EndTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ITriggerBaseInternal)Schedule).EndTime = value ?? null; }

        /// <summary>[Required] The frequency to trigger schedule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.RecurrenceFrequency? ScheduleFrequency { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IRecurrenceTriggerInternal)Schedule).Frequency; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IRecurrenceTriggerInternal)Schedule).Frequency = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.RecurrenceFrequency)""); }

        /// <summary>[Required] List of hours for the schedule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public int[] ScheduleHour { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IRecurrenceTriggerInternal)Schedule).ScheduleHour; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IRecurrenceTriggerInternal)Schedule).ScheduleHour = value ?? null /* arrayOf */; }

        /// <summary>[Required] Specifies schedule interval in conjunction with frequency</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public int? ScheduleInterval { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IRecurrenceTriggerInternal)Schedule).Interval; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IRecurrenceTriggerInternal)Schedule).Interval = value ?? default(int); }

        /// <summary>[Required] List of minutes for the schedule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public int[] ScheduleMinute { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IRecurrenceTriggerInternal)Schedule).ScheduleMinute; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IRecurrenceTriggerInternal)Schedule).ScheduleMinute = value ?? null /* arrayOf */; }

        /// <summary>List of month days for the schedule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public int[] ScheduleMonthDay { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IRecurrenceTriggerInternal)Schedule).ScheduleMonthDay; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IRecurrenceTriggerInternal)Schedule).ScheduleMonthDay = value ?? null /* arrayOf */; }

        /// <summary>Specifies start time of schedule in ISO 8601 format, but without a UTC offset.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public string ScheduleStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ITriggerBaseInternal)Schedule).StartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ITriggerBaseInternal)Schedule).StartTime = value ?? null; }

        /// <summary>
        /// Specifies time zone in which the schedule runs.
        /// TimeZone should follow Windows time zone format. Refer: https://docs.microsoft.com/en-us/windows-hardware/manufacture/desktop/default-time-zones?view=windows-11
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public string ScheduleTimeZone { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ITriggerBaseInternal)Schedule).TimeZone; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ITriggerBaseInternal)Schedule).TimeZone = value ?? null; }

        /// <summary>[Required]</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.TriggerType? ScheduleTriggerType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ITriggerBaseInternal)Schedule).TriggerType; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ITriggerBaseInternal)Schedule).TriggerType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.TriggerType)""); }

        /// <summary>List of days for the schedule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.WeekDay[] ScheduleWeekDay { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IRecurrenceTriggerInternal)Schedule).ScheduleWeekDay; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IRecurrenceTriggerInternal)Schedule).ScheduleWeekDay = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="SparkConfiguration" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMaterializationSettingsSparkConfiguration _sparkConfiguration;

        /// <summary>Specifies the spark compute settings</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMaterializationSettingsSparkConfiguration SparkConfiguration { get => (this._sparkConfiguration = this._sparkConfiguration ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.MaterializationSettingsSparkConfiguration()); set => this._sparkConfiguration = value; }

        /// <summary>Backing field for <see cref="StoreType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.MaterializationStoreType? _storeType;

        /// <summary>Specifies the stores to which materialization should happen</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.MaterializationStoreType? StoreType { get => this._storeType; set => this._storeType = value; }

        /// <summary>Creates an new <see cref="MaterializationSettings" /> instance.</summary>
        public MaterializationSettings()
        {

        }
    }
    public partial interface IMaterializationSettings :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable
    {
        /// <summary>
        /// This is the email recipient list which has a limitation of 499 characters in total concat with comma separator
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This is the email recipient list which has a limitation of 499 characters in total concat with comma separator",
        SerializedName = @"emails",
        PossibleTypes = new [] { typeof(string) })]
        string[] NotificationEmail { get; set; }
        /// <summary>Send email notification to user on specified notification type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Send email notification to user on specified notification type",
        SerializedName = @"emailOn",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.EmailNotificationEnableType) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.EmailNotificationEnableType[] NotificationEmailOn { get; set; }
        /// <summary>
        /// Send webhook callback to a service. Key is a user-provided name for the webhook.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Send webhook callback to a service. Key is a user-provided name for the webhook.",
        SerializedName = @"webhooks",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.INotificationSettingWebhooks) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.INotificationSettingWebhooks NotificationWebhook { get; set; }
        /// <summary>Specifies the instance type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the instance type",
        SerializedName = @"instanceType",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceInstanceType { get; set; }
        /// <summary>
        /// Specifies end time of schedule in ISO 8601, but without a UTC offset. Refer https://en.wikipedia.org/wiki/ISO_8601.
        /// Recommented format would be "2022-06-01T00:00:01"
        /// If not present, the schedule will run indefinitely
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies end time of schedule in ISO 8601, but without a UTC offset. Refer https://en.wikipedia.org/wiki/ISO_8601.
        Recommented format would be ""2022-06-01T00:00:01""
        If not present, the schedule will run indefinitely",
        SerializedName = @"endTime",
        PossibleTypes = new [] { typeof(string) })]
        string ScheduleEndTime { get; set; }
        /// <summary>[Required] The frequency to trigger schedule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"[Required] The frequency to trigger schedule.",
        SerializedName = @"frequency",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.RecurrenceFrequency) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.RecurrenceFrequency? ScheduleFrequency { get; set; }
        /// <summary>[Required] List of hours for the schedule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"[Required] List of hours for the schedule.",
        SerializedName = @"hours",
        PossibleTypes = new [] { typeof(int) })]
        int[] ScheduleHour { get; set; }
        /// <summary>[Required] Specifies schedule interval in conjunction with frequency</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"[Required] Specifies schedule interval in conjunction with frequency",
        SerializedName = @"interval",
        PossibleTypes = new [] { typeof(int) })]
        int? ScheduleInterval { get; set; }
        /// <summary>[Required] List of minutes for the schedule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"[Required] List of minutes for the schedule.",
        SerializedName = @"minutes",
        PossibleTypes = new [] { typeof(int) })]
        int[] ScheduleMinute { get; set; }
        /// <summary>List of month days for the schedule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of month days for the schedule",
        SerializedName = @"monthDays",
        PossibleTypes = new [] { typeof(int) })]
        int[] ScheduleMonthDay { get; set; }
        /// <summary>Specifies start time of schedule in ISO 8601 format, but without a UTC offset.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies start time of schedule in ISO 8601 format, but without a UTC offset.",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(string) })]
        string ScheduleStartTime { get; set; }
        /// <summary>
        /// Specifies time zone in which the schedule runs.
        /// TimeZone should follow Windows time zone format. Refer: https://docs.microsoft.com/en-us/windows-hardware/manufacture/desktop/default-time-zones?view=windows-11
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies time zone in which the schedule runs.
        TimeZone should follow Windows time zone format. Refer: https://docs.microsoft.com/en-us/windows-hardware/manufacture/desktop/default-time-zones?view=windows-11",
        SerializedName = @"timeZone",
        PossibleTypes = new [] { typeof(string) })]
        string ScheduleTimeZone { get; set; }
        /// <summary>[Required]</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"[Required] ",
        SerializedName = @"triggerType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.TriggerType) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.TriggerType? ScheduleTriggerType { get; set; }
        /// <summary>List of days for the schedule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of days for the schedule.",
        SerializedName = @"weekDays",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.WeekDay) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.WeekDay[] ScheduleWeekDay { get; set; }
        /// <summary>Specifies the spark compute settings</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the spark compute settings",
        SerializedName = @"sparkConfiguration",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMaterializationSettingsSparkConfiguration) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMaterializationSettingsSparkConfiguration SparkConfiguration { get; set; }
        /// <summary>Specifies the stores to which materialization should happen</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifies the stores to which materialization should happen",
        SerializedName = @"storeType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.MaterializationStoreType) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.MaterializationStoreType? StoreType { get; set; }

    }
    internal partial interface IMaterializationSettingsInternal

    {
        /// <summary>Specifies the notification details</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.INotificationSetting Notification { get; set; }
        /// <summary>
        /// This is the email recipient list which has a limitation of 499 characters in total concat with comma separator
        /// </summary>
        string[] NotificationEmail { get; set; }
        /// <summary>Send email notification to user on specified notification type</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.EmailNotificationEnableType[] NotificationEmailOn { get; set; }
        /// <summary>
        /// Send webhook callback to a service. Key is a user-provided name for the webhook.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.INotificationSettingWebhooks NotificationWebhook { get; set; }
        /// <summary>The recurrence schedule.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IRecurrenceSchedule RecurrenceSchedule { get; set; }
        /// <summary>Specifies the compute resource settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMaterializationComputeResource Resource { get; set; }
        /// <summary>Specifies the instance type</summary>
        string ResourceInstanceType { get; set; }
        /// <summary>Specifies the schedule details</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IRecurrenceTrigger Schedule { get; set; }
        /// <summary>
        /// Specifies end time of schedule in ISO 8601, but without a UTC offset. Refer https://en.wikipedia.org/wiki/ISO_8601.
        /// Recommented format would be "2022-06-01T00:00:01"
        /// If not present, the schedule will run indefinitely
        /// </summary>
        string ScheduleEndTime { get; set; }
        /// <summary>[Required] The frequency to trigger schedule.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.RecurrenceFrequency? ScheduleFrequency { get; set; }
        /// <summary>[Required] List of hours for the schedule.</summary>
        int[] ScheduleHour { get; set; }
        /// <summary>[Required] Specifies schedule interval in conjunction with frequency</summary>
        int? ScheduleInterval { get; set; }
        /// <summary>[Required] List of minutes for the schedule.</summary>
        int[] ScheduleMinute { get; set; }
        /// <summary>List of month days for the schedule</summary>
        int[] ScheduleMonthDay { get; set; }
        /// <summary>Specifies start time of schedule in ISO 8601 format, but without a UTC offset.</summary>
        string ScheduleStartTime { get; set; }
        /// <summary>
        /// Specifies time zone in which the schedule runs.
        /// TimeZone should follow Windows time zone format. Refer: https://docs.microsoft.com/en-us/windows-hardware/manufacture/desktop/default-time-zones?view=windows-11
        /// </summary>
        string ScheduleTimeZone { get; set; }
        /// <summary>[Required]</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.TriggerType? ScheduleTriggerType { get; set; }
        /// <summary>List of days for the schedule.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.WeekDay[] ScheduleWeekDay { get; set; }
        /// <summary>Specifies the spark compute settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IMaterializationSettingsSparkConfiguration SparkConfiguration { get; set; }
        /// <summary>Specifies the stores to which materialization should happen</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.MaterializationStoreType? StoreType { get; set; }

    }
}
// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Android Device Owner General Device Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AndroidDeviceOwnerGeneralDeviceConfiguration : DeviceConfiguration
    {
    
        /// <summary>
        /// Gets or sets accounts block modification.
        /// Indicates whether or not adding or removing accounts is disabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accountsBlockModification", Required = Newtonsoft.Json.Required.Default)]
        public bool? AccountsBlockModification { get; set; }
    
        /// <summary>
        /// Gets or sets apps allow install from unknown sources.
        /// Indicates whether or not the user is allowed to enable to unknown sources setting.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appsAllowInstallFromUnknownSources", Required = Newtonsoft.Json.Required.Default)]
        public bool? AppsAllowInstallFromUnknownSources { get; set; }
    
        /// <summary>
        /// Gets or sets apps auto update policy.
        /// Indicates the value of the app auto update policy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appsAutoUpdatePolicy", Required = Newtonsoft.Json.Required.Default)]
        public AndroidDeviceOwnerAppAutoUpdatePolicyType? AppsAutoUpdatePolicy { get; set; }
    
        /// <summary>
        /// Gets or sets apps default permission policy.
        /// Indicates the permission policy for requests for runtime permissions if one is not defined for the app specifically.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appsDefaultPermissionPolicy", Required = Newtonsoft.Json.Required.Default)]
        public AndroidDeviceOwnerDefaultAppPermissionPolicyType? AppsDefaultPermissionPolicy { get; set; }
    
        /// <summary>
        /// Gets or sets bluetooth block configuration.
        /// Indicates whether or not to block a user from configuring bluetooth.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bluetoothBlockConfiguration", Required = Newtonsoft.Json.Required.Default)]
        public bool? BluetoothBlockConfiguration { get; set; }
    
        /// <summary>
        /// Gets or sets bluetooth block contact sharing.
        /// Indicates whether or not to block a user from sharing contacts via bluetooth.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bluetoothBlockContactSharing", Required = Newtonsoft.Json.Required.Default)]
        public bool? BluetoothBlockContactSharing { get; set; }
    
        /// <summary>
        /// Gets or sets camera blocked.
        /// Indicates whether or not to disable the use of the camera.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cameraBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? CameraBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets cellular block wi fi tethering.
        /// Indicates whether or not to block Wi-Fi tethering.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cellularBlockWiFiTethering", Required = Newtonsoft.Json.Required.Default)]
        public bool? CellularBlockWiFiTethering { get; set; }
    
        /// <summary>
        /// Gets or sets data roaming blocked.
        /// Indicates whether or not to block a user from data roaming.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dataRoamingBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? DataRoamingBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets date time configuration blocked.
        /// Indicates whether or not to block the user from manually changing the date or time on the device
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dateTimeConfigurationBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? DateTimeConfigurationBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets factory reset device administrator emails.
        /// List of Google account emails that will be required to authenticate after a device is factory reset before it can be set up.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "factoryResetDeviceAdministratorEmails", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> FactoryResetDeviceAdministratorEmails { get; set; }
    
        /// <summary>
        /// Gets or sets factory reset blocked.
        /// Indicates whether or not the factory reset option in settings is disabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "factoryResetBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? FactoryResetBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets kiosk mode apps.
        /// A list of managed apps that will be shown when the device is in Kiosk Mode. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "kioskModeApps", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AppListItem> KioskModeApps { get; set; }
    
        /// <summary>
        /// Gets or sets microphone force mute.
        /// Indicates whether or not to block unmuting the microphone on the device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "microphoneForceMute", Required = Newtonsoft.Json.Required.Default)]
        public bool? MicrophoneForceMute { get; set; }
    
        /// <summary>
        /// Gets or sets network escape hatch allowed.
        /// Indicates whether or not the device will allow connecting to a temporary network connection at boot time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "networkEscapeHatchAllowed", Required = Newtonsoft.Json.Required.Default)]
        public bool? NetworkEscapeHatchAllowed { get; set; }
    
        /// <summary>
        /// Gets or sets nfc block outgoing beam.
        /// Indicates whether or not to block NFC outgoing beam.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "nfcBlockOutgoingBeam", Required = Newtonsoft.Json.Required.Default)]
        public bool? NfcBlockOutgoingBeam { get; set; }
    
        /// <summary>
        /// Gets or sets password block keyguard.
        /// Indicates whether or not the keyguard is disabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordBlockKeyguard", Required = Newtonsoft.Json.Required.Default)]
        public bool? PasswordBlockKeyguard { get; set; }
    
        /// <summary>
        /// Gets or sets password expiration days.
        /// Indicates the amount of time in seconds that a password can be set for before it expires and a new password will be required. Valid values 1 to 365
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordExpirationDays", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordExpirationDays { get; set; }
    
        /// <summary>
        /// Gets or sets password minimum length.
        /// Indicates the minimum length of the password required on the device. Valid values 4 to 16
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinimumLength", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinimumLength { get; set; }
    
        /// <summary>
        /// Gets or sets password minutes of inactivity before screen timeout.
        /// Milliseconds of inactivity before the screen times out.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinutesOfInactivityBeforeScreenTimeout", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinutesOfInactivityBeforeScreenTimeout { get; set; }
    
        /// <summary>
        /// Gets or sets password previous password count to block.
        /// Indicates the length of password history, where the user will not be able to enter a new password that is the same as any password in the history. Valid values 0 to 24
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordPreviousPasswordCountToBlock", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordPreviousPasswordCountToBlock { get; set; }
    
        /// <summary>
        /// Gets or sets password required type.
        /// Indicates the minimum password quality required on the device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordRequiredType", Required = Newtonsoft.Json.Required.Default)]
        public AndroidDeviceOwnerRequiredPasswordType? PasswordRequiredType { get; set; }
    
        /// <summary>
        /// Gets or sets password sign in failure count before factory reset.
        /// Indicates the number of times a user can enter an incorrect password before the device is wiped. Valid values 4 to 11
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordSignInFailureCountBeforeFactoryReset", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordSignInFailureCountBeforeFactoryReset { get; set; }
    
        /// <summary>
        /// Gets or sets safe boot blocked.
        /// Indicates whether or not rebooting the device into safe boot is disabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "safeBootBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? SafeBootBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets screen capture blocked.
        /// Indicates whether or not to disable the capability to take screenshots.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "screenCaptureBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? ScreenCaptureBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets security allow debugging features.
        /// Indicates whether or not to block the user from enabling debugging features on the device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "securityAllowDebuggingFeatures", Required = Newtonsoft.Json.Required.Default)]
        public bool? SecurityAllowDebuggingFeatures { get; set; }
    
        /// <summary>
        /// Gets or sets security require verify apps.
        /// Indicates whether or not verify apps is required.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "securityRequireVerifyApps", Required = Newtonsoft.Json.Required.Default)]
        public bool? SecurityRequireVerifyApps { get; set; }
    
        /// <summary>
        /// Gets or sets status bar blocked.
        /// Indicates whether or the status bar is disabled, including notifications, quick settings and other screen overlays.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "statusBarBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? StatusBarBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets stay on modes.
        /// List of modes in which the device's display will stay powered-on. This collection can contain a maximum of 4 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "stayOnModes", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AndroidDeviceOwnerBatteryPluggedMode> StayOnModes { get; set; }
    
        /// <summary>
        /// Gets or sets storage allow usb.
        /// Indicates whether or not to allow USB mass storage.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "storageAllowUsb", Required = Newtonsoft.Json.Required.Default)]
        public bool? StorageAllowUsb { get; set; }
    
        /// <summary>
        /// Gets or sets storage block external media.
        /// Indicates whether or not to block external media.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "storageBlockExternalMedia", Required = Newtonsoft.Json.Required.Default)]
        public bool? StorageBlockExternalMedia { get; set; }
    
        /// <summary>
        /// Gets or sets storage block usb file transfer.
        /// Indicates whether or not to block USB file transfer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "storageBlockUsbFileTransfer", Required = Newtonsoft.Json.Required.Default)]
        public bool? StorageBlockUsbFileTransfer { get; set; }
    
        /// <summary>
        /// Gets or sets system update window start minutes after midnight.
        /// Indicates the number of minutes after midnight that the system update window starts. Valid values 0 to 1440
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "systemUpdateWindowStartMinutesAfterMidnight", Required = Newtonsoft.Json.Required.Default)]
        public Int32? SystemUpdateWindowStartMinutesAfterMidnight { get; set; }
    
        /// <summary>
        /// Gets or sets system update window end minutes after midnight.
        /// Indicates the number of minutes after midnight that the system update window ends. Valid values 0 to 1440
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "systemUpdateWindowEndMinutesAfterMidnight", Required = Newtonsoft.Json.Required.Default)]
        public Int32? SystemUpdateWindowEndMinutesAfterMidnight { get; set; }
    
        /// <summary>
        /// Gets or sets system update install type.
        /// The type of system update configuration.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "systemUpdateInstallType", Required = Newtonsoft.Json.Required.Default)]
        public AndroidDeviceOwnerSystemUpdateInstallType? SystemUpdateInstallType { get; set; }
    
        /// <summary>
        /// Gets or sets users block add.
        /// Indicates whether or not adding users and profiles is disabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "usersBlockAdd", Required = Newtonsoft.Json.Required.Default)]
        public bool? UsersBlockAdd { get; set; }
    
        /// <summary>
        /// Gets or sets users block remove.
        /// Indicates whether or not to disable removing other users from the device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "usersBlockRemove", Required = Newtonsoft.Json.Required.Default)]
        public bool? UsersBlockRemove { get; set; }
    
        /// <summary>
        /// Gets or sets volume block adjustment.
        /// Indicates whether or not adjusting the master volume is disabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "volumeBlockAdjustment", Required = Newtonsoft.Json.Required.Default)]
        public bool? VolumeBlockAdjustment { get; set; }
    
        /// <summary>
        /// Gets or sets wifi block edit configurations.
        /// Indicates whether or not to block the user from editing the wifi connection settings.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "wifiBlockEditConfigurations", Required = Newtonsoft.Json.Required.Default)]
        public bool? WifiBlockEditConfigurations { get; set; }
    
        /// <summary>
        /// Gets or sets wifi block edit policy defined configurations.
        /// Indicates whether or not to block the user from editing just the networks defined by the policy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "wifiBlockEditPolicyDefinedConfigurations", Required = Newtonsoft.Json.Required.Default)]
        public bool? WifiBlockEditPolicyDefinedConfigurations { get; set; }
    
    }
}


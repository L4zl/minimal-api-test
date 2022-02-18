﻿using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class MsmSetting
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        public long MsmSettingId { get; set; }
        /// <summary>
        /// Should the desktop lists be refreshed automatically by other dialogs?
        /// </summary>
        public bool RefreshDesktopLists { get; set; }
        /// <summary>
        /// Is the Label Editor active?  If it is, labels can be customised.
        /// </summary>
        public bool LabelEditorActive { get; set; }
        /// <summary>
        /// Should customised values be displayed?
        /// </summary>
        public bool LabelEditorUseCustomisedValues { get; set; }
        /// <summary>
        /// Major Version Number
        /// </summary>
        public short? VersionMajor { get; set; }
        /// <summary>
        /// Minor Version Number
        /// </summary>
        public short? VersionMinor { get; set; }
        /// <summary>
        /// Build Number
        /// </summary>
        public short? VersionBuild { get; set; }
        /// <summary>
        /// Revision Number
        /// </summary>
        public short? VersionRevision { get; set; }
        /// <summary>
        /// Should the toolbar be visible on independent dialogs?
        /// </summary>
        public bool ShowIndependentDialogToolbar { get; set; }
        /// <summary>
        /// Should the footer buttons be visible on independent dialogs?
        /// </summary>
        public bool? ShowIndependentDialogFooterButtons { get; set; }
        /// <summary>
        /// Is Feature Area Logging enabled?
        /// </summary>
        public bool? FeatureAreaLoggingActive { get; set; }
        /// <summary>
        /// Is the Usage Log being updated?
        /// </summary>
        public bool? UsageLogActive { get; set; }
        public bool ShowSmartLinkButtons { get; set; }
        public short SequenceDecimalPlaces { get; set; }
        public bool PersistToolbarSettings { get; set; }
        public bool? PerformCompatibilityCheck { get; set; }
        /// <summary>
        /// Required by ObjectStore
        /// </summary>
        public byte[] OpLock { get; set; } = null!;
        /// <summary>
        /// GetDate()
        /// </summary>
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}

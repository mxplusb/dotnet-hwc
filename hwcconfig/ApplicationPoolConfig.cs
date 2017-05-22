namespace hwcconfig
{
    /// THIS IS GENERATED CODE. DO NOT EDIT.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class configuration
    {

        private configurationSectionGroup[] configSectionsField;

        private configurationConfigProtectedData configProtectedDataField;

        private configurationSystemapplicationHost systemapplicationHostField;

        private configurationSystemwebServer[] systemwebServerField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("sectionGroup", IsNullable = false)]
        public configurationSectionGroup[] configSections
        {
            get
            {
                return this.configSectionsField;
            }
            set
            {
                this.configSectionsField = value;
            }
        }

        /// <remarks/>
        public configurationConfigProtectedData configProtectedData
        {
            get
            {
                return this.configProtectedDataField;
            }
            set
            {
                this.configProtectedDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("system.applicationHost")]
        public configurationSystemapplicationHost systemapplicationHost
        {
            get
            {
                return this.systemapplicationHostField;
            }
            set
            {
                this.systemapplicationHostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("system.webServer")]
        public configurationSystemwebServer[] systemwebServer
        {
            get
            {
                return this.systemwebServerField;
            }
            set
            {
                this.systemwebServerField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSectionGroup
    {

        private object[] itemsField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("section", typeof(configurationSectionGroupSection))]
        [System.Xml.Serialization.XmlElementAttribute("sectionGroup", typeof(configurationSectionGroupSectionGroup))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSectionGroupSection
    {

        private string nameField;

        private string allowDefinitionField;

        private string overrideModeDefaultField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string allowDefinition
        {
            get
            {
                return this.allowDefinitionField;
            }
            set
            {
                this.allowDefinitionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string overrideModeDefault
        {
            get
            {
                return this.overrideModeDefaultField;
            }
            set
            {
                this.overrideModeDefaultField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSectionGroupSectionGroup
    {

        private object[] itemsField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("section", typeof(configurationSectionGroupSectionGroupSection))]
        [System.Xml.Serialization.XmlElementAttribute("sectionGroup", typeof(configurationSectionGroupSectionGroupSectionGroup))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSectionGroupSectionGroupSection
    {

        private string nameField;

        private string overrideModeDefaultField;

        private string allowDefinitionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string overrideModeDefault
        {
            get
            {
                return this.overrideModeDefaultField;
            }
            set
            {
                this.overrideModeDefaultField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string allowDefinition
        {
            get
            {
                return this.allowDefinitionField;
            }
            set
            {
                this.allowDefinitionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSectionGroupSectionGroupSectionGroup
    {

        private configurationSectionGroupSectionGroupSectionGroupSection[] sectionField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("section")]
        public configurationSectionGroupSectionGroupSectionGroupSection[] section
        {
            get
            {
                return this.sectionField;
            }
            set
            {
                this.sectionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSectionGroupSectionGroupSectionGroupSection
    {

        private string nameField;

        private string overrideModeDefaultField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string overrideModeDefault
        {
            get
            {
                return this.overrideModeDefaultField;
            }
            set
            {
                this.overrideModeDefaultField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationConfigProtectedData
    {

        private configurationConfigProtectedDataAdd[] providersField;

        private string defaultProviderField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("add", IsNullable = false)]
        public configurationConfigProtectedDataAdd[] providers
        {
            get
            {
                return this.providersField;
            }
            set
            {
                this.providersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string defaultProvider
        {
            get
            {
                return this.defaultProviderField;
            }
            set
            {
                this.defaultProviderField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationConfigProtectedDataAdd
    {

        private string nameField;

        private string typeField;

        private string descriptionField;

        private string keyContainerNameField;

        private string cspProviderNameField;

        private bool useMachineContainerField;

        private bool useOAEPField;

        private string sessionKeyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string keyContainerName
        {
            get
            {
                return this.keyContainerNameField;
            }
            set
            {
                this.keyContainerNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cspProviderName
        {
            get
            {
                return this.cspProviderNameField;
            }
            set
            {
                this.cspProviderNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool useMachineContainer
        {
            get
            {
                return this.useMachineContainerField;
            }
            set
            {
                this.useMachineContainerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool useOAEP
        {
            get
            {
                return this.useOAEPField;
            }
            set
            {
                this.useOAEPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string sessionKey
        {
            get
            {
                return this.sessionKeyField;
            }
            set
            {
                this.sessionKeyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemapplicationHost
    {

        private configurationSystemapplicationHostApplicationPools applicationPoolsField;

        private configurationSystemapplicationHostListenerAdapters listenerAdaptersField;

        private configurationSystemapplicationHostSites sitesField;

        private object webLimitsField;

        /// <remarks/>
        public configurationSystemapplicationHostApplicationPools applicationPools
        {
            get
            {
                return this.applicationPoolsField;
            }
            set
            {
                this.applicationPoolsField = value;
            }
        }

        /// <remarks/>
        public configurationSystemapplicationHostListenerAdapters listenerAdapters
        {
            get
            {
                return this.listenerAdaptersField;
            }
            set
            {
                this.listenerAdaptersField = value;
            }
        }

        /// <remarks/>
        public configurationSystemapplicationHostSites sites
        {
            get
            {
                return this.sitesField;
            }
            set
            {
                this.sitesField = value;
            }
        }

        /// <remarks/>
        public object webLimits
        {
            get
            {
                return this.webLimitsField;
            }
            set
            {
                this.webLimitsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemapplicationHostApplicationPools
    {

        private configurationSystemapplicationHostApplicationPoolsAdd addField;

        /// <remarks/>
        public configurationSystemapplicationHostApplicationPoolsAdd add
        {
            get
            {
                return this.addField;
            }
            set
            {
                this.addField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemapplicationHostApplicationPoolsAdd
    {

        private string nameField;

        private string managedRuntimeVersionField;

        private string managedPipelineModeField;

        private string cLRConfigFileField;

        private bool autoStartField;

        private string startModeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string managedRuntimeVersion
        {
            get
            {
                return this.managedRuntimeVersionField;
            }
            set
            {
                this.managedRuntimeVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string managedPipelineMode
        {
            get
            {
                return this.managedPipelineModeField;
            }
            set
            {
                this.managedPipelineModeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CLRConfigFile
        {
            get
            {
                return this.cLRConfigFileField;
            }
            set
            {
                this.cLRConfigFileField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool autoStart
        {
            get
            {
                return this.autoStartField;
            }
            set
            {
                this.autoStartField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string startMode
        {
            get
            {
                return this.startModeField;
            }
            set
            {
                this.startModeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemapplicationHostListenerAdapters
    {

        private configurationSystemapplicationHostListenerAdaptersAdd addField;

        /// <remarks/>
        public configurationSystemapplicationHostListenerAdaptersAdd add
        {
            get
            {
                return this.addField;
            }
            set
            {
                this.addField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemapplicationHostListenerAdaptersAdd
    {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemapplicationHostSites
    {

        private configurationSystemapplicationHostSitesSiteDefaults siteDefaultsField;

        private configurationSystemapplicationHostSitesApplicationDefaults applicationDefaultsField;

        private configurationSystemapplicationHostSitesVirtualDirectoryDefaults virtualDirectoryDefaultsField;

        private configurationSystemapplicationHostSitesSite siteField;

        /// <remarks/>
        public configurationSystemapplicationHostSitesSiteDefaults siteDefaults
        {
            get
            {
                return this.siteDefaultsField;
            }
            set
            {
                this.siteDefaultsField = value;
            }
        }

        /// <remarks/>
        public configurationSystemapplicationHostSitesApplicationDefaults applicationDefaults
        {
            get
            {
                return this.applicationDefaultsField;
            }
            set
            {
                this.applicationDefaultsField = value;
            }
        }

        /// <remarks/>
        public configurationSystemapplicationHostSitesVirtualDirectoryDefaults virtualDirectoryDefaults
        {
            get
            {
                return this.virtualDirectoryDefaultsField;
            }
            set
            {
                this.virtualDirectoryDefaultsField = value;
            }
        }

        /// <remarks/>
        public configurationSystemapplicationHostSitesSite site
        {
            get
            {
                return this.siteField;
            }
            set
            {
                this.siteField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemapplicationHostSitesSiteDefaults
    {

        private configurationSystemapplicationHostSitesSiteDefaultsLogFile logFileField;

        private configurationSystemapplicationHostSitesSiteDefaultsTraceFailedRequestsLogging traceFailedRequestsLoggingField;

        /// <remarks/>
        public configurationSystemapplicationHostSitesSiteDefaultsLogFile logFile
        {
            get
            {
                return this.logFileField;
            }
            set
            {
                this.logFileField = value;
            }
        }

        /// <remarks/>
        public configurationSystemapplicationHostSitesSiteDefaultsTraceFailedRequestsLogging traceFailedRequestsLogging
        {
            get
            {
                return this.traceFailedRequestsLoggingField;
            }
            set
            {
                this.traceFailedRequestsLoggingField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemapplicationHostSitesSiteDefaultsLogFile
    {

        private string logFormatField;

        private string directoryField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string logFormat
        {
            get
            {
                return this.logFormatField;
            }
            set
            {
                this.logFormatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string directory
        {
            get
            {
                return this.directoryField;
            }
            set
            {
                this.directoryField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemapplicationHostSitesSiteDefaultsTraceFailedRequestsLogging
    {

        private bool enabledField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool enabled
        {
            get
            {
                return this.enabledField;
            }
            set
            {
                this.enabledField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemapplicationHostSitesApplicationDefaults
    {

        private string applicationPoolField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string applicationPool
        {
            get
            {
                return this.applicationPoolField;
            }
            set
            {
                this.applicationPoolField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemapplicationHostSitesVirtualDirectoryDefaults
    {

        private bool allowSubDirConfigField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool allowSubDirConfig
        {
            get
            {
                return this.allowSubDirConfigField;
            }
            set
            {
                this.allowSubDirConfigField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemapplicationHostSitesSite
    {

        private configurationSystemapplicationHostSitesSiteApplication applicationField;

        private configurationSystemapplicationHostSitesSiteBindings bindingsField;

        private string nameField;

        private byte idField;

        private bool serverAutoStartField;

        /// <remarks/>
        public configurationSystemapplicationHostSitesSiteApplication application
        {
            get
            {
                return this.applicationField;
            }
            set
            {
                this.applicationField = value;
            }
        }

        /// <remarks/>
        public configurationSystemapplicationHostSitesSiteBindings bindings
        {
            get
            {
                return this.bindingsField;
            }
            set
            {
                this.bindingsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool serverAutoStart
        {
            get
            {
                return this.serverAutoStartField;
            }
            set
            {
                this.serverAutoStartField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemapplicationHostSitesSiteApplication
    {

        private configurationSystemapplicationHostSitesSiteApplicationVirtualDirectory virtualDirectoryField;

        private string pathField;

        private string applicationPoolField;

        /// <remarks/>
        public configurationSystemapplicationHostSitesSiteApplicationVirtualDirectory virtualDirectory
        {
            get
            {
                return this.virtualDirectoryField;
            }
            set
            {
                this.virtualDirectoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string path
        {
            get
            {
                return this.pathField;
            }
            set
            {
                this.pathField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string applicationPool
        {
            get
            {
                return this.applicationPoolField;
            }
            set
            {
                this.applicationPoolField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemapplicationHostSitesSiteApplicationVirtualDirectory
    {

        private string pathField;

        private string physicalPathField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string path
        {
            get
            {
                return this.pathField;
            }
            set
            {
                this.pathField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string physicalPath
        {
            get
            {
                return this.physicalPathField;
            }
            set
            {
                this.physicalPathField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemapplicationHostSitesSiteBindings
    {

        private configurationSystemapplicationHostSitesSiteBindingsBinding bindingField;

        /// <remarks/>
        public configurationSystemapplicationHostSitesSiteBindingsBinding binding
        {
            get
            {
                return this.bindingField;
            }
            set
            {
                this.bindingField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemapplicationHostSitesSiteBindingsBinding
    {

        private string protocolField;

        private string bindingInformationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string protocol
        {
            get
            {
                return this.protocolField;
            }
            set
            {
                this.protocolField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string bindingInformation
        {
            get
            {
                return this.bindingInformationField;
            }
            set
            {
                this.bindingInformationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServer
    {

        private configurationSystemwebServerAdd[] modulesField;

        private configurationSystemwebServerHandlers handlersField;

        private object aspField;

        private configurationSystemwebServerCaching cachingField;

        private object cgiField;

        private configurationSystemwebServerDefaultDocument defaultDocumentField;

        private configurationSystemwebServerDirectoryBrowse directoryBrowseField;

        private object fastCgiField;

        private configurationSystemwebServerGlobalModules globalModulesField;

        private configurationSystemwebServerHttpCompression httpCompressionField;

        private configurationSystemwebServerHttpErrors httpErrorsField;

        private configurationSystemwebServerHttpLogging httpLoggingField;

        private configurationSystemwebServerHttpProtocol httpProtocolField;

        private object httpRedirectField;

        private object httpTracingField;

        private configurationSystemwebServerFilter[] isapiFiltersField;

        private object odbcLoggingField;

        private configurationSystemwebServerSecurity securityField;

        private object serverRuntimeField;

        private object serverSideIncludeField;

        private configurationSystemwebServerStaticContent staticContentField;

        private configurationSystemwebServerTracing tracingField;

        private object urlCompressionField;

        private object validationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("add", IsNullable = false)]
        public configurationSystemwebServerAdd[] modules
        {
            get
            {
                return this.modulesField;
            }
            set
            {
                this.modulesField = value;
            }
        }

        /// <remarks/>
        public configurationSystemwebServerHandlers handlers
        {
            get
            {
                return this.handlersField;
            }
            set
            {
                this.handlersField = value;
            }
        }

        /// <remarks/>
        public object asp
        {
            get
            {
                return this.aspField;
            }
            set
            {
                this.aspField = value;
            }
        }

        /// <remarks/>
        public configurationSystemwebServerCaching caching
        {
            get
            {
                return this.cachingField;
            }
            set
            {
                this.cachingField = value;
            }
        }

        /// <remarks/>
        public object cgi
        {
            get
            {
                return this.cgiField;
            }
            set
            {
                this.cgiField = value;
            }
        }

        /// <remarks/>
        public configurationSystemwebServerDefaultDocument defaultDocument
        {
            get
            {
                return this.defaultDocumentField;
            }
            set
            {
                this.defaultDocumentField = value;
            }
        }

        /// <remarks/>
        public configurationSystemwebServerDirectoryBrowse directoryBrowse
        {
            get
            {
                return this.directoryBrowseField;
            }
            set
            {
                this.directoryBrowseField = value;
            }
        }

        /// <remarks/>
        public object fastCgi
        {
            get
            {
                return this.fastCgiField;
            }
            set
            {
                this.fastCgiField = value;
            }
        }

        /// <remarks/>
        public configurationSystemwebServerGlobalModules globalModules
        {
            get
            {
                return this.globalModulesField;
            }
            set
            {
                this.globalModulesField = value;
            }
        }

        /// <remarks/>
        public configurationSystemwebServerHttpCompression httpCompression
        {
            get
            {
                return this.httpCompressionField;
            }
            set
            {
                this.httpCompressionField = value;
            }
        }

        /// <remarks/>
        public configurationSystemwebServerHttpErrors httpErrors
        {
            get
            {
                return this.httpErrorsField;
            }
            set
            {
                this.httpErrorsField = value;
            }
        }

        /// <remarks/>
        public configurationSystemwebServerHttpLogging httpLogging
        {
            get
            {
                return this.httpLoggingField;
            }
            set
            {
                this.httpLoggingField = value;
            }
        }

        /// <remarks/>
        public configurationSystemwebServerHttpProtocol httpProtocol
        {
            get
            {
                return this.httpProtocolField;
            }
            set
            {
                this.httpProtocolField = value;
            }
        }

        /// <remarks/>
        public object httpRedirect
        {
            get
            {
                return this.httpRedirectField;
            }
            set
            {
                this.httpRedirectField = value;
            }
        }

        /// <remarks/>
        public object httpTracing
        {
            get
            {
                return this.httpTracingField;
            }
            set
            {
                this.httpTracingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("filter", IsNullable = false)]
        public configurationSystemwebServerFilter[] isapiFilters
        {
            get
            {
                return this.isapiFiltersField;
            }
            set
            {
                this.isapiFiltersField = value;
            }
        }

        /// <remarks/>
        public object odbcLogging
        {
            get
            {
                return this.odbcLoggingField;
            }
            set
            {
                this.odbcLoggingField = value;
            }
        }

        /// <remarks/>
        public configurationSystemwebServerSecurity security
        {
            get
            {
                return this.securityField;
            }
            set
            {
                this.securityField = value;
            }
        }

        /// <remarks/>
        public object serverRuntime
        {
            get
            {
                return this.serverRuntimeField;
            }
            set
            {
                this.serverRuntimeField = value;
            }
        }

        /// <remarks/>
        public object serverSideInclude
        {
            get
            {
                return this.serverSideIncludeField;
            }
            set
            {
                this.serverSideIncludeField = value;
            }
        }

        /// <remarks/>
        public configurationSystemwebServerStaticContent staticContent
        {
            get
            {
                return this.staticContentField;
            }
            set
            {
                this.staticContentField = value;
            }
        }

        /// <remarks/>
        public configurationSystemwebServerTracing tracing
        {
            get
            {
                return this.tracingField;
            }
            set
            {
                this.tracingField = value;
            }
        }

        /// <remarks/>
        public object urlCompression
        {
            get
            {
                return this.urlCompressionField;
            }
            set
            {
                this.urlCompressionField = value;
            }
        }

        /// <remarks/>
        public object validation
        {
            get
            {
                return this.validationField;
            }
            set
            {
                this.validationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerAdd
    {

        private string nameField;

        private bool lockItemField;

        private bool lockItemFieldSpecified;

        private string typeField;

        private string preConditionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool lockItem
        {
            get
            {
                return this.lockItemField;
            }
            set
            {
                this.lockItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lockItemSpecified
        {
            get
            {
                return this.lockItemFieldSpecified;
            }
            set
            {
                this.lockItemFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string preCondition
        {
            get
            {
                return this.preConditionField;
            }
            set
            {
                this.preConditionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerHandlers
    {

        private configurationSystemwebServerHandlersAdd[] addField;

        private string accessPolicyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("add")]
        public configurationSystemwebServerHandlersAdd[] add
        {
            get
            {
                return this.addField;
            }
            set
            {
                this.addField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string accessPolicy
        {
            get
            {
                return this.accessPolicyField;
            }
            set
            {
                this.accessPolicyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerHandlersAdd
    {

        private string nameField;

        private string pathField;

        private string verbField;

        private string modulesField;

        private string scriptProcessorField;

        private string resourceTypeField;

        private string requireAccessField;

        private bool allowPathInfoField;

        private bool allowPathInfoFieldSpecified;

        private string preConditionField;

        private byte responseBufferLimitField;

        private bool responseBufferLimitFieldSpecified;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string path
        {
            get
            {
                return this.pathField;
            }
            set
            {
                this.pathField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string verb
        {
            get
            {
                return this.verbField;
            }
            set
            {
                this.verbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string modules
        {
            get
            {
                return this.modulesField;
            }
            set
            {
                this.modulesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string scriptProcessor
        {
            get
            {
                return this.scriptProcessorField;
            }
            set
            {
                this.scriptProcessorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string resourceType
        {
            get
            {
                return this.resourceTypeField;
            }
            set
            {
                this.resourceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string requireAccess
        {
            get
            {
                return this.requireAccessField;
            }
            set
            {
                this.requireAccessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool allowPathInfo
        {
            get
            {
                return this.allowPathInfoField;
            }
            set
            {
                this.allowPathInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool allowPathInfoSpecified
        {
            get
            {
                return this.allowPathInfoFieldSpecified;
            }
            set
            {
                this.allowPathInfoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string preCondition
        {
            get
            {
                return this.preConditionField;
            }
            set
            {
                this.preConditionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte responseBufferLimit
        {
            get
            {
                return this.responseBufferLimitField;
            }
            set
            {
                this.responseBufferLimitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool responseBufferLimitSpecified
        {
            get
            {
                return this.responseBufferLimitFieldSpecified;
            }
            set
            {
                this.responseBufferLimitFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerCaching
    {

        private bool enabledField;

        private bool enableKernelCacheField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool enabled
        {
            get
            {
                return this.enabledField;
            }
            set
            {
                this.enabledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool enableKernelCache
        {
            get
            {
                return this.enableKernelCacheField;
            }
            set
            {
                this.enableKernelCacheField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerDefaultDocument
    {

        private configurationSystemwebServerDefaultDocumentAdd[] filesField;

        private bool enabledField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("add", IsNullable = false)]
        public configurationSystemwebServerDefaultDocumentAdd[] files
        {
            get
            {
                return this.filesField;
            }
            set
            {
                this.filesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool enabled
        {
            get
            {
                return this.enabledField;
            }
            set
            {
                this.enabledField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerDefaultDocumentAdd
    {

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerDirectoryBrowse
    {

        private bool enabledField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool enabled
        {
            get
            {
                return this.enabledField;
            }
            set
            {
                this.enabledField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerGlobalModules
    {

        private configurationSystemwebServerGlobalModulesAdd addField;

        /// <remarks/>
        public configurationSystemwebServerGlobalModulesAdd add
        {
            get
            {
                return this.addField;
            }
            set
            {
                this.addField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerGlobalModulesAdd
    {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerHttpCompression
    {

        private configurationSystemwebServerHttpCompressionScheme schemeField;

        private configurationSystemwebServerHttpCompressionAdd[] staticTypesField;

        private configurationSystemwebServerHttpCompressionAdd1[] dynamicTypesField;

        private string directoryField;

        /// <remarks/>
        public configurationSystemwebServerHttpCompressionScheme scheme
        {
            get
            {
                return this.schemeField;
            }
            set
            {
                this.schemeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("add", IsNullable = false)]
        public configurationSystemwebServerHttpCompressionAdd[] staticTypes
        {
            get
            {
                return this.staticTypesField;
            }
            set
            {
                this.staticTypesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("add", IsNullable = false)]
        public configurationSystemwebServerHttpCompressionAdd1[] dynamicTypes
        {
            get
            {
                return this.dynamicTypesField;
            }
            set
            {
                this.dynamicTypesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string directory
        {
            get
            {
                return this.directoryField;
            }
            set
            {
                this.directoryField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerHttpCompressionScheme
    {

        private string nameField;

        private string dllField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dll
        {
            get
            {
                return this.dllField;
            }
            set
            {
                this.dllField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerHttpCompressionAdd
    {

        private string mimeTypeField;

        private bool enabledField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string mimeType
        {
            get
            {
                return this.mimeTypeField;
            }
            set
            {
                this.mimeTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool enabled
        {
            get
            {
                return this.enabledField;
            }
            set
            {
                this.enabledField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerHttpCompressionAdd1
    {

        private string mimeTypeField;

        private bool enabledField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string mimeType
        {
            get
            {
                return this.mimeTypeField;
            }
            set
            {
                this.mimeTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool enabled
        {
            get
            {
                return this.enabledField;
            }
            set
            {
                this.enabledField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerHttpErrors
    {

        private configurationSystemwebServerHttpErrorsError[] errorField;

        private string lockAttributesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("error")]
        public configurationSystemwebServerHttpErrorsError[] error
        {
            get
            {
                return this.errorField;
            }
            set
            {
                this.errorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lockAttributes
        {
            get
            {
                return this.lockAttributesField;
            }
            set
            {
                this.lockAttributesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerHttpErrorsError
    {

        private ushort statusCodeField;

        private string prefixLanguageFilePathField;

        private string pathField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort statusCode
        {
            get
            {
                return this.statusCodeField;
            }
            set
            {
                this.statusCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string prefixLanguageFilePath
        {
            get
            {
                return this.prefixLanguageFilePathField;
            }
            set
            {
                this.prefixLanguageFilePathField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string path
        {
            get
            {
                return this.pathField;
            }
            set
            {
                this.pathField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerHttpLogging
    {

        private bool dontLogField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool dontLog
        {
            get
            {
                return this.dontLogField;
            }
            set
            {
                this.dontLogField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerHttpProtocol
    {

        private configurationSystemwebServerHttpProtocolCustomHeaders customHeadersField;

        private configurationSystemwebServerHttpProtocolRedirectHeaders redirectHeadersField;

        /// <remarks/>
        public configurationSystemwebServerHttpProtocolCustomHeaders customHeaders
        {
            get
            {
                return this.customHeadersField;
            }
            set
            {
                this.customHeadersField = value;
            }
        }

        /// <remarks/>
        public configurationSystemwebServerHttpProtocolRedirectHeaders redirectHeaders
        {
            get
            {
                return this.redirectHeadersField;
            }
            set
            {
                this.redirectHeadersField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerHttpProtocolCustomHeaders
    {

        private object clearField;

        /// <remarks/>
        public object clear
        {
            get
            {
                return this.clearField;
            }
            set
            {
                this.clearField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerHttpProtocolRedirectHeaders
    {

        private object clearField;

        /// <remarks/>
        public object clear
        {
            get
            {
                return this.clearField;
            }
            set
            {
                this.clearField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerFilter
    {

        private string nameField;

        private string pathField;

        private bool enableCacheField;

        private string preConditionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string path
        {
            get
            {
                return this.pathField;
            }
            set
            {
                this.pathField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool enableCache
        {
            get
            {
                return this.enableCacheField;
            }
            set
            {
                this.enableCacheField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string preCondition
        {
            get
            {
                return this.preConditionField;
            }
            set
            {
                this.preConditionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerSecurity
    {

        private configurationSystemwebServerSecurityAccess accessField;

        private object applicationDependenciesField;

        private configurationSystemwebServerSecurityAuthentication authenticationField;

        private configurationSystemwebServerSecurityAuthorization authorizationField;

        private object ipSecurityField;

        private configurationSystemwebServerSecurityAdd[] isapiCgiRestrictionField;

        private configurationSystemwebServerSecurityRequestFiltering requestFilteringField;

        /// <remarks/>
        public configurationSystemwebServerSecurityAccess access
        {
            get
            {
                return this.accessField;
            }
            set
            {
                this.accessField = value;
            }
        }

        /// <remarks/>
        public object applicationDependencies
        {
            get
            {
                return this.applicationDependenciesField;
            }
            set
            {
                this.applicationDependenciesField = value;
            }
        }

        /// <remarks/>
        public configurationSystemwebServerSecurityAuthentication authentication
        {
            get
            {
                return this.authenticationField;
            }
            set
            {
                this.authenticationField = value;
            }
        }

        /// <remarks/>
        public configurationSystemwebServerSecurityAuthorization authorization
        {
            get
            {
                return this.authorizationField;
            }
            set
            {
                this.authorizationField = value;
            }
        }

        /// <remarks/>
        public object ipSecurity
        {
            get
            {
                return this.ipSecurityField;
            }
            set
            {
                this.ipSecurityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("add", IsNullable = false)]
        public configurationSystemwebServerSecurityAdd[] isapiCgiRestriction
        {
            get
            {
                return this.isapiCgiRestrictionField;
            }
            set
            {
                this.isapiCgiRestrictionField = value;
            }
        }

        /// <remarks/>
        public configurationSystemwebServerSecurityRequestFiltering requestFiltering
        {
            get
            {
                return this.requestFilteringField;
            }
            set
            {
                this.requestFilteringField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerSecurityAccess
    {

        private string sslFlagsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string sslFlags
        {
            get
            {
                return this.sslFlagsField;
            }
            set
            {
                this.sslFlagsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerSecurityAuthentication
    {

        private configurationSystemwebServerSecurityAuthenticationAnonymousAuthentication anonymousAuthenticationField;

        private object basicAuthenticationField;

        private object clientCertificateMappingAuthenticationField;

        private object digestAuthenticationField;

        private object iisClientCertificateMappingAuthenticationField;

        private configurationSystemwebServerSecurityAuthenticationWindowsAuthentication windowsAuthenticationField;

        /// <remarks/>
        public configurationSystemwebServerSecurityAuthenticationAnonymousAuthentication anonymousAuthentication
        {
            get
            {
                return this.anonymousAuthenticationField;
            }
            set
            {
                this.anonymousAuthenticationField = value;
            }
        }

        /// <remarks/>
        public object basicAuthentication
        {
            get
            {
                return this.basicAuthenticationField;
            }
            set
            {
                this.basicAuthenticationField = value;
            }
        }

        /// <remarks/>
        public object clientCertificateMappingAuthentication
        {
            get
            {
                return this.clientCertificateMappingAuthenticationField;
            }
            set
            {
                this.clientCertificateMappingAuthenticationField = value;
            }
        }

        /// <remarks/>
        public object digestAuthentication
        {
            get
            {
                return this.digestAuthenticationField;
            }
            set
            {
                this.digestAuthenticationField = value;
            }
        }

        /// <remarks/>
        public object iisClientCertificateMappingAuthentication
        {
            get
            {
                return this.iisClientCertificateMappingAuthenticationField;
            }
            set
            {
                this.iisClientCertificateMappingAuthenticationField = value;
            }
        }

        /// <remarks/>
        public configurationSystemwebServerSecurityAuthenticationWindowsAuthentication windowsAuthentication
        {
            get
            {
                return this.windowsAuthenticationField;
            }
            set
            {
                this.windowsAuthenticationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerSecurityAuthenticationAnonymousAuthentication
    {

        private bool enabledField;

        private string userNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool enabled
        {
            get
            {
                return this.enabledField;
            }
            set
            {
                this.enabledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string userName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerSecurityAuthenticationWindowsAuthentication
    {

        private configurationSystemwebServerSecurityAuthenticationWindowsAuthenticationAdd[] providersField;

        private bool enabledField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("add", IsNullable = false)]
        public configurationSystemwebServerSecurityAuthenticationWindowsAuthenticationAdd[] providers
        {
            get
            {
                return this.providersField;
            }
            set
            {
                this.providersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool enabled
        {
            get
            {
                return this.enabledField;
            }
            set
            {
                this.enabledField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerSecurityAuthenticationWindowsAuthenticationAdd
    {

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerSecurityAuthorization
    {

        private configurationSystemwebServerSecurityAuthorizationAdd addField;

        /// <remarks/>
        public configurationSystemwebServerSecurityAuthorizationAdd add
        {
            get
            {
                return this.addField;
            }
            set
            {
                this.addField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerSecurityAuthorizationAdd
    {

        private string accessTypeField;

        private string usersField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string accessType
        {
            get
            {
                return this.accessTypeField;
            }
            set
            {
                this.accessTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string users
        {
            get
            {
                return this.usersField;
            }
            set
            {
                this.usersField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerSecurityAdd
    {

        private string pathField;

        private bool allowedField;

        private string groupIdField;

        private string descriptionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string path
        {
            get
            {
                return this.pathField;
            }
            set
            {
                this.pathField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool allowed
        {
            get
            {
                return this.allowedField;
            }
            set
            {
                this.allowedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string groupId
        {
            get
            {
                return this.groupIdField;
            }
            set
            {
                this.groupIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerSecurityRequestFiltering
    {

        private configurationSystemwebServerSecurityRequestFilteringAdd[] denyUrlSequencesField;

        private configurationSystemwebServerSecurityRequestFilteringFileExtensions fileExtensionsField;

        private configurationSystemwebServerSecurityRequestFilteringRequestLimits requestLimitsField;

        private configurationSystemwebServerSecurityRequestFilteringVerbs verbsField;

        private configurationSystemwebServerSecurityRequestFilteringHiddenSegments hiddenSegmentsField;

        private bool allowDoubleEscapingField;

        private bool allowHighBitCharactersField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("add", IsNullable = false)]
        public configurationSystemwebServerSecurityRequestFilteringAdd[] denyUrlSequences
        {
            get
            {
                return this.denyUrlSequencesField;
            }
            set
            {
                this.denyUrlSequencesField = value;
            }
        }

        /// <remarks/>
        public configurationSystemwebServerSecurityRequestFilteringFileExtensions fileExtensions
        {
            get
            {
                return this.fileExtensionsField;
            }
            set
            {
                this.fileExtensionsField = value;
            }
        }

        /// <remarks/>
        public configurationSystemwebServerSecurityRequestFilteringRequestLimits requestLimits
        {
            get
            {
                return this.requestLimitsField;
            }
            set
            {
                this.requestLimitsField = value;
            }
        }

        /// <remarks/>
        public configurationSystemwebServerSecurityRequestFilteringVerbs verbs
        {
            get
            {
                return this.verbsField;
            }
            set
            {
                this.verbsField = value;
            }
        }

        /// <remarks/>
        public configurationSystemwebServerSecurityRequestFilteringHiddenSegments hiddenSegments
        {
            get
            {
                return this.hiddenSegmentsField;
            }
            set
            {
                this.hiddenSegmentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool allowDoubleEscaping
        {
            get
            {
                return this.allowDoubleEscapingField;
            }
            set
            {
                this.allowDoubleEscapingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool allowHighBitCharacters
        {
            get
            {
                return this.allowHighBitCharactersField;
            }
            set
            {
                this.allowHighBitCharactersField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerSecurityRequestFilteringAdd
    {

        private string sequenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string sequence
        {
            get
            {
                return this.sequenceField;
            }
            set
            {
                this.sequenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerSecurityRequestFilteringFileExtensions
    {

        private configurationSystemwebServerSecurityRequestFilteringFileExtensionsAdd[] addField;

        private bool allowUnlistedField;

        private bool applyToWebDAVField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("add")]
        public configurationSystemwebServerSecurityRequestFilteringFileExtensionsAdd[] add
        {
            get
            {
                return this.addField;
            }
            set
            {
                this.addField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool allowUnlisted
        {
            get
            {
                return this.allowUnlistedField;
            }
            set
            {
                this.allowUnlistedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool applyToWebDAV
        {
            get
            {
                return this.applyToWebDAVField;
            }
            set
            {
                this.applyToWebDAVField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerSecurityRequestFilteringFileExtensionsAdd
    {

        private string fileExtensionField;

        private bool allowedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fileExtension
        {
            get
            {
                return this.fileExtensionField;
            }
            set
            {
                this.fileExtensionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool allowed
        {
            get
            {
                return this.allowedField;
            }
            set
            {
                this.allowedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerSecurityRequestFilteringRequestLimits
    {

        private uint maxAllowedContentLengthField;

        private ushort maxUrlField;

        private ushort maxQueryStringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint maxAllowedContentLength
        {
            get
            {
                return this.maxAllowedContentLengthField;
            }
            set
            {
                this.maxAllowedContentLengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort maxUrl
        {
            get
            {
                return this.maxUrlField;
            }
            set
            {
                this.maxUrlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort maxQueryString
        {
            get
            {
                return this.maxQueryStringField;
            }
            set
            {
                this.maxQueryStringField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerSecurityRequestFilteringVerbs
    {

        private bool allowUnlistedField;

        private bool applyToWebDAVField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool allowUnlisted
        {
            get
            {
                return this.allowUnlistedField;
            }
            set
            {
                this.allowUnlistedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool applyToWebDAV
        {
            get
            {
                return this.applyToWebDAVField;
            }
            set
            {
                this.applyToWebDAVField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerSecurityRequestFilteringHiddenSegments
    {

        private configurationSystemwebServerSecurityRequestFilteringHiddenSegmentsAdd[] addField;

        private bool applyToWebDAVField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("add")]
        public configurationSystemwebServerSecurityRequestFilteringHiddenSegmentsAdd[] add
        {
            get
            {
                return this.addField;
            }
            set
            {
                this.addField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool applyToWebDAV
        {
            get
            {
                return this.applyToWebDAVField;
            }
            set
            {
                this.applyToWebDAVField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerSecurityRequestFilteringHiddenSegmentsAdd
    {

        private string segmentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string segment
        {
            get
            {
                return this.segmentField;
            }
            set
            {
                this.segmentField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerStaticContent
    {

        private configurationSystemwebServerStaticContentMimeMap[] mimeMapField;

        private string lockAttributesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mimeMap")]
        public configurationSystemwebServerStaticContentMimeMap[] mimeMap
        {
            get
            {
                return this.mimeMapField;
            }
            set
            {
                this.mimeMapField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lockAttributes
        {
            get
            {
                return this.lockAttributesField;
            }
            set
            {
                this.lockAttributesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerStaticContentMimeMap
    {

        private string fileExtensionField;

        private string mimeTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fileExtension
        {
            get
            {
                return this.fileExtensionField;
            }
            set
            {
                this.fileExtensionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string mimeType
        {
            get
            {
                return this.mimeTypeField;
            }
            set
            {
                this.mimeTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerTracing
    {

        private configurationSystemwebServerTracingAdd[] traceProviderDefinitionsField;

        private configurationSystemwebServerTracingTraceFailedRequests traceFailedRequestsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("add", IsNullable = false)]
        public configurationSystemwebServerTracingAdd[] traceProviderDefinitions
        {
            get
            {
                return this.traceProviderDefinitionsField;
            }
            set
            {
                this.traceProviderDefinitionsField = value;
            }
        }

        /// <remarks/>
        public configurationSystemwebServerTracingTraceFailedRequests traceFailedRequests
        {
            get
            {
                return this.traceFailedRequestsField;
            }
            set
            {
                this.traceFailedRequestsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerTracingAdd
    {

        private configurationSystemwebServerTracingAddAreas areasField;

        private string nameField;

        private string guidField;

        /// <remarks/>
        public configurationSystemwebServerTracingAddAreas areas
        {
            get
            {
                return this.areasField;
            }
            set
            {
                this.areasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string guid
        {
            get
            {
                return this.guidField;
            }
            set
            {
                this.guidField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerTracingAddAreas
    {

        private object clearField;

        private configurationSystemwebServerTracingAddAreasAdd[] addField;

        /// <remarks/>
        public object clear
        {
            get
            {
                return this.clearField;
            }
            set
            {
                this.clearField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("add")]
        public configurationSystemwebServerTracingAddAreasAdd[] add
        {
            get
            {
                return this.addField;
            }
            set
            {
                this.addField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerTracingAddAreasAdd
    {

        private string nameField;

        private ushort valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerTracingTraceFailedRequests
    {

        private configurationSystemwebServerTracingTraceFailedRequestsAdd addField;

        /// <remarks/>
        public configurationSystemwebServerTracingTraceFailedRequestsAdd add
        {
            get
            {
                return this.addField;
            }
            set
            {
                this.addField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerTracingTraceFailedRequestsAdd
    {

        private configurationSystemwebServerTracingTraceFailedRequestsAddAdd[] traceAreasField;

        private configurationSystemwebServerTracingTraceFailedRequestsAddFailureDefinitions failureDefinitionsField;

        private string pathField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("add", IsNullable = false)]
        public configurationSystemwebServerTracingTraceFailedRequestsAddAdd[] traceAreas
        {
            get
            {
                return this.traceAreasField;
            }
            set
            {
                this.traceAreasField = value;
            }
        }

        /// <remarks/>
        public configurationSystemwebServerTracingTraceFailedRequestsAddFailureDefinitions failureDefinitions
        {
            get
            {
                return this.failureDefinitionsField;
            }
            set
            {
                this.failureDefinitionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string path
        {
            get
            {
                return this.pathField;
            }
            set
            {
                this.pathField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerTracingTraceFailedRequestsAddAdd
    {

        private string providerField;

        private string verbosityField;

        private string areasField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string provider
        {
            get
            {
                return this.providerField;
            }
            set
            {
                this.providerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string verbosity
        {
            get
            {
                return this.verbosityField;
            }
            set
            {
                this.verbosityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string areas
        {
            get
            {
                return this.areasField;
            }
            set
            {
                this.areasField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class configurationSystemwebServerTracingTraceFailedRequestsAddFailureDefinitions
    {

        private string statusCodesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string statusCodes
        {
            get
            {
                return this.statusCodesField;
            }
            set
            {
                this.statusCodesField = value;
            }
        }
    }
}
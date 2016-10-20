﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MetroDemo.Models;
using Microsoft.OfficeProPlus.InstallGen.Presentation.Annotations;
using Microsoft.OfficeProPlus.InstallGen.Presentation.Enums;
using Microsoft.OfficeProPlus.InstallGenerator.Models;
using Org.BouncyCastle.Utilities.Collections;

namespace Microsoft.OfficeProPlus.InstallGen.Presentation.Models
{
    public class CmPackage : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        private ObservableCollection<CmProgram> _programs = new ObservableCollection<CmProgram>();
        

        public CmPackage()
        {
           
            DownloadUrls = new List<DownloadUrl>();
            DeploymentDirectory = string.Empty;
            DeploymentSource = DeploymentSource.CDN;
            MoveFiles = true;
            UpdateOnlyChangedBits = false;
            SiteCode = "S01";

            Programs = new ObservableCollection<CmProgram> {new CmProgram()};

            DistributionPointGroupName = string.Empty;
            DistributionPoint = string.Empty;
            DeploymentExpiryDurationInDays = 15;
            CustomPackageShareName = "OfficeDeployment";
            CMPSModulePath = string.Empty;

            PopulateDownloadUrls();
        }

        private void PopulateDownloadUrls()
        {
            DownloadUrls.Add(new DownloadUrl()
            {
                Name = "SharedFunctions.ps1",
                Url = "https://raw.githubusercontent.com/OfficeDev/Office-IT-Pro-Deployment-Scripts/master/Office-ProPlus-Deployment/Setup-CMOfficeDeployment/SharedFunctions.ps1"
            });

            DownloadUrls.Add(new DownloadUrl()
            {
                Name = "Setup-CMOfficeDeployment.ps1",
                Url = "https://raw.githubusercontent.com/OfficeDev/Office-IT-Pro-Deployment-Scripts/master/Office-ProPlus-Deployment/Setup-CMOfficeDeployment/Setup-CMOfficeDeployment.ps1"
            });

            DownloadUrls.Add(new DownloadUrl()
            {
                Name = "Download-OfficeProPlusChannels.ps1",
                Url = "https://raw.githubusercontent.com/OfficeDev/Office-IT-Pro-Deployment-Scripts/master/Office-ProPlus-Deployment/Setup-CMOfficeDeployment/Download-OfficeProPlusChannels.ps1"
            });
            DownloadUrls.Add(new DownloadUrl()
            {
                Name = "Office 365 ProPlus XML Editor.url",
                Url = "https://raw.githubusercontent.com/OfficeDev/Office-IT-Pro-Deployment-Scripts/master/Office-ProPlus-Deployment/Setup-CMOfficeDeployment/Office%20365%20ProPlus%20XML%20Editor.url"
            });
            DownloadUrls.Add(new DownloadUrl()
            {
                Name = "CM-OfficeDeploymentScript.ps1",
                Url = "https://raw.githubusercontent.com/OfficeDev/Office-IT-Pro-Deployment-Scripts/master/Office-ProPlus-Deployment/Setup-CMOfficeDeployment/DeploymentFiles/CM-OfficeDeploymentScript.ps1"
            });
            DownloadUrls.Add(new DownloadUrl()
            {
                Name = "Change-OfficeChannel.ps1",
                Url = "https://raw.githubusercontent.com/OfficeDev/Office-IT-Pro-Deployment-Scripts/master/Office-ProPlus-Deployment/Setup-CMOfficeDeployment/DeploymentFiles/Change-OfficeChannel.ps1"
            });
            DownloadUrls.Add(new DownloadUrl()
            {
                Name = "Create-Office365AnywhereTask.ps1",
                Url = "https://raw.githubusercontent.com/OfficeDev/Office-IT-Pro-Deployment-Scripts/master/Office-ProPlus-Deployment/Setup-CMOfficeDeployment/DeploymentFiles/Create-Office365AnywhereTask.ps1"
            });
            DownloadUrls.Add(new DownloadUrl()
            {
                Name = "DefaultConfiguration.xml",
                Url = "https://raw.githubusercontent.com/OfficeDev/Office-IT-Pro-Deployment-Scripts/master/Office-ProPlus-Deployment/Setup-CMOfficeDeployment/DeploymentFiles/DefaultConfiguration.xml"
            });
            DownloadUrls.Add(new DownloadUrl()
            {
                Name = "DeployConfigFile.ps1",
                Url = "https://raw.githubusercontent.com/OfficeDev/Office-IT-Pro-Deployment-Scripts/master/Office-ProPlus-Deployment/Setup-CMOfficeDeployment/DeploymentFiles/DeployConfigFile.ps1"
            });
            DownloadUrls.Add(new DownloadUrl()
            {
                Name = "Dynamic-UpdateSource.ps1",
                Url = "https://raw.githubusercontent.com/OfficeDev/Office-IT-Pro-Deployment-Scripts/master/Office-ProPlus-Deployment/Setup-CMOfficeDeployment/DeploymentFiles/Dynamic-UpdateSource.ps1"
            });
            DownloadUrls.Add(new DownloadUrl()
            {
                Name = "Edit-OfficeConfigurationFile.ps1",
                Url = "https://raw.githubusercontent.com/OfficeDev/Office-IT-Pro-Deployment-Scripts/master/Office-ProPlus-Deployment/Setup-CMOfficeDeployment/DeploymentFiles/Edit-OfficeConfigurationFile.ps1"
            });
            DownloadUrls.Add(new DownloadUrl()
            {
                Name = "EnvironmentalFilter.ps1",
                Url = "https://raw.githubusercontent.com/OfficeDev/Office-IT-Pro-Deployment-Scripts/master/Office-ProPlus-Deployment/Setup-CMOfficeDeployment/DeploymentFiles/EnvironmentalFilter.ps1"
            });
            DownloadUrls.Add(new DownloadUrl()
            {
                Name = "Generate-ODTConfigurationXML.ps1",
                Url = "https://raw.githubusercontent.com/OfficeDev/Office-IT-Pro-Deployment-Scripts/master/Office-ProPlus-Deployment/Setup-CMOfficeDeployment/DeploymentFiles/Generate-ODTConfigurationXML.ps1"
            });
            DownloadUrls.Add(new DownloadUrl()
            {
                Name = "Get-OfficeVersion.ps1",
                Url = "https://raw.githubusercontent.com/OfficeDev/Office-IT-Pro-Deployment-Scripts/master/Office-ProPlus-Deployment/Setup-CMOfficeDeployment/DeploymentFiles/Get-OfficeVersion.ps1"
            });
            DownloadUrls.Add(new DownloadUrl()
            {
                Name = "Install-OfficeClickToRun.ps1",
                Url = "https://raw.githubusercontent.com/OfficeDev/Office-IT-Pro-Deployment-Scripts/master/Office-ProPlus-Deployment/Setup-CMOfficeDeployment/DeploymentFiles/Install-OfficeClickToRun.ps1"
            });
            DownloadUrls.Add(new DownloadUrl()
            {
                Name = "LanguageConfiguration.xml",
                Url = "https://raw.githubusercontent.com/OfficeDev/Office-IT-Pro-Deployment-Scripts/master/Office-ProPlus-Deployment/Setup-CMOfficeDeployment/DeploymentFiles/LanguageConfiguration.xml"
            });
            DownloadUrls.Add(new DownloadUrl()
            {
                Name = "OffScrub03.vbs",
                Url = "https://raw.githubusercontent.com/OfficeDev/Office-IT-Pro-Deployment-Scripts/master/Office-ProPlus-Deployment/Setup-CMOfficeDeployment/DeploymentFiles/OffScrub03.vbs"
            });
            DownloadUrls.Add(new DownloadUrl()
            {
                Name = "OffScrub07.vbs",
                Url = "https://raw.githubusercontent.com/OfficeDev/Office-IT-Pro-Deployment-Scripts/master/Office-ProPlus-Deployment/Setup-CMOfficeDeployment/DeploymentFiles/OffScrub07.vbs"
            });
            DownloadUrls.Add(new DownloadUrl()
            {
                Name = "OffScrub10.vbs",
                Url = "https://raw.githubusercontent.com/OfficeDev/Office-IT-Pro-Deployment-Scripts/master/Office-ProPlus-Deployment/Setup-CMOfficeDeployment/DeploymentFiles/OffScrub10.vbs"
            });
            DownloadUrls.Add(new DownloadUrl()
            {
                Name = "OffScrub_O15msi.vbs",
                Url = "https://raw.githubusercontent.com/OfficeDev/Office-IT-Pro-Deployment-Scripts/master/Office-ProPlus-Deployment/Setup-CMOfficeDeployment/DeploymentFiles/OffScrub_O15msi.vbs"
            });
            DownloadUrls.Add(new DownloadUrl()
            {
                Name = "OffScrub_O16msi.vbs",
                Url = "https://raw.githubusercontent.com/OfficeDev/Office-IT-Pro-Deployment-Scripts/master/Office-ProPlus-Deployment/Setup-CMOfficeDeployment/DeploymentFiles/OffScrub_O16msi.vbs"
            });
            DownloadUrls.Add(new DownloadUrl()
            {
                Name = "OffScrubc2r.vbs",
                Url = "https://raw.githubusercontent.com/OfficeDev/Office-IT-Pro-Deployment-Scripts/master/Office-ProPlus-Deployment/Setup-CMOfficeDeployment/DeploymentFiles/OffScrubc2r.vbs"
            });
            DownloadUrls.Add(new DownloadUrl()
            {
                Name = "Office2016Setup.exe",
                Url = "https://github.com/OfficeDev/Office-IT-Pro-Deployment-Scripts/raw/master/Office-ProPlus-Deployment/Setup-CMOfficeDeployment/DeploymentFiles/Office2016Setup.exe"
            });
            DownloadUrls.Add(new DownloadUrl()
            {
                Name = "Remove-OfficeClickToRun.ps1",
                Url = "https://raw.githubusercontent.com/OfficeDev/Office-IT-Pro-Deployment-Scripts/master/Office-ProPlus-Deployment/Setup-CMOfficeDeployment/DeploymentFiles/Remove-OfficeClickToRun.ps1"
            });
            DownloadUrls.Add(new DownloadUrl()
            {
                Name = "Remove-PreviousOfficeInstalls.ps1",
                Url = "https://raw.githubusercontent.com/OfficeDev/Office-IT-Pro-Deployment-Scripts/master/Office-ProPlus-Deployment/Setup-CMOfficeDeployment/DeploymentFiles/Remove-PreviousOfficeInstalls.ps1"
            });
            DownloadUrls.Add(new DownloadUrl()
            {
                Name = "SharedFunctions.ps1",
                Url = "https://raw.githubusercontent.com/OfficeDev/Office-IT-Pro-Deployment-Scripts/master/Office-ProPlus-Deployment/Setup-CMOfficeDeployment/DeploymentFiles/SharedFunctions.ps1"
            });
            DownloadUrls.Add(new DownloadUrl()
            {
                Name = "Update-Office365Anywhere.ps1",
                Url = "https://raw.githubusercontent.com/OfficeDev/Office-IT-Pro-Deployment-Scripts/master/Office-ProPlus-Deployment/Setup-CMOfficeDeployment/DeploymentFiles/Update-Office365Anywhere.ps1"
            });
            DownloadUrls.Add(new DownloadUrl()
            {
                Name = "o365client_32bit.xml",
                Url = "https://raw.githubusercontent.com/OfficeDev/Office-IT-Pro-Deployment-Scripts/master/Office-ProPlus-Deployment/Setup-CMOfficeDeployment/DeploymentFiles/o365client_32bit.xml"
            });
            DownloadUrls.Add(new DownloadUrl()
            {
                Name = "o365client_64bit.xml",
                Url = "https://github.com/OfficeDev/Office-IT-Pro-Deployment-Scripts/blob/master/Office-ProPlus-Deployment/Setup-CMOfficeDeployment/DeploymentFiles/o365client_64bit.xml"
            });

        }

        public List<DownloadUrl> DownloadUrls { get; set; }

        public string DeploymentDirectory { get; set; }

        public CMScenario Scenario { get; set; }

        public DeploymentSource DeploymentSource { get; set; }

        public ObservableCollection<CmProgram> Programs
        {
            get {return _programs;}
            set
            {
                _programs = value;
                OnPropertyChanged();
            }
        }

        public string SiteCode { get; set;}

        public string DistributionPoint { get; set; }

        public string DistributionPointGroupName { get; set; }

        public string CustomPackageShareName { get; set; }

        public string CMPSModulePath { get; set; }

        public bool MoveFiles { get; set; }

        public bool UpdateOnlyChangedBits { get; set; }

        public int DeploymentExpiryDurationInDays { get; set; }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

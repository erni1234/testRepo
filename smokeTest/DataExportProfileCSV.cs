﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace smokeTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The DataExportProfileCSV recording.
    /// </summary>
    [TestModule("2bdc20e6-09db-4fcc-8231-91bad9550593", ModuleType.Recording, 1)]
    public partial class DataExportProfileCSV : ITestModule
    {
        /// <summary>
        /// Holds an instance of the smokeTestRepository repository.
        /// </summary>
        public static smokeTestRepository repo = smokeTestRepository.Instance;

        static DataExportProfileCSV instance = new DataExportProfileCSV();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DataExportProfileCSV()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DataExportProfileCSV Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.NavMonitorIndex' at 44;31.", repo.ElproMONITORLogin.NavMonitorIndexInfo, new RecordItemIndex(0));
            repo.ElproMONITORLogin.NavMonitorIndex.Click("44;31");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.NavDeviceSettingsIndex' at 64;18.", repo.ElproMONITORLogin.NavDeviceSettingsIndexInfo, new RecordItemIndex(1));
            repo.ElproMONITORLogin.NavDeviceSettingsIndex.Click("64;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.NavProfilesDataExportProfiles' at 89;13.", repo.ElproMONITORLogin.NavProfilesDataExportProfilesInfo, new RecordItemIndex(2));
            repo.ElproMONITORLogin.NavProfilesDataExportProfiles.Click("89;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ElproMONITORLogin.ContentCenter.AddNewProfile'.", repo.ElproMONITORLogin.ContentCenter.AddNewProfileInfo, new RecordItemIndex(3));
            Validate.Exists(repo.ElproMONITORLogin.ContentCenter.AddNewProfileInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.ContentCenter.AddNewProfile' at 56;17.", repo.ElproMONITORLogin.ContentCenter.AddNewProfileInfo, new RecordItemIndex(4));
            repo.ElproMONITORLogin.ContentCenter.AddNewProfile.Click("56;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.Name' at 196;19.", repo.ElproMONITORLogin.NameInfo, new RecordItemIndex(5));
            repo.ElproMONITORLogin.Name.Click("196;19");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.Name' at 232;16.", repo.ElproMONITORLogin.NameInfo, new RecordItemIndex(6));
            repo.ElproMONITORLogin.Name.Click("232;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'CSF{Back}V-Profile' with focus on 'ElproMONITORLogin.Name'.", repo.ElproMONITORLogin.NameInfo, new RecordItemIndex(7));
            repo.ElproMONITORLogin.Name.PressKeys("CSF{Back}V-Profile");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.ExportToCsv' at 7;5.", repo.ElproMONITORLogin.ExportToCsvInfo, new RecordItemIndex(8));
            repo.ElproMONITORLogin.ExportToCsv.Click("7;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ElproMONITORLogin.TitleFileDescriptor'.", repo.ElproMONITORLogin.TitleFileDescriptorInfo, new RecordItemIndex(9));
            Validate.Exists(repo.ElproMONITORLogin.TitleFileDescriptorInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.OptionTagPercentDataExportProfileNamePer' at 78;5.", repo.ElproMONITORLogin.OptionTagPercentDataExportProfileNamePerInfo, new RecordItemIndex(10));
            repo.ElproMONITORLogin.OptionTagPercentDataExportProfileNamePer.Click("78;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.BtnAddSubfolderTemplate' at 12;18.", repo.ElproMONITORLogin.BtnAddSubfolderTemplateInfo, new RecordItemIndex(11));
            repo.ElproMONITORLogin.BtnAddSubfolderTemplate.Click("12;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -480 units.", new RecordItemIndex(12));
            Mouse.ScrollWheel(-480);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ElproMONITORLogin.MshtmlHTMLInputElementClass.ContentContainerShow'.", repo.ElproMONITORLogin.MshtmlHTMLInputElementClass.ContentContainerShowInfo, new RecordItemIndex(13));
            Validate.Exists(repo.ElproMONITORLogin.MshtmlHTMLInputElementClass.ContentContainerShowInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.Save' at 12;20.", repo.ElproMONITORLogin.SaveInfo, new RecordItemIndex(14));
            repo.ElproMONITORLogin.Save.Click("12;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.Close' at 17;23.", repo.ElproMONITORLogin.CloseInfo, new RecordItemIndex(15));
            repo.ElproMONITORLogin.Close.Click("17;23");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

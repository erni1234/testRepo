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
    ///The DataDestinationFTP recording.
    /// </summary>
    [TestModule("de3d62f8-46d4-4e3f-a122-cd10803faff2", ModuleType.Recording, 1)]
    public partial class DataDestinationFTP : ITestModule
    {
        /// <summary>
        /// Holds an instance of the smokeTestRepository repository.
        /// </summary>
        public static smokeTestRepository repo = smokeTestRepository.Instance;

        static DataDestinationFTP instance = new DataDestinationFTP();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DataDestinationFTP()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DataDestinationFTP Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.NavMonitorIndex' at 39;23.", repo.ElproMONITORLogin.NavMonitorIndexInfo, new RecordItemIndex(0));
            repo.ElproMONITORLogin.NavMonitorIndex.Click("39;23");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.NavDeviceSettingsIndex' at 65;11.", repo.ElproMONITORLogin.NavDeviceSettingsIndexInfo, new RecordItemIndex(1));
            repo.ElproMONITORLogin.NavDeviceSettingsIndex.Click("65;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.NavProfilesDataDestinationProfiles' at 116;5.", repo.ElproMONITORLogin.NavProfilesDataDestinationProfilesInfo, new RecordItemIndex(2));
            repo.ElproMONITORLogin.NavProfilesDataDestinationProfiles.Click("116;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ElproMONITORLogin.ThTagSensorNam'.", repo.ElproMONITORLogin.ThTagSensorNamInfo, new RecordItemIndex(3));
            Validate.Exists(repo.ElproMONITORLogin.ThTagSensorNamInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ElproMONITORLogin.ThTagIOModule'.", repo.ElproMONITORLogin.ThTagIOModuleInfo, new RecordItemIndex(4));
            Validate.Exists(repo.ElproMONITORLogin.ThTagIOModuleInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ElproMONITORLogin.ListDataTableNoFooter.ThTagDelay'.", repo.ElproMONITORLogin.ListDataTableNoFooter.ThTagDelayInfo, new RecordItemIndex(5));
            Validate.Exists(repo.ElproMONITORLogin.ListDataTableNoFooter.ThTagDelayInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.ContentCenter.AddNewProfile' at 85;19.", repo.ElproMONITORLogin.ContentCenter.AddNewProfileInfo, new RecordItemIndex(6));
            repo.ElproMONITORLogin.ContentCenter.AddNewProfile.Click("85;19");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{END}{SHIFT DOWN}{HOME}{SHIFT UP}{DELETE}' with focus on 'ElproMONITORLogin.Name'.", repo.ElproMONITORLogin.NameInfo, new RecordItemIndex(7));
            repo.ElproMONITORLogin.Name.PressKeys("{END}{SHIFT DOWN}{HOME}{SHIFT UP}{DELETE}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'FTP-Drive' with focus on 'ElproMONITORLogin.Name'.", repo.ElproMONITORLogin.NameInfo, new RecordItemIndex(8));
            repo.ElproMONITORLogin.Name.PressKeys("FTP-Drive");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to 'FTP' on item 'ElproMONITORLogin.Type'.", repo.ElproMONITORLogin.TypeInfo, new RecordItemIndex(9));
            repo.ElproMONITORLogin.Type.Element.SetAttributeValue("TagValue", "FTP");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.Path' at 30;16.", repo.ElproMONITORLogin.PathInfo, new RecordItemIndex(10));
            repo.ElproMONITORLogin.Path.Click("30;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '192.168.100.21' with focus on 'ElproMONITORLogin.Path'.", repo.ElproMONITORLogin.PathInfo, new RecordItemIndex(11));
            repo.ElproMONITORLogin.Path.PressKeys("192.168.100.21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.Loginname' at 42;18.", repo.ElproMONITORLogin.LoginnameInfo, new RecordItemIndex(12));
            repo.ElproMONITORLogin.Loginname.Click("42;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'erdogb{Tab}' with focus on 'ElproMONITORLogin.Loginname'.", repo.ElproMONITORLogin.LoginnameInfo, new RecordItemIndex(13));
            repo.ElproMONITORLogin.Loginname.PressKeys("erdogb{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Password1234' with focus on 'ElproMONITORLogin.Password'.", repo.ElproMONITORLogin.PasswordInfo, new RecordItemIndex(14));
            repo.ElproMONITORLogin.Password.PressKeys("Password1234");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ElproMONITORLogin.BtnCreateDataDestinationTestFile'.", repo.ElproMONITORLogin.BtnCreateDataDestinationTestFileInfo, new RecordItemIndex(15));
            Validate.Exists(repo.ElproMONITORLogin.BtnCreateDataDestinationTestFileInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.BtnCreateDataDestinationTestFile' at 81;28.", repo.ElproMONITORLogin.BtnCreateDataDestinationTestFileInfo, new RecordItemIndex(16));
            repo.ElproMONITORLogin.BtnCreateDataDestinationTestFile.Click("81;28");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ElproMONITORLogin.ResponseCreateTestFile'.", repo.ElproMONITORLogin.ResponseCreateTestFileInfo, new RecordItemIndex(17));
            Validate.Exists(repo.ElproMONITORLogin.ResponseCreateTestFileInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.Save' at 45;25.", repo.ElproMONITORLogin.SaveInfo, new RecordItemIndex(18));
            repo.ElproMONITORLogin.Save.Click("45;25");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.Close' at 18;23.", repo.ElproMONITORLogin.CloseInfo, new RecordItemIndex(19));
            repo.ElproMONITORLogin.Close.Click("18;23");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
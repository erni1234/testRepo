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
    ///The DataDestinationLocal recording.
    /// </summary>
    [TestModule("39465195-6765-47c5-8e18-e26de972c74b", ModuleType.Recording, 1)]
    public partial class DataDestinationLocal : ITestModule
    {
        /// <summary>
        /// Holds an instance of the smokeTestRepository repository.
        /// </summary>
        public static smokeTestRepository repo = smokeTestRepository.Instance;

        static DataDestinationLocal instance = new DataDestinationLocal();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DataDestinationLocal()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DataDestinationLocal Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.NavMonitorIndex' at 90;27.", repo.ElproMONITORLogin.NavMonitorIndexInfo, new RecordItemIndex(0));
            repo.ElproMONITORLogin.NavMonitorIndex.Click("90;27");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.NavDeviceSettingsIndex' at 100;15.", repo.ElproMONITORLogin.NavDeviceSettingsIndexInfo, new RecordItemIndex(1));
            repo.ElproMONITORLogin.NavDeviceSettingsIndex.Click("100;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.NavProfilesDataDestinationProfiles' at 124;12.", repo.ElproMONITORLogin.NavProfilesDataDestinationProfilesInfo, new RecordItemIndex(2));
            repo.ElproMONITORLogin.NavProfilesDataDestinationProfiles.Click("124;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ElproMONITORLogin.ContentCenter.AddNewProfile'.", repo.ElproMONITORLogin.ContentCenter.AddNewProfileInfo, new RecordItemIndex(3));
            Validate.Exists(repo.ElproMONITORLogin.ContentCenter.AddNewProfileInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.ContentCenter.AddNewProfile' at 61;9.", repo.ElproMONITORLogin.ContentCenter.AddNewProfileInfo, new RecordItemIndex(4));
            repo.ElproMONITORLogin.ContentCenter.AddNewProfile.Click("61;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{END}{SHIFT DOWN}{HOME}{SHIFT UP}{DELETE}' with focus on 'ElproMONITORLogin.Name'.", repo.ElproMONITORLogin.NameInfo, new RecordItemIndex(5));
            repo.ElproMONITORLogin.Name.PressKeys("{END}{SHIFT DOWN}{HOME}{SHIFT UP}{DELETE}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}LocalDrive' with focus on 'ElproMONITORLogin.Name'.", repo.ElproMONITORLogin.NameInfo, new RecordItemIndex(6));
            repo.ElproMONITORLogin.Name.PressKeys("{Back}LocalDrive");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to 'Drive' on item 'ElproMONITORLogin.Type'.", repo.ElproMONITORLogin.TypeInfo, new RecordItemIndex(7));
            repo.ElproMONITORLogin.Type.Element.SetAttributeValue("TagValue", "Drive");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.Path' at 109;19.", repo.ElproMONITORLogin.PathInfo, new RecordItemIndex(8));
            repo.ElproMONITORLogin.Path.Click("109;19");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'C{LShiftKey down}:{LShiftKey up}{LControlKey down}{RMenu down}{OemBackslash}{LControlKey up}{LControlKey up}{RMenu up}Data' with focus on 'ElproMONITORLogin.Path'.", repo.ElproMONITORLogin.PathInfo, new RecordItemIndex(9));
            repo.ElproMONITORLogin.Path.PressKeys("C{LShiftKey down}:{LShiftKey up}{LControlKey down}{RMenu down}{OemBackslash}{LControlKey up}{LControlKey up}{RMenu up}Data");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.BtnCreateDataDestinationTestFile' at 80;15.", repo.ElproMONITORLogin.BtnCreateDataDestinationTestFileInfo, new RecordItemIndex(10));
            repo.ElproMONITORLogin.BtnCreateDataDestinationTestFile.Click("80;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ElproMONITORLogin.ResponseCreateTestFile'.", repo.ElproMONITORLogin.ResponseCreateTestFileInfo, new RecordItemIndex(11));
            Validate.Exists(repo.ElproMONITORLogin.ResponseCreateTestFileInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.Save' at 19;19.", repo.ElproMONITORLogin.SaveInfo, new RecordItemIndex(12));
            repo.ElproMONITORLogin.Save.Click("19;19");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.Close' at 26;17.", repo.ElproMONITORLogin.CloseInfo, new RecordItemIndex(13));
            repo.ElproMONITORLogin.Close.Click("26;17");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
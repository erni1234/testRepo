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
    ///The AddDigitalInputs recording.
    /// </summary>
    [TestModule("d3685e36-f569-492d-ab64-28e1aafc0532", ModuleType.Recording, 1)]
    public partial class AddDigitalInputs : ITestModule
    {
        /// <summary>
        /// Holds an instance of the smokeTestRepository repository.
        /// </summary>
        public static smokeTestRepository repo = smokeTestRepository.Instance;

        static AddDigitalInputs instance = new AddDigitalInputs();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddDigitalInputs()
        {
            DigitalInputName = "";
            IOModule = "";
            SensorGroupName = "";
            Channel = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddDigitalInputs Instance
        {
            get { return instance; }
        }

#region Variables

        string _DigitalInputName;

        /// <summary>
        /// Gets or sets the value of variable DigitalInputName.
        /// </summary>
        [TestVariable("977cbdc9-5e4f-4aad-a10a-a7efff1d0ba8")]
        public string DigitalInputName
        {
            get { return _DigitalInputName; }
            set { _DigitalInputName = value; }
        }

        string _IOModule;

        /// <summary>
        /// Gets or sets the value of variable IOModule.
        /// </summary>
        [TestVariable("3e8e71b1-73f1-4d2c-b9ea-8159a2c9d32b")]
        public string IOModule
        {
            get { return _IOModule; }
            set { _IOModule = value; }
        }

        string _SensorGroupName;

        /// <summary>
        /// Gets or sets the value of variable SensorGroupName.
        /// </summary>
        [TestVariable("fafc34e3-9ea5-46bc-986f-71abbcf6e5d3")]
        public string SensorGroupName
        {
            get { return _SensorGroupName; }
            set { _SensorGroupName = value; }
        }

        string _Channel;

        /// <summary>
        /// Gets or sets the value of variable Channel.
        /// </summary>
        [TestVariable("431137d4-99c6-4a28-ad0b-16cf152b5a07")]
        public string Channel
        {
            get { return _Channel; }
            set { _Channel = value; }
        }

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.NavDeviceSettingsIndex' at 48;20.", repo.ElproMONITORLogin.NavDeviceSettingsIndexInfo, new RecordItemIndex(0));
            repo.ElproMONITORLogin.NavDeviceSettingsIndex.Click("48;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ElproMONITORLogin.NavDeviceSettingsDigitalInputs'.", repo.ElproMONITORLogin.NavDeviceSettingsDigitalInputsInfo, new RecordItemIndex(1));
            Validate.Exists(repo.ElproMONITORLogin.NavDeviceSettingsDigitalInputsInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.NavDeviceSettingsDigitalInputs' at 74;18.", repo.ElproMONITORLogin.NavDeviceSettingsDigitalInputsInfo, new RecordItemIndex(2));
            repo.ElproMONITORLogin.NavDeviceSettingsDigitalInputs.Click("74;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ElproMONITORLogin.ContentCenter.AddNewDigitalInput'.", repo.ElproMONITORLogin.ContentCenter.AddNewDigitalInputInfo, new RecordItemIndex(3));
            Validate.Exists(repo.ElproMONITORLogin.ContentCenter.AddNewDigitalInputInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.ContentCenter.AddNewDigitalInput' at 96;19.", repo.ElproMONITORLogin.ContentCenter.AddNewDigitalInputInfo, new RecordItemIndex(4));
            repo.ElproMONITORLogin.ContentCenter.AddNewDigitalInput.Click("96;19");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{END}{SHIFT DOWN}{HOME}{SHIFT UP}{DELETE}' with focus on 'ElproMONITORLogin.Name'.", repo.ElproMONITORLogin.NameInfo, new RecordItemIndex(5));
            repo.ElproMONITORLogin.Name.PressKeys("{END}{SHIFT DOWN}{HOME}{SHIFT UP}{DELETE}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DigitalInputName' with focus on 'ElproMONITORLogin.Name'.", repo.ElproMONITORLogin.NameInfo, new RecordItemIndex(6));
            repo.ElproMONITORLogin.Name.PressKeys(DigitalInputName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$IOModule' with focus on 'ElproMONITORLogin.IoModuleId'.", repo.ElproMONITORLogin.IoModuleIdInfo, new RecordItemIndex(7));
            repo.ElproMONITORLogin.IoModuleId.PressKeys(IOModule);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Channel' with focus on 'ElproMONITORLogin.Channel'.", repo.ElproMONITORLogin.ChannelInfo, new RecordItemIndex(8));
            repo.ElproMONITORLogin.Channel.PressKeys(Channel);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '1' on item 'ElproMONITORLogin.LoggingInterval'.", repo.ElproMONITORLogin.LoggingIntervalInfo, new RecordItemIndex(9));
            repo.ElproMONITORLogin.LoggingInterval.Element.SetAttributeValue("TagValue", "1");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -480 units.", new RecordItemIndex(10));
            Mouse.ScrollWheel(-480);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '1' on item 'ElproMONITORLogin.SetAAlarmProfileId'.", repo.ElproMONITORLogin.SetAAlarmProfileIdInfo, new RecordItemIndex(11));
            repo.ElproMONITORLogin.SetAAlarmProfileId.Element.SetAttributeValue("TagValue", "1");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -600 units.", new RecordItemIndex(12));
            Mouse.ScrollWheel(-600);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$SensorGroupName' with focus on 'ElproMONITORLogin.SensorGroupList'.", repo.ElproMONITORLogin.SensorGroupListInfo, new RecordItemIndex(13));
            repo.ElproMONITORLogin.SensorGroupList.PressKeys(SensorGroupName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.AddSensorGroup' at Center.", repo.ElproMONITORLogin.AddSensorGroupInfo, new RecordItemIndex(14));
            repo.ElproMONITORLogin.AddSensorGroup.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.Save' at Center.", repo.ElproMONITORLogin.SaveInfo, new RecordItemIndex(15));
            repo.ElproMONITORLogin.Save.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.Close' at Center.", repo.ElproMONITORLogin.CloseInfo, new RecordItemIndex(16));
            repo.ElproMONITORLogin.Close.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "User", "Digital Inputs added successfully", new RecordItemIndex(17));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
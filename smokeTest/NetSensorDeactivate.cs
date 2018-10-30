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
    ///The NetSensorDeactivate recording.
    /// </summary>
    [TestModule("741628d9-f0da-4499-9157-057b6b09253b", ModuleType.Recording, 1)]
    public partial class NetSensorDeactivate : ITestModule
    {
        /// <summary>
        /// Holds an instance of the smokeTestRepository repository.
        /// </summary>
        public static smokeTestRepository repo = smokeTestRepository.Instance;

        static NetSensorDeactivate instance = new NetSensorDeactivate();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public NetSensorDeactivate()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static NetSensorDeactivate Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.NavMonitorIndex' at 63;22.", repo.ElproMONITORLogin.NavMonitorIndexInfo, new RecordItemIndex(0));
            repo.ElproMONITORLogin.NavMonitorIndex.Click("63;22");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.ContentLeft.Net05Min' at 57;11.", repo.ElproMONITORLogin.ContentLeft.Net05MinInfo, new RecordItemIndex(1));
            repo.ElproMONITORLogin.ContentLeft.Net05Min.Click("57;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.Sensors.Checkbox2' at 19;7.", repo.ElproMONITORLogin.Sensors.Checkbox2Info, new RecordItemIndex(2));
            repo.ElproMONITORLogin.Sensors.Checkbox2.Click("19;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ElproMONITORLogin.ContentCenter.ButtonTagDeactivate'.", repo.ElproMONITORLogin.ContentCenter.ButtonTagDeactivateInfo, new RecordItemIndex(3));
            Validate.Exists(repo.ElproMONITORLogin.ContentCenter.ButtonTagDeactivateInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.ContentCenter.ButtonTagDeactivate' at 59;10.", repo.ElproMONITORLogin.ContentCenter.ButtonTagDeactivateInfo, new RecordItemIndex(4));
            repo.ElproMONITORLogin.ContentCenter.ButtonTagDeactivate.Click("59;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to 'NetSensorDeactivation' on item 'ElproMONITORLogin.Form.Templates'.", repo.ElproMONITORLogin.Form.TemplatesInfo, new RecordItemIndex(5));
            repo.ElproMONITORLogin.Form.Templates.Element.SetAttributeValue("TagValue", "NetSensorDeactivation");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.Form.Password' at 94;27.", repo.ElproMONITORLogin.Form.PasswordInfo, new RecordItemIndex(6));
            repo.ElproMONITORLogin.Form.Password.Click("94;27");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'password1234' with focus on 'ElproMONITORLogin.Form.Password'.", repo.ElproMONITORLogin.Form.PasswordInfo, new RecordItemIndex(7));
            repo.ElproMONITORLogin.Form.Password.PressKeys("password1234");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.ContentRight.ButtonTagDeactivate' at 74;12.", repo.ElproMONITORLogin.ContentRight.ButtonTagDeactivateInfo, new RecordItemIndex(8));
            repo.ElproMONITORLogin.ContentRight.ButtonTagDeactivate.Click("74;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 50s.", new RecordItemIndex(9));
            Delay.Duration(50000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.NavMonitorIndex' at Center.", repo.ElproMONITORLogin.NavMonitorIndexInfo, new RecordItemIndex(10));
            repo.ElproMONITORLogin.NavMonitorIndex.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.ContentLeft.Net05Min' at Center.", repo.ElproMONITORLogin.ContentLeft.Net05MinInfo, new RecordItemIndex(11));
            repo.ElproMONITORLogin.ContentLeft.Net05Min.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.Sensors.Checkbox2' at Center.", repo.ElproMONITORLogin.Sensors.Checkbox2Info, new RecordItemIndex(12));
            repo.ElproMONITORLogin.Sensors.Checkbox2.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ElproMONITORLogin.ContentCenter.ButtonTagActivate'.", repo.ElproMONITORLogin.ContentCenter.ButtonTagActivateInfo, new RecordItemIndex(13));
            Validate.Exists(repo.ElproMONITORLogin.ContentCenter.ButtonTagActivateInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", "Net Sensor deactivated with success", new RecordItemIndex(14));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

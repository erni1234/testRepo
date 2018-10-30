/*
 * Created by Ranorex
 * User: erdogb
 * Date: 07.09.2018
 * Time: 15:55
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
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

namespace smokeTest
{
    /// <summary>
    /// Description of VerifyUnitExportScheduleTask.
    /// </summary>
    [TestModule("75D3003D-E782-4EAD-A784-1594FDC99D4E", ModuleType.UserCode, 1)]
    public class VerifyUnitExportScheduleTask : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerifyUnitExportScheduleTask()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            var repo = smokeTestRepository.Instance;
            var navDeviceSettingsIndex = repo.ElproMONITORLogin.NavDeviceSettingsIndex;
            var navApplicationSettingsExportScheduleTa = repo.ElproMONITORLogin.NavApplicationSettingsExportScheduleTa;
            var tdTagAT = repo.ElproMONITORLogin.TdTagAT;
            var edit = repo.ElproMONITORLogin.ContentRight.Edit;
            var interval = repo.ElproMONITORLogin.Interval;
            var unit = repo.ElproMONITORLogin.Unit;

            navDeviceSettingsIndex.Click();
            navApplicationSettingsExportScheduleTa.Click();
            
            tdTagAT.Click();
            edit.Click();
            
          
            
        }
    }
}

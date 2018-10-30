/*
 * Created by Ranorex
 * User: erdogb
 * Date: 16.04.2018
 * Time: 13:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
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
    /// Description of DigitalInputsEnabledButtonsverification.
    /// </summary>
    [TestModule("CF4F30B5-9727-4740-9AF1-AF83E0B3760F", ModuleType.UserCode, 1)]
    public class DigitalInputsEnabledButtonsverification : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DigitalInputsEnabledButtonsverification()
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
            var navMonitorIndex = repo.ElproMONITORLogin.NavMonitorIndex;
            var navDeviceSettingsDigitalInputs = repo.ElproMONITORLogin.NavDeviceSettingsDigitalInputs;


            var navDeviceSettingsIndex = repo.ElproMONITORLogin.NavDeviceSettingsIndex;
          
            navMonitorIndex.Click();
            Delay.Milliseconds(500);
            
            navDeviceSettingsIndex.Click();
            navDeviceSettingsDigitalInputs.Click();
            
          
          TdTag tdTagDI = "/dom[@caption~'^elproMONITOR\\ -\\ Digital\\ In' and @page='DigitalInputs']//table[#'DataTables_Table_0']/tbody/tr[1]/td[3]";
          
         
            
           tdTagDI.Click();
           
      
           
         
            Validate.Exists(repo.ElproMONITORDigitalInputs.ContentRight.ReportInfo);                        
            Report.Screenshot(repo.ElproMONITORDigitalInputs.ContentRight.Report);
            Report.Info(repo.ElproMONITORDigitalInputs.ContentRight.Report.Enabled.ToString());
            
            Validate.Exists(repo.ElproMONITORDigitalInputs.ContentRight.RetireInfo);
            Report.Screenshot(repo.ElproMONITORDigitalInputs.ContentRight.Retire);
            
            Validate.Attribute(repo.ElproMONITORDigitalInputs.ContentRight.RetireInfo,"Enabled", true);
           
            
                        
           
            
            Validate.Exists(repo.ElproMONITORDigitalInputs.ContentRight.EditInfo);
            Report.Screenshot(repo.ElproMONITORDigitalInputs.ContentRight.Edit);
            
            Validate.Attribute(repo.ElproMONITORDigitalInputs.ContentRight.EditInfo,"Enabled", true);
            
            Validate.Exists(repo.ElproMONITORDigitalInputs.ContentRight.AddNewDigitalInputInfo);
            Report.Screenshot(repo.ElproMONITORDigitalInputs.ContentRight.AddNewDigitalInput);
            
           
            Validate.Exists(repo.ElproMONITORDigitalInputs.ContentRight.CloseInfo);
            Report.Screenshot(repo.ElproMONITORDigitalInputs.ContentRight.Close);
            
            Validate.Attribute(repo.ElproMONITORDigitalInputs.ContentRight.CloseInfo,"Enabled", true);
            
            
        }
    }
}

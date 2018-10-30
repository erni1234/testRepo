/*
 * Created by Ranorex
 * User: erdogb
 * Date: 19.04.2018
 * Time: 13:30
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
    /// Description of SensorElementsValidation2.
    /// </summary>
    [TestModule("70AFD81C-40A8-454C-A37A-4C9585E86DD4", ModuleType.UserCode, 1)]
    public class SensorElementsValidation2 : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SensorElementsValidation2()
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
          var navDeviceSettingsSensors = repo.ElproMONITORLogin.NavDeviceSettingsSensors;
          var navDeviceSettingsIndex = repo.ElproMONITORLogin.NavDeviceSettingsIndex;

          
          navDeviceSettingsIndex.Click();
          
          navDeviceSettingsSensors.Click();
        

         TdTag tdTagSI = "/dom[@caption='elproMONITOR - Sensors' and @page='Sensors']//table[#'DataTables_Table_0']/tbody/tr[1]/td[3]";
         tdTagSI.Click();
          
         
          ButtonTag report = "/dom[1]//div[#'contentRight']/?/?/button[@innertext='Report']";    
          ButtonTag retire = "/dom[1]//div[#'contentRight']/?/?/button[@innertext='Retire']";  
          ButtonTag edit = "/dom[1]//div[#'contentRight']/?/?/button[@innertext='Edit']";  
          ButtonTag close = "/dom[1]//div[#'contentRight']/?/?/button[@innertext='Close']";       
                 
                      
                          
         
          
          if (report.Enabled == true && retire.Enabled==true && edit.Enabled==true && close.Enabled== true)
         
          {
          	
          	Report.Screenshot(report); Report.Screenshot(retire); Report.Screenshot(edit); Report.Screenshot(close);
          	Report.Info("REPORT, RETIRE,EDIT AND CLOSE BUTTONS ARE PRESENT AND ENABLED");
          
          }
          
          else 
          	Report.Info("One or more Buttons is not enabled");
          
       
        }
    }
}

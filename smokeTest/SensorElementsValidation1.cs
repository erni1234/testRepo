/*
 * Created by Ranorex
 * User: erdogb
 * Date: 16.04.2018
 * Time: 15:22
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
    /// Description of SensorElementsValidation.
    /// </summary>
    [TestModule("D8382DAC-677C-40D4-B91E-A19E5DC7268F", ModuleType.UserCode, 1)]
    public class SensorElementsValidation1 : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SensorElementsValidation1()
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
           
      
           if (repo.ElproMONITORSensors.ContentRight.ReportInfo.Exists(0) && repo.ElproMONITORSensors.ContentRight.RetireInfo.Exists(0)
               
               && repo.ElproMONITORSensors.ContentRight.EditInfo.Exists(0) && repo.ElproMONITORSensors.ContentRight.AddNewSensorInfo.Exists(0) 
               
               && repo.ElproMONITORSensors.ContentRight.CloseInfo.Exists(0) && repo.ElproMONITORSensors.ContentRight.Edit.Enabled == true 
            
           	   && repo.ElproMONITORSensors.ContentRight.Close.Enabled == true)
               
           	
                    
            Validate.Exists(repo.ElproMONITORSensors.ContentRight.ReportInfo);                        
            Report.Screenshot(repo.ElproMONITORSensors.ContentRight.Report);
            Report.Info(repo.ElproMONITORSensors.ContentRight.Report.Enabled.ToString());
            
           // Validate.Exists(repo.ElproMONITORSensors.ContentRight.RetireInfo);
            Report.Screenshot(repo.ElproMONITORSensors.ContentRight.Retire);
            
          //  Validate.Attribute(repo.ElproMONITORSensors.ContentRight.RetireInfo,"Enabled", true);
          
            
         //   Validate.Exists(repo.ElproMONITORSensors.ContentRight.EditInfo);
            Report.Screenshot(repo.ElproMONITORSensors.ContentRight.Edit);
            
           // Validate.Attribute(repo.ElproMONITORSensors.ContentRight.EditInfo,"Enabled", true);
            
           // Validate.Exists(repo.ElproMONITORSensors.ContentRight.AddNewSensorInfo);
            Report.Screenshot(repo.ElproMONITORSensors.ContentRight.AddNewSensor);
            
           
          //  Validate.Exists(repo.ElproMONITORSensors.ContentRight.CloseInfo);
            Report.Screenshot(repo.ElproMONITORSensors.ContentRight.Close);
            
            Validate.Attribute(repo.ElproMONITORSensors.ContentRight.CloseInfo,"Enabled", true);
            
            Report.Info("The following Buttons are enabled: REPORT,RETIRE,EDIT,CLOSE and ADD-NEW-DIGITIALINPUT");
            
        }
    }
}

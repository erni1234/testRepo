/*
 * Created by Ranorex
 * User: erdogb
 * Date: 28.03.2018
 * Time: 14:08
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
    /// Description of settingsButtonandPageVerification.
    /// </summary>
    [TestModule("1B22F1CF-AF57-486E-82DA-478DC5954FBF", ModuleType.UserCode, 1)]
    public class SettingsButtonAndPageVerification : ITestModule
    {
    	
    	public static smokeTestRepository repo = smokeTestRepository.Instance;
        
        public SettingsButtonAndPageVerification()
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
            
                
       
 // Validation of Settings-Tab and Page Content including PageButtons
     
       int count = 5;

      for ( int n = 0; n <= count; n++)
      {
       	switch(n)
       		
       {
       	 case 0:
       		Validate.Exists(repo.ElproMONITORLogin.NavDeviceSettingsIndexInfo);
            repo.ElproMONITORLogin.NavDeviceSettingsIndex.Click();            
            continue;
 // SenorButton Vallidation
        case 1: 
            repo.ElproMONITORLogin.NavDeviceSettingsSensors.Click();
            Validate.Exists(repo.ElproMONITORLogin.ContentCenter.AddNewSensorInfo);
            Report.Screenshot(repo.ElproMONITORLogin.Self);
            continue;
// DigitalInputButton Vallidation    
        case 2:
            repo.ElproMONITORLogin.NavDeviceSettingsDigitalInputs.Click();
            Validate.Exists(repo.ElproMONITORLogin.ContentCenter.AddNewDigitalInputInfo);
            Report.Screenshot(repo.ElproMONITORLogin.Self);
            continue;
 // DigitalOutputButton Vallidation  
       case 3:
            repo.ElproMONITORLogin.NavDeviceSettingsDigitalOutputs.Click();
            Validate.Exists(repo.ElproMONITORLogin.ContentCenter.AddNewDigitalOutputInfo);
            Report.Screenshot(repo.ElproMONITORLogin.Self);
            continue;
 // SensorGroupsButton Vallidation 
       case 4:
            repo.ElproMONITORLogin.NavDeviceSettingsSensorGroups.Click();
            Validate.Exists(repo.ElproMONITORLogin.ContentCenter.AddNewSensorGroupInfo);
            Report.Screenshot(repo.ElproMONITORLogin.Self);
            continue;
  // IO-ModulesButton Vallidation 
       case 5:
            repo.ElproMONITORLogin.NavDeviceSettingsIoModules.Click();
            Validate.Exists(repo.ElproMONITORLogin.ContentCenter.AddNewIOModuleInfo);
            Report.Screenshot(repo.ElproMONITORLogin.Self); 
            break;
          
       	     }
           }
 
        }
    }
}

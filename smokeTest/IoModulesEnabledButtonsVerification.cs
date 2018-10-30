/*
 * Created by Ranorex
 * User: erdogb
 * Date: 16.04.2018
 * Time: 12:42
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
    /// Description of SensorEnabledButtonsVerification.
    /// </summary>
    [TestModule("F7D71903-0FFE-4522-A9C4-0D9A93325F62", ModuleType.UserCode, 1)]
    public class IoModulesEnabledButtonsVerification : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public IoModulesEnabledButtonsVerification()
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
            var navDeviceSettingsIoModules = repo.ElproMONITORLogin.NavDeviceSettingsIoModules;
            var navDeviceSettingsIndex = repo.ElproMONITORLogin.NavDeviceSettingsIndex;
          
           
            	
          
            navDeviceSettingsIndex.Click();
            navDeviceSettingsIoModules.Click();
           
         TdTag check = "/dom[@caption~'^elproMONITOR\\ -\\ I/O\\ Module']//table[#'DataTables_Table_0']/tbody/tr[1]/td[1]";
        // InputTag id125 = "/dom[@caption~'^elproMONITOR\\ -\\ I/O\\ Module']//input[#'Id_159']";
          
         
           var report = repo.ElproMONITORLogin.ContentCenter.Report;
           var delete = repo.ElproMONITORLogin.ContentCenter.Delete;
           var addNewIOModule = repo.ElproMONITORLogin.ContentCenter.AddNewIOModule;
           var edit = repo.ElproMONITORLogin.ContentCenter.Edit;

                   
           check.Click();
           
         //  id125.Click();
   // Verifying Enabled Buttons when a Module is selected       
          
           if (repo.ElproMONITORLogin.ContentCenter.Report.Enabled==true)
           	
           {
           Report.Info("Report Button is enabled"); Report.Screenshot(report);
                      
           }
           else
           {
           	Report.Warn("Report Button is not enabled");
            Report.Screenshot(report);
           
           }
          
           
           if (repo.ElproMONITORLogin.ContentCenter.Delete.Enabled==true)
           	
           {
           Validate.Exists(repo.ElproMONITORLogin.ContentCenter.DeleteInfo);
           Report.Info("Delete Button is enabled"); Report.Screenshot(delete);
                      
           }
           else
           {
           	Report.Warn("Delete Button is not enabled");
           	Report.Screenshot(delete);
           }
          
          if (repo.ElproMONITORLogin.ContentCenter.Edit.Enabled==true)
           	
           {
           Validate.Exists(repo.ElproMONITORLogin.ContentCenter.EditInfo);
           Report.Info("Edit Button is enabled"); Report.Screenshot(edit);
                      
           }
           else
           {
           	Report.Warn("Edit Button is not enabled");
           	Report.Screenshot(edit);
           }
           
           if (repo.ElproMONITORLogin.ContentCenter.AddNewIOModule.Enabled==true)
           	
           {
           Validate.Exists(repo.ElproMONITORLogin.ContentCenter.AddNewIOModuleInfo);
           Report.Info("AddNewIOModule Button is enabled"); Report.Screenshot(addNewIOModule);
                      
           }
           else
           {
           	Report.Warn("AddNewIOModule Button is not enabled");
            Report.Screenshot(addNewIOModule);
           }
           
            
            
        }
    }
}

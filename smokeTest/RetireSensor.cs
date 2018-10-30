/*
 * Created by Ranorex
 * User: erdogb
 * Date: 27.08.2018
 * Time: 14:36
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
    /// Description of RetireSensor.
    /// </summary>
    [TestModule("C37E9A0A-C421-4277-87D9-2E57232438DE", ModuleType.UserCode, 1)]
    public class RetireSensor : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RetireSensor()
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
           
            
            
           // navMonitorIndex.Click();
             navDeviceSettingsIndex.Click();
            
            var navDeviceSettingsSensors = repo.ElproMONITORLogin.NavDeviceSettingsSensors;
            
           
            navDeviceSettingsSensors.Click();
            
           // TdTag tdTagS = "/dom[1]//table[#'DataTables_Table_0']/tbody/tr[1]/td[3]";
           // TdTag tdTagS = "/dom[@caption='elproMONITOR - Sensors']//table[#'DataTables_Table_0']/tbody/tr[1]/td[@innertext='S-0101-4PT-CH1']";
           // var tdTagLB = repo.ElproMONITORLogin.ListDataTableNoFooter.TdTagLB;
            
           
            var tdTagAT = repo.ElproMONITORLogin.TdTagAT;

            tdTagAT.Click();
            
           var retire = repo.ElproMONITORLogin.ContentRight.Retire;
          
            
            if(retire.Enabled==true)
            {
            	Validate.Exists(retire);
            	Report.Screenshot(retire);
            	retire.Click();
            	            	
                 
            var commentTemplateId = repo.ElproMONITORLogin.CommentTemplateId;
            var password = repo.ElproMONITORLogin.Password;
           
                      
            	
            	commentTemplateId.PressKeys("NetSensorDefect");
            	password.PressKeys("password1234");
            	
            	var save = repo.ElproMONITORLogin.Save;
                var close = repo.ElproMONITORLogin.Close;
                
            	save.Click();
            	         	
            	
            	
            	Report.Info("Sensor successfully retired");
            
            }

            
         
            


            
            
            
            
        }
    }
}

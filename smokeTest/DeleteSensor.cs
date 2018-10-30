/*
 * Created by Ranorex
 * User: erdogb
 * Date: 28.08.2018
 * Time: 15:57
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
    /// Description of DeleteSensor.
    /// </summary>
    [TestModule("16F50D46-433D-40FF-85D5-3F6E12AFCA5D", ModuleType.UserCode, 1)]
    public class DeleteSensor : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DeleteSensor()
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
              
           
            navDeviceSettingsIndex.Click();
            
            var navDeviceSettingsSensors = repo.ElproMONITORLogin.NavDeviceSettingsSensors;
            
            navDeviceSettingsSensors.Click();
           
            
            
            var tdTagAT = repo.ElproMONITORLogin.TdTagAT;

            tdTagAT.Click();
            
           ButtonTag delete = "/dom[1]//div[#'contentRight']/?/?/button[@innertext='Delete']";
           // var delete = repo.ElproMONITORLogin.ContentCenter.Delete;

           
            
         
            
             if(delete.Enabled==true)
           
             {
            	Validate.Exists(delete);
            	Report.Screenshot(delete);
            	delete.Click();
            	            	
                 
            var commentTemplateId = repo.ElproMONITORLogin.CommentTemplateId;
            var password = repo.ElproMONITORLogin.Password;
           
                      
            	
            	commentTemplateId.PressKeys("ProSensorDefect");
            	password.PressKeys("password1234");
            	
            	var save = repo.ElproMONITORLogin.Save;
                var close = repo.ElproMONITORLogin.Close;
                
            	save.Click();
            	         	
            	
            	
            	Report.Info("Sensor successfully deleted");
            
            } 


        }
    }
}

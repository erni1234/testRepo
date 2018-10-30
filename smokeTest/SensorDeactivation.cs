/*
 * Created by Ranorex
 * User: erdogb
 * Date: 24.08.2018
 * Time: 14:06
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
    /// Description of NetSensorDeactivated.
    /// </summary>
    [TestModule("DEDDC69B-4944-4113-A9D3-386502796972", ModuleType.UserCode, 1)]
    public class SensorDeactivation : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SensorDeactivation()
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

            var net05Min = repo.ElproMONITORLogin.ContentLeft.Net05Min;
            var checkbox2 = repo.ElproMONITORLogin.Sensors.Checkbox2;
            
           
            navMonitorIndex.Click();
            net05Min.Click();
            checkbox2.Click();
          
            

            

           
           var buttonTagDeactivate = repo.ElproMONITORLogin.ContentCenter.ButtonTagDeactivate;
     

           if(buttonTagDeactivate.Enabled==true)
           	
           	
            {
           	   
            	Report.Screenshot(buttonTagDeactivate);
            	Validate.Exists(buttonTagDeactivate);
            	buttonTagDeactivate.Click();
            	
            	var templates = repo.ElproMONITORLogin.Form.Templates;  
            	var password = repo.ElproMONITORLogin.Form.Password;
            	ButtonTag buttonTagDeactivate1 = "/dom[@caption='elproMONITOR - Monitor']//div[#'contentRight']//button[@innertext~'^\\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ Deactiva']";
            	var buttonTagActivate = repo.ElproMONITORLogin.ContentCenter.ButtonTagActivate;
            	
            	if (repo.ElproMONITORLogin.Form.TemplatesInfo.Exists(0) && repo.ElproMONITORLogin.Form.PasswordInfo.Exists(0))
            	
            	{
            		
            	templates.PressKeys("NetSensorDeactivation");
            	password.PressKeys("password1234");
            	            	
            	buttonTagDeactivate1.Click();
            	Report.Screenshot(repo.ElproMONITORLogin.Self);
            	}
            	
            	else
            	{
            		Report.Screenshot(repo.ElproMONITORLogin.Self);
            	}
            	
            	        	
            	
            	
            	
            	//Duration newDuration = new Duration(4*60*1000);
            	
            	
            	Thread.Sleep(5*60*1000);
            	
            	if (buttonTagActivate.Enabled==true)
            	{
            		Report.Screenshot(buttonTagActivate);
            		Report.Info("Deactivation by User successfully completed");
            	}
            	else
            	{
            		Report.Warn("Deactivation of Net-Sensor was not accomplished ");
            	}
            	
            }
            
                
            else
            {
            	Report.Warn("Sensor has already been deactivated");
            } 

        }
    }
}

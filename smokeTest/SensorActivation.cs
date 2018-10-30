/*
 * Created by Ranorex
 * User: erdogb
 * Date: 27.08.2018
 * Time: 13:34
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
    /// Description of NetSensorActivated.
    /// </summary>
    [TestModule("F5965E55-97F2-4D5D-8A41-6EA4073E8354", ModuleType.UserCode, 1)]
    public class SensorActivation : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SensorActivation()
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
            var buttonTagActivate = repo.ElproMONITORLogin.ContentCenter.ButtonTagActivate;

            if(buttonTagActivate.Enabled==true && buttonTagDeactivate.Enabled==false)
            {
            	Report.Screenshot(buttonTagActivate);
            	Report.Screenshot(buttonTagDeactivate);
            	buttonTagActivate.Click();
            	
            	var templates = repo.ElproMONITORLogin.Form.Templates;  
            	var password = repo.ElproMONITORLogin.Form.Password;
                ButtonTag buttonTagActivate1 = "/dom[@caption='elproMONITOR - Monitor']//div[#'contentRight']//button[@innertext~'^\\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ \\ Activate']";
            	
            	
            	
            	
            	if (repo.ElproMONITORLogin.Form.TemplatesInfo.Exists(0) && repo.ElproMONITORLogin.Form.PasswordInfo.Exists(0))
            	
            	{
            	templates.PressKeys("NetSensorDefect");
            	password.PressKeys("password1234");
            	
            	buttonTagActivate1.Click();
            	
            	}
            	Report.Screenshot(repo.ElproMONITORLogin.Self);
            	}
            	
            	else
            	{
            		Report.Screenshot(repo.ElproMONITORLogin.Self);
            	}
            	
            	
            	Thread.Sleep(5*60*1000);
            	
            

            	if (buttonTagDeactivate.Enabled==true)
            	{
            		Report.Screenshot(buttonTagDeactivate);
            		Report.Info("Activation of NetSensor by User successfully completed");
            	}
            	else
            	{
            		Report.Info("Activation of Net-Sensor could not be accomplished after 3 Mins");
            	}
                        
            
            /*else
            {
            
            	Report.Warn("Net Sensor activation not possible");
            }*/
            
            }
            
        }
    }


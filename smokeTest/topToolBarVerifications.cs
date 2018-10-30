/*
 * Created by Ranorex
 * User: erdogb
 * Date: 28.03.2018
 * Time: 13:04
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
    /// Description of topToolBarVerifications.
    /// </summary>
    [TestModule("961F59D2-9A70-4B90-883A-272E13B28615", ModuleType.UserCode, 1)]
    public class topToolBarVerifications : ITestModule
    {
    	
    	public static smokeTestRepository repo = smokeTestRepository.Instance;
    	
    	
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public topToolBarVerifications()
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
      
            //Verification of the four major top-toolbar buttons and pages before inserting modules and sensors
            
            repo.ElproMONITORLogin.NavElproAbout.Click();
            Delay.Milliseconds(500);
    
            //Image comparism and validation of elproMonitorAboutPage
            
            Validate.Exists(repo.ElproMONITORLogin.NavElproAboutInfo);
            Report.Screenshot(repo.ElproMONITORLogin.Self);
            
            
            Bitmap aboutPageMonitor = Ranorex.Imaging.Load("F:/screenshotsSmokeTest/elproMONITORAbout.png");
          
            
            if (Ranorex.Imaging.Contains(repo.ElproMONITORLogin.Self,aboutPageMonitor) == true)
            	
            	
           {  
            	
            repo.ElproMONITORLogin.Self.Click(new Location(aboutPageMonitor, new Imaging.FindOptions(0.95)));
            Report.Success("Correct Version of elproMonitor"); 
             
           }  

            else
            	
            {
            	Report.Warn("wrong Version of Monitor installed");
            }
            

            
            
            if (repo.ElproMONITORLogin.NavMonitorIndexInfo.Exists(0))
            	
                
             {
            repo.ElproMONITORLogin.NavMonitorIndex.Click();
            Delay.Milliseconds(500);
            Report.Screenshot(repo.ElproMONITORLogin.Self);
            Validate.Exists(repo.ElproMONITORLogin.NavMonitorIndexInfo);
            bool exists = Validate.Exists(repo.ElproMONITORLogin.NavMonitorIndexInfo,"Existance of MONITOR-TAB verified'{0}'",false);  
            Report.Screenshot(repo.ElproMONITORLogin.NavMonitorIndex);
             }
                
            else 
                	
             {
                Report.Info("Monitor Tab is not available");
             }
            
           
          if (repo.ElproMONITORLogin.NavCalibrationIndexInfo.Exists(0))

             
          	
             {
            repo.ElproMONITORLogin.NavCalibrationIndex.Click();
            Delay.Milliseconds(500);
            Report.Screenshot(repo.ElproMONITORLogin.Self);
            Validate.Exists(repo.ElproMONITORLogin.NavCalibrationIndexInfo);
            Report.Screenshot(repo.ElproMONITORLogin.NavCalibrationIndex);
             }
                
                    
          else 
                    	
             {
               Report.Warn("No calibration Tab available");
             }
           
                    
                    
                    
         if (repo.ElproMONITORLogin.NavDeviationsIndexInfo.Exists(0))
                    	
              { 
         	
            repo.ElproMONITORLogin.NavDeviationsIndex.Click();
            Delay.Milliseconds(500);
            Report.Screenshot(repo.ElproMONITORLogin.Self);
            Validate.Exists(repo.ElproMONITORLogin.NavDeviationsIndexInfo);
            Report.Screenshot(repo.ElproMONITORLogin.NavDeviationsIndex);
              }
                        
           else
             {
               Report.Failure("No Deviation Tab available");
             }
            

         if (repo.ElproMONITORLogin.NavDeviceSettingsIndexInfo.Exists(0))
                        	
           
             {
            repo.ElproMONITORLogin.NavDeviceSettingsIndex.Click();
            Delay.Milliseconds(500);
            Report.Screenshot(repo.ElproMONITORLogin.Self);
            Validate.Exists(repo.ElproMONITORLogin.NavDeviceSettingsIndexInfo);
            Report.Screenshot(repo.ElproMONITORLogin.NavDeviceSettingsIndex);
             }
                            
           else
             {
              	Report.Failure("No Settings Tab available");
             }
           
           
        }
    }
}

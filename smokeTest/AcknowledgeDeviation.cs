/*
 * Created by Ranorex
 * User: erdogb
 * Date: 29.08.2018
 * Time: 11:09
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
    /// Description of AcknowledgeDeviation.
    /// </summary>
    [TestModule("B869F3CB-310F-4C12-B44C-47F63C71F2FB", ModuleType.UserCode, 1)]
    public class AcknowledgeDeviation : ITestModule
    	
    {
    	
    	  public static smokeTestRepository repo = smokeTestRepository.Instance;
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AcknowledgeDeviation()
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
            
           
            var navDeviationsIndex = repo.ElproMONITORLogin.NavDeviationsIndex;
            navDeviationsIndex.Click();
            Delay.Milliseconds(200);
            
            var checkbox = repo.ElproMONITORLogin.Checkbox;		
            checkbox.Click();
            
            var buttonTagDetails = repo.ElproMONITORLogin.ContentCenter.ButtonTagDetails;
            var buttonTagAcknowledge = repo.ElproMONITORLogin.ContentCenter.ButtonTagAcknowledge;
            
            if(buttonTagDetails.Enabled==true)
            {
            	buttonTagDetails.Click();
            
            var contentContainerShow = repo.ElproMONITORLogin.ContentContainerShow;                 
          
                

                 contentContainerShow.Click();
                 Report.Screenshot(contentContainerShow);
                
                 Keyboard.Press("{PageDown}");
                 Report.Screenshot(contentContainerShow);
            }
            
              var buttonTagAcknowledge1 = repo.ElproMONITORLogin.ContentRight.ButtonTagAcknowledge;
              
            if (buttonTagAcknowledge1.Enabled==true)
            {
                /* Duration newDuration = new Duration(1000);
                 
                 repo.ElproMONITORLogin.ContentCenter.ButtonTagAcknowledgeInfo.WaitForExists(newDuration); */
                 
                 
                 buttonTagAcknowledge1.Click();
                 
                 var templates = repo.ElproMONITORLogin.Form.Templates;
                 var password = repo.ElproMONITORLogin.Form.Password;
                 
                 
                 templates.PressKeys("ProsensorDeviation");
                 password.PressKeys("password1234");
                 
                 var buttonTagSave = repo.ElproMONITORLogin.ContentRight.ButtonTagSave;
                 var buttonTagDetails1 = repo.ElproMONITORLogin.ContentCenter.ButtonTagDetails;
               //  var checkbox = repo.ElproMONITORLogin.Checkbox;

                 buttonTagSave.Click();
                 buttonTagDetails1.Click();
                // checkbox.Click();
             //   Validate.Attribute(repo.ElproMONITORLogin.ContentCenter.ButtonTagAcknowledgeInfo,"Disabled",true);
                Report.Screenshot(buttonTagAcknowledge);
                Report.Info("Deviation Ackwoledgement completed successfully");
                 
              
                 
            }
            else
            {
            	Report.Warn("Deviation has already been acknowledged");
            }
            
            
        }
    }
}

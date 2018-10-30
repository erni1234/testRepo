/*
 * Created by Ranorex
 * User: erdogb
 * Date: 23.05.2018
 * Time: 16:49
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
    /// Description of DeviationVerification.
    /// </summary>
    [TestModule("3D0663C7-50EA-48E9-B5C4-86AF378AF016", ModuleType.UserCode, 1)]
    public class DeviationVerification : ITestModule
    {
    	
    public static smokeTestRepository repo = smokeTestRepository.Instance;
    
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DeviationVerification()
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
            var buttonTagComment = repo.ElproMONITORLogin.ContentCenter.ButtonTagComment;
            var buttonTagReport = repo.ElproMONITORLogin.ContentCenter.ButtonTagReport;
           
            
            var sensorAlarmTag = repo.ElproMONITORLogin.ContentLeft.SensorAlarmTag;
            var systemIssuesTag = repo.ElproMONITORLogin.ContentLeft.SystemIssuesTag;
            var sensorWarningTag = repo.ElproMONITORLogin.ContentLeft.SensorWarningTag;
            var sensorIssuesTag = repo.ElproMONITORLogin.ContentLeft.SensorIssuesTag;
         
           

            for(int i = 0; i<=3; i++)
            {
            	
            	
            	switch(i)
            	{
            	
            	 case 0:
            

            if (buttonTagDetails.Enabled==true&&buttonTagAcknowledge.Enabled==true&&buttonTagComment.Enabled==true&&buttonTagReport.Enabled==true)
            	
            {
            
            	Report.Info("The following Bottons are enabled Details,Acknowlege,Comment and Report");
                      
            }
            
            else
            {
            	Report.Warn("One or more buttons in Deviation Menu is not enabled ");
            
            }
              continue;
            
                  case 1:
                 Validate.Exists(repo.ElproMONITORLogin.ContentCenter.ButtonTagDetailsInfo);
                 Report.Screenshot(buttonTagDetails,true);
                 
                 Validate.Exists(repo.ElproMONITORLogin.ContentCenter.ButtonTagAcknowledgeInfo);
                 Report.Screenshot(buttonTagAcknowledge,true);
                 
                 Validate.Exists(repo.ElproMONITORLogin.ContentCenter.ButtonTagCommentInfo);
                 Report.Screenshot(buttonTagComment,true);
                 
                 Validate.Exists(repo.ElproMONITORLogin.ContentCenter.ButtonTagReportInfo);
                 Report.Screenshot(buttonTagReport,true);
                 
                 continue;

                 case 2:
                 
                 Validate.Exists(repo.ElproMONITORLogin.ContentLeft.SensorAlarmTagInfo);
                 Report.Screenshot(sensorAlarmTag);
                 
                 Validate.Exists(repo.ElproMONITORLogin.ContentLeft.SystemIssuesTagInfo);
                 Report.Screenshot(systemIssuesTag);
                 
                 Validate.Exists(repo.ElproMONITORLogin.ContentLeft.SensorWarningTagInfo);
                 Report.Screenshot(sensorWarningTag);
                 
                 Validate.Exists(repo.ElproMONITORLogin.ContentLeft.SensorIssuesTagInfo);
                 Report.Screenshot( sensorIssuesTag);               
                 
               
                 continue;
                 
                case 3:                            
                 if (buttonTagReport.Enabled==true)
                 
                 {
                    buttonTagReport.Click();
                 	Thread.Sleep(1*60*1000);
                 	Report.Screenshot(repo.ElproMONITORLogin.Self);
                 	Keyboard.Press("{PageDown}");
                 	Report.Screenshot(repo.ElproMONITORLogin.Self);
                 }
                 else
                 {
                 	Report.Info("PDF Report couldn't be downloaded within a minute");
                 }
                 break;
                
                            	
            	}
            	       	
            	
            	            	
            	
            	
            }
            
                

           
           
           
            
           
            
           

        }
    }
}

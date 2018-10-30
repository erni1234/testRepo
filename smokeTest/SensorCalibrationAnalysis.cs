/*
 * Created by Ranorex
 * User: erdogb
 * Date: 24.07.2018
 * Time: 15:33
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
    /// Description of CalibrationAnalysis.
    /// </summary>
    [TestModule("471DEBD6-0AED-4CF2-B2FD-820E87BB0487", ModuleType.UserCode, 1)]
    public class SensorCalibrationAnalysis : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SensorCalibrationAnalysis()
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
            navMonitorIndex.Click();
            
            var pro01Min = repo.ElproMONITORLogin.ContentLeft.Pro01Min;
            pro01Min.Click();
            
            var checkbox2 = repo.ElproMONITORLogin.Sensors.Checkbox2;
            checkbox2.Click();
           
            var buttonTagAnalysis = repo.ElproMONITORLogin.ContentCenter.ButtonTagAnalysis;
            var buttonTagCalibrate = repo.ElproMONITORLogin.ContentCenter.ButtonTagCalibrate;
            var checkbox1 = repo.ElproMONITORLogin.Sensors.Checkbox1;


//            var buttonTagExport = repo.ElproMONITORLogin.ContentRight.ButtonTagExport;
             
            
            var s01014PTCH1 = repo.ElproMONITORLogin.Sensors.S01014PTCH1;
             
           
            
          

            if( buttonTagCalibrate.Enabled==true && buttonTagAnalysis.Enabled==true)
            
            {
            	Report.Screenshot(buttonTagCalibrate);
            	Report.Screenshot(buttonTagAnalysis);
            	
            	Validate.Exists(repo.ElproMONITORLogin.ContentCenter.ButtonTagCalibrateInfo);
            	
            	buttonTagCalibrate.Click(); 
            	
            	Thread.Sleep(1*60*1000);
            	
            	checkbox1.Click();
            	s01014PTCH1.Click();  
            	
            	
            
            	            	
            
            }
            else
            {
            	Report.Screenshot(buttonTagCalibrate);
            	Report.Info("Calibrate Button does not exit");
            }
            
            
            var buttonTagCompleted = repo.ElproMONITORLogin.ContentCenter.ButtonTagCompleted;
            var buttonTagClose = repo.ElproMONITORLogin.ContentRight.ButtonTagClose;
            var buttonTagReport = repo.ElproMONITORLogin.ContentRight.ButtonTagReport;
            

            
             if(buttonTagReport.Enabled)
            	
                {  
            	    
            		
            		Report.Screenshot(repo.ElproMONITORLogin.Self);
            		buttonTagReport.Click();
            		Thread.Sleep(1*60*1000);
            		
            		
            		Report.Screenshot(repo.ElproMONITORLogin.Self);
            		
            	
            		var aVLAVView = repo.Http192168250188ApiReportApiGe.AVLAVView;
                	           		
            		aVLAVView.PressKeys("{alt down}{f4 down}");
            		
            		var buttonDieAktuelleRegisterkarteSchlies = repo.InternetExplorer.ButtonDieAktuelleRegisterkarteSchlies;
            		
            		buttonDieAktuelleRegisterkarteSchlies.Click();

            		
            		buttonTagClose.Click();
            		ButtonTag buttonTagCompleted1 = "/dom[@domain='192.168.250.188']//div[#'contentCenter']/?/?/button[@innertext='Completed']";
            		//var buttonTagCompleted1 = repo.ElproMONITORLogin.ContentCenter.ButtonTagCompleted;
            		
            		Thread.Sleep(5000);
            		buttonTagCompleted1.MoveTo();
            		buttonTagCompleted1.Click();
            		
            	}
            
            	else
            	{
            		Report.Screenshot(buttonTagReport);
            		Report.Info("The Report Button is not enabled");
            	}
            
            	
          
           
            	

        }
    }
}

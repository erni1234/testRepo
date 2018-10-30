/*
 * Created by Ranorex
 * User: erdogb
 * Date: 20.04.2018
 * Time: 16:22
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
    /// Description of combobox.
    /// </summary>
    [TestModule("A87A9D00-3562-4918-8722-9DB38A25A349", ModuleType.UserCode, 1)]
    public class SensorAnalysis : ITestModule
    {
        
    	
      public static smokeTestRepository repo = smokeTestRepository.Instance;
    	/// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SensorAnalysis()
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
            
            
             repo.ElproMONITORLogin.NavElproAbout.Click();
            Delay.Milliseconds(500);
    
         //Image comparism and validation of elproMonitorAboutPage
            
       Validate.Exists(repo.ElproMONITORLogin.NavElproAboutInfo);
       Report.Screenshot(repo.ElproMONITORLogin.Self);
            
            
       Bitmap aboutPageMonitor = Ranorex.Imaging.Load("F:/screenshotsSmokeTest/elproMONITORAbout.png");
            
       repo.ElproMONITORLogin.Self.Click(new Location(aboutPageMonitor, new Imaging.FindOptions(0.95)));
           
       Report.Success("Correct Version of elproMonitor installed");
          
       var navMonitorIndex = repo.ElproMONITORLogin.NavMonitorIndex;  
       navMonitorIndex.Click();
          
       var net01Min = repo.ElproMONITORLogin.Net01Min;
       net01Min.Click();
       
       var sIMLP4M31 = repo.ElproMONITORLogin.SIMLP4M31;         
       sIMLP4M31.Click();
       
       var buttonTagExport = repo.ElproMONITORLogin.ContentRight.ButtonTagExport;
       var buttonTagReport = repo.ElproMONITORLogin.ContentRight.ButtonTagReport;
       var buttonTagClose = repo.ElproMONITORLogin.ContentRight.ButtonTagClose;
       var buttonTagPreviousWeek = repo.ElproMONITORLogin.Form.ButtonTagPreviousWeek;
       var buttonTagPreviousMonth = repo.ElproMONITORLogin.Form.ButtonTagPreviousMonth;
       var buttonTagPreviousYear = repo.ElproMONITORLogin.Form.ButtonTagPreviousYear;
       var buttonTagLast_7_Days = repo.ElproMONITORLogin.Form.ButtonTagLast_7_Days;

       
     if (buttonTagExport.Enabled == true && buttonTagReport.Enabled== true && buttonTagClose.Enabled==true && buttonTagLast_7_Days.Enabled==true
        && buttonTagPreviousWeek.Enabled==true && buttonTagPreviousMonth.Enabled==true && buttonTagPreviousYear.Enabled==true)
       	
       {
       	Report.Info("Export Button is enabled");
       	Validate.Exists(repo.ElproMONITORLogin.ContentRight.ButtonTagExportInfo);
       	Report.Screenshot(buttonTagExport);
       	
       	Report.Info("Report Button is enabled");
       	Validate.Exists(repo.ElproMONITORLogin.ContentRight.ButtonTagReportInfo);
       	Report.Screenshot(buttonTagReport);
       	
       	Report.Info("Close Button is enabled");
       	Validate.Exists(repo.ElproMONITORLogin.ContentRight.ButtonTagCloseInfo);
       	Report.Screenshot(buttonTagClose);
       	
       	Report.Screenshot(buttonTagLast_7_Days,true); Report.Screenshot(buttonTagPreviousWeek,true);
       	Report.Screenshot(buttonTagPreviousMonth,true);Report.Screenshot(buttonTagPreviousYear,true);
       }

       else if (buttonTagExport.Enabled== false)
      
       {
       Report.Screenshot(buttonTagExport);
       Report.Warn("Export Button ist not enabled");
       }
       
       else if (buttonTagReport.Enabled==false)
       	
       {
       	Report.Screenshot(buttonTagReport);
       	Report.Warn("Report Button is not enabled");
       }
      
       else if (buttonTagClose.Enabled==false)
       	
       {
       	Report.Screenshot(buttonTagClose);
       	Report.Warn("Close Button is not enabled");
       }
       
    else
      {
       Report.Warn("A Calendar button in sensor Analysis Period is not enabled");
       
      }
       
       var buttonTagShow = repo.ElproMONITORLogin.Form.ButtonTagShow;
       var buttonTagPrevious = repo.ElproMONITORLogin.Form.ButtonTagPrevious;
       var buttonTagNext = repo.ElproMONITORLogin.Form.ButtonTagNext;

       if (buttonTagShow.Enabled==true)
       {
       	buttonTagShow.MoveTo();
       	Report.Screenshot(buttonTagShow,true);
       	buttonTagPrevious.MoveTo();
       	buttonTagPrevious.Click();
       }
       
       else
       {
       	Report.Warn("Show Button in Diagram is not enabled");
       }
       
       
       if (buttonTagPrevious.Enabled==true)
       	
       {
       	buttonTagPrevious.Click();
       	Report.Screenshot(buttonTagPrevious,true);
       }
       
       else
       {
       	Report.Warn("Previous Button is not enabled");
       }
       
       if (buttonTagNext.Enabled==true)
       {
       	Report.Screenshot(buttonTagNext,true);
       }
       
       else
       	
       {
       	Report.Warn("Next button is not enabled after pressing the previous button");
       }
       
       
       for (int n= 0; n<= 3; n++)
       {
       	
       
        	switch(n)
        	{      		                 
           
            
           case 0:
             var h2TagSensorAna = repo.ElproMONITORLogin.Form.H2TagSensorAnalysis;
             var someSectionCalendar = repo.ElproMONITORLogin.Form.SomeSectionCalendar;
            Report.Screenshot(someSectionCalendar);
            continue;         

            case 1:            
             var sensorDiagram = repo.ElproMONITORLogin.Form.SensorDiagram;
             var h2TagChart = repo.ElproMONITORLogin.Form.H2TagChart;
             Report.Screenshot(sensorDiagram);
             h2TagChart.Click();
             continue;
           
            case 2:             
            var h2TagEvents = repo.ElproMONITORLogin.H2TagEvents;
            var eventList = repo.ElproMONITORLogin.EventList;
             Report.Screenshot(eventList);
             eventList.PressKeys("{PageDown}");
             Report.Screenshot(eventList);
             buttonTagClose.Click();
             continue;
            
            case 3:
            var buttonTagAnalysis = repo.ElproMONITORLogin.ContentCenter.ButtonTagAnalysis;
            var buttonTagDeactivate = repo.ElproMONITORLogin.ContentCenter.ButtonTagDeactivate;
            var buttonTagActivate = repo.ElproMONITORLogin.ContentCenter.ButtonTagActivate;
             
               if (buttonTagAnalysis.Enabled==true && buttonTagDeactivate.Enabled==true)
                {
               	Validate.Exists(repo.ElproMONITORLogin.ContentCenter.ButtonTagAnalysisInfo);
               	Report.Screenshot(buttonTagAnalysis,true);
               	
               	Validate.Exists(repo.ElproMONITORLogin.ContentCenter.ButtonTagDeactivateInfo);
               	Report.Screenshot(buttonTagDeactivate,true);
               	               	
               	Validate.Exists(repo.ElproMONITORLogin.ContentCenter.ButtonTagActivateInfo);
                }
               else
                {
            	Report.Warn("Analysis Button and Deactivate Buttons for Sensors are not enabled");
                }
               
              break; 
        	}
       
       
       
       }
       
        
       

        }
    }
}

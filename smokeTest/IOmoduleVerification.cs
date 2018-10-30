/*
 * Created by Ranorex
 * User: erdogb
 * Date: 11.04.2018
 * Time: 13:20
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
    /// Description of IOmoduleVerification.
    /// </summary>
    [TestModule("E2ED32A3-3DF2-4157-929D-9A94A76D89B8", ModuleType.UserCode, 1)]
    public class IOmoduleVerification : ITestModule
    {
    	
    	 public static smokeTestRepository repo = smokeTestRepository.Instance;
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public IOmoduleVerification()
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
                  
      
           
            var navDeviceSettingsIndex = repo.ElproMONITORLogin.NavDeviceSettingsIndex;
            var navDeviceSettingsIoModules = repo.ElproMONITORLogin.NavDeviceSettingsIoModules;

           

            
            if(navDeviceSettingsIndex.Visible==true)
            {
            navDeviceSettingsIndex.Click();
            Delay.Milliseconds(100);
            navDeviceSettingsIoModules.MoveTo();
            navDeviceSettingsIoModules.Click();
            }
            
            
           

            
           
           TdTag tdTagLB = "/dom[@caption~'^elproMONITOR\\ -\\ I/O\\ Module']//table[#'DataTables_Table_0']/tbody/tr[1]/td[3]";
          //var tdTagLB = repo.ElproMONITORLogin.ListDataTableNoFooter.TdTagLB;
         // var tdTagLB = repo.ElproMONITORLogin.ListDataTableNoFooter.TdTagLB;

           tdTagLB.MoveTo();
           tdTagLB.Click();
            
               
            
          
            var edit = repo.ElproMONITORLogin.ContentRight.Edit;

                                  
            if (edit.Enabled==true)
            	
            {
             edit.MoveTo();
             edit.Click();
            }
            
             else
             
             {
             	Report.Warn("Add Module Button is not enabled");
             	
             }
             
             
             var btnScanBridge = repo.ElproMONITORLogin.BtnScanBridge;

                  
         
          var spanTagID0105ECOLOGPRO2TH = repo.ElproMONITORLogin.PluginEditForm.SpanTagID0105ECOLOGPRO2TH;
          var spanTagID0101ECOLOGPRO4PT = repo.ElproMONITORLogin.PluginEditForm.SpanTagID0101ECOLOGPRO4PT;
          var spanTagID0102ECOLOGPRO4MA = repo.ElproMONITORLogin.PluginEditForm.SpanTagID0102ECOLOGPRO4MA;
          var spanTagID0103ECOLOGPRO4DI = repo.ElproMONITORLogin.PluginEditForm.SpanTagID0103ECOLOGPRO4DI;
          var spanTagID0104ECOLOGPRO4DO = repo.ElproMONITORLogin.PluginEditForm.SpanTagID0104ECOLOGPRO4DO;
          var scanBridgeResult4MA = repo.ElproMONITORLogin.PluginEditForm.ScanBridgeResult4MA;
          var scanBridgeResult4PT = repo.ElproMONITORLogin.PluginEditForm.ScanBridgeResult4PT;
          var scanBridgeResult4DI = repo.ElproMONITORLogin.PluginEditForm.ScanBridgeResult4DI;
          var scanBridgeResult4DO = repo.ElproMONITORLogin.PluginEditForm.ScanBridgeResult4DO;
          var scanBridgeResult2TH = repo.ElproMONITORLogin.PluginEditForm.ScanBridgeResult2TH;

         
          var cancel = repo.ElproMONITORLogin.Cancel;
           
           int noModules =5;
           
           for(int i =1; i <= noModules; i++)
           	
           {
           	if (btnScanBridge.Enabled==true)
           {
             	switch(i)
               {
          		case 1:                 
                
             	Report.Screenshot(btnScanBridge);
            	spanTagID0101ECOLOGPRO4PT.Click();
            	Delay.Milliseconds(500);
            	Report.Screenshot(spanTagID0101ECOLOGPRO4PT);
            	Report.Screenshot(scanBridgeResult4PT);                
            	spanTagID0101ECOLOGPRO4PT.Click();
           		continue;
            		
            	case 2:
           		
           		spanTagID0102ECOLOGPRO4MA.Click();
           		Keyboard.Press("{PageDown}");
           		Delay.Milliseconds(500);
           		Report.Screenshot(spanTagID0102ECOLOGPRO4MA);
           		Report.Screenshot(scanBridgeResult4MA);
           		spanTagID0102ECOLOGPRO4MA.Click();
             	continue;

             	
                case 3: 
             	
             	spanTagID0103ECOLOGPRO4DI.Click();
             	Keyboard.Press("{PageDown}");
             	Keyboard.Press("{PageDown}");
             	Delay.Milliseconds(500);
             	Report.Screenshot(spanTagID0103ECOLOGPRO4DI);
             	Report.Screenshot(scanBridgeResult4DI);
             	spanTagID0103ECOLOGPRO4DI.Click();
             	continue;
             	
             	
                case 4:
             	
             	spanTagID0104ECOLOGPRO4DO.Click();
             	Keyboard.Press("{PageDown}");
             	Delay.Milliseconds(500);
             	Report.Screenshot(spanTagID0104ECOLOGPRO4DO);
             	Report.Screenshot(scanBridgeResult4DO);
             	spanTagID0104ECOLOGPRO4DO.Click();
             	continue;
             	
             	
                case 5:
             	
             	spanTagID0105ECOLOGPRO2TH.Click();
             	Delay.Milliseconds(500);
             	Report.Screenshot(spanTagID0105ECOLOGPRO2TH);
             	Report.Screenshot(scanBridgeResult2TH);
             	spanTagID0105ECOLOGPRO2TH.Click();
             	cancel.Click();
              	break;
             	
             	
            	}
            
           	}

           	
           }
       } 
    }
}

/*
 * Created by Ranorex
 * User: erdogb
 * Date: 27.04.2018
 * Time: 09:44
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
    /// Description of VerificationElproUser.
    /// </summary>
    [TestModule("B578F6E5-287F-455F-9C71-22A0330F1701", ModuleType.UserCode, 1)]
    public class VerificationElproUser : ITestModule
    {
    	
    	public static userRepo repo = userRepo.Instance;
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerificationElproUser()
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
            
            
        var edit = repo.WebDocument192168250180.MainContentLeft.Edit;
        var add = repo.WebDocument192168250180.MainContentLeft.Add;
        var report = repo.WebDocument192168250180.MainContentLeft.Report;
        var delete = repo.WebDocument192168250180.MainContentLeft.Delete;
        var name = repo.WebDocument192168250180.Name;            
        var users = repo.WebDocument192168250180.Users;
        
        
          users.Click();
          name.Click();
          
          
          
          if(repo.WebDocument192168250180.MainContentLeft.Edit.Enabled==true||repo.WebDocument192168250180.MainContentLeft.Delete.Enabled==true)
         
                  {
            	Report.Info("edit button is enabled");
            	Report.Screenshot(edit);
                  }
        
          else
          	if(repo.WebDocument192168250180.MainContentLeft.Edit.Enabled==false||repo.WebDocument192168250180.MainContentLeft.Delete.Enabled==false)
        
    	 
                    {
         	         	Report.Error(" Edit Button not enabled");
                    }
            
        
         	
         	
            
            
        }
    }
}

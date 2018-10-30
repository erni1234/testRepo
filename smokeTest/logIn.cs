/*
 * Created by Ranorex
 * User: erdogb
 * Date: 28.03.2018
 * Time: 11:03
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
    /// Description of logIn.
    /// </summary>
    [TestModule("0FD8DAFE-0FEE-4DDE-842C-5AB594E9145C", ModuleType.UserCode, 1)]
    public class logIn : ITestModule
    {
       public static smokeTestRepository repo = smokeTestRepository.Instance;  
        
        
    	/// <summary>
        /// Constructs a new instance.
        /// </summary>
        public logIn()
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
        
            Form elproMONITORLoginInternetExplorer = "/form[@title~'^elproMONITOR\\ -\\ Login\\ -\\ In']";
            
            elproMONITORLoginInternetExplorer.Maximize();
            var submit = repo.ElproMONITORLogin.Submit;

            

            repo.ElproMONITORLogin.UserName.PressKeys("admin");
            repo.ElproMONITORLogin.Password.PressKeys("password1234");
            
            
            
            if (repo.ElproMONITORLogin.SubmitInfo.Exists(0) || repo.ElproMONITORLogin.Submit.Enabled==true)
           
            { submit.MoveTo();
            
            Report.Screenshot(submit);
            Report.Info("SUBMIT BUTTON VERIFIED");
            submit.Click();}
          
          else
            
          	Report.Info("THE IS A PROBLEM WITH THE MONITOR STARTING PAGE");

       }
    }
}

/*
 * Created by Ranorex
 * User: erdogb
 * Date: 28.03.2018
 * Time: 10:54
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
    /// Description of logOut.
    /// </summary>
    [TestModule("006387AE-2D00-4ECE-AEB5-D1F7F73DCF8F", ModuleType.UserCode, 1)]
    public class logOut : ITestModule    	
  
    {
    	public static smokeTestRepository repo = smokeTestRepository.Instance;
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public logOut()
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
          
            var elproMONITORLogin = repo.ElproMONITORLogin;

            repo.ElproMONITORLogin.NavAccountLogout.Click();
            
            
            
           // Host.Local.CloseApplication("");
            
        }
    }
}

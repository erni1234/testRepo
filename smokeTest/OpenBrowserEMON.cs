﻿/*
 * Created by Ranorex
 * User: erdogb
 * Date: 07.03.2018
 * Time: 11:17
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
    /// Description of loginEMON.
    /// </summary>
    [TestModule("15C2C4A0-A0D6-4336-B531-5F2690B8A355", ModuleType.UserCode, 1)]
    public class OpenBrowserEMON : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public OpenBrowserEMON()
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
            
           Host.Local.OpenBrowser("http://192.168.250.188/Account/Login","IE");
           
           Delay.Ms(500);
           
          
           
          
        }
    }
}

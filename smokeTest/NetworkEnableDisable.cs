/*
 * Created by Ranorex
 * User: erdogb
 * Date: 31.08.2018
 * Time: 13:39
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
using System.Diagnostics; 

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace smokeTest
{
    /// <summary>
    /// Description of NetworkEnableDisable.
    /// </summary>
    [TestModule("6D7C28B5-4270-4DCF-B7BE-B63B10A99BFD", ModuleType.UserCode, 1)]
    public class NetworkEnableDisable : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public NetworkEnableDisable()
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
            
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "ipconfig";
            info.Arguments = "/renew"; // or /release if you want to disconnect
            info.WindowStyle = ProcessWindowStyle.Hidden;
            
            
        Process p = Process.Start(info);
        p.WaitForExit();

        }
    }
}

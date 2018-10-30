﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

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
using Ranorex.Core.Repository;

namespace smokeTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CreateComments recording.
    /// </summary>
    [TestModule("d46ba475-30e5-422f-abb7-3eca53b0b707", ModuleType.Recording, 1)]
    public partial class CreateComments : ITestModule
    {
        /// <summary>
        /// Holds an instance of the smokeTestRepository repository.
        /// </summary>
        public static smokeTestRepository repo = smokeTestRepository.Instance;

        static CreateComments instance = new CreateComments();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CreateComments()
        {
            CommentName = "";
            Text = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CreateComments Instance
        {
            get { return instance; }
        }

#region Variables

        string _CommentName;

        /// <summary>
        /// Gets or sets the value of variable CommentName.
        /// </summary>
        [TestVariable("f6d10f87-5ae2-4b21-9e59-a0ba7dba4626")]
        public string CommentName
        {
            get { return _CommentName; }
            set { _CommentName = value; }
        }

        string _Text;

        /// <summary>
        /// Gets or sets the value of variable Text.
        /// </summary>
        [TestVariable("7a427472-c42f-4d66-92f4-cc742a216801")]
        public string Text
        {
            get { return _Text; }
            set { _Text = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.NavDeviceSettingsIndex' at 95;16.", repo.ElproMONITORLogin.NavDeviceSettingsIndexInfo, new RecordItemIndex(0));
            repo.ElproMONITORLogin.NavDeviceSettingsIndex.Click("95;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.NavApplicationSettingsCommentTemplates' at 89;11.", repo.ElproMONITORLogin.NavApplicationSettingsCommentTemplatesInfo, new RecordItemIndex(1));
            repo.ElproMONITORLogin.NavApplicationSettingsCommentTemplates.Click("89;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.ContentCenter.AddNewTemplate' at 64;11.", repo.ElproMONITORLogin.ContentCenter.AddNewTemplateInfo, new RecordItemIndex(2));
            repo.ElproMONITORLogin.ContentCenter.AddNewTemplate.Click("64;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{END}{SHIFT DOWN}{HOME}{SHIFT UP}{DELETE}' with focus on 'ElproMONITORLogin.Name'.", repo.ElproMONITORLogin.NameInfo, new RecordItemIndex(3));
            repo.ElproMONITORLogin.Name.PressKeys("{END}{SHIFT DOWN}{HOME}{SHIFT UP}{DELETE}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CommentName' with focus on 'ElproMONITORLogin.Name'.", repo.ElproMONITORLogin.NameInfo, new RecordItemIndex(4));
            repo.ElproMONITORLogin.Name.PressKeys(CommentName);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Text' with focus on 'ElproMONITORLogin.Text'.", repo.ElproMONITORLogin.TextInfo, new RecordItemIndex(5));
            repo.ElproMONITORLogin.Text.PressKeys(Text);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.AllowEdit' at 3;5.", repo.ElproMONITORLogin.AllowEditInfo, new RecordItemIndex(6));
            repo.ElproMONITORLogin.AllowEdit.Click("3;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ElproMONITORLogin.Save' at 19;18.", repo.ElproMONITORLogin.SaveInfo, new RecordItemIndex(7));
            repo.ElproMONITORLogin.Save.Click("19;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'ElproMONITORLogin.ContentCenter.AddNewTemplate'", repo.ElproMONITORLogin.ContentCenter.AddNewTemplateInfo, new ActionTimeout(10000), new RecordItemIndex(8));
            repo.ElproMONITORLogin.ContentCenter.AddNewTemplateInfo.WaitForExists(10000);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 30s.", new RecordItemIndex(9));
            Delay.Duration(30000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
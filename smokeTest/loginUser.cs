/*
 * Created by Ranorex
 * User: erdogb
 * Date: 24.04.2018
 * Time: 12:58
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
    /// Description of loginUser.
    /// </summary>
    [TestModule("7082E0C9-0A4B-4220-8D91-21FBEA71DDF5", ModuleType.UserCode, 1)]
    public class loginUser : ITestModule    	
     {
       
public static userRepo repo = userRepo.Instance;
    	/// <summary>
        /// Constructs a new instance.
        /// </summary>
        public loginUser()
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
     
       Form http192168250183ElproUSERInte = "/form[@title~'^http://192\\.168\\.250\\.188/el']";            
      
        
        http192168250183ElproUSERInte.Maximize();
           
            
        var elpro = repo.WebDocument192168250180.Elpro;
        var btnBtnDefaultNgScopeNgIsolateScop = repo.WebDocument192168250180.RowProductLogoContent.BtnBtnDefaultNgScopeNgIsolateScop;
      
        
        if  (repo.WebDocument192168250180.ElproInfo.Exists(0))
        	
        	{
        	repo.WebDocument192168250180.RowProductLogoContent.Username.PressKeys("admin");
            repo.WebDocument192168250180.RowProductLogoContent.Password.PressKeys("password1234");            
              
            Report.Screenshot(elpro);
            btnBtnDefaultNgScopeNgIsolateScop.Click();
             }
        
         else 
         	
         {
         	Report.Info("This is not the elproUser login");
         }

         
        var edit = repo.WebDocument192168250180.MainContentLeft.Edit;
        var add = repo.WebDocument192168250180.MainContentLeft.Add;
        var report = repo.WebDocument192168250180.MainContentLeft.Report;
        var delete = repo.WebDocument192168250180.MainContentLeft.Delete;
        var name = repo.WebDocument192168250180.Name;            
        var users = repo.WebDocument192168250180.Users;
        
        
                 
         
         
           
            if(repo.WebDocument192168250180.UsersInfo.Exists(0))
           
            {            	
           
            users.Click();
            name.Click();
            
            // verifies the exiatance of tab-buttons
            
            Validate.Exists(repo.WebDocument192168250180.MainContentLeft.EditInfo);
            Report.Screenshot(edit);
            
            Validate.Exists(repo.WebDocument192168250180.MainContentLeft.AddInfo);
            Report.Screenshot(add);

            Validate.Exists(repo.WebDocument192168250180.MainContentLeft.ReportInfo);
            Report.Screenshot(report);
            
            Validate.Exists(repo.WebDocument192168250180.MainContentLeft.DeleteInfo);
            Report.Screenshot(delete); 
            
            // checks for enabled buttons for the users
                                 
            }
            
         
            else
            	
            {
           	Report.Info("wrong User Page");
            }   
            

            if(!repo.WebDocument192168250180.MainContentLeft.Edit.Enabled!=true||!repo.WebDocument192168250180.MainContentLeft.Delete.Enabled!=true)
            	
                        	
                    {
                 	Report.Error(" Edit or Delete Button is not enabled");
                    }
            
            
            	
            
            // verifies the exixtance of side buttons for the groups
                  
            var groups = repo.WebDocument192168250180.Groups;           
            
            if (repo.WebDocument192168250180.GroupsInfo.Exists(0))
            	
            {
            	
            	Validate.Exists(repo.WebDocument192168250180.GroupsInfo);
            	groups.Click();            	
            	
            }
            
            
            else
            	
            {
            throw new Exception("Groups Page does not exits");
            }
           
            
            
          InputTag nameSupervisor = "/dom[@page='']//div[#'borderLayout_eGridPanel']/div[@id='center']/div/div[2]/div[1]/div/div[2]//input[@name='name']";
          nameSupervisor.Click();
          
          SpanTag edit1 = "/dom[@page='']//div[#'borderLayout_eGridPanel']/div[@id='center']/div/div[2]/div[2]/div/div/div[1]/div[4]/span[@innertext='Edit']";
          SpanTag delete1 = "/dom[@page='']//div[#'borderLayout_eGridPanel']/div[@id='center']/div/div[2]/div[2]/div/div/div[1]/div[5]/span[@innertext='Delete']";
          
          Validate.Exists(edit1);
          Report.Screenshot(edit1);
                    
          Validate.Exists(delete1);
          Report.Screenshot(delete1);

        }
    }
}

using MSharp;

namespace App
{
    public class Project : MSharp.Project
    {
        public Project()
        {
            Name("MSharpExperiments.DigitalAgencyWebsite")
                .SolutionFile("MSharpExperiments.DigitalAgencyWebsite.sln");

            Role("Local.Request");
            Role("Anonymous");
            Role("Admin")
                .SkipQueryStringSecurity();

            Layout("Admin default")
                .AjaxRedirect()
                .VirtualPath("~/Views/Layouts/AdminDefault.cshtml")
                .Default();

            Layout("Admin default Modal")
                .Modal()
                .VirtualPath("~/Views/Layouts/AdminDefault.Modal.cshtml");

            Layout("Login")
                .AjaxRedirect()
                .VirtualPath("~/Views/Layouts/Login.cshtml");

            Layout("Blank")
                .AjaxRedirect()
                .VirtualPath("~/Views/Layouts/Blank.cshtml");

            Layout("Default")
                .AjaxRedirect()
                .VirtualPath("~/Views/Layouts/Default.cshtml");

            PageSetting("LeftMenu");
            PageSetting("SubMenu");
            PageSetting("TopMenu");

            PageSetting("MainNav");
            PageSetting("MainFooter");

            AutoTask("Clean old temp uploads")
                .Every(10, TimeUnit.Minute)
                .Run("await Olive.Mvc.FileUploadService.DeleteTempFiles(olderThan: 1.Hours());");
        }
    }
}
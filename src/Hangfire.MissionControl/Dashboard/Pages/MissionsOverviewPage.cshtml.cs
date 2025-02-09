#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hangfire.MissionControl.Dashboard.Pages;

#line 2 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
using System.Linq;
    
#line default
#line hidden
#line 3 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
using Hangfire.Dashboard.Pages;
    
#line default
#line hidden
    
#line 4 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
using Hangfire.MissionControl;
    
#line default
#line hidden
    
#line 5 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
#line default
#line hidden
    
#line 6 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
using Hangfire.MissionControl.Dashboard.Pages.Controls;
    
#line default
#line hidden
    
#line 7 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
using Hangfire.MissionControl.Model;
    
#line default
#line hidden
    
[System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
internal partial class MissionsOverviewPage : Hangfire.Dashboard.RazorPage
{
#line hidden

    public override void Execute()
    {


        WriteLiteral("\r\n");









            
#line 9 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
  
        string selectedCategory = this.SelectedCategory;
        MissionMap missionMap = this.MissionMap;
        MissionControlOptions options = this.Options;
        Layout = new LayoutPage(Title);
        var availableMissions = missionMap.Missions.Where(x => x.Value.CategoryName == selectedCategory).Select(x => x.Value).ToArray();


            
#line default
#line hidden
        WriteLiteral("\r\n<link rel=\"stylesheet\" type=\"text/css\" href=\"");


            
#line 17 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
        Write(Url.To("/mission-control/css/cssstyles"));

            
#line default
#line hidden
        WriteLiteral("\" />\r\n<link rel=\"stylesheet\" type=\"text/css\" href=\"");


            
#line 18 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
        Write(Url.To("/mission-control/css/cssbootstrapdatetimepicker"));

            
#line default
#line hidden
        WriteLiteral("\" />\r\n<script>\r\n    var baseUrl = \"");


            
#line 20 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
        Write(Url.To("/mission/launch"));

            
#line default
#line hidden
        WriteLiteral("\";\r\n    var idFieldName = \"");


            
#line 21 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
        Write(Mission.IdField);

            
#line default
#line hidden
        WriteLiteral("\";\r\n    var jobLinkBaseUrl = \"");


            
#line 22 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
        Write(Url.JobDetails(""));

            
#line default
#line hidden
        WriteLiteral("\";\r\n    var requireConfirmation = ");


            
#line 23 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
        Write(options.RequireConfirmation.ToString().ToLowerInvariant());

            
#line default
#line hidden
        WriteLiteral(";\r\n</script>\r\n<script type=\"application/javascript\" src=\"");


            
#line 25 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
        Write(Url.To("/mission-control/js/jsmoment"));

            
#line default
#line hidden
        WriteLiteral("\"></script>\r\n<script defer type=\"application/javascript\" src=\"");


            
#line 26 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
        Write(Url.To("/mission-control/js/jsbootstrapdatetimepicker"));

            
#line default
#line hidden
        WriteLiteral("\"></script>\r\n<script defer type=\"application/javascript\" src=\"");


            
#line 27 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
        Write(Url.To("/mission-control/js/jspage"));

            
#line default
#line hidden
        WriteLiteral("\"></script>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        ");


            
#line 31 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
        Write(CategoriesSidebar.Render(Html, selectedCategory, missionMap));

            
#line default
#line hidden
        WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-9\">\r\n        <h1 class=\"page-header\">");


            
#line 34 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
        Write(selectedCategory);

            
#line default
#line hidden
        WriteLiteral("</h1>\r\n");


            
#line 35 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
        if (availableMissions.Length == 0)
        {

            
#line default
#line hidden
            WriteLiteral("            <div class=\"alert alert-warning\" role=\"alert\">\r\n                No mi" +
                         "ssions for a selected category are available.\r\n            </div>\r\n");


            
#line 40 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
        }

            
#line default
#line hidden
        WriteLiteral("\r\n");


            
#line 42 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
        foreach (var mission in availableMissions)
        {

            
#line default
#line hidden
            WriteLiteral("            <div class=\"panel panel-default\">\r\n                <div class=\"panel-" +
                         "heading\">\r\n                    <div class=\"btn-group\">\r\n                        " +
                         "<a role=\"button\" data-toggle=\"collapse\" href=\"#");


            
#line 47 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
            Write(mission.Id);

            
#line default
#line hidden
            WriteLiteral("-panel\" aria-expanded=\"false\">\r\n                            <h3 class=\"panel-titl" +
                         "e\">\r\n                                ");


            
#line 49 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
            Write(mission.Name);

            
#line default
#line hidden
            WriteLiteral("\r\n                            </h3>\r\n                        </a>\r\n              " +
                         "      </div>\r\n                </div>\r\n                <div id=\"");


            
#line 54 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
            Write(mission.Id);

            
#line default
#line hidden
            WriteLiteral("-panel\" class=\"panel-body collapse\">\r\n");


            
#line 55 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
            if (!string.IsNullOrWhiteSpace(mission.Description))
            {

            
#line default
#line hidden
                WriteLiteral("                        <p>");


            
#line 57 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                Write(mission.Description);

            
#line default
#line hidden
                WriteLiteral("</p>\r\n");


            
#line 58 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
            }

            
#line default
#line hidden
            WriteLiteral("\r\n");


            
#line 60 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                      
            var snippetStyle = IsReadOnly ? "margin-bottom: 0px" : "";
                    

            
#line default
#line hidden

            
#line 63 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
            if (options.HideCodeSnippet is false)
            {

            
#line default
#line hidden
                WriteLiteral("                        <div class=\"job-snippet\" style=\"");


            
#line 65 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                Write(snippetStyle);

            
#line default
#line hidden
                WriteLiteral("\">\r\n                            <div class=\"job-snippet-code\">\r\n                 " +
                             "               <kbd style=\"float: right\"><span class=\"glyphicon glyphicon-consol" +
                             "e\"></span>&nbsp;queue:&nbsp;");


            
#line 67 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                Write(mission.Queue ?? "default");

            
#line default
#line hidden
                WriteLiteral("</kbd>\r\n                                <pre><code>");


            
#line 68 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                Write(MissionRenderer.RenderMission(mission.MethodInfo));

            
#line default
#line hidden
                WriteLiteral("</code></pre>\r\n                            </div>\r\n                        </div>" +
                             "\r\n");


            
#line 71 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
            }

            
#line default
#line hidden

            
#line 72 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
            if (!IsReadOnly)
            {

            
#line default
#line hidden
                WriteLiteral("                        <form id=\"");


            
#line 74 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                Write(mission.Id);

            
#line default
#line hidden
                WriteLiteral("\" autocomplete=\"off\">\r\n");


            
#line 75 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                foreach (var parameter in mission.MethodInfo.GetParameters())
                {
                    var control = ControlFactory.CreateControl(parameter);
                    if (control is NullControl)
                    {
                        continue;
                    }


            
#line default
#line hidden
                    WriteLiteral("                                <div class=\"form-group\">\r\n                       " +
                                 "             ");


            
#line 84 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                    Write(Html.RenderPartial(control));

            
#line default
#line hidden
                    WriteLiteral("\r\n                                </div>\r\n");


            
#line 86 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                }

            
#line default
#line hidden
                WriteLiteral("\r\n                            <button type=\"button\" class=\"btn btn-info\" onclick=" +
                             "\"onMissionStart(this, \'");


            
#line 88 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
                Write(mission.Id);

            
#line default
#line hidden
                WriteLiteral("\');\">Enqueue</button>\r\n                        </form>\r\n");


            
#line 90 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
            }

            
#line default
#line hidden
            WriteLiteral("                </div>\r\n                <div id=\"");


            
#line 92 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
            Write(mission.Id);

            
#line default
#line hidden
            WriteLiteral("-alerts\" class=\"panel-footer hidden\"></div>\r\n            </div>\r\n");


            
#line 94 "..\..\Dashboard\Pages\MissionsOverviewPage.cshtml"
        }

            
#line default
#line hidden
        WriteLiteral("    </div>\r\n</div>");


    }
}
#pragma warning restore 1591

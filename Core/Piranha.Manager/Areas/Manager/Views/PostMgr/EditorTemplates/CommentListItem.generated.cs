﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Piranha.Areas.Manager.Views.PostMgr.EditorTemplates
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Piranha;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Manager/Views/PostMgr/EditorTemplates/CommentListItem.cshtml")]
    public partial class CommentListItem_ : System.Web.Mvc.WebViewPage<Piranha.Manager.Models.Post.EditModel.CommentListItem>
    {
        public CommentListItem_()
        {
        }
        public override void Execute()
        {
WriteLiteral("<tr>\r\n\t<td>\r\n");

WriteLiteral("\t\t");

            
            #line 5 "..\..\Areas\Manager\Views\PostMgr\EditorTemplates\CommentListItem.cshtml"
   Write(Html.HiddenFor(m => m.Id, new { @class = "comment-id" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("\t\t");

            
            #line 6 "..\..\Areas\Manager\Views\PostMgr\EditorTemplates\CommentListItem.cshtml"
   Write(Model.Created.ToString("yyyy-MM-dd"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\t</td>\r\n\t<td>\r\n\t\t<a");

WriteLiteral(" data-toggle=\"collapse\"");

WriteAttribute("href", Tuple.Create(" href=\"", 221), Tuple.Create("\"", 238)
, Tuple.Create(Tuple.Create("", 228), Tuple.Create("#", 228), true)
            
            #line 9 "..\..\Areas\Manager\Views\PostMgr\EditorTemplates\CommentListItem.cshtml"
, Tuple.Create(Tuple.Create("", 229), Tuple.Create<System.Object, System.Int32>(Model.Id
            
            #line default
            #line hidden
, 229), false)
);

WriteLiteral(">");

            
            #line 9 "..\..\Areas\Manager\Views\PostMgr\EditorTemplates\CommentListItem.cshtml"
                                               Write(Model.Author);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n\t\t<div");

WriteAttribute("id", Tuple.Create(" id=\"", 265), Tuple.Create("\"", 279)
            
            #line 10 "..\..\Areas\Manager\Views\PostMgr\EditorTemplates\CommentListItem.cshtml"
, Tuple.Create(Tuple.Create("", 270), Tuple.Create<System.Object, System.Int32>(Model.Id
            
            #line default
            #line hidden
, 270), false)
);

WriteLiteral(" class=\"collapse\"");

WriteLiteral(">\r\n\t\t\t<p");

WriteLiteral(" class=\"well well-sm comment-body\"");

WriteLiteral(">\r\n");

            
            #line 12 "..\..\Areas\Manager\Views\PostMgr\EditorTemplates\CommentListItem.cshtml"
				
            
            #line default
            #line hidden
            
            #line 12 "..\..\Areas\Manager\Views\PostMgr\EditorTemplates\CommentListItem.cshtml"
                 if (!String.IsNullOrWhiteSpace(Model.Email)) {

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t<strong>Author email: </strong>");

WriteLiteral("<a");

WriteAttribute("href", Tuple.Create(" href=\"", 433), Tuple.Create("\"", 459)
, Tuple.Create(Tuple.Create("", 440), Tuple.Create("mailto:", 440), true)
            
            #line 13 "..\..\Areas\Manager\Views\PostMgr\EditorTemplates\CommentListItem.cshtml"
, Tuple.Create(Tuple.Create("", 447), Tuple.Create<System.Object, System.Int32>(Model.Email
            
            #line default
            #line hidden
, 447), false)
);

WriteLiteral(">");

            
            #line 13 "..\..\Areas\Manager\Views\PostMgr\EditorTemplates\CommentListItem.cshtml"
                                                                            Write(Model.Email);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 14 "..\..\Areas\Manager\Views\PostMgr\EditorTemplates\CommentListItem.cshtml"
				}

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t");

            
            #line 15 "..\..\Areas\Manager\Views\PostMgr\EditorTemplates\CommentListItem.cshtml"
                 if (!String.IsNullOrWhiteSpace(Model.WebSite)) {

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t<strong>Author website: </strong>");

WriteLiteral("<a");

WriteAttribute("href", Tuple.Create(" href=\"", 581), Tuple.Create("\"", 602)
            
            #line 16 "..\..\Areas\Manager\Views\PostMgr\EditorTemplates\CommentListItem.cshtml"
, Tuple.Create(Tuple.Create("", 588), Tuple.Create<System.Object, System.Int32>(Model.WebSite
            
            #line default
            #line hidden
, 588), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 16 "..\..\Areas\Manager\Views\PostMgr\EditorTemplates\CommentListItem.cshtml"
                                                                                         Write(Model.WebSite);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 17 "..\..\Areas\Manager\Views\PostMgr\EditorTemplates\CommentListItem.cshtml"
				}

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t");

            
            #line 18 "..\..\Areas\Manager\Views\PostMgr\EditorTemplates\CommentListItem.cshtml"
                 if (!String.IsNullOrWhiteSpace(Model.Email) || !String.IsNullOrWhiteSpace(Model.WebSite)) {

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t\t<br>");

WriteLiteral("<br>\r\n");

            
            #line 20 "..\..\Areas\Manager\Views\PostMgr\EditorTemplates\CommentListItem.cshtml"
				}

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t");

            
            #line 21 "..\..\Areas\Manager\Views\PostMgr\EditorTemplates\CommentListItem.cshtml"
           Write(Html.Raw(Model.Body.Replace("\n", "<br>")));

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t</p>\r\n\t\t</div>\r\n\t</td>\r\n\t<td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">");

            
            #line 25 "..\..\Areas\Manager\Views\PostMgr\EditorTemplates\CommentListItem.cshtml"
                       Write(Html.CheckBoxFor(m => m.IsApproved, new { @class = "comment-approved" }));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n\t<td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">");

            
            #line 26 "..\..\Areas\Manager\Views\PostMgr\EditorTemplates\CommentListItem.cshtml"
                       Write(Html.CheckBoxFor(m => m.IsSpam, new { @class = "comment-spam" }));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n</tr>");

        }
    }
}
#pragma warning restore 1591

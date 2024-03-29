// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
// 0114: suppress "Foo.BarController.Baz()' hides inherited member 'Qux.BarController.Baz()'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword." when an action (with an argument) overrides an action in a parent controller
#pragma warning disable 1591, 3008, 3009, 0108, 0114
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace T4MVC
{
    public class PartialsController
    {

        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
            }
            static readonly _GridClass s_Grid = new _GridClass();
            public _GridClass Grid { get { return s_Grid; } }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public partial class _GridClass
            {
                static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
                public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
                public class _ViewNamesClass
                {
                    public readonly string Bootstrap3_Fluid = "Bootstrap3-Fluid";
                    public readonly string Bootstrap3 = "Bootstrap3";
                }
                public readonly string Bootstrap3_Fluid = "~/Views/Partials/Grid/Bootstrap3-Fluid.cshtml";
                public readonly string Bootstrap3 = "~/Views/Partials/Grid/Bootstrap3.cshtml";
                static readonly _EditorsClass s_Editors = new _EditorsClass();
                public _EditorsClass Editors { get { return s_Editors; } }
                [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
                public partial class _EditorsClass
                {
                    static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
                    public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
                    public class _ViewNamesClass
                    {
                        public readonly string Base = "Base";
                        public readonly string Embed = "Embed";
                        public readonly string Macro = "Macro";
                        public readonly string Media = "Media";
                        public readonly string Rte = "Rte";
                        public readonly string Textstring = "Textstring";
                    }
                    public readonly string Base = "~/Views/Partials/Grid/Editors/Base.cshtml";
                    public readonly string Embed = "~/Views/Partials/Grid/Editors/Embed.cshtml";
                    public readonly string Macro = "~/Views/Partials/Grid/Editors/Macro.cshtml";
                    public readonly string Media = "~/Views/Partials/Grid/Editors/Media.cshtml";
                    public readonly string Rte = "~/Views/Partials/Grid/Editors/Rte.cshtml";
                    public readonly string Textstring = "~/Views/Partials/Grid/Editors/Textstring.cshtml";
                }
            }
        }
    }

}

#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108, 0114

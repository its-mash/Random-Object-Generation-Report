#pragma checksum "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\Pages\Report.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bf5a3ba348f1b462b5ea566692d785d32350680"
// <auto-generated/>
#pragma warning disable 1591
namespace Random_Object_Generation.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\_Imports.razor"
using Random_Object_Generation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\_Imports.razor"
using Random_Object_Generation.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\_Imports.razor"
using Random_Object_Generation.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/report")]
    public partial class Report : ReportBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"text-center\">Report</h3>\r\n\r\n");
#nullable restore
#line 6 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\Pages\Report.razor"
 if (unknownObjects == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<div>\r\n        loading\r\n    </div>\r\n");
#nullable restore
#line 11 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\Pages\Report.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table table-bordered");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, @"<thead>
            <tr>
                <th scope=""col"" class=""text-center"">Numeric</th>
                <th scope=""col"" class=""text-center"">Alphanumeric</th>
                <th scope=""col"" class=""text-center"">Float</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "tr");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "td");
            __builder.AddAttribute(13, "class", "text-center");
            __builder.AddContent(14, 
#nullable restore
#line 25 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\Pages\Report.razor"
                                         NumericPercentage.ToString("0.##")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddAttribute(17, "class", "text-center");
            __builder.AddContent(18, 
#nullable restore
#line 26 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\Pages\Report.razor"
                                         AlphaNumbericPercentage.ToString("0.##")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "td");
            __builder.AddAttribute(21, "class", "text-center");
            __builder.AddContent(22, 
#nullable restore
#line 27 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\Pages\Report.razor"
                                         FloatPercentage.ToString("0.##")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "p-3 m-3");
            __builder.AddMarkupContent(29, "\r\n\r\n");
#nullable restore
#line 33 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\Pages\Report.razor"
         foreach(UnknownObject ob in unknownObjects)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "            ");
            __builder.OpenElement(31, "div");
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.AddContent(33, 
#nullable restore
#line 36 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\Pages\Report.razor"
                 ob.Value

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(34, " - ");
            __builder.AddContent(35, 
#nullable restore
#line 36 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\Pages\Report.razor"
                             ob.Type

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 38 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\Pages\Report.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 40 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\Pages\Report.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

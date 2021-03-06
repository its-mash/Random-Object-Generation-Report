#pragma checksum "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\Pages\RandomObjectGeneration.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb74961fec6635c3fe25413e083a279674de2c3c"
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
#nullable restore
#line 4 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\Pages\RandomObjectGeneration.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class RandomObjectGeneration : RandomObjectGenerationBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"text-center\">Random Object Generation</h3>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\Pages\RandomObjectGeneration.razor"
 if (randomObjects == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<div>\r\n        Loading\r\n    </div>\r\n");
#nullable restore
#line 16 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\Pages\RandomObjectGeneration.razor"
}
else
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\Pages\RandomObjectGeneration.razor"
     foreach (var randomObject in randomObjects)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card text-center mb-4");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-header");
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "type", "checkbox");
            __builder.AddAttribute(12, "disabled", 
#nullable restore
#line 24 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\Pages\RandomObjectGeneration.razor"
                                                 IsGenerating

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(13, "checked", 
#nullable restore
#line 24 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\Pages\RandomObjectGeneration.razor"
                                                                       randomObject.IsEnable

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\Pages\RandomObjectGeneration.razor"
                                                                                                       eventArgs => { CheckBoxClicked(randomObject); }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventPreventDefaultAttribute(15, "onclick", 
#nullable restore
#line 24 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\Pages\RandomObjectGeneration.razor"
                                                                                                                                                                                 true

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.AddContent(17, 
#nullable restore
#line 25 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\Pages\RandomObjectGeneration.razor"
                 randomObject.Type

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "card-body d-flex");
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "col-4 form-group d-flex flex-row justify-content-center");
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.AddMarkupContent(26, "<label class=\"col-8 align-self-center\" for=\"currentPercentage\"> Preferred Percentage : </label>\r\n                    ");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "disabled", 
#nullable restore
#line 30 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\Pages\RandomObjectGeneration.razor"
                                      !randomObject.IsEnable || IsGenerating 

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(29, "class", "col-4");
            __builder.AddAttribute(30, "type", "number");
            __builder.AddAttribute(31, "max", "100");
            __builder.AddAttribute(32, "min", "0");
            __builder.AddAttribute(33, "value", 
#nullable restore
#line 30 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\Pages\RandomObjectGeneration.razor"
                                                                                                                                    randomObject.PreferredPercentage

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\Pages\RandomObjectGeneration.razor"
                                                                                                                                                                                eventArgs => { PreferredPercentageChanged(randomObject, eventArgs); }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "step", "1");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "col-4 form-group d-flex flex-row justify-content-center");
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.AddMarkupContent(41, "<label class=\"col-8 align-self-center\" for=\"currentPercentage\"> Current Percentage : </label>\r\n                    ");
            __builder.OpenElement(42, "label");
            __builder.AddAttribute(43, "class", "col-2 badge badge-light p-1 align-self-center");
            __builder.AddContent(44, 
#nullable restore
#line 34 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\Pages\RandomObjectGeneration.razor"
                                                                                  randomObject.GetCurrentPercentage().ToString("0.##")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "col-4 form-group  d-flex flex-row justify-content-center");
            __builder.AddMarkupContent(49, "\r\n                    ");
            __builder.OpenElement(50, "label");
            __builder.AddAttribute(51, "class", "col-8");
            __builder.AddAttribute(52, "for", "currentPercentage align-self-center");
            __builder.AddContent(53, " Last Generated ");
            __builder.AddContent(54, 
#nullable restore
#line 37 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\Pages\RandomObjectGeneration.razor"
                                                                                                    randomObject.Type

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(55, " : ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                    ");
            __builder.OpenElement(57, "label");
            __builder.AddAttribute(58, "class", "col-4 badge badge-light p-1 align-self-center");
            __builder.AddContent(59, 
#nullable restore
#line 38 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\Pages\RandomObjectGeneration.razor"
                                                                                   (MarkupString)randomObject.LastGeneratedObject

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n            ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "card-footer text-muted");
            __builder.AddMarkupContent(65, "\r\n                ");
            __builder.AddMarkupContent(66, "<label for=\"totalCount\"> Total Generated: </label>\r\n                ");
            __builder.OpenElement(67, "label");
            __builder.AddAttribute(68, "class", "badge badge-info p-1");
            __builder.AddContent(69, " ");
            __builder.AddContent(70, 
#nullable restore
#line 43 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\Pages\RandomObjectGeneration.razor"
                                                      randomObject.GetThisObjectGeneratedCount()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n");
#nullable restore
#line 46 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\Pages\RandomObjectGeneration.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(74, "    <hr>\r\n");
            __builder.AddContent(75, "    ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "d-flex justify-content-center p-4");
            __builder.AddMarkupContent(78, "\r\n        ");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "col-8");
            __builder.AddMarkupContent(81, "\r\n");
#nullable restore
#line 51 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\Pages\RandomObjectGeneration.razor"
             if (TotalPercentage != 100)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(82, "                ");
            __builder.AddMarkupContent(83, "<div class=\"alert alert-danger\" role=\"alert\">\r\n                    Error: Total Percentage has to be 100\r\n                </div>\r\n");
#nullable restore
#line 56 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\Pages\RandomObjectGeneration.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\Pages\RandomObjectGeneration.razor"
             if (!AtLeastOneEnabled)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(84, "                ");
            __builder.AddMarkupContent(85, "<div class=\"alert alert-danger\" role=\"alert\">\r\n                    Error: Please select at least one Object\r\n                </div>\r\n");
#nullable restore
#line 62 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\Pages\RandomObjectGeneration.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(86, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n");
            __builder.AddContent(89, "    ");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "class", "form-group d-flex justify-content-end align-items-center p-3");
            __builder.AddMarkupContent(92, "\r\n        ");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "col-4 align-self-right");
            __builder.AddMarkupContent(95, "\r\n            ");
            __builder.AddMarkupContent(96, "<label>Size in KB : </label>\r\n            ");
            __builder.OpenElement(97, "input");
            __builder.AddAttribute(98, "type", "number");
            __builder.AddAttribute(99, "max", "1024");
            __builder.AddAttribute(100, "min", "1");
            __builder.AddAttribute(101, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 70 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\Pages\RandomObjectGeneration.razor"
                                        FileSizeInKB

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(102, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => FileSizeInKB = __value, FileSizeInKB, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n        ");
            __builder.OpenElement(105, "div");
            __builder.AddAttribute(106, "class", "col-2 align-self-left");
            __builder.AddMarkupContent(107, "\r\n            ");
            __builder.OpenElement(108, "button");
            __builder.AddAttribute(109, "class", "btn btn-success btn-lg rounded");
            __builder.AddAttribute(110, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\Pages\RandomObjectGeneration.razor"
                                                                     StartGenerating

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(111, "disabled", 
#nullable restore
#line 73 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\Pages\RandomObjectGeneration.razor"
                                                                                                 !AtLeastOneEnabled || TotalPercentage != 100 || IsGenerating

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(112, "Start");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n        ");
            __builder.OpenElement(115, "div");
            __builder.AddAttribute(116, "class", "col-2 align-self-left");
            __builder.AddMarkupContent(117, "\r\n            ");
            __builder.OpenElement(118, "button");
            __builder.AddAttribute(119, "class", "btn btn-danger btn-lg rounded");
            __builder.AddAttribute(120, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 76 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\Pages\RandomObjectGeneration.razor"
                                                                    StopGenerating

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(121, "disabled", 
#nullable restore
#line 76 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\Pages\RandomObjectGeneration.razor"
                                                                                               !IsGenerating

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(122, "End");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n    <h1></h1>\r\n    <hr>\r\n    ");
            __builder.OpenElement(126, "div");
            __builder.AddAttribute(127, "class", "form-group d-flex justify-content-center align-items-center");
            __builder.AddMarkupContent(128, "\r\n        ");
            __builder.OpenElement(129, "div");
            __builder.AddAttribute(130, "class", "col-3");
            __builder.AddMarkupContent(131, "\r\n");
#nullable restore
#line 84 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\Pages\RandomObjectGeneration.razor"
             if (!IsGenerating)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(132, "                ");
            __builder.AddMarkupContent(133, "<a class=\"btn btn-primary btn-lg btn-block rounded \" href=\"/report\">Generate Report</a>\r\n");
#nullable restore
#line 87 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\Pages\RandomObjectGeneration.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(134, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n    <hr>\r\n");
#nullable restore
#line 91 "C:\Users\Akash\Desktop\Random Object Generation\Random Object Generation\Pages\RandomObjectGeneration.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor httpContextAccessor { get; set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\jjuip2\Desktop\GIT_27Maal\27MaalBlazor\27MaalBlazor\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa3ce4fdd06f6b5ed401c66f16d55af794df781e"
// <auto-generated/>
#pragma warning disable 1591
namespace _27MaalBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 3 "C:\Users\jjuip2\Desktop\GIT_27Maal\27MaalBlazor\27MaalBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jjuip2\Desktop\GIT_27Maal\27MaalBlazor\27MaalBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jjuip2\Desktop\GIT_27Maal\27MaalBlazor\27MaalBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jjuip2\Desktop\GIT_27Maal\27MaalBlazor\27MaalBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jjuip2\Desktop\GIT_27Maal\27MaalBlazor\27MaalBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jjuip2\Desktop\GIT_27Maal\27MaalBlazor\27MaalBlazor\_Imports.razor"
using _27MaalBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jjuip2\Desktop\GIT_27Maal\27MaalBlazor\27MaalBlazor\_Imports.razor"
using _27MaalBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jjuip2\Desktop\GIT_27Maal\27MaalBlazor\27MaalBlazor\Pages\Index.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jjuip2\Desktop\GIT_27Maal\27MaalBlazor\27MaalBlazor\Pages\Index.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jjuip2\Desktop\GIT_27Maal\27MaalBlazor\27MaalBlazor\Pages\Index.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddAttribute(2, "style", "padding-top: 10px; padding-left: 10px; padding-bottom: 30px;");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "style", "float: left;");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "img");
            __builder.AddAttribute(8, "src", 
#nullable restore
#line 11 "C:\Users\jjuip2\Desktop\GIT_27Maal\27MaalBlazor\27MaalBlazor\Pages\Index.razor"
                   imageSource

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.AddMarkupContent(11, @"<div>
        <h2 style=""padding-left: 570px; padding-top: 1px; font-family:Verdana; font-weight: bold;"">Egedal kommune 27 mål</h2>
        <h4 style=""padding-left: 310px; font-family:Verdana; font-weight: bold; "">Følg med i Egedals arbejde mod at blive et endnu bedre sted at bo og arbejde</h4>

    </div>

");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "row");
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "style", "padding-bottom: 25px; padding-top: 10px; padding-left: 15px;");
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "select");
            __builder.AddAttribute(20, "class", "form-control");
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\jjuip2\Desktop\GIT_27Maal\27MaalBlazor\27MaalBlazor\Pages\Index.razor"
                                                 VælgGraf

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "style", "width:500px; font-size: 20px; border:2px solid rgba(0,0,0,0.4); background-color: rgb(245, 242, 230); ");
            __builder.AddMarkupContent(23, "\r\n\r\n");
#nullable restore
#line 25 "C:\Users\jjuip2\Desktop\GIT_27Maal\27MaalBlazor\27MaalBlazor\Pages\Index.razor"
             foreach (var mulighed in valg)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(24, "                ");
            __builder.OpenElement(25, "option");
            __builder.AddAttribute(26, "value", 
#nullable restore
#line 27 "C:\Users\jjuip2\Desktop\GIT_27Maal\27MaalBlazor\27MaalBlazor\Pages\Index.razor"
                               mulighed

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(27, 
#nullable restore
#line 27 "C:\Users\jjuip2\Desktop\GIT_27Maal\27MaalBlazor\27MaalBlazor\Pages\Index.razor"
                                         mulighed

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
#nullable restore
#line 28 "C:\Users\jjuip2\Desktop\GIT_27Maal\27MaalBlazor\27MaalBlazor\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
#nullable restore
#line 37 "C:\Users\jjuip2\Desktop\GIT_27Maal\27MaalBlazor\27MaalBlazor\Pages\Index.razor"
 if (tal == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(33, "    ");
            __builder.AddMarkupContent(34, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 40 "C:\Users\jjuip2\Desktop\GIT_27Maal\27MaalBlazor\27MaalBlazor\Pages\Index.razor"
}
else
{


#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "    ");
            __builder.OpenElement(36, "table");
            __builder.AddAttribute(37, "class", "table");
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.AddMarkupContent(39, @"<thead>
            <tr>
                <th style=""border: 1px solid #ccc; text-align: center; background-color:rgb(214, 224, 197); border-color: white; padding: 1rem;"">Placering</th>
                <th style=""border: 1px solid #ccc; text-align: center; background-color:rgb(214, 224, 197); border-color: white; padding: 1rem;"">Seneste placering Egedal</th>
                <th style=""border: 1px solid #ccc; text-align: center; background-color:rgb(214, 224, 197); border-color: white; padding: 1rem;"">Status Egedal</th>
                <th style=""border: 1px solid #ccc; text-align: center; background-color:rgb(214, 224, 197); border-color: white; padding: 1rem;"">Seneste måling Egedal</th>
                <th style=""border: 1px solid #ccc; text-align: center; background-color:rgb(214, 224, 197); border-color: white; padding: 1rem;"">Status Danmark</th>

            </tr>
        </thead>
        ");
            __builder.OpenElement(40, "tbody");
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.OpenElement(42, "tr");
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.OpenElement(44, "td");
            __builder.AddAttribute(45, "style", "border: 1px solid #ccc; text-align: center; background-color:whitesmoke; border-color: white; padding: 1rem;");
            __builder.AddContent(46, 
#nullable restore
#line 59 "C:\Users\jjuip2\Desktop\GIT_27Maal\27MaalBlazor\27MaalBlazor\Pages\Index.razor"
                                                                                                                                          tal.placering

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.OpenElement(48, "td");
            __builder.AddAttribute(49, "style", "border: 1px solid #ccc; text-align: center; background-color:whitesmoke; border-color: white; padding: 1rem;");
            __builder.AddContent(50, 
#nullable restore
#line 60 "C:\Users\jjuip2\Desktop\GIT_27Maal\27MaalBlazor\27MaalBlazor\Pages\Index.razor"
                                                                                                                                          tal.senesteEgedal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                ");
            __builder.OpenElement(52, "td");
            __builder.AddAttribute(53, "style", "border: 1px solid #ccc; text-align: center; background-color:whitesmoke; border-color: white; padding: 1rem;");
            __builder.AddContent(54, 
#nullable restore
#line 61 "C:\Users\jjuip2\Desktop\GIT_27Maal\27MaalBlazor\27MaalBlazor\Pages\Index.razor"
                                                                                                                                          tal.statusEgedal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                ");
            __builder.OpenElement(56, "td");
            __builder.AddAttribute(57, "style", "border: 1px solid #ccc; text-align: center; background-color:whitesmoke; border-color: white; padding: 1rem;");
            __builder.AddContent(58, 
#nullable restore
#line 62 "C:\Users\jjuip2\Desktop\GIT_27Maal\27MaalBlazor\27MaalBlazor\Pages\Index.razor"
                                                                                                                                          tal.senesteDanmark

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                ");
            __builder.OpenElement(60, "td");
            __builder.AddAttribute(61, "style", "border: 1px solid #ccc; text-align: center; background-color:whitesmoke; border-color: white; padding: 1rem;");
            __builder.AddContent(62, 
#nullable restore
#line 63 "C:\Users\jjuip2\Desktop\GIT_27Maal\27MaalBlazor\27MaalBlazor\Pages\Index.razor"
                                                                                                                                          tal.statusDanmark

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n\r\n\r\n\r\n\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n");
            __builder.AddContent(67, "    ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "style", "padding-top: 30px;");
            __builder.AddMarkupContent(70, "\r\n        ");
            __builder.OpenElement(71, "table");
            __builder.AddAttribute(72, "class", "table");
            __builder.AddMarkupContent(73, "\r\n            ");
            __builder.OpenElement(74, "thead");
            __builder.AddMarkupContent(75, "\r\n                ");
            __builder.OpenElement(76, "tr");
            __builder.AddMarkupContent(77, "\r\n                    ");
            __builder.AddMarkupContent(78, "<th style=\"border: 1px solid #ccc; text-align: center; background-color:rgb(214, 224, 197); border-color: white; padding: 1rem;\">Indikator</th>\r\n                    ");
            __builder.OpenElement(79, "td");
            __builder.AddAttribute(80, "style", "border: 1px solid #ccc; text-align: left; background-color:rgb(214, 224, 197); border-color: white; padding: 1rem;");
            __builder.AddContent(81, 
#nullable restore
#line 78 "C:\Users\jjuip2\Desktop\GIT_27Maal\27MaalBlazor\27MaalBlazor\Pages\Index.razor"
                                                                                                                                                    tal.Indikator

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n            ");
            __builder.OpenElement(85, "tbody");
            __builder.AddMarkupContent(86, "\r\n                ");
            __builder.AddMarkupContent(87, @"<tr>
                    <th style=""border: 1px solid #ccc; text-align: center; width: 250px; background-color:whitesmoke; border-color: white; padding: 1rem;"">Mål</th>
                    <td style=""border: 1px solid #ccc; text-align: left; background-color:whitesmoke; border-color: white; padding: 1rem;"">Top 10 i Danmark</td>
                </tr>
                ");
            __builder.OpenElement(88, "tr");
            __builder.AddMarkupContent(89, "\r\n                    ");
            __builder.AddMarkupContent(90, "<th style=\"border: 1px solid #ccc; text-align: center; background-color:rgb(214, 224, 197); border-color: white; padding: 1rem;\">Hvorfor er det vigtigt?</th>\r\n                    ");
            __builder.OpenElement(91, "td");
            __builder.AddAttribute(92, "style", "border: 1px solid #ccc; text-align: left; background-color:rgb(214, 224, 197); border-color: white; padding: 1rem;");
            __builder.AddContent(93, 
#nullable restore
#line 88 "C:\Users\jjuip2\Desktop\GIT_27Maal\27MaalBlazor\27MaalBlazor\Pages\Index.razor"
                                                                                                                                                    tal.Hvorfor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n                ");
            __builder.OpenElement(96, "tr");
            __builder.AddMarkupContent(97, "\r\n                    ");
            __builder.AddMarkupContent(98, "<th style=\"border: 1px solid #ccc; text-align: center; background-color:whitesmoke; border-color: white; padding: 1rem;\">Hvad gør vi allerede?</th>\r\n                    ");
            __builder.OpenElement(99, "td");
            __builder.AddAttribute(100, "style", "border: 1px solid #ccc; text-align: left; background-color:whitesmoke; border-color: white; padding: 1rem;");
            __builder.AddContent(101, 
#nullable restore
#line 92 "C:\Users\jjuip2\Desktop\GIT_27Maal\27MaalBlazor\27MaalBlazor\Pages\Index.razor"
                                                                                                                                            tal.Hvad

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n                ");
            __builder.OpenElement(104, "tr");
            __builder.AddMarkupContent(105, "\r\n                    ");
            __builder.AddMarkupContent(106, "<th style=\"border: 1px solid #ccc; text-align: center; background-color:rgb(214, 224, 197); border-color: white; padding: 1rem;\">Eventuelt nye initiativer?</th>\r\n                    ");
            __builder.OpenElement(107, "td");
            __builder.AddAttribute(108, "style", "border: 1px solid #ccc; text-align: left; background-color:rgb(214, 224, 197); border-color: white; padding: 1rem;");
            __builder.AddContent(109, 
#nullable restore
#line 96 "C:\Users\jjuip2\Desktop\GIT_27Maal\27MaalBlazor\27MaalBlazor\Pages\Index.razor"
                                                                                                                                                    tal.Initiativer

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n");
#nullable restore
#line 101 "C:\Users\jjuip2\Desktop\GIT_27Maal\27MaalBlazor\27MaalBlazor\Pages\Index.razor"
    
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 104 "C:\Users\jjuip2\Desktop\GIT_27Maal\27MaalBlazor\27MaalBlazor\Pages\Index.razor"
       

    private string? imageSource = $"images/egedal1.png";
    private Egedalmaal tal;
    private string categori { get; set; }




    protected override async Task OnInitializedAsync()
    {
        categori = "Afgangskarakterer i folkeskolen";
        tal = await Http.GetFromJsonAsync<Egedalmaal>("https://localhost:44336/api/egemaal/1");
        await Load();

    }

    protected async Task Load()
    {
        switch (categori)
        {
            case "Afgangskarakterer i folkeskolen":
                tal = await Http.GetFromJsonAsync<Egedalmaal>("https://localhost:44336/api/egemaal/1");
                StateHasChanged();
                break;

            case "Fravær blandt elever i folkeskolen":
                tal = await Http.GetFromJsonAsync<Egedalmaal>("https://localhost:44300/api/_27maal/2");
                StateHasChanged();
                break;
            case "Forebyggelse til udsatte børn og unge":
                tal = await Http.GetFromJsonAsync<Egedalmaal>("https://localhost:44300/api/_27maal/3");

                StateHasChanged();
                break;
            case "Sikker skoletrafik":
                tal = await Http.GetFromJsonAsync<Egedalmaal>("https://localhost:44300/api/_27maal/4");

                StateHasChanged();
                break;
            case "Elever i ungdomsuddannelse":
                tal = await Http.GetFromJsonAsync<Egedalmaal>("https://localhost:44300/api/_27maal/5");

                StateHasChanged();
                break;
            case "Beskæftigelsesgraden":
                tal = await Http.GetFromJsonAsync<Egedalmaal>("https://localhost:44300/api/_27maal/6");

                StateHasChanged();
                break;
            case "Erhvervsklima":
                tal = await Http.GetFromJsonAsync<Egedalmaal>("https://localhost:44300/api/_27maal/7");

                StateHasChanged();
                break;
            case "Udlicitering og konkurrenceudsættelse":
                tal = await Http.GetFromJsonAsync<Egedalmaal>("https://localhost:44300/api/_27maal/8");

                StateHasChanged();
                break;
            case "Fysisk helbred":
                tal = await Http.GetFromJsonAsync<Egedalmaal>("https://localhost:44300/api/_27maal/9 ");

                StateHasChanged();
                break;
            case "Fysisk aktivitet":
                tal = await Http.GetFromJsonAsync<Egedalmaal>("https://localhost:44300/api/_27maal/10");

                StateHasChanged();
                break;
            case "Rygning":
                tal = await Http.GetFromJsonAsync<Egedalmaal>("https://localhost:44300/api/_27maal/11");

                StateHasChanged();
                break;
            case "Alkohol":
                tal = await Http.GetFromJsonAsync<Egedalmaal>("https://localhost:44300/api/_27maal/12");

                StateHasChanged();
                break;
            case "Genindlæggelser":
                tal = await Http.GetFromJsonAsync<Egedalmaal>("https://localhost:44300/api/_27maal/13");

                StateHasChanged();
                break;
            case "Ofte uønsket alene (færrest)":
                tal = await Http.GetFromJsonAsync<Egedalmaal>("https://localhost:44300/api/_27maal/14");

                StateHasChanged();
                break;
            case "Mentalt helbred":
                tal = await Http.GetFromJsonAsync<Egedalmaal>("https://localhost:44300/api/_27maal/15");

                StateHasChanged();
                break;
            case "Stress":
                tal = await Http.GetFromJsonAsync<Egedalmaal>("https://localhost:44300/api/_27maal/16");

                StateHasChanged();
                break;
            case "Antal indbrud":
                tal = await Http.GetFromJsonAsync<Egedalmaal>("https://localhost:44300/api/_27maal/17");

                StateHasChanged();
                break;
            case "Anmeldte voldsforbrydelser":
                tal = await Http.GetFromJsonAsync<Egedalmaal>("https://localhost:44300/api/_27maal/18");

                StateHasChanged();
                break;
            case "Liggetid på hussalg":
                tal = await Http.GetFromJsonAsync<Egedalmaal>("https://localhost:44300/api/_27maal/19");

                StateHasChanged();
                break;
            case "Besøg på bibliotekerne":
                tal = await Http.GetFromJsonAsync<Egedalmaal>("https://localhost:44300/api/_27maal/20");

                StateHasChanged();
                break;
            case "Unikke medlemmer af idrætsorganisation":
                tal = await Http.GetFromJsonAsync<Egedalmaal>("https://localhost:44300/api/_27maal/21");

                StateHasChanged();
                break;
            case "Genanvendelse af affald":
                tal = await Http.GetFromJsonAsync<Egedalmaal>("https://localhost:44300/api/_27maal/22");

                StateHasChanged();
                break;
            case "CO2 reduktion":
                tal = await Http.GetFromJsonAsync<Egedalmaal>("https://localhost:44300/api/_27maal/23");
               
                StateHasChanged();
                break;
            case "Anbefaling af kommunen":
                tal = await Http.GetFromJsonAsync<Egedalmaal>("https://localhost:44300/api/_27maal/24");

                StateHasChanged();
                break;
            case "Tilfredshed med kommunens service":
                tal = await Http.GetFromJsonAsync<Egedalmaal>("https://localhost:44300/api/_27maal/25");

                StateHasChanged();
                break;
            case "Medarbejdernes sygefravær":
                tal = await Http.GetFromJsonAsync<Egedalmaal>("https://localhost:44300/api/_27maal/26");

                StateHasChanged();
                break;
            case "Samlet trvisel 4.-9kl":
                tal = await Http.GetFromJsonAsync<Egedalmaal>("https://localhost:44300/api/_27maal/27");

                StateHasChanged();
                break;

        }

        //forandring = tal.placering - tal.;
    }

    protected async Task VælgGraf(ChangeEventArgs e)
    {

        categori = Convert.ToString(e.Value);
        await Load();

    }

    List<string> valg = new List<string>() { "Afgangskarakterer i folkeskolen", "Medarbejdernes sygefravær", "Tilfredshed med kommunens service", "Anbefaling af kommunen", "CO2 reduktion",
                "Genanvendelse af affald", "Unikke medlemmer af idrætsorganisation", "Besøg på bibliotekerne", "Liggetid på hussalg", "Anmeldte voldsforbrydelser", "Antal indbrud", "Stress",
            "Mentalt helbred", "Ofte uønsket alene (færrest)", "Genindlæggelser", "Alkohol", "Rygning", "Fysisk aktivitet", "Fysisk helbred", "Udlicitering og konkurrenceudsættelse", "Erhvervsklima",
            "Beskæftigelsesgraden", "Elever i ungdomsuddannelse", "Sikker skoletrafik", "Forebyggelse til udsatte børn og unge", "Fravær blandt elever i folkeskolen", "Samlet trvisel 4.-9kl" };

    public class Egedalmaal
    {
        public int id { get; set; }
        public string kategori { get; set; }
        public double? statusEgedal { get; set; }
        public double? statusDanmark { get; set; }
        public double? senesteEgedal { get; set; }
        public double? senesteDanmark { get; set; }
        public int? placering { get; set; }
        public string? Hvad { get; set; }
        public string? Hvorfor { get; set; }
        public string? Initiativer { get; set; }
        public string? Indikator { get; set; }


    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591

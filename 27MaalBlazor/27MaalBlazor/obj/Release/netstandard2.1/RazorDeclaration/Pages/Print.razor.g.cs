// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 5 "C:\Users\jjuip2\Desktop\GIT_27Maal\27MaalBlazor\27MaalBlazor\Pages\Print.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jjuip2\Desktop\GIT_27Maal\27MaalBlazor\27MaalBlazor\Pages\Print.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jjuip2\Desktop\GIT_27Maal\27MaalBlazor\27MaalBlazor\Pages\Print.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/print")]
    public partial class Print : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 344 "C:\Users\jjuip2\Desktop\GIT_27Maal\27MaalBlazor\27MaalBlazor\Pages\Print.razor"
       

        private Egedalmaal tal_Afgangskarakterer;
        private Egedalmaal tal_FraværFolkeskolen;
        private Egedalmaal tal_ForebyggelseUdsatteBørn;
        private Egedalmaal tal_Sikker_Skoletrafik;
        private Egedalmaal tal_EleverUngdomsUdd;
        private Egedalmaal tal_Beskæftigelsesgraden;
        private Egedalmaal tal_Erhvervsklima;
        private Egedalmaal tal_Udlicitering;
        private Egedalmaal tal_FysiskHelbred;
        private Egedalmaal tal_FysiskAktivitet;
        private Egedalmaal tal_Rygning;
        private Egedalmaal tal_Alkohold;
        private Egedalmaal tal_Genindlæggelser;
        private Egedalmaal tal_OfteAlene;
        private Egedalmaal tal_MentaltHelbred;
        private Egedalmaal tal_Stress;
        private Egedalmaal tal_AntalInbrud;
        private Egedalmaal tal_AnmVoldsforbrydelse;
        private Egedalmaal tal_LiggetidHusSalg;
        private Egedalmaal tal_BesøgBibl;
        private Egedalmaal tal_UnikkeMedlIdræt;
        private Egedalmaal tal_Genanvendelse;
        private Egedalmaal tal_CO2_reduktion;
        private Egedalmaal tal_Anbefaling;
        private Egedalmaal tal_TilfredshedKommuneService;
        private Egedalmaal tal_MedArbSygefravær;
        private Egedalmaal tal_SamletTrivsel;

        protected override async Task OnInitializedAsync()
        {

            //"Afgangskarakterer i folkeskolen":
            tal_Afgangskarakterer = await Http.GetFromJsonAsync<Egedalmaal>("http://localhost:44357/api/egemaal/1");
            //StateHasChanged();
            //"Fravær blandt elever i folkeskolen":
            tal_FraværFolkeskolen = await Http.GetFromJsonAsync<Egedalmaal>("http://egedal27api:84/api/egemaal/2");
            //StateHasChanged();
            //"Forebyggelse til udsatte børn og unge":
            tal_ForebyggelseUdsatteBørn = await Http.GetFromJsonAsync<Egedalmaal>("http://egedal27api:84/api/egemaal/3");
            //StateHasChanged();
            //"Sikker skoletrafik"
            tal_Sikker_Skoletrafik = await Http.GetFromJsonAsync<Egedalmaal>("http://egedal27api:84/api/egemaal/4");
            //"Elever i ungdomsuddannelse"
            tal_EleverUngdomsUdd = await Http.GetFromJsonAsync<Egedalmaal>("http://egedal27api:84/api/egemaal/5");
            //StateHasChanged();
            //"Beskæftigelsesgraden":
            tal_Beskæftigelsesgraden = await Http.GetFromJsonAsync<Egedalmaal>("http://egedal27api:84/api/egemaal/6");
            //StateHasChanged();
            //"Erhvervsklima":
            tal_Erhvervsklima = await Http.GetFromJsonAsync<Egedalmaal>("http://egedal27api:84/api/egemaal/7");
            //StateHasChanged();
            //"Udlicitering og konkurrenceudsættelse":
            tal_Udlicitering = await Http.GetFromJsonAsync<Egedalmaal>("http://egedal27api:84/api/egemaal/8");
            //StateHasChanged();
            //"Fysisk helbred":
            tal_FysiskHelbred = await Http.GetFromJsonAsync<Egedalmaal>("http://egedal27api:84/api/egemaal/9 ");
            //StateHasChanged();
            //"Fysisk aktivitet"
            tal_FysiskAktivitet = await Http.GetFromJsonAsync<Egedalmaal>("http://egedal27api:84/api/egemaal/10");
            //StateHasChanged();
            //"Rygning":
            tal_Rygning = await Http.GetFromJsonAsync<Egedalmaal>("http://egedal27api:84/api/egemaal/11");
            //StateHasChanged();
            //"Alkohol":
            tal_Alkohold = await Http.GetFromJsonAsync<Egedalmaal>("http://egedal27api:84/api/egemaal/12");
            //StateHasChanged();
            //"Genindlæggelser":
            tal_Genindlæggelser = await Http.GetFromJsonAsync<Egedalmaal>("http://egedal27api:84/api/egemaal/13");
            //StateHasChanged();
            //"Ofte uønsket alene (færrest)":
            tal_OfteAlene = await Http.GetFromJsonAsync<Egedalmaal>("http://egedal27api:84/api/egemaal/14");
            //StateHasChanged();
            //"Mentalt helbred":
            tal_MentaltHelbred = await Http.GetFromJsonAsync<Egedalmaal>("http://egedal27api:84/api/egemaal/15");
            //StateHasChanged();
            //"Stress":
            tal_Stress = await Http.GetFromJsonAsync<Egedalmaal>("http://egedal27api:84/api/egemaal/16");
            //StateHasChanged();
            //"Antal indbrud":
            tal_AntalInbrud = await Http.GetFromJsonAsync<Egedalmaal>("http://egedal27api:84/api/egemaal/17");
            //StateHasChanged();
            //"Anmeldte voldsforbrydelser":
            tal_AnmVoldsforbrydelse = await Http.GetFromJsonAsync<Egedalmaal>("http://egedal27api:84/api/egemaal/18");
            //StateHasChanged();
            //"Liggetid på hussalg":
            tal_LiggetidHusSalg = await Http.GetFromJsonAsync<Egedalmaal>("http://egedal27api:84/api/egemaal/19");
            //StateHasChanged();
            //"Besøg på bibliotekerne":
            tal_BesøgBibl = await Http.GetFromJsonAsync<Egedalmaal>("http://egedal27api:84/api/egemaal/20");
            //StateHasChanged();
            //"Unikke medlemmer af idrætsorganisation":
            tal_UnikkeMedlIdræt = await Http.GetFromJsonAsync<Egedalmaal>("http://egedal27api:84/api/egemaal/21");
            //StateHasChanged();
            //"Genanvendelse af affald":
            tal_Genanvendelse = await Http.GetFromJsonAsync<Egedalmaal>("http://egedal27api:84/api/egemaal/22");
            //StateHasChanged();
            //"CO2 reduktion":
            tal_CO2_reduktion = await Http.GetFromJsonAsync<Egedalmaal>("http://egedal27api:84/api/egemaal/23");
            //StateHasChanged();
            //"Anbefaling af kommunen":
            tal_Anbefaling = await Http.GetFromJsonAsync<Egedalmaal>("http://egedal27api:84/api/egemaal/24");
            //StateHasChanged();
            //"Tilfredshed med kommunens service":
            tal_TilfredshedKommuneService = await Http.GetFromJsonAsync<Egedalmaal>("http://egedal27api:84/api/egemaal/25");
            //StateHasChanged();
            //"Medarbejdernes sygefravær":
            tal_MedArbSygefravær = await Http.GetFromJsonAsync<Egedalmaal>("http://egedal27api:84/api/egemaal/26");
            //StateHasChanged();
            //"Samlet trvisel 4.-9kl":
            tal_SamletTrivsel = await Http.GetFromJsonAsync<Egedalmaal>("http://egedal27api:84/api/egemaal/27");
            //StateHasChanged();


        }


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
            public string? Dato { get; set; }


        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591

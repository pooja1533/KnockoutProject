#pragma checksum "D:\KnockputProject\KnockoutProject\KnockoutProject\KnockoutProject\Views\Hotel\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eaca6b052ac1d2eb1eee5a641db599ed5ccc7dbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hotel_Edit), @"mvc.1.0.view", @"/Views/Hotel/Edit.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\KnockputProject\KnockoutProject\KnockoutProject\KnockoutProject\Views\_ViewImports.cshtml"
using Core.Constants;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eaca6b052ac1d2eb1eee5a641db599ed5ccc7dbf", @"/Views/Hotel/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9c643758476e6b4f1bf97edad2cba031026dc83", @"/Views/_ViewImports.cshtml")]
    public class Views_Hotel_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModels.HotelViewModel>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\KnockputProject\KnockoutProject\KnockoutProject\KnockoutProject\Views\Hotel\Edit.cshtml"
  
    ViewBag.Title = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eaca6b052ac1d2eb1eee5a641db599ed5ccc7dbf3283", async() => {
                WriteLiteral(@"
    <title>
        Index page
    </title>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/1.10.2/jquery.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.10.3/jquery-ui.min.js""></script>
    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/knockout/3.3.0/knockout-min.js""></script>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<style>
    html {
        height: 100%;
    }

    body {
        height: 100%;
    }

    .global-container {
        height: 100%;
        display: flex;
        align-items: center;
        justify-content: center;
        background-color: #f5f5f5;
    }

    table {
        padding-top: 10px;
        font-size: 14px;
        margin-top: 30px;
    }

    .card-title {
        font-weight: 300;
    }

    .btn {
        font-size: 14px;
        margin-top: 20px;
    }

    .login-form {
       /* width: 330px;*/
        margin: 20px;
    }

    .sign-up {
        text-align: center;
        padding: 20px 0 0;
    }

    .alert {
        margin-bottom: -30px;
        font-size: 13px;
        margin-top: 20px;
    }
</style>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eaca6b052ac1d2eb1eee5a641db599ed5ccc7dbf5519", async() => {
                WriteLiteral("\r\n    <div class=\"pt-3\">\r\n        <div class=\"global-container\">\r\n            <div class=\"card login-form\">\r\n                <div class=\"card-body\">\r\n                    <div class=\"sign-up\">\r\n                        <a data-bind=\"attr: { \'href\': \'");
#nullable restore
#line 69 "D:\KnockputProject\KnockoutProject\KnockoutProject\KnockoutProject\Views\Hotel\Edit.cshtml"
                                                  Write(Url.Action("Index", "Hotel"));

#line default
#line hidden
#nullable disable
                WriteLiteral("/\'}\" class=\"btn-link\">Back to list</a>\r\n                    </div>\r\n                    <h3 class=\"card-title text-center\">Edit Hotel </h3>\r\n");
#nullable restore
#line 72 "D:\KnockputProject\KnockoutProject\KnockoutProject\KnockoutProject\Views\Hotel\Edit.cshtml"
                     using (Html.BeginForm())
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <div class=""card-text"">
                            <form>
                                <div class=""form-group"">
                                    <label for=""name"">Name </label>
                                    <input type=""text"" class=""form-control form-control-sm"" id=""name"" aria-describedby=""name"" data-bind=""value:name"">
                                </div>
                                <div class=""form-group"">
                                    <label for=""address1"">Address1 </label>
                                    <input type=""text"" class=""form-control form-control-sm"" id=""address1"" data-bind=""value:address1"">
                                </div>
                                <div class=""form-group"">
                                    <label for=""address2"">Address2 </label>
                                    <input type=""text"" class=""form-control form-control-sm"" id=""address2"" data-bind=""value:address2"">
                                </div>
 ");
                WriteLiteral(@"                               <div class=""form-group"">
                                    <label for=""address3"">Address3 </label>
                                    <input type=""text"" class=""form-control form-control-sm"" id=""address3"" data-bind=""value:address3"">
                                </div>
                                <div class=""form-group"">
                                    <label for=""email"">Email </label>
                                    <input type=""email"" class=""form-control form-control-sm"" id=""email"" data-bind=""value:email"">
                                </div>
                                <div class=""form-group"">
                                    <label for=""website"">website </label>
                                    <input type=""text"" class=""form-control form-control-sm"" id=""website"" data-bind=""value:website"">
                                </div>
                                <div class=""form-group"">
                                    <label for=""pinc");
                WriteLiteral(@"ode"">pincode </label>
                                    <input type=""text"" class=""form-control form-control-sm"" id=""pincode"" data-bind=""value:pincode"">
                                </div>
                                <div class=""form-group"">
                                    <label for=""country"">country </label>
                                    <select data-bind=""options: countryCollection, optionsCaption: 'Choose country...',
                    optionsValue: function (item) { return item.id; },
                    optionsText: function (item) { return item.name; }, value: CountryId,
                    valueUpdate: 'change'"" id=""Country"" name=""Country""></select>
                                </div>
                                <div>
                                    <label for=""state""> Select State</label>
                                    <select data-bind=""options: stateCollection, optionsCaption: 'Choose state...',
        optionsValue: function (item) { return item.id;");
                WriteLiteral(@" },
        optionsText: function (item) { return item.name; },  value: StateId,
        valueUpdate: 'change'"" id=""State"" name=""State""></select>
                                    <br />
                                </div>
                                <div class=""form-group"">
                                    <label for=""star"">star</label>
                                    <select data-bind=""options: starCollection, optionsCaption: 'Choose star...',
                    optionsValue: function (item) { return item.id; },
                    optionsText: function (item) { return item.description; }, value: StarId,
                    valueUpdate: 'change'"" id=""Star"" name=""Star""></select>
                                </div>
                                <div>
                                    <label for=""city"">Select City</label>
                                    <select data-bind=""options: cityCollection, optionsCaption: 'Choose city...',
        optionsValue: function (item) ");
                WriteLiteral(@"{ return item.id; },
        optionsText: function (item) { return item.name; }, value: CityId,
        valueUpdate: 'change'"" id=""City"" name=""City""></select>
                                </div>
                                <input type=""button"" class=""btn btn-primary btn-block"" data-bind=""click:editHotel"" value=""Submit"" />
                            </form>
                        </div>
");
#nullable restore
#line 136 "D:\KnockputProject\KnockoutProject\KnockoutProject\KnockoutProject\Views\Hotel\Edit.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <script type=\"text/javascript\">\r\n                    var SelectedHotel = \'");
#nullable restore
#line 138 "D:\KnockputProject\KnockoutProject\KnockoutProject\KnockoutProject\Views\Hotel\Edit.cshtml"
                                    Write(Html.Raw(ViewBag.SelectedHotel));

#line default
#line hidden
#nullable disable
                WriteLiteral("\';\r\n                    </script>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</html>

<script type=""text/javascript"">
    var parsedSelectedHotel = $.parseJSON(SelectedHotel);
    $(function () {
        ko.applyBindings(modelEdit);
    });
    var modelEdit = {
        starCollection: ko.observableArray(),
        countryCollection: ko.observableArray(),
        stateCollection: ko.observableArray(),
        cityCollection: ko.observableArray(),
        name: ko.observable(parsedSelectedHotel.name),
        address1: ko.observable(parsedSelectedHotel.address1),
        address2: ko.observable(parsedSelectedHotel.address2),
        address3: ko.observable(parsedSelectedHotel.address3),
        email: ko.observable(parsedSelectedHotel.email),
        website: ko.observable(parsedSelectedHotel.website),
        pincode: ko.observable(parsedSelectedHotel.pincode),
        StarId: ko.observable(parsedSelectedHotel.star),
        CountryId: ko.observable(parsedSelectedHotel.countryId),
        StateId: ko.observable(parsedSelectedHotel.stateId),
        CityId: ko.o");
            WriteLiteral(@"bservable(parsedSelectedHotel.cityId),
        Id: ko.observable(parsedSelectedHotel.id),
        editHotel: function () {
            var hotelViewModel = {
                name:this.name(),
                address1:this.address1(),
                address2:this.address2(),
                address3:this.address3(),
                email:this.email(),
                website:this.website(),
                pincode:this.pincode(),
                StarId: this.StarId(),
                CountryId: this.CountryId(),
                StateId: this.StateId(),
                CityId: this.CityId(),
                Id: this.Id(),
            };
            //alert(hotelViewModel);
            try {
                $.ajax({
                    url: '/Hotel/Edit',
                    type: 'POST',
                    data: hotelViewModel,
                    dataType: 'json',
                    //contentType: 'application/json',
                    success: function (data) {
                  ");
            WriteLiteral(@"      if (data.isError == false)
                            window.location.href = data.redirectUrl;
                        else {
                            alert(""Something went wrong when you delete hotel"");
                        }
                    },
                    error: function () {
                        alert(""Something went wrong when you delete hotel"");
                    }
                });
            }
            catch (e) {
                window.location.href =""/Hotel/ListofHotels/""
            }
        }
    };
    $(parsedSelectedHotel.country).each(function (index, element) {
        modelEdit.countryCollection.push(element);
    });
    $(parsedSelectedHotel.states).each(function (index, element) {
        modelEdit.stateCollection.push(element);
    });
    $(parsedSelectedHotel.city).each(function (index, element) {
        modelEdit.cityCollection.push(element);
    });
    $(parsedSelectedHotel.stars).each(function (index, element) {
       ");
            WriteLiteral(@" modelEdit.starCollection.push(element);
    });
    function successCallback(data) {
        window.location.href = '/Hotel/Index/';
    }

    function errorCallback(err) {
        window.location.href = '/Home/Index/';
    }
    $(""#Country"").change(function () {
        var countryId = $(""#Country"").val();
        countryId = parseInt(countryId);
        if (countryId > 0) {
            $.ajax({
                type: ""GET"",
                url: ""/Hotel/GetStates?countryId="" + countryId,
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
                success: function (response) {
                    modelEdit.stateCollection.removeAll();
                    if (response != """") {
                        $(response).each(function (index, element) {
                            modelEdit.stateCollection.push(element);
                        });
                        //ko.cleanNode(hotelCreate);
                        //    ko.apply");
            WriteLiteral(@"Bindings(hotelCreate);
                    }
                }
            });
        }

    });
    $(""#State"").change(function () {
        var stateId = $(""#State"").val();
        stateId = parseInt(stateId);
        if (stateId > 0) {
            $.ajax({
                type: ""GET"",
                url: ""/Hotel/GetCities?stateId="" + stateId,
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
                success: function (response) {
                    modelEdit.cityCollection.removeAll();
                    if (response != """") {
                        $(response).each(function (index, element) {
                            modelEdit.cityCollection.push(element);
                        });
                        //var element = $('#hotelform')[0];
                        //ko.cleanNode(element);
                        //  ko.cleanNode(document.getElementById(""#hotelform""));
                        //ko.cleanNode(hotelCreat");
            WriteLiteral("e);\r\n                        //ko.applyBindings(hotelCreate);\r\n                    }\r\n                }\r\n            });\r\n        }\r\n\r\n    });\r\n</script>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModels.HotelViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
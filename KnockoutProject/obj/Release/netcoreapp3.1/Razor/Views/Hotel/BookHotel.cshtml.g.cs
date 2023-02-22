#pragma checksum "D:\KnockputProject\KnockoutProject\KnockoutProject\KnockoutProject\Views\Hotel\BookHotel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48ef35987d2f225a8be09766f4c38751fc738574"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hotel_BookHotel), @"mvc.1.0.view", @"/Views/Hotel/BookHotel.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48ef35987d2f225a8be09766f4c38751fc738574", @"/Views/Hotel/BookHotel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9c643758476e6b4f1bf97edad2cba031026dc83", @"/Views/_ViewImports.cshtml")]
    public class Views_Hotel_BookHotel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModels.HotelBookingViewModel>
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
#line 2 "D:\KnockputProject\KnockoutProject\KnockoutProject\KnockoutProject\Views\Hotel\BookHotel.cshtml"
  
        Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48ef35987d2f225a8be09766f4c38751fc7385743352", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <title>
        Book Hotel
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

    form {
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
/*        width: 330px;
*/        margin: 20px;
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48ef35987d2f225a8be09766f4c38751fc7385745619", async() => {
                WriteLiteral(@"
    <div class=""pt-3"">
        <div class=""global-container"">
            <div class=""card login-form"">
                <div class=""card-body"">
                    <h3 class=""card-title text-center""> Book Hotel</h3>
                    <div class=""card-text"">
                        <form id=""hotelform"">
                            <div class=""form-group"">
                                <label for=""Country""> Select Hotel</label>
                                <input type=""text"" class=""autosuggest"" id=""txtAutoComplete"" aria-describedby=""name"" data-bind=""value:Name"">
                                <input type=""hidden"" id=""HotelId"" data-bind=""value:HotelId"" />

                            </div>
                            <div class=""form-group"" id=""date"" style=""display:none;"">
                                <label>From Date</label>
                                <input type=""text"" id=""StartDate"" data-bind=""value: StartDate()"" />
                                <label>To Date</label>
   ");
                WriteLiteral(@"                             <input type=""text"" id=""EndDate"" data-bind=""value: EndDate()"" />
                            </div>
                            <div class=""form-group"" id=""btnsubmit"" style=""display:none;"">
                                <input type=""button"" class=""btn btn-primary btn-block"" data-bind=""click:BookHotel"" value=""Book Hotel"" />
                            </div>
                            <div class=""card-text"">
                                <table class=""table"">
                                    <tr>
                                        <th>Hotel Name</th>
                                        <th>FromDate</th>
                                        <th>ToDate</th>
                                        <th>Action</th>
                                    </tr>
                                    <tbody data-bind=""foreach:bookedHotels"">
                                        <tr>
                                            <td data-bind=""text:name""></td>
 ");
                WriteLiteral(@"                                           <td data-bind=""text:fromDate""></td>
                                            <td data-bind=""text:toDate""></td>
                                            <td>
                                                <a data-bind=""attr: { 'href': '");
#nullable restore
#line 102 "D:\KnockputProject\KnockoutProject\KnockoutProject\KnockoutProject\Views\Hotel\BookHotel.cshtml"
                                                                          Write(Url.Action("EditBooking", "Hotel"));

#line default
#line hidden
#nullable disable
                WriteLiteral("/\' + id }\" class=\"btn-link\">Edit</a>\r\n");
                WriteLiteral(@"                                                <a data-bind=""click:function(param1){DeleteBooking(id)},attr: { 'href':''}"" class=""btn-link"">Delete</a>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
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

<script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/knockout/3.3.0/knockout-min.js""></script>
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js""></script>
<link href=""https://ajax.googleapis.com/ajax/libs/jqueryui/1.8.1/themes/base/jquery-ui.css"" rel=""stylesheet"" type=""text/css"">
<script type=""text/javascript"" src=""https://ajax.googleapis.com/ajax/libs/jqueryui/1.8.1/jquery-ui.min.js""></script>
<script type=""text/javascript"">
    function DeleteBooking(id) {
        if (confirm(""Are you sure to want to Delete?"") == true) {
            $.ajax({
                type: ""POST"",
                url: ""/Hotel/DeleteBooking?id="" + id,
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
                success: function (response) {
                    if (response.isError == false) {
                        window.location.href = response.redirectUrl;
                    } else {
             ");
            WriteLiteral(@"           alert(""Something went wrong when you delete booking"");
                    }
                }
            });
        }
        else
            return false;
    }
    function SearchText() {

        bookHotel = {
            Name: ko.observable(""""),
            HotelId: ko.observable(),
            StartDate: ko.observable(),
            EndDate: ko.observable(),
            bookedHotels: ko.observableArray([]),
            BookHotel: function () {
                HotelId: this.HotelId;
                Name: this.name;
                StartDate: this.startDate;
                EndDate: this.endDate;

                bookHotel.HotelId = parseInt(this.HotelId);
                bookHotel.StartDate = Date.parse(this.startDate);
                bookHotel.EndDate = Date.parse(this.endDate);

                var HotelBookingViewModel = {
                    HotelId: bookHotel.HotelId,
                    Name:bookHotel.Name,
                    StartDate: bookHotel.startDa");
            WriteLiteral(@"te,
                    EndDate: bookHotel.endDate,
                }
                //alert(ko.toJSON(HotelBookingViewModel));
                $.ajax({
                    url: '/Hotel/BookHotel',
                    type: 'post',
                    dataType: 'json',
                    data: HotelBookingViewModel, //Here the data wil be converted to JSON
                    //contentType: 'application/json',
                    success: function (data) {
                        /*bookHotel.bookedHotels(data);*/
                        alert(""Booked hotel successfully"");
                        window.location.href = window.location.href;
                    },
                    error: function () {
                        alert(""Something went wrong"");
                    }
                });
            }
        };


        $("".autosuggest"").autocomplete({
            source: function (request, response) {
                var value = document.getElementById('txtAutoComplete'");
            WriteLiteral(@").value;
                $.ajax({
                    type: ""POST"",
                    url: ""GetHotelName"",
                    data: { Prefix: value },
                    dataType: ""json"",
                    success: function (data) {
                        if (data.length == 0) {
                            alert(""No Result found"");
                            var element = document.getElementById(""txtAutoComplete"");
                            element.classList.remove(""ui-autocomplete-loading"");
                            return false;
                        }
                        else {
                            response($.map(data, function (item) {
                                return { label: item.name, value: item.name, Id: item.id };
                            }))
                        }
                        
                    },
                    error: function (result) {
                        alert(""Error"");
                    }
                });");
            WriteLiteral(@"
            },
            select: function (e, i) {
                $(""#HotelId"").val(i.item.Id);
                bookHotel.HotelId = $(""#HotelId"").val();
                if (HotelId != '') {
                    var div = document.getElementById(""date"");
                    div.style.display = ""block"";

                    var submitBtn = document.getElementById(""btnsubmit"");
                    submitBtn.style.display = ""block"";
                }
            },
        });

        ko.bindingHandlers.datePicker = {
            init: function (element, valueAccessor, allBindingsAccessor) {
                var options = { format: 'dd-mm-yyyy', weekStart: 1, autoclose: true };
                $(element).datepicker(options);
                $(element).datepicker().on('changeDate', function (e) { valueAccessor()(e.date); });
            },
            update: function (element, valueAccessor, allBindingsAccessor) {
                var date = ko.unwrap(valueAccessor());
                $(el");
            WriteLiteral(@"ement).datepicker('setDate', date);
            }
        };
        var FromDate = new Date();
        var ToDate = new Date();

        var d = new Date();
        d.setDate(d.getDate());
        //default range
        var defRange = 30;
        // total range 1yr +/-
        var e = new Date();
        var xDate = 365;
        e.setDate(d.getDate() - xDate);

        $('#StartDate').datepicker({
            minDate: d,
            beforeShow: function () {
                $('.ui-datepicker').css('font-size', 10);
            },
            onSelect: function (date) {

                bookHotel.Name = $(""#txtAutoComplete"").val();
                var dp2 = $('#EndDate');
                var startDate = $(this).datepicker('getDate');
                var minDate = new Date();
                startDate.setDate(startDate.getDate() + xDate);
                $(this).change()
                //defaults to past 30 days
                dp2.datepicker('setDate', -defRange);
             ");
            WriteLiteral(@"   dp2.change();
                //minDate.setDate(minDate.getDate() - xDate);
                //set max date for start and end range
                //dp2.datepicker('option', 'maxDate', startDate);
                //dp2.datepicker('option', 'minDate', minDate);
                $(this).datepicker('option', 'minDate', minDate);
                bookHotel.startDate = date;
            }
        });
        $('#EndDate').datepicker({
            //maxDate: d,
            minDate: d,
            beforeShow: function () {
                $('.ui-datepicker').css('font-size', 10);
            },
            onSelect: function (date) {

                bookHotel.Name = $(""#txtAutoComplete"").val();
                var dp2 = $('#EndDate');
                var endDate = $(this).datepicker('getDate');
                var minDate = new Date();
                endDate.setDate(endDate.getDate() + xDate);
                $(this).change()
                //defaults to past 30 days
                //dp2");
            WriteLiteral(@".datepicker('setDate', -defRange);
                //dp2.change();
                //minDate.setDate(minDate.getDate() - xDate);
                //set max date for start and end range
                //dp2.datepicker('option', 'maxDate', endDate);
                //dp2.datepicker('option', 'minDate', minDate);
                $(this).datepicker('option', 'minDate', minDate);
                bookHotel.endDate = date;
            }
        });

        $('#StartDate').focus(function () {
            $('#StartDate').datepicker('show');
        });

        $('#EndDate').focus(function () {
            $('#EndDate').datepicker('show');
        });
        ko.applyBindings(bookHotel);
        jQuery.browser = {
            msie: false,
            version: 0
        };
    }
    $(document).ready(function () {
        SearchText();
        $.ajax({
            type: ""GET"",
            url: ""/Hotel/GetBookedHotels"",
            contentType: ""application/json; charset=utf-8"",
          ");
            WriteLiteral(@"  dataType: ""json"",
            success: function (response) {
                if (response != """") {
                    $(response).each(function (index, element) {
                        bookHotel.bookedHotels.push(element);
                    });
                    //    ko.applyBindings(hotelCreate);
                }
            }
        });
    })
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModels.HotelBookingViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

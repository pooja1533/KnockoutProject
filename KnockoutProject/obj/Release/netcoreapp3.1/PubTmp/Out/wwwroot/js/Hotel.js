
//debugger;
//var hotelCreate = function () {
//    var self = this;
//    self.Name = ko.observable(),
//    self.Address1 = ko.observable()
//    self.Address2 = ko.observable(),
//    self.Address3 = ko.observable(),
//    self.Pincode = ko.observable(),
//    self.Email = ko.observable(),
//    self.countryCollection= ko.observableArray(),
//    self.Website = ko.observable();
//    var hotelData =
//    {
//        Name: self.Name,
//        Address1:self.Address1,
//        Address2: self.Address2,
//        Address3: self.Address3,
//        Pincode: self.Pincode,
//        Email: self.Email,
//        Website: self.Website,
//        countryCollection: self.countryCollection,
//    };
//    self.AddHotel= function () {
//        debugger;
//        try {
//            $.ajax({
//                url: '/Hotel/Test',
//                type: 'post',
//                dataType: 'json',
//                data: ko.toJSON(hotelData), //Here the data wil be converted to JSON
//                contentType: 'application/json',
//                success: successCallback,
//                error: errorCallback
//            });
//        } catch (e) {
//            alert(e);
//        }
//    }
//};
//function successCallback(data) {
//    alert("sucees");
//}

//function errorCallback(err) {
//    alert("fail");
//}
//debugger;
////$(function () {
////    debugger;
////    ko.applyBindings(hotelCreate);
////});
//ko.applyBindings(hotelCreate);
//$.ajax({
//    type: "GET",
//    url: "/Hotel/GetCounries",
//    contentType: "application/json; charset=utf-8",
//    dataType: "json",
//    success: function (response) {
//        debugger;
//        if (response != "") {
//            debugger;
//            $(response).each(function (index, element) {
//                debugger;
//                self.hotelCreate.countryCollection.push(element);
//            });
//        //    ko.applyBindings(hotelCreate);
//        }
//    }
//});




//debugger;
//var hotelCreate = {
//        Name : ko.observable(),
//        Address1 : ko.observable(),
//    Address2 : ko.observable(),
//        Address3 : ko.observable(),
//        Pincode : ko.observable(),
//        Email : ko.observable(),
//    countryCollection: ko.observableArray(),
//    stateCollection: ko.observableArray(),
//    cityCollection: ko.observableArray(),
//    Website: ko.observable(),
//    CountryId: ko.observable(),
//    StateId: ko.observable(),
//    CityId: ko.observable(),
//    //var hotelData =
//    //{
//    //    Name: self.Name,
//    //    Address1: self.Address1,
//    //    Address2: self.Address2,
//    //    Address3: self.Address3,
//    //    Pincode: self.Pincode,
//    //    Email: self.Email,
//    //    Website: self.Website,
//    //    countryCollection: self.countryCollection,
//    //};
//    AddHotel: function () {
//        //var self = this;
//        //hotelCreate.Country = ko.observable();
//        CountryId: this.CountryId();
//        StateId: this.StateId();
//        debugger;
//        try {
//            $.ajax({
//                url: '/Hotel/Test',
//                type: 'post',
//                dataType: 'json',
//                data: ko.toJSON(hotelCreate), //Here the data wil be converted to JSON
//                contentType: 'application/json',
//                success: successCallback,
//                error: errorCallback
//            });
//        } catch (e) {
//            alert(e);
//        }
//    }
//};
//function successCallback(data) {
//    alert("sucees");
//}

//function errorCallback(err) {
//    alert("fail");
//}
//debugger;
//$(document).ready(function () {
//    debugger;
//    $.ajax({
//        type: "GET",
//        url: "/Hotel/GetCounries",
//        contentType: "application/json; charset=utf-8",
//        dataType: "json",
//        success: function (response) {
//            debugger;
//            if (response != "") {
//                debugger;
//                $(response).each(function (index, element) {
//                    hotelCreate.countryCollection.push(element);
//                });
//                ko.applyBindings(hotelCreate);
//            }
//        }
//    });
//    $("#Country").change(function () {
//        debugger;
//        var countryId = $("#Country").val();
//        //alert(countryId);
//        //alert(typeof (countryId));
//        countryId = parseInt(countryId);
//        //alert(typeof (countryId))
//        if (countryId > 0) {
//            $.ajax({
//                type: "GET",
//                url: "/Hotel/GetStates?countryId=" + countryId,
//                contentType: "application/json; charset=utf-8",
//                dataType: "json",
//                success: function (response) {
//                    debugger;
//                    if (response != "") {
//                        $(response).each(function (index, element) {
//                            hotelCreate.stateCollection.push(element);
//                        });
//                    //    ko.applyBindings(hotelCreate);
//                    }
//                }
//            });
//        }
        
//    });
//    $("#State").change(function () {
//        debugger;
//        var stateId = $("#State").val();
//        stateId = parseInt(stateId);
//        //alert(stateId);
//        if (stateId > 0) {
//            $.ajax({
//                type: "GET",
//                url: "/Hotel/GetCities?stateId=" + stateId,
//                contentType: "application/json; charset=utf-8",
//                dataType: "json",
//                success: function (response) {
//                    debugger;
//                    if (response != "") {
//                        $(response).each(function (index, element) {
//                            hotelCreate.cityCollection.push(element);
//                        });
//                        //var element = $('#hotelform')[0];
//                        //ko.cleanNode(element);
//                        //  ko.cleanNode(document.getElementById("#hotelform"));
//                        ko.applyBindings(hotelCreate.stateCollection);
//                    }
//                }
//            });
//        }
        
//    });
//});

debugger;
//var hotelCreate = {
//    Name: ko.observable(),
//    Address1: ko.observable(),
//    Address2: ko.observable(),
//    Address3: ko.observable(),
//    Pincode: ko.observable(),
//    Email: ko.observable(),
//    countryCollection: ko.observableArray(),
//    stateCollection: ko.observableArray(),
//    cityCollection: ko.observableArray(),
//    Website: ko.observable(),
//    CountryId: ko.observable(),
//    StateId: ko.observable(),
//    CityId: ko.observable(),
//    AddHotel: function () {
//        //var self = this;
//        //hotelCreate.Country = ko.observable();
//        CountryId: this.CountryId();
//        StateId: this.StateId();
//        debugger;
//        try {
//            $.ajax({
//                url: '/Hotel/Test',
//                type: 'post',
//                dataType: 'json',
//                data: ko.toJSON(hotelCreate), //Here the data wil be converted to JSON
//                contentType: 'application/json',
//                success: successCallback,
//                error: errorCallback
//            });
//        } catch (e) {
//            alert(e);
//        }
//    }
//};
function successCallback(data) {
    alert("sucees");
}

function errorCallback(err) {
    alert("fail");
}
function FetchCountries() {
    hotelCreate = {
        Name: ko.observable(),
        Address1: ko.observable(),
        Address2: ko.observable(),
        Address3: ko.observable(),
        Pincode: ko.observable(),
        Email: ko.observable(),
        countryCollection: ko.observableArray(),
        stateCollection: ko.observableArray(),
        cityCollection: ko.observableArray(),
        starCollection: ko.observableArray(),
        Website: ko.observable(),
        CountryId: ko.observable(),
        StateId: ko.observable(),
        CityId: ko.observable(),
        StarId: ko.observable(),
        AddHotel: function () {
            CountryId: this.CountryId();
            StateId: this.StateId();
            CityId: this.CityId();
            StarId: this.StarId();
            //alert(StarId);
            try {
                $.ajax({
                    url: '/Hotel/AddHotel',
                    type: 'post',
                    dataType: 'json',
                    data: ko.toJSON(hotelCreate), //Here the data wil be converted to JSON
                    contentType: 'application/json',
                    success: function (data) {
                        if (data.isError == false)
                            window.location.href = data.redirectUrl
                                ;
                        else {
                            alert("Something went wrong");
                        }
                    },
                    error: function () {
                        alert("Something went wrong");
                    }
                });
            } catch (e) {
                alert(e);
            }
        }
    };
    $.ajax({
        type: "GET",
        url: "/Hotel/GetCounries",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            if (response != "") {
                $(response).each(function (index, element) {
                    hotelCreate.countryCollection.push(element);
                });
            //    ko.applyBindings(hotelCreate);
            }
        }
    });
    $.ajax({
        type: "GET",
        url: "/Hotel/GetStars",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            if (response != "") {
                $(response).each(function (index, element) {
                    hotelCreate.starCollection.push(element);
                });
                ko.applyBindings(hotelCreate);
            }
        }
    });
}
$(document).ready(function () {
    FetchCountries();
    $("#Country").change(function () {
        var countryId = $("#Country").val();
        countryId = parseInt(countryId);
        if (countryId > 0) {
            $.ajax({
                type: "GET",
                url: "/Hotel/GetStates?countryId=" + countryId,
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    hotelCreate.stateCollection.removeAll();
                    if (response != "") {
                        $(response).each(function (index, element) {
                            hotelCreate.stateCollection.push(element);
                        });
                        //ko.cleanNode(hotelCreate);
                        //    ko.applyBindings(hotelCreate);
                    }
                }
            });
        }

    });
    $("#State").change(function () {
        var stateId = $("#State").val();
        stateId = parseInt(stateId);
        if (stateId > 0) {
            $.ajax({
                type: "GET",
                url: "/Hotel/GetCities?stateId=" + stateId,
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    hotelCreate.cityCollection.removeAll();
                    if (response != "") {
                        $(response).each(function (index, element) {
                            hotelCreate.cityCollection.push(element);
                        });
                    }
                }
            });
        }

    });
});



function SearchText() {

    sightSeenViewModel = {
        SightseenName: ko.observable(""),
        Description: ko.observable(),
        Name: ko.observable(),
        CityId: ko.observable(),
        AddSightSeen: function () {
            sightSeenViewModel.CityId = parseInt(sightSeenViewModel.CityId);
            //alert(ko.toJSON(sightSeenViewModel));
            $.ajax({
                url: '/Tour/AddSightSeen',
                type: 'post',
                dataType: 'json',
                //data: ko.toJSON(sightSeenViewModel.SightseenName), //Here the data wil be converted to JSON
                data: ko.toJSON(sightSeenViewModel),
                contentType: 'application/json',
                success: function (data) {
                    if (data.isError == false) {
                        alert("Sight Seen Added successfully");
                        window.location.href = data.redirectUrl;
                    }
                    else {
                        alert("Something went wrong");
                    }
                },
                error: function () {
                    alert("Something went wrong");
                }
            });
        }
    };

    $(".autosuggest").autocomplete({
        source: function (request, response) {
            var value = document.getElementById('txtAutoComplete').value;
            $.ajax({
                type: "POST",
                url: "/Tour/GetCityName",
                data: { prefix: value },
                datatype: "json",
                success: function (data) {
                    response($.map(data, function (item) {
                        return { label: item.name, value: item.name, id: item.id };
                    }))
                },
                error: function (result) {
                    alert("error");
                }
            });
        },
        select: function (e, i) {
            $("#CityId").val(i.item.id);
            sightSeenViewModel.CityId = $("#CityId").val();
        },
    });
    ko.applyBindings(sightSeenViewModel);
}
$(document).ready(function () {
    SearchText();
})
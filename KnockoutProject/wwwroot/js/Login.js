var modelCreate = {
    Email: ko.observable(),
    Password: ko.observable(),
    LoginClick: function () {
        var UserViewModel = {
            Email:this.Email(),
            Password : this.Password()
        };
        if (UserViewModel.Email == null && UserViewModel.Password == null) {
            alert("please enter username & password");
        }
        else if (UserViewModel.Email == null || UserViewModel.Email == undefined || UserViewModel.Email == "") {
            alert("please enter email");
        }
        else if (UserViewModel.Password == null || UserViewModel.Password == undefined || UserViewModel.Password=="") {
            alert("please enter Password");
        }
        if (UserViewModel.Email != null && UserViewModel.Email != "" && UserViewModel.Password != null && UserViewModel.Password!="") {
            try {
                $.ajax({
                    url: '/Login/Login',
                    type: 'POST',
                    data: UserViewModel,
                    dataType: 'json',
                    success: function (data) {
                        if (data.isError == false)
                            window.location.href = data.redirectUrl
                                ;
                        else {
                            alert("User name or password wrong");
                        }
                    },
                    error: function () {
                        alert("login failed");
                    }
                });
            }
            catch (e) {
                window.location.href = '/Login/Login';
            }
        }
        
    }
}
$(function () {
    ko.applyBindings(modelCreate);
});


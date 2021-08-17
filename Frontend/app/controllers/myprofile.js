app.controller("myprofile", function ($scope, $http, ajax, $routeParams) {
    ajax.get("https://localhost:44384/api/User/Get", success, error);
    function success(response) {
        $scope.users = response.data;
    }
    function error(error) {

    }
    $scope.edit = function (user) {
        console.log("ashshi");
        console.log(user);
        var d = {
            name: user.name,
            email: user.email,
            password: user.password,
            phone: user.phone,
        };
        console.log(d);

        ajax.post("https://localhost:44384/api/User/edit/", d,
            function (response) {
                console.log(response);
                alert("edited");
            },
            function (err) {
                console.log(err);
            });
    }
});

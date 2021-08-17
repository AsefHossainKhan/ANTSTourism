var app = angular.module("myApp", ["ngRoute"]);
var API_PORT = "https://localhost:44384/";
app.config(["$routeProvider", "$locationProvider", function ($routeProvider, $locationProvider) {

    $routeProvider
        .when("/", {
            templateUrl: "views/pages/adminHome.html"
        })
        .when("/edit/:id", {
            templateUrl: "views/pages/edit.html",
            controller: 'edit'
        })
        .when("/showproducts", {
            templateUrl: "views/pages/showproducts.html",
            controller: 'showproducts'
        })
        .when("/addpackage", {
            templateUrl: "views/pages/addpackage.html",
            controller: 'addpackage'
        })
        .when("/showorder", {
            templateUrl: "views/pages/showorder.html",
            controller: 'showorder'
        })
        .when("/showorder/:id", {
            templateUrl: "views/pages/orderdetails.html",
            controller: 'orderdetails'
        })
        .when("/myprofile", {
            templateUrl: "views/pages/myprofile.html",
            controller: 'myprofile'
        })
        .when("/login", {
            templateUrl: "views/pages/login.html",
            controller: 'login'
        })
        .when("/admin/viewusers", {
            templateUrl: "views/pages/adminViewUsers.html",
            controller: 'adminViewUsers'
        })
        .when("/admin/createuser", {
            templateUrl: "views/pages/adminCreateUser.html",
            controller: 'adminCreateUser'
        })
        .when("/admin/edituser/:id", {
            templateUrl: "views/pages/adminEditUser.html",
            controller: 'adminEditUser'
        })
        .when("/admin/deleteuser/:id", {
            templateUrl: "views/pages/adminDeleteUser.html",
            controller: 'adminDeleteUser'
        })
        .otherwise({
            redirectTo: "/"
        });
    //$locationProvider.html5Mode(true);
    //$locationProvider.hashPrefix('');
    //if(window.history && window.history.pushState){
    //$locationProvider.html5Mode(true);
    //}

}]);


app.controller("myController", function($rootScope){
    $rootScope.isUserSeller = false;
    $rootScope.isUserAdmin = true;
    $rootScope.isUserLoggedIn = false;
})

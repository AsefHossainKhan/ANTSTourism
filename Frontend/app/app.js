var app = angular.module("myApp", ["ngRoute"]);
app.config(["$routeProvider", "$locationProvider", function ($routeProvider, $locationProvider) {

    $routeProvider
        .when("/", {
            templateUrl: "views/pages/demopage.html"
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
    $rootScope.isUserSeller = true;
    $rootScope.isUserLoggedIn = false;
})

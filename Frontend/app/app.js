var app = angular.module("myApp", ["ngRoute"]);
app.config(["$routeProvider", "$locationProvider", function ($routeProvider, $locationProvider) {

    $routeProvider
        .when("/", {
            templateUrl: "views/pages/adminHome.html"
        })
        .when("/seller/package/edit/:id", {
            templateUrl: "views/pages/SellerPackageEdit.html",
            controller: 'SellerPackageEdit'
        })
        .when("/SellerHome", {
            templateUrl: "views/pages/SellerHome.html",
            controller: 'SellerHome'
        })
        .when("/seller/showpackages", {
            templateUrl: "views/pages/SellerShowPackages.html",
            controller: 'SellerShowPackages'
        })
        .when("/seller/addpackage", {
            templateUrl: "views/pages/SellerAddPackage.html",
            controller: 'SellerAddPackage'
        })
        .when("/seller/showorder", {
            templateUrl: "views/pages/SellerShowOrder.html",
            controller: 'SellerShowOrder'
        })
        .when("/showorder/:id", {
            templateUrl: "views/pages/orderdetails.html",
            controller: 'orderdetails'
        })
        .when("/seller/myprofile", {
            templateUrl: "views/pages/SellerProfile.html",
            controller: 'SellerProfile'
        })
        .when("/login", {
            templateUrl: "views/pages/login.html",
            controller: 'login'
        })
        .when("/seller/dashboard", {
            templateUrl: "views/pages/SellerDashboard.html",
            controller: 'SellerDashboard'
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


app.controller("myController", function ($rootScope) {
    $rootScope.isUserSeller = true;
    $rootScope.isUserAdmin = false;
    $rootScope.isUserLoggedIn = false;

    $rootScope.UserId="";
    $rootScope.UserType="";
    $rootScope.UserName="";
    $rootScope.UserEmail="";
    $rootScope.UserPhone="";
    $rootScope.UserPassword="";
})

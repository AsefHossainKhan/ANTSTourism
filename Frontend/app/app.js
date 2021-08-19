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
        .when("/admin/viewnotices", {
            templateUrl: "views/pages/adminViewNotices.html",
            controller: 'adminViewNotices'
        })
        .when("/admin/createnotice", {
            templateUrl: "views/pages/adminCreateNotice.html",
            controller: 'adminCreateNotice'
        })
        .when("/admin/editnotice/:id", {
            templateUrl: "views/pages/adminEditNotice.html",
            controller: 'adminEditNotice'
        })
        .when("/admin/deletenotice/:id", {
            templateUrl: "views/pages/adminDeleteNotice.html",
            controller: 'adminDeleteNotice'
        })
        .when("/admin/viewvouchers", {
            templateUrl: "views/pages/adminViewVouchers.html",
            controller: 'adminViewVouchers'
        })
        .when("/admin/createvoucher", {
            templateUrl: "views/pages/adminCreateVoucher.html",
            controller: 'adminCreateVoucher'
        })
        .when("/admin/editvoucher/:id", {
            templateUrl: "views/pages/adminEditVoucher.html",
            controller: 'adminEditVoucher'
        })
        .when("/admin/deletevoucher/:id", {
            templateUrl: "views/pages/adminDeleteVoucher.html",
            controller: 'adminDeleteVoucher'
        })
        .when("/admin/adminactions", {
            templateUrl: "views/pages/adminActions.html",
            controller: 'adminActions'
        })
        .when("/admin/viewauditlog", {
            templateUrl: "views/pages/adminViewAuditLog.html",
            controller: 'adminViewAuditLog'
        })
        .when("/admin/viewcomplains", {
            templateUrl: "views/pages/adminViewComplains.html",
            controller: 'adminViewComplains'
        })
        .when("/admin/editcomplain/:id", {
            templateUrl: "views/pages/adminEditComplain.html",
            controller: 'adminEditComplain'
        })
        .when("/admin/deletecomplain/:id", {
            templateUrl: "views/pages/adminDeleteComplain.html",
            controller: 'adminDeleteComplain'
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
    $rootScope.isUserSeller = false;
    $rootScope.isUserAdmin = false;
    $rootScope.isUserLoggedIn = false;
})

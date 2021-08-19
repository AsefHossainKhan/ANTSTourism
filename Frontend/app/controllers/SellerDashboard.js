app.controller("SellerDashboard", function ($scope, $http, ajax,$rootScope) {
    ajax.get("https://localhost:44384/api/Package/GetAll/"+$rootScope.UserId, success, error);
    function success(response) {
      $scope.products = response.data;
    }
    function error(error) {
  
    }
});
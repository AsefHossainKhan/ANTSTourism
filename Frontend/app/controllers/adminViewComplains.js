app.controller("adminViewComplains", function ($scope, $http, ajax,$location) {
  ajax.get(API_PORT + "api/complains/all", success, error);
  function success(response) {
    $scope.complains = response.data;
    console.log(response.data);
  }
  function error(error) {

  }

});
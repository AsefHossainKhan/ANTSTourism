app.controller("showorder", function ($scope, $http, ajax) {
  ajax.get("https://localhost:44384/api/Order/GetAll", success, error);
  function success(response) {
    $scope.orders = response.data;
  }
  function error(error) {

  }

  $scope.Status = function (id, status) {
    console.log("ashsi");
    console.log(id);
    console.log(status);
    ajax.get("https://localhost:44384/api/Order/Status/" + id + "/" + status,
      function success(response) {
        ajax.get("https://localhost:44384/api/Order/GetAll", success, error);
        function success(response) {
          $scope.orders = response.data;
        }
        function error(error) {

        }
      },
      function (err) {
        console.log(err);
      }
    );
  }
});
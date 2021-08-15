app.controller("showproducts", function ($scope, $http, ajax) {
  ajax.get("https://localhost:44384/api/Package/GetAll", success, error);
  function success(response) {
    $scope.products = response.data;
  }
  function error(error) {

  }

  $scope.delete = function (id) {
    console.log("ashsi");
    ajax.post("https://localhost:44384/api/Package/delete/" + id,
      function (response) {
        console.log(response);
        alert("deleted");
      },
      function (err) {
        console.log(err);
      }
    );
  }
});
app.controller("showproducts", function ($scope, $http, ajax) {
  ajax.get("https://localhost:44384/api/Package/GetAll", success, error);
  function success(response) {
    $scope.products = response.data;
  }
  function error(error) {

  }

  $scope.delete = function (id) {
    if (confirm('Are you sure your want to delete?')) {
      //do stuff

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
  }

  $scope.Search = function () {
    console.log("ashsi");
    ajax.get("https://localhost:44384/api/Package/Search/" + $scope.search,
      function success(response) {
        $scope.products = response.data;
      },
      function (err) {
        console.log(err);
      }
    );
  }
});
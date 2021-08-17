app.controller("addpackage", function ($scope, ajax, $rootScope) {
  alert($rootScope.isUserLoggedIn);

  $scope.addproduct = function () {
    console.log("ashshi");
    var d = {
      packagename: $scope.Name,
      price: $scope.Price,
      category: $scope.Category,
      details: $scope.Details,
      discount: $scope.Discount,
      advertisement: $scope.Advertisement,
      location: $scope.Location
    };
    ajax.post("https://localhost:44384/api/Package/Add", d,
      function (response) {
        alert("package added");
      },
      function (err) {
        console.log(err);
      });
  };
});
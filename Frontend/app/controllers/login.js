app.controller("login", function ($scope, ajax, $rootScope) {
  $scope.login = function (email, password) {
    console.log("ashsi");
    console.log($scope.Email);
    ajax.get("https://localhost:44384/api/Login/" + $scope.Email + "/" + $scope.Password,
      function (response) {
        console.log(response);
        $scope.user = response.data;
        if ($scope.user == null) {
          alert("beta email password thik moto de");
        }
        $rootScope.isUserLoggedIn = true;
        console.log($scope.user);
      },
      function (err) {
        alert(err);
      })
  }
});
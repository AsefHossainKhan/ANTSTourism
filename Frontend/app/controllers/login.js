app.controller("login", function ($scope, ajax, $rootScope, $location) {
  if ($rootScope.isUserLoggedIn) {
    $location.path("/");
    return;
  }
  $rootScope.PageType = "login";
  console.log($rootScope.PageType);
  $scope.login = function (user) {
    // console.log("ashsi");
    // console.log($scope.Email);
    // console.log($rootScope.UserType);
    
    ajax.post(
      "https://localhost:44384/api/Login", user,
      function (response) {
        // console.log(response);
        $scope.user = response.data;
        if ($scope.user == null) {
          alert("Invalid Email and Password");
        } else {
          //set id value and type value
          $rootScope.UserId = $scope.user.userid;
          $rootScope.UserType = $scope.user.usertype;
          $rootScope.UserName = $scope.user.name;
          $rootScope.UserPassword = $scope.user.password;
          $rootScope.UserPhone = $scope.user.phone;
          $rootScope.UserEmail = $scope.user.email;
          localStorage.setItem("user", JSON.stringify($scope.user));
          // console.log($rootScope.UserName);
          //set login status
          if ($scope.user.usertype == "Seller") {
            $rootScope.isUserLoggedIn = true;
            window.location.href =
              "http://127.0.0.1:5502/Index.html#!/SellerHome";
          }
          else if ($scope.user.usertype == "Admin") {
            $rootScope.isUserLoggedIn = true;
            window.location.href = "http://127.0.0.1:5502/Index.html#!/admin/";
          }
        }
      },
      function (err) {
        alert(err);
      }
    );
  };
});

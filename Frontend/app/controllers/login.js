app.controller("login", function ($scope, ajax, $rootScope) {
  $scope.login = function (email, password) {
    console.log("ashsi");
    console.log($scope.Email);
    ajax.get("https://localhost:44384/api/Login/" + $scope.Email + "/" + $scope.Password,
      function (response) {
        console.log(response);
        $scope.user = response.data;
        if ($scope.user == null) {
          alert("Invalid Email and Password");
        }
        else{
          //set id value and type value
          $rootScope.UserId=$scope.user.userid;
          $rootScope.UserType=$scope.user.usertype;
          $rootScope.UserName=$scope.user.name;
          $rootScope.UserPassword=$scope.user.password;
          $rootScope.UserPhone=$scope.user.phone;
          $rootScope.UserEmail=$scope.user.email;
          console.log($rootScope.UserName);
          //set login status
          if($scope.user.usertype=="Seller"){
            $rootScope.isUserLoggedIn = true;
            console.log($scope.user);
            $rootScope.isUserSeller=true;
            window.location.href = "http://127.0.0.1:5502/Index.html#!/SellerHome";
          }
        }
        
      },
      function (err) {
        alert(err);
      })
  }
});
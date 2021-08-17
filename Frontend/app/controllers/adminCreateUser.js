app.controller("adminCreateUser", function ($scope, $http, ajax, $location) {
  // ajax.get(API_PORT + "api/users/all", success, error);
  // function success(response) {
  //   $scope.users = response.data;
  //   console.log(response.data);
  // }
  // function error(error) {

  // }

  $scope.createUser = function (user) {
    if (user.password != user.cpassword){
      $scope.passError = "Passwords Dont Match";
    }
    else {
      ajax.post(API_PORT + "api/users/add",user,
      function(response){
        console.log(response);
        $location.path("/admin/viewusers")
      },
      function(err){
        console.log(err);
      });
    }
  };
});

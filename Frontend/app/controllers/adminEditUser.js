app.controller(
  "adminEditUser",
  function ($scope, $http, ajax, $location, $routeParams) {
    var id = $routeParams.id;
    ajax.get(API_PORT + "api/users/" + id, success, error);
    function success(response) {
      $scope.user = response.data;
      console.log(response.data);
    }
    function error(error) {}

    $scope.editUser = function (user) {
      ajax.put(
        API_PORT + "api/users/edit",
        user,
        function (response) {
          console.log(response);
          $location.path("/admin/viewusers");
        },
        function (err) {
          console.log(err);
        }
      );
    };
  }
);

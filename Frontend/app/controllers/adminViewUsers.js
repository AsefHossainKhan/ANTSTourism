app.controller("adminViewUsers", function ($scope, $http, ajax,$location) {
  ajax.get(API_PORT + "api/users/all", success, error);
  function success(response) {
    $scope.users = response.data;
    console.log(response.data);
  }
  function error(error) {

  }


  // $scope.editUsers = function (user) {
  //   $location.path("/admin/viewusers")
  // }

  // $scope.delete = function (id) {
  //   if (confirm('Are you sure your want to delete?')) {
  //     //do stuff

  //     console.log("ashsi");
  //     ajax.post("https://localhost:44384/api/Package/delete/" + id,
  //       function (response) {
  //         console.log(response);
  //         alert("deleted");
  //       },
  //       function (err) {
  //         console.log(err);
  //       }
  //     );
  //   }
  // }

  $scope.search = function () {
    if ($scope.searchText === "") {
      ajax.get(API_PORT + "api/users/all", success, error);
    }
    else {
      ajax.get(API_PORT + "api/users/search/" + $scope.searchText,
      function success(response) {
        $scope.users = response.data;
      },
      function (err) {
        console.log(err);
      }
    );
    }

  }
});
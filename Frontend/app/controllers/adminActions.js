app.controller("adminActions", function ($scope, $http, ajax, $location, $route) {
  ajax.get(API_PORT + "api/users/all", success, error);
  function success(response) {
    $scope.users = response.data;

    console.log(response.data);
  }
  function error(error) {}
  $scope.statuses = ["Valid", "Invalid", "Banned"];
  // $scope.statuses = [
  //   {
  //     actionName: "Valid",
  //     actionId: 1,
  //   },
  //   {
  //     actionName: "Invalid",
  //     actionId: 2,
  //   },
  //   {
  //     actionName: "Banned",
  //     actionId: 3,
  //   },
  // ];
  $scope.search = function () {
    if ($scope.searchText === "") {
      ajax.get(API_PORT + "api/users/all", success, error);
    } else {
      ajax.get(
        API_PORT + "api/users/search/" + $scope.searchText,
        function success(response) {
          $scope.users = response.data;
        },
        function (err) {
          console.log(err);
        }
      );
    }
  };
  $scope.takeAction = function (user) {
    ajax.put(
      API_PORT + "api/users/edit",
      user,
      function (response) {
        // console.log(response.data);
        var actionType = "";
        if (response.data.status === "Valid") {
          actionType = 1;
        } else if (response.data.status === "Invalid") {
          actionType = 2;
        } else if (response.data.status === "Banned") {
          actionType = 3;
        }
        auditLog = {
          adminid: 1,
          userid: user.userid,
          actiontypeid: actionType,
        };
        if (user.prevStatus != user.status) {
          ajax.post(
            API_PORT + "api/auditlogs/add",
            auditLog,
            function (response) {
              console.log(response.data);
            },
            function (err) {
              console.log(err);
            }
          );
        }
        $route.reload();
        
      },
      function (err) {
        console.log(err);
      }
    );
  };
});

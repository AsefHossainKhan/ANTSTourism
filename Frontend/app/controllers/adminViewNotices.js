app.controller("adminViewNotices", function ($scope, $http, ajax,$location) {
  ajax.get(API_PORT + "api/notices/all", success, error);
  function success(response) {
    $scope.notices = response.data;
    console.log(response.data);
  }
  function error(error) {

  }

  $scope.search = function () {
    if ($scope.searchText === "") {
      ajax.get(API_PORT + "api/notices/all", success, error);
    }
    else {
      ajax.get(API_PORT + "api/notices/search/" + $scope.searchText,
      function success(response) {
        $scope.notices = response.data;
      },
      function (err) {
        console.log(err);
      }
    );
    }

  }
});
app.controller("adminCreateNotice", function ($scope, $http, ajax, $location) {
  $scope.statuses = ["Active", "Inactive"];
  $scope.usertypes = ["Admin", "Manager", "Seller", "Customer"];

  $scope.createNotice = function (notice) {
    notice.userid = 1;
    // console.log(notice);
    ajax.post(
      API_PORT + "api/notices/add",
      notice,
      function (response) {
        console.log(response);
        $location.path("/admin/viewnotices");
      },
      function (err) {
        console.log(err);
      }
    );
  };
});

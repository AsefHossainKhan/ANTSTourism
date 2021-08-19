app.controller("adminCreateVoucher", function ($scope, $http, ajax, $location, $rootScope) {
  if ($rootScope.UserType != "Admin") {
    $location.path("/");
    return;
  }
  $scope.statuses = ["Active", "Inactive"];

  $scope.createVoucher = function (voucher) {
    voucher.userid = $rootScope.UserId;
    // console.log(voucher);
    ajax.post(
      API_PORT + "api/vouchers/add",
      voucher,
      function (response) {
        console.log(response);
        $location.path("/admin/viewvouchers");
      },
      function (err) {
        console.log(err);
      }
    );
  };
});

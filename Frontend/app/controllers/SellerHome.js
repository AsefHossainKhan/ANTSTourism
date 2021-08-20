app.controller("SellerHome", function ($scope, ajax, $rootScope) {
    if ($rootScope.UserType != "Seller") {
        $location.path("/");
        return;
    }
    console.log($rootScope.UserName);
    $scope.name = $rootScope.UserName;
    console.log($scope.name);
    $scope.id = $rootScope.UserId;
    $scope.type = $rootScope.UserType;
});
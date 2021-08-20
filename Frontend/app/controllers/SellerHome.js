app.controller("SellerHome", function ($scope, ajax, $rootScope) {
    console.log($rootScope.UserName);
    $scope.name = $rootScope.UserName;
    console.log($scope.name);
    $scope.id = $rootScope.UserId;
    $scope.type = $rootScope.UserType;
});
app.controller("login",function($scope,ajax,$rootScope){
  $scope.buttonPress = function(){
    alert("button pressed");
    $rootScope.isUserLoggedIn = true;
  }
});
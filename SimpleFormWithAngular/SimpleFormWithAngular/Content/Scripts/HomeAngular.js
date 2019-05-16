var app = angular.module("Homeapp", []);
app.controller("HomeController", function ($scope, $http) {
    $scope.btntext = "save";
    $scope.savedata = function () {
        $scope.btntext = "please wait..";
        $http({
            method: "Post",
            url: "/Home/AddUsers",
            data: $scope.user
        }).success(function (d) {
            $scope.btntext = "Save";
            $scope.user = null;
            alert(d);
        }).error(function () {
            alert("Fail");
        });
    };

    $http.get("/Home/GetUserList").then(function (d) {
        $scope.record = d.data;
    }, function (error) {
        alert('Failed');
    });

    $scope.loadrecord = function (id) {
        if (id > 0)
        {
            $http.get("/Home/GetUser?id=" + id).then(function (d) {
                $scope.user = d.data[0];
            }, function (error) {
                alert('Failed');
            });
        }
     
    };
    $scope.deleterecord = function (id) {
        $http.get("/Home/DeleteUser?id=" + id).then(function (d) {
            alert(d.data);
            $http.get("/Home/GetUserList").then(function (d) {
                $scope.record = d.data;
            }, function (error) {
                alert('Failed');
            });
        }, function (error) {
            alert('Failed');
        });
    };
});


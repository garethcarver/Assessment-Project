var AssessmentApp = angular.module('AssessApp', []);
AssessmentApp.controller('AssessmentsController', function ($scope) {
    $scope.GetAssessment = function (type) {
        $scope.currentPage = 0;
        $scope.pageSize = 10;
        $scope.results = [];

        $.ajax({
            url: "/Assessments/GetData",
            type: 'GET',
            data: { dataValue: type },
            cache: false,
            dataType: 'json',
            success: function (response) {
                var resp = JSON.stringify(response);
                var assessmentDetails = JSON.parse(resp);
                if (type == 1) {
                    $scope.results = assessmentDetails.Assessment;
                    $scope.numberOfPages = function () {
                        return Math.ceil($scope.results.length / $scope.pageSize);
                    }
                    $scope.$apply();
                }
                if (type == 2) {
                    $scope.results = assessmentDetails.jobs;
                    $scope.numberOfPages = function () {
                        return Math.ceil($scope.results.length / $scope.pageSize);
                    }
                    $scope.$apply();
                }
            },
            error: function (error) {
                alert(error);
            }
        })
      
    }

});
AssessmentApp.filter('startFrom', function () {
    return function (data, start) {
        start = +start;
        return data.slice(start);
    }
});

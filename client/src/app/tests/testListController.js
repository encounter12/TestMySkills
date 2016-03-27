(function () {
    'use strict';

    angular
        .module('test')
        .controller('testListController', ['$scope', 'testResource', function ($scope, testResource) {
            $scope.tests = testResource.query(function (result) {
                $scope.tests = result;
            });
        }]);
})();

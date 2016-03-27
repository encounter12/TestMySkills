(function () {
    'use strict';

    function testResource($resource, $appSettings) {
        return $resource($appSettings.serverPath + '/api/tests/:id');
    }

    angular
        .module('test')
        .factory('testResource',
                ['$resource',
                'appSettings',
                testResource]);
}());

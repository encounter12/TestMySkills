(function () {
    'use strict';

    angular
        .module('common', [])
        .constant('appSettings', {
            serverPath: 'http://localhost:5000'
        });
}());

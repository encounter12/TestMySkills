(function() {
  'use strict';

  angular
    .module('test')
    .config(routeConfig);

  /** @ngInject */
  function routeConfig($stateProvider, $urlRouterProvider) {
    $stateProvider
      .state('testList', {
        url: '/tests',
        templateUrl: 'app/tests/testListView.html',
        controller: 'testListController',
        controllerAs: 'testList'
      });

    $urlRouterProvider.otherwise('/');
  }

})();

(function() {
  'use strict';

  angular
    .module('testSystem.Client')
    .run(runBlock);

  /** @ngInject */
  function runBlock($log) {

    $log.debug('runBlock end');
  }

})();

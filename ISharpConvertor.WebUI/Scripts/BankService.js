(function () {
    'use strict';

    var BankService = angular.module('BankService', ['ngResource']);
   BankService.factory('Bank', ['$resource',
        function ($resource) {
            return $resource('/api/allbanks', {}, {
                query: { method: 'GET', params: {}, isArray: true}
            });
        }
    ]);
})();

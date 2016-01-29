(function () {
    'use strict';

    angular
        .module('BankApp')
        .controller('BankController', BankController);
    
               

    BankController.$inject = ['$scope', 'Bank'];

    function BankController($scope, Bank) {
        $scope.Bank = Bank.query();
       
    }
})();




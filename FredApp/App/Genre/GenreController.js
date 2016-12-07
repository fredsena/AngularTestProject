(function () {
    'use strict';
    angular.module('FredApp')
            .controller('GenreController', genreController);
    genreController.$inject = ['$scope', 'GenreService'];
    function genreController($scope, GenreService) {
        var vm = this;
        $scope.List = [];
        $scope.item = {};
        $scope.message = {};

        LoadData();


        function LoadData() {
            GenreService.GetAll()
                .then(function (response) {
                    $scope.List = response.data;
                }, function (error) {
                    $scope.status = 'Unable to load Genre data: ' + error.message;
                });
        };

        $scope.EditarItem = function (item, isNew) {
            $scope.item = angular.copy(item);
            var result = isNew ? "inclusão" : "alteração";
            $scope.message = result;
        }

        $scope.save = function (isValid) {

            if (isValid == false) { alert("Correct the validation errors first"); return; }

            GenreService.Update($scope.item);

            //console.log(result);
        };
    }
})();
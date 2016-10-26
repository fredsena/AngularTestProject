(function () {
    'use strict';

    angular.module('FredApp')
            .controller('GenreController', genreController);

    genreController.$inject = ['$scope', 'GenreService'];

    function genreController($scope, GenreService)
    {

        $scope.name = "Fred";
        $scope.List = [];

        GenreService.query(function (data) {
            $scope.List = data;
        });

        //$scope.ListGenres = 



    }

})();
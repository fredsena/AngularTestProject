(function () {

    'use strict';

    angular
        .module("BaseService")
        .factory("GenreService", ["$resource", genreService]);


    function genreService($resource) {
        return $resource("/api/Genre/GetList");
    }            


})();
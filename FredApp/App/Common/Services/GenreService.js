(function () {
    'use strict';
    angular
        .module("FredApp")
        .factory('GenreService', ['$http', function ($http) {
            var GenreService = {};

            GenreService.GetAll = function () {
                return $http.get("/api/Genre/GetList");
            };

            GenreService.Update = function (genre) {
                return $http.put("/api/Genre/Update", genre);
            };


            //GenreService.GetAll = function () {
            //    var defer = $q.defer();
            //    return $http.get("/api/Genre/GetList")
            //        .then(function (response) {
            //            defer.resolve(response.data);
            //        }.bind(this), function (response) {
            //            defer.reject({ error: response.data, status: response.status });
            //        });
            //    return defer.promise;               
            //};    
           
            return GenreService;
        }]);
})();
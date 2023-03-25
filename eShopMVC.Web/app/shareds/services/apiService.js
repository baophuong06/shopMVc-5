/// <reference path="../../../assets/admin/libs/angular/angular.js" />

//const { param } = require("jquery");

(function (app) {
    app.factory('apiService', apiService);
        apiService.$inject = ['$http'];
        function apiService($http) {
            return {
                get: get,
                post: post
            } 

            function post(url, data, success, failure) {
                $http.post(url, data).then(function (result) {
                    success(result);
                },
                    function (error) {
                        //if (data.error = '401') {
                        //    console
                        //}
                        failure(error);
                    }
                );
            }

            function get(url, params, success, failure) {
                $http.get(url, params).then(function (result) {
                    success(result);
                },
                    function (error) {
                        failure(error);
                    }
                );
            }
    }
})(angular.module('eshopmvc.common'));
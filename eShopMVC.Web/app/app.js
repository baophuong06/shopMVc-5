/// <reference path="../assets/admin/libs/angular/angular.js" />

(function () {
   
    angular.module('eshopmvc',
        ['eshopmvc.products',
         'eshopmvc.product_categories',

        , 'eshopmvc.common']).config(config);//'eshopmvc',
    config.$inject = ['$stateProvider', '$urlRouterProvider', '$qProvider'];

    function config($stateProvider, $urlRouterProvider, $qProvider) {
       
        $urlRouterProvider.otherwise("/admin");
        $stateProvider.state('home', {
            url: "/admin",
            templateUrl: "/app/components/home/homeView.html",
            controller: "homeController"
        });
        $qProvider.errorOnUnhandledRejections(false);
    }
    //app.config(['$qProvider', function ($qProvider) {
    //    $qProvider.errorOnUnhandledRejections(false);
    //}]);
})();

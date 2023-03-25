/// <reference path="../../../assets/admin/libs/angular/angular.js" />
(function () {
    angular.module('eshopmvc.products', ["eshopmvc.common"]).config(config);
    config.$inject = ['$stateProvider', '$urlRouterProvider'];
    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('products', {
            url: "/products",
            templateUrl: "/app/components/products/productListView.html",
            controller: "productListController"
        }).state('product_add', {
            url: "/product_add",
            templateUrl: "/app/components/products/productAddView.html",
            controller: "productAddController"
        });
    }
})();//angular.module('eshopmvc.products')
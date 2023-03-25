/// <reference path="../../../assets/admin/libs/angular/angular.js" />
(function (app) {
    app.controller('productCategoryAddController', productCategoryAddController);
    productCategoryAddController.$inject = ['$scope', 'apiService','$state'];
    function productCategoryAddController($scope, apiService,$state) {
        $scope.productCategory = {
            CreateBy: new Date(),
            Status: true
        }
        //$scope.parentCategories = [];
        $scope.AddProductCategory = AddProductCategory;
        //$scope.loadParentCategory = loadParentCategory;
        
         function AddProductCategory() {
             apiService.post('/api/productcategory/create', $scope.productCategory, function (result) {
                 console.log(result.data.Name + "da duoc them moi");
                $state.go('product_categories');
            }, function () {
                console.log('add unsuccessfuly');
            });
        }
        function loadParentCategory() {
            
            apiService.get('/api/productcategory/getallparent', null, function (result) {
                //console.log(result.data);
                $scope.parentCategories = result.data;
            }, function () {
                console.log('faile');
            });
           
        }
        loadParentCategory();
    }
    
  
})(angular.module('eshopmvc.product_categories'));
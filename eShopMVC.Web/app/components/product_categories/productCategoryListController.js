(function (app) {
    app.controller('productCategoryListController', productCategoryListController);

    productCategoryListController.$inject = ['$scope', 'apiService'];

    function productCategoryListController($scope,apiService) {
        $scope.productCategories = [];
        $scope.page = 0;
        $scope.totalCount = 0;
        $scope.totalPages = 0;
        //$scope.pageIndex = 0;
        //$scope.pageSize = 2;
        $scope.getProductCategory = getProductCategory;

        //function getProductCategory() {
        //    //page = page || 0;
        //    //var config = {
        //    //    params: {
        //    //       page:page,
            
        //    //        pageSize:2
        //    //    }
        //    //}
        //    apiService.get('/api/productcategory/getall',null, function (result) {
        //            $scope.productCategories = result.data;//.Items;
        //        //$scope.page = result.data.Page;
        //        //$scope.totalCount = result.data.TotalCount;
        //        //$scope.pageCount = result.data.TotalPages;
               
        //    }, function () {
        //        console.log('load productcategory fail');
        //    });

            function getProductCategory(page) {
                page = page || 0;
                var config = {
                    params: {
                        page: page,

                        pageSize: 2
                    }
                }
                apiService.get('/api/productcategory/getallpage', config, function (result) {
                    $scope.productCategories = result.data;
                    $scope.page = result.data;
                    $scope.totalCount = result.data;
                    $scope.totalPages = result.data;
            
                }, function () {
                    console.log('load productcategory fail');
                });
        }
        $scope.getProductCategory();
    }
})(angular.module('eshopmvc.product_categories'));

//$scope.curPage = 1,
//    $scope.itemsPerPage = 3,
//    $scope.maxSize = 5;

//this.items = itemsDetails;

//$scope.numOfPages = function () {
//    return Math.ceil(itemsDetails.length / $scope.itemsPerPage);

//};

//$scope.$watch('curPage + numPerPage', function () {
//    var begin = (($scope.curPage - 1) * $scope.itemsPerPage),
//        end = begin + $scope.itemsPerPage;

//    $scope.filteredItems = itemsDetails.slice(begin, end);
//});
//});
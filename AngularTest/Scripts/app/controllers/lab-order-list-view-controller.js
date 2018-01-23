angular
    .module('myApp')
    .controller('labOrderListViewController',
        [
            '$scope', 'asyncDataService', 'apiEndpoints',
            function ($scope, asyncDataService, apiEndpoints) {
                function loadData() {
                    //api endpoints defined in constants.js
                    var url = apiEndpoints.labOrderList;
                    asyncDataService.getDataFromUrl(url).then(function (data) {
                        $scope.labOrders = data;
                        console.log($scope);
                    });
                }
                loadData();
            }
        ]);

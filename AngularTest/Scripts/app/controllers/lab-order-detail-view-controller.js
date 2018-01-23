angular
    .module('myApp')
    .controller('labOrderDetailViewController',
        [
            '$scope', 'asyncDataService', 'apiEndpoints',
            function ($scope, asyncDataService, apiEndpoints) {
                function loadData() {
                    //api endpoints defined in constants.js
                    var url = apiEndpoints.labOrderDetail;
                    asyncDataService.getDataFromUrl(url).then(function (data) {
                        $scope.labOrder = data;
                        console.log($scope);
                    });
                }
                loadData();
            }
        ]);

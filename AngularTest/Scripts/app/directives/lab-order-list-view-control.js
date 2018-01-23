angular
    .module('myApp')
    .directive('labOrderListViewControl',
        ['directiveTemplates',
            function (directiveTemplates) {
                var result = {
                    controller: 'labOrderListViewController',
                    //defined in constants
                    templateUrl: directiveTemplates.labOrderListViewControl,
                    restrict: 'A'
                };
                return result;
            }
        ]);
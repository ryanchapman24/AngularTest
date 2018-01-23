//(function (ng) {

//    'use strict';



//    angular
//        .module('myApp',
//            [
//                'ui.router',
//                'ngMaterial',
//                'ngAnimate',
//                'ngAria'
//            ]);
//    /*
//    console.log('remindMd dependancies injected');
//    */
//})();

'use strict';
angular.module('myApp',
    [
        'ui.router',
        'ngMaterial',
        'ngAnimate',
        'ngAria'
    ]).run([
    '$rootScope', '$state', function($rootScope, $state) {
        $rootScope.$state = $state;
    }
]);
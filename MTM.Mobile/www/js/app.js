// Ionic Starter App

// angular.module is a global place for creating, registering and retrieving Angular modules
// 'starter' is the name of this angular module example (also set in a <body> attribute in index.html)
// the 2nd parameter is an array of 'requires'
// 'starter.controllers' is found in controllers.js
angular.module('starter', ['ionic', 'ionic-material', 'starter.controllers', 'ionMdInput'])

.run(function ($ionicPlatform) {
    $ionicPlatform.ready(function () {
        // Hide the accessory bar by default (remove this to show the accessory bar above the keyboard
        // for form inputs)
        if (cordova.platformId === 'ios' && window.cordova && window.cordova.plugins.Keyboard) {
            cordova.plugins.Keyboard.hideKeyboardAccessoryBar(true);
            cordova.plugins.Keyboard.disableScroll(true);

        }
        if (window.StatusBar) {
            // org.apache.cordova.statusbar required
            StatusBar.styleDefault();
        }
    });
})

.config(function ($stateProvider, $urlRouterProvider, $ionicConfigProvider) {

    // Turn off caching for demo simplicity's sake
    $ionicConfigProvider.views.maxCache(0);

    $stateProvider

      .state('app', {
          url: '/app',
          abstract: true,
          templateUrl: 'templates/menu.html',
          controller: 'AppCtrl'
      })

    .state('app.search', {
        url: '/search',
        views: {
            'menuContent': {
                templateUrl: 'templates/search.html',
                controller: 'searchCtrl'
            }
        }
    })

    .state('app.petProfiles', {
        url: '/petProfiles',
        views: {
            'menuContent': {
                templateUrl: 'templates/petProfiles.html',
                controller: 'petProfilesCtrl'
            }
        }
    })

    .state('app.petProfile', {
        url: '/petProfiles/:petProfileId',
        views: {
            'menuContent': {
                templateUrl: 'templates/petProfile.html',
                controller: 'petProfileCtrl'
            }
        }
    })

      .state('app.tasks', {
          url: '/checkList/:petProfileId',
          views: {
              'menuContent': {
                  templateUrl: 'templates/checkList.html',
                  controller: 'checkListCtrl'
              }
          }
      })

        .state('app.task', {
            url: '/checkList/:checkListItemId',
            views: {
                'menuContent': {
                    templateUrl: 'templates/checkListITem.html',
                    controller: 'checkListItemCtrl'
                }
            }
        })


    .state('app.login', {
        url: '/login',
        views: {
            'menuContent': {
                templateUrl: 'templates/login.html',
                controller: 'LoginCtrl'
            },
            'fabContent': {
                template: ''
            }
        }
    })

    .state('app.profile', {
        url: '/profile',
        views: {
            'menuContent': {
                templateUrl: 'templates/profile.html',
                controller: 'ProfileCtrl'
            }
        }
    });
    // if none of the above states are matched, use this as the fallback
    $urlRouterProvider.otherwise('/app/login');
});

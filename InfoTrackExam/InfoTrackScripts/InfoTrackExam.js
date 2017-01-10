/// <reference path="angular.js" />
var myApp = angular.module("InfoTrackExam", [])
                   .controller("InfoTrackExamController", function ($scope, $log, $http) {
                       $scope.PerformInputValidation = function () {
                           if ($scope.searchKeyword == "" || $scope.searchUrl == "") {

                               return true;
                           }
                          
                       }

                       //Function to verify the Search Keyword in Google....
                       $scope.VerifyUrl = function () {
                           $scope.verificationResult = "";

                           if ($scope.searchKeyword == "" || $scope.searchKeyword == null || $scope.searchUrl == "" || $scope.searchUrl == null) {
                               $scope.verificationResult = "Please Enter Seach Keyword and URL to Proceed!";

                               
                           }
                           else {
                               $http({
                                   method: 'GET',
                                   url: '/InfoTrack/VerifyUrlInGoogleSearchResult',
                                   params: { searchKeyword: $scope.searchKeyword, searchUrl: $scope.searchUrl }
                               }).then(function (response) {
                                   $scope.verificationResult = response.data;
                                   $log.info(response.data);//This is only for debugging purpose...
                               });
                           }
                       }

                   });
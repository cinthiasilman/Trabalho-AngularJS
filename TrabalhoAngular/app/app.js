var app = angular.module("app", ['ngRoute'])

 .config(function ($routeProvider, $locationProvider) {

     $routeProvider.when('/Inscricao/Cursos', { templateUrl: '/templates/Cursos/cursos.html', controller: 'CursosController' });

     $routeProvider.when('/Inscricao/Alunos', { templateUrl: '/templates/Alunos/alunos.html', controller: 'AlunosController' });

     $locationProvider.html5Mode(true);

 });

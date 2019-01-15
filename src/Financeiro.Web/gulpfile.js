var gulp = require ('gulp');
var concat = require('gulp-concat');
var cssmin = require('gulp-cssmin');
var uncss = require('gulp-uncss');
var browserSync = require('browser-sync').create();

gulp.task('browser-sync', function(){

    browserSync.init({
        prox: 'localhost:5000'
    });

    gulp.watch('./styles/*.css',['css']);
    gulp.watch('./js/*.js',['js']);
});

gulp.task('js', function(){

    return gulp.src([
        './node_modules/bootstrap/dist/js/bootstrap.min.js',
        './node_modules/jquery/dist/jquery.min.js',
        './node_modules/jquery-validation/dist/jquery.validate.min.js',
        './node_modules/jquery-validation-unobtrusive/jquery.validate.unobtrusive.js',
        './js/site.js',
    ])
    .pipe(gulp.dest('wwwroot/js'))
    .pipe(browserSync.stream());
});

gulp.task('css', function(){

    return gulp.src([
        './Style/site.css',
        './node_modules/bootstrap/dist/css/bootstrap.css',
    ])
    .pipe(concat('site.min.css'))
    .pipe(cssmin())
  //  .pipe(uncss({html: ['Views/**/*.cshtml']})) // Retira do CSS oque não está cedo utilizado
    .pipe(gulp.dest('wwwroot/css'))
    .pipe(browserSync.stream());
});
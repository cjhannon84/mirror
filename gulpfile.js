var gulp = require("gulp");
var concat = require("gulp-concat");
var minify = require("gulp-minify");

gulp.task("scripts", function() {
    return gulp.src([
                './bower_components/jquery/dist/jquery.slim.min.js',
                './bower_components/bootstrap/dist/js/bootstrap.min.js',
                './bower_components/handlebars/handlebars.min.js',
                './node_modules/moment/min/moment-with-locales.min.js',
                './js/mirror.js'
            ])
            .pipe(concat('mirror.js'))
            .pipe(minify())
            .pipe(gulp.dest('./wwwroot/js'));
});

gulp.task("styles", function() {
    return gulp.src([
        './node_modules/@fortawesome/fontawesome-pro/css/all.min.css',
        './bower_components/bootstrap/dist/css/bootstrap.min.css',
        './css/default.css'
    ])
    .pipe(concat('global.css'))
    .pipe(minify())
    .pipe(gulp.dest('./wwwroot/css'));
});

gulp.task("fonts", function() {
    return gulp.src([
        './node_modules/@fortawesome/fontawesome-pro/webfonts/*'
    ]).pipe(gulp.dest('./wwwroot/webfonts'))
});
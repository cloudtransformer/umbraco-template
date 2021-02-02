var gulp = require('gulp');
var $ = require('gulp-load-plugins')({ lazy: true });

var cssDestination = '../CloudTransformerTemplate/css';
var fontsDestination = '../CloudTransformerTemplate/fonts';
var imagesDestination = '../CloudTransformerTemplate/images';
var jsDestination = '../CloudTransformerTemplate/scripts';

var cssSources = ['app/sass/**/*.scss','!app/sass/_shared/*.scss'];
var jsSources = ['app/js/**/*.js'];

gulp.task('vendor', function (done) {

    var fontsVendors = null;
    var imagesVendors = ['node_modules/flag-icon-css/**/*.svg'];
    var jsVendors = null;

    /*gulp.src(fontsVendors)
        .pipe(gulp.dest(fontsDestination));*/

    gulp.src(imagesVendors)
        .pipe(gulp.dest(imagesDestination));

    /*gulp.src(jsVendors)
        .pipe(gulp.dest(jsDestination));*/

    done();
});

gulp.task('debug', gulp.series('vendor', function (done) {

    gulp.src(cssSources)
        .pipe($.sourcemaps.init())
        .pipe($.sass().on('error', $.sass.logError))
        .pipe($.sourcemaps.write('.'))
        .pipe(gulp.dest(cssDestination));

    gulp.src(jsSources)
        .pipe($.sourcemaps.init())
        .pipe($.concat('main.js'))
        .pipe($.sourcemaps.write('.'))
        .pipe(gulp.dest(jsDestination));

    done();
}));

gulp.task('release', gulp.series('vendor', function (done) {

    gulp.src(cssSources)
        .pipe($.sass().on('error', $.sass.logError))
        .pipe($.cleanCss({ level: { 1: { specialComments: 'remove' } } }))
        .pipe(gulp.dest(cssDestination));

    gulp.src(jsSources)
        .pipe($.concat('main.js'))
        .pipe($.uglify())
        .pipe(gulp.dest(jsDestination));

    done();
}));

gulp.task('default', gulp.series('debug', function (done) { done() }));
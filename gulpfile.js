const path = require('path');
const exec = require('child_process').exec;
const gulp = require('gulp');
const browserify = require('browserify');
const source = require('vinyl-source-stream');
const streamify = require('gulp-streamify');
const envify = require('gulp-envify');

const environment = {
  NODE_ENV: 'development',
};


gulp.task('browserify-babelify', () => {
  // set up the browserify instance on a task basis
  const b = browserify('./sources/index.js');
  return b.bundle()
    .pipe(source('index.js'))
    .pipe(streamify(envify(environment)))
//    .pipe(streamify(uglify()))
    .pipe(gulp.dest('./www/js/'));
});


gulp.task('prepare', ['browserify-babelify'], () => {
  exec('cordova prepare');
});


gulp.task('default', () => {
  gulp.watch([
    path.join(__dirname, '/sources/**/*.js'),
    path.join(__dirname, '/sources/**/*.vue'),
    path.join(__dirname, '/www/**/*.html'),
    path.join(__dirname, '/www/**/*.css'),
  ], ['prepare']);
});

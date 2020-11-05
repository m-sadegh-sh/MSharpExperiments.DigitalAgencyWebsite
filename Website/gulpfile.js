const gulp = require("gulp");
const sass = require("gulp-sass");
const browserSync = require("browser-sync").create();
const dotnetWatch = require("gulp-dotnet-watch");

// #region dev

function sassCompile() {
  return gulp
    .src("wwwroot/styles/default/**/[!_]*.scss")
    .pipe(sass().on("error", sass.logError))
    .pipe(gulp.dest("wwwroot/styles/default/"))
    .pipe(browserSync.stream());
}

function watchTask() {
  gulp.watch("wwwroot/styles/**/*.scss", sassCompile);
  //gulp.watch("Views/**/*.cshtml").on("change", browserSync.reload);
  gulp.watch("wwwroot/scripts/**/*.js").on("change", browserSync.reload);
}

function browserSyncTask() {
  return browserSync.init({
      proxy: "http://localhost:19585"
  });
}

function dotnet() {
  return dotnetWatch.watch("run");
}

exports.sass = sassCompile;

exports.dev = function dev() {
    //too slow
    //dotnet();
  browserSyncTask();
  watchTask();
};

// #endregion

gulp.task('default', watchTask);
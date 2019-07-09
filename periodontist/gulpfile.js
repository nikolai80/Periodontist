var gulp = require('gulp'),
    sass = require('gulp-sass');

gulp.task('sass', function(){ // Создаем таск "sass"
    return gulp.src('content/Site.scss') // Берем источник
        .pipe(sass()) // Преобразуем Sass в CSS посредством gulp-sass
        .pipe(gulp.dest('content/')); // Выгружаем результата в папку app/css
});

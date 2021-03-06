﻿module.exports = function (grunt) {
	var babelConfig = {
		files: {
			src: ["scripts/es6/**/*js"],
			dest: "scripts/es5/scripts.js"
		}
	};

	var concatConfig = {
		files: {
			src: ["bower_components/jquery/dist/jquery.js", "scripts/es5/*.js"],
			dest: "wwwroot/scripts/script.js"
		}
	}

	var uglifyConfig = {
		files: {
			src: "wwwroot/scripts/script.js",
			dest: "wwwroot/scripts/script.min.js"
		}
	}

	grunt.initConfig({
		babel: babelConfig,
		concat: concatConfig,
		uglify: uglifyConfig
	});

	grunt.registerTask("build", ["babel", "concat", "uglify"])

	grunt.loadNpmTasks("grunt-babel");
	grunt.loadNpmTasks("grunt-contrib-concat");
	grunt.loadNpmTasks("grunt-contrib-uglify");
};
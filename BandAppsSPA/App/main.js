requirejs.config({
    paths: {
        'text': '../Scripts/text',
        'durandal': '../Scripts/durandal',
        'plugins': '../Scripts/durandal/plugins',
        'transitions': '../Scripts/durandal/transitions'
    }
});

define('jquery', function () { return jQuery; });
define('knockout', ko);

define(function(require) {
    var system = require('../scripts/durandal/system'),
        app = require('../scripts/durandal/app');

    system.debug(true);
    app.start().then(function () {
        app.setRoot('shell');
    });

});
﻿define('Base', [], function () {
    var activeTabs, exports;
    activeTabs = function ($container) {
        return $container.on('click', '.tab-bar a', function (evt) {
            evt.preventDefault();
            $(this).parents(".tab-bar").find("a").each(function () {
                $(this).removeClass("selected");
                if ($(this).data("view")) {
                    return $($(this).data("view")).hide();
                }
            });
            $(this).addClass("selected");
            if ($(this).data("view")) {
                return $($(this).data("view")).show();
            }
        });
    };
    return exports = {
        activeTabs: activeTabs
    };
});
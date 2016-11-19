
; (function (factory) {
    if (typeof define === 'function' && define.amd) {
        define(['jquery'], factory);
    } else if (typeof module !== 'undefined' && module.exports) {
        module.exports = factory(['jquery']);
    } else {
        this['service'] = factory(this.$);
    }
})(function ($) {

    var module = this;
    module.highlightColor = "yellow";


    module.highlight = function (el, strColor) {
        $(el).css('background', strColor);
    }
    return {
        init: function() {
            console.log($);
        },
        highlightAll: function () {
            module.highlight('div', module.highlightColor);
        }
    };
});
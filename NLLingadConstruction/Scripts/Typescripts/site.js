/// <reference path="../typings/jquery/jquery.d.ts" />
/// <reference path="../typings/bootstrap/bootstrap.d.ts" />
/// <reference path="edhelpers.ts" />
;
$(function () {
    ED.initializeImageFill();
    ED.initializeSmoothScrolling();
    $('body').scrollspy({
        target: '.navbar',
        offset: 160
    });
    $('.carousel').carousel('pause');
    initializeShowGotoTop();
    //$('#top').stellar();
    $(window).bind('load', function () {
        $('#body').show();
        $('#waiting').hide();
        new window.WOW().init();
        animateMainScreen();
    });
    $('#testButton').click(function () {
        animateCompanyName();
    });
});
$(window).load(function () {
});
var animateMainScreen = function () {
    setTimeout(animateCompanyName, 500);
    setTimeout(animateSubCompanyName, 1000);
    setTimeout(animateQuote, 2500);
};
var animateCompanyName = function () {
    animate('#top .company-frontpage .company-name', 'fadeInDown');
};
var animateSubCompanyName = function () {
    animate('#architect', 'fadeInLeft', 'inline');
    setTimeout(function () {
        animate('#designers', 'fadeInLeft', 'inline');
    }, 500);
    setTimeout(function () {
        animate('#builders', 'fadeInLeft', 'inline');
    }, 1000);
};
var animateQuote = function () {
    animate('#quote', 'fadeInLeft', 'inline');
};
var animate = function (selector, animation, display) {
    if (display === undefined)
        display = 'block';
    var $company = $(selector);
    //$company.css('display', display);
    $company.css('opacity', 1);
    $company.addClass('animated ' + animation);
    setTimeout(function () {
        $company.removeClass('animated ' + animation);
    }, 3000);
};
var initializeShowGotoTop = function () {
    var docElem = document.documentElement, $topButton = $('#goto-top-button-div'), didScroll = false, showButtonOn = 350;
    function init() {
        $(window).scroll(function (event) {
            if (!didScroll) {
                didScroll = true;
                setTimeout(scrollPage, 250);
            }
        });
    }
    function scrollPage() {
        var sy = scrollY();
        if (sy >= showButtonOn) {
            $topButton.css('opacity', 0.7);
        }
        else {
            $topButton.css('opacity', 0);
        }
        didScroll = false;
    }
    function scrollY() {
        return window.pageYOffset || docElem.scrollTop;
    }
    init();
};
//# sourceMappingURL=site.js.map
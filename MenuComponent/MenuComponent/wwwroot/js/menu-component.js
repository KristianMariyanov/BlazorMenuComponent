window['MenuComponent'] = window['MenuComponent'] || {};
window['MenuComponent']['OnMenuMouseOver'] = function (menuId, e) {
    var element = document.querySelectorAll('[data-key="' + menuId + '"]');
    if (element && element.length && element[0].children[0] && element[0].children.length) {
        element[0].children[0].style.visibility = 'visible';
        element[0].children[0].style.opacity = '1';
    }
};

window['MenuComponent']['OnMenuMouseOut'] = function (menuId, e) {
    var element = document.querySelectorAll('[data-key="' + menuId + '"]');
    if (element && element.length && element[0].children[0] && element[0].children.length) {
        element[0].children[0].style.visibility = 'hidden';
        element[0].children[0].style.opacity = '0';
    }
};
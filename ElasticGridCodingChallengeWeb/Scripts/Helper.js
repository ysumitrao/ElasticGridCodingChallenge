function GetStartsWith(inputStr) {
    $('#spanStartsWith').text(startsWith(inputStr));
}

function startsWith(inputStr) {
    var compareString = $('#txtComparisionString').val();
    return compareString.indexOf(inputStr) === 0;
}

function GetEndsWith(inputStr) {
    $('#spanEndsWith').text(endsWith(inputStr));
}
function endsWith(inputStr) {
    var compareString = $('#txtComparisionString').val();
    return compareString.match(inputStr + '$') == inputStr;
}

function GetStrippedHtml(inputStr) {
    $('#spanStrippedHtml').text(stripHtml(inputStr));
}

function stripHtml(inputStr) {
    var _inputStr = $(inputStr).text();
    return _inputStr === '' ? inputStr : _inputStr;
}

function jqAnchor(objInput, option) {
    $(objInput).find('a').click(function () {
        var url = $(this).attr("href");
        var target = $(this).attr("data­window­group");
        var option = $(this).attr("option");

        url = url == undefined ? "#" : url;
        target = target == undefined ? "_blank" : target;
        option = option == "" || option == undefined ? "toolbar=yes, scrollbars=yes, resizable=yes, menubar=yes, width=400, height=400" : option;
        newwindow = window.open(url, target, option);
        return false;
    });
}
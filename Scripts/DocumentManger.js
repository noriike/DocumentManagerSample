$(function () {
    /* 文書管理画面 */
    $("#drpCategory").on('click', 'li a', function () {
        if ($(this).text() == '指定なし') {
            $("#btnCategory").text('文書カテゴリ');
        } else {
            $("#btnCategory").text($(this).text());
            $("#btnCategory").val($(this).text());
        }
    });

});
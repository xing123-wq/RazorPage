$(function () {
    //全选或全不选
    $("#all").click(function () {
        if (this.checked) {
            $("#list :checkbox").attr("checked", true);
        } else {
            $("#list :checkbox").attr("checked", false);
        }
    });
    //    //获取选中选项的值
    $("#getValue").click(function () {
        var valArr = new Array;
        $("#list :checkbox[checked]").each(function (i) {
            valArr[i] = $(this).val();
        });
        var vals = valArr.join(',');
        alert(vals);
    });
});

//取多个name进行字体闪烁
function roplcolor() {
    var free = document.getElementsByName('bay');
    for (var i = 0; i < free.length; i++) {
        if (free[i].style.color === 'blue') {
            free[i].style.color = '#8a6d3b';
        } else {
            free[i].style.color = 'blue';
        }
    }
}
setInterval(roplcolor, 1000);
//点击解除禁用
function disable() {
    var relieve = document.getElementById("user.name").disabled = "";
    var disarm = document.getElementById("user.number").disabled = "";

}

$(function () {
    $('[data-toggle="tooltip"]').tooltip()
})
$('#myTabs a').click(function (e) {
    e.preventDefault()
    $(this).tab('show')
})//工具提示
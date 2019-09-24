var parssword = document.querySelectorAll('[xlt]');
var verifypassword = document.querySelectorAll('[xlt]');

if (parssword === verifypassword) {

}
else {
    alert('你输入的密码不一致');
}
//window.onbeforeunload = function (e) {
//    return '';
//};      
document.getElementsByTagName('form')[0].onsubmit = function () {
    if (document.getElementsByName('UserName')[0].value === '') {
        return false;
    }
}
window.onbeforeunload = function (e) {
    return '关闭提示';
};
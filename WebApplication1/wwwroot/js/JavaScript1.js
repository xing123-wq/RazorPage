//铃铛闪烁
function changecolor() {
    var star = document.getElementById('greet');
    if (star.style.color === 'red') {
        star.style.color = 'green';
    } else {
        star.style.color = 'red';
    }
}
setInterval(changecolor, 1000);
//眼睛闪烁
function opticalcolor() {
    var eyeball = document.getElementById('eye');
    if (eyeball.style.color === 'white') {
        eyeball.style.color = 'blue';
    } else {
        eyeball.style.color = 'white';
    }
}
setInterval(opticalcolor, 1000);
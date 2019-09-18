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
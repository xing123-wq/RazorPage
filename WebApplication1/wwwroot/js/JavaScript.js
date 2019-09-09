
//循环
function sum(array) {
    var array = [b, d];
    while/*循环*/ (b < 100) {
        b = b + 2;
        d = d + b;
    }
    console.log(d);//输出
}



////////求值
var z = [(27 + 11) * 2 - 10] / 2;

////////冒泡排序
var array = [4, 2, 4, 25, 63, 24, 667, 78]/*数组*/
for (var i = 0; i < array.length; i++) {
    for (var j = 0; j < array.length - i - 1; j++)
        if (array[j] > array[j + 1]) {
            var a = array[j];
            array[j] = array[j + 1];
            array[j + 1] = a;
        }
}
console.log(array);

//封装素数
function myfunction(max) {
    var arr = [];
    for (var i = 2; i < max; i++) {//2<100,for循环。
        var yes = true;//
        for (var j = 2; j <= i / 2; j++) {
            if (i % j == 0) {
                yes = false;//yes=布尔值false
                break;
            }
        }
        if (yes) {
            arr.push(i);


        }
    }
    console.log(arr);



}
myfunction(100);





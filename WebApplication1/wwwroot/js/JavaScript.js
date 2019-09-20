////封装成一个函数Sum()，可以计算任意起始位置、任意步长
var Sum = function (first, step, end) {
    var result = 0;
    while (first < end) {
        first = first + step;
        result = result + first;
    }
    console.log(result);
}

//////////求值
var z = [(27 + 11) * 2 - 10] / 2;

//////////冒泡排序
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

////封装素数
function myfunction(max) {
    var err = [];
    for (var i = 2; i < max; i++) {//2<100,for循环。
        var yes = true;//
        for (var j = 2; j <= i / 2; j++) {
            if (i % j == 0) {
                yes = false;//yes=布尔值false
                break;
            }
        }
        if (yes) {
            err.push(i);


        }
    }
    console.log(err);



}


////封装一个函数，建立一个函数getMaxNumber()，可以接受任意多各种类型。
function getMaxNumber() {
    var Max = -Infinity;
    for (var i = 0; i < arguments.length; i++) {
        if (typeof arguments[i] == "number" && arguments[i] > Max) {
            Max = arguments[i]
        }
    }
    console.log(Max);

}

//封装一个函数Swap(arr, i, j),i和j的值交换下标
var arr = [8, 3];
function swap(arr, i, j) {
    var temp = arr[i];
    arr[i] = arr[j];
    arr[j] = temp;
}
swap(arr, 0, 1);
//利用上面的Swap()函数，将“冒泡排序”封装成函数bubbleSort()
var bubbleSort = function () {
    var swap = [12, 7, 8, 37, 20, 42, 69, 51];
    for (var i = 0; i < swap.length - 1; i++) {
        for (var j = 0; j < swap.length - 1 - i; j++) {
            if (swap[j] > swap[j + 1]) {
                a = swap[j];
                swap[j] = swap[j + 1];
                swap[j + 1] = a;
            }
        }
    }
    console.log(swap);
}

//////将源栈同学姓名/昵称装入数组，再根据该数组输出共有多少同学
////在上述数组头部加上小鱼老师，末尾加上大飞哥
function yuangzhan() {
    var array = ["薛明林", "彭志强", "王新", " 陈晓斌", "陈百万", "于维谦", "杨进文"];
    array.push("小余老师");
    array.unshift("飞哥");
    result = array.length;
    console.log(result);
}

////删除一个数组里面重复的元素
function daleteEcho(arr) {
    var hash = [];
    for (var i = 0; i < arr.length; i++) {
        if (arr.indexOf(arr[i]) == i) {//inddexof取下标
            hash.push(arr[i])//把arr[i];数组推向hash=[];
        }
    }
    console.log(hash)
}

//////替换字符串
function alphabetic() {
    var str = "`源栈`：飞哥小班教学，线下免费收看";//字符串
    var tex = str.replace("飞哥", "大神");//
    text = str.replace("线下", "线上");
    console.log(tex);
}
//规范字符串内容
function standard() {
    //截取字符串内容
    var str = ['why', 'gIT', 'vs2019', 'community', 'VERSION'];
    var arr = [];
    for (var i = 0; i < str.length; i++) {
        arr[i] = str[i].slice(0, 6);
        arr.push(str[i]);
        //转变为首字母大写
        var a = arr.join(",");
        var text = a.toLowerCase();
        var newText = text.replace("w", "W");

    }
    console.log(newText);

}
//生成随机数
function getRandomArray(length, max) {
    var arr = [];
    for (var i = 0; i < length - 1; i++) {
        arr[i] = Math.floor(Math.random() * max);
        arr.push(i);
    }
    console.log(arr);
}
//颠倒字符顺序
function reverse() {
    var str = ("hello,yuanzhan");
    var array = str.split("").reverse().join("");
    console.log(array);

}
function strAdd() {
    var str = (`There are two ways to create a RegExp object
        : a literal notation and a constructor.To indicate strings
        , the parameters to the literal notation do not use quotation
        marks while the parameters to the constructor function do use 
        quotation - marks.So the following expressions create the same
    regular expression`);
    var arr = str.split("");
    for (var i = 0; i < str.length; i++) {
        if (true) {

        } else {
            //什么都不做
        }
    }
    console.log(arr);
}
//构建一个函数has9(number) ，可以判断number中是否带有数字9
//构建一个函数has8(number) ，可以判断number中是否带有数字8；
//使用上述函数，找出10000以内有多少个数字包含：9或者8或者6。
function has(number) {
    var result = 0;
    for (var i = 0; i < number + 1; i++) {
        if (has9(i) || has8(i) || has6(i)) {
            result++;
        } else {
            //什么都不做
        }
    }
    console.log(result);
}
//构建一个函数has6(number) ，可以判断number中是否带有数字6；
function has9(number) {
    return hasx(number, 9)
}
function has6(number) {
    return hasx(number, 6)
}
function has8(number) {
    return hasx(number, 8)
}
function hasx(number, x) {
    return String(number).indexOf(x) >= 0;
}
//模拟名称空间
var get986 = function (number) {
    var result = 0;
    for (var i = 0; i < number + 1; i++) {
        if (has9(i) || has8(i) || has6(i)) {
            result++;
        } else {
            //什么都不做
        }
    }
    console.log(result);
}
//使用setTimeout()（不是setInterval()）实现每隔1秒钟依次显示：
//第n周，源栈同学random人。（n逐次递增，random随机）

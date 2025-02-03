var reverse = function(x) {
    let res = 0;
    if (x < 0) {
        res = parseInt(String(x).slice(1).split('').reverse().join('')) * -1;
    } else {
        res = parseInt(String(x).split('').reverse().join(''));
    }

    if (res > Math.pow(2, 31) - 1 || res < -Math.pow(2, 31)) {
        return 0;
    }

    return res;    
};
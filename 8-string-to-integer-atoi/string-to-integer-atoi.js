let myAtoi = function (s) {
    const ans = Number.parseInt(s);
    if (ans) {
        if (ans <= -2147483648) return -2147483648;
        else if (ans >= 2147483647) return 2147483647;
        else return ans;
    }
    return 0;
};
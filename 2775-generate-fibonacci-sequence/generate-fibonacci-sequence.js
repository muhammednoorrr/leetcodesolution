/**
 * @return {Generator<number>}
 */
var fibGenerator = function*(h) {
    for(let b=1,a=0;true;b+=a,a=b-a){
        yield a;
    };
};

/**
 * const gen = fibGenerator();
 * gen.next().value; // 0
 * gen.next().value; // 1
 */
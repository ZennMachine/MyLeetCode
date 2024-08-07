/**
 * @param {integer} init
 * @return { increment: Function, decrement: Function, reset: Function }
 */
var createCounter = function(init) {
    currentVal = init;
    function increment() {
        currentVal++;
        return currentVal;
    }
    function decrement() {
        currentVal--;
        return currentVal;
    }
    function reset() {
        currentVal = init;
        return currentVal;
    }

    return {
        increment: increment,
        decrement: decrement,
        reset: reset
    }
};

/**
 * const counter = createCounter(5)
 * counter.increment(); // 6
 * counter.reset(); // 5
 * counter.decrement(); // 4
 */
// https://leetcode.com/problems/apply-transform-over-each-element-in-array/submissions/1221152202

/**
 * @param {number[]} arr
 * @param {Function} fn
 * @return {number[]}
 */
var map = function(arr, fn) {
    const newArr = [];
    for(let i = 0; i < arr.length; i++)
    {
        newArr.push(fn(arr[i], i));
    }
    return newArr;
};


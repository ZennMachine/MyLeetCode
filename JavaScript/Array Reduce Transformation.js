// https://leetcode.com/problems/array-reduce-transformation/submissions/1224031849

/**
 * @param {number[]} nums
 * @param {Function} fn
 * @param {number} init
 * @return {number}
 */
var reduce = function(nums, fn, init) {
    var val = init;
    if(nums.length === 0) {
        return init;
    }
    for(let i = 0; i < nums.length; i++) {
        val = fn(val, nums[i]);
    }
    return val;
};
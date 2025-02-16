/**
 * @param {number[]} candidates
 * @param {number} target
 * @return {number[][]}
 */
var combinationSum = function(candidates, target) {
    const res = [];

    function makeCombination(idx, comb, total) {
        if (total === target) {
            res.push([...comb]);
            return;
        }

        if (total > target || idx >= candidates.length) {
            return;
        }

        comb.push(candidates[idx]);
        makeCombination(idx, comb, total + candidates[idx]);
        comb.pop();
        makeCombination(idx + 1, comb, total);
    }

    makeCombination(0, [], 0);
    return res;    
};
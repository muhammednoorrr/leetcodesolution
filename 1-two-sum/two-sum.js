/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function(nums, target) {
    const mapIndex = [];
    const mapVal = []
    for(let i = 0; i < nums.length;i++){
        const cur = nums[i];
        const x = target - cur;
        if(mapVal.includes(x)){
            return [i,mapVal.indexOf(x)]
        }
        mapIndex.push(i)
        mapVal.push(cur)
    }
};
/**
 * @param {number[]} nums1
 * @param {number[]} nums2
 * @return {number}
 */
var findMedianSortedArrays = function(nums1, nums2) {
    const array = [...nums1, ...nums2].sort((a,b) => a - b)
    const mid = Math.floor(array.length / 2);
    
    if (array.length % 2 === 0) {
        return (array[mid] + array[mid - 1]) / 2;
    } else {
        return array[mid];
    }
};
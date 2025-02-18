/**
 * Definition for a binary tree node.
 * function TreeNode(val, left, right) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.left = (left===undefined ? null : left)
 *     this.right = (right===undefined ? null : right)
 * }
 */
/**
 * @param {TreeNode} root
 * @return {number}
 */
function countingTraversal(root, num) {
    if (root == null) return;
    else num[0] = num[0] + 1;
    countingTraversal(root.left, num);
    countingTraversal(root.right, num);
};
var countNodes = function (root) {
    let num = [0];
    countingTraversal(root, num);
    return num[0];
};
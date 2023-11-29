class Solution:
    def removeOuterParentheses(self, S: str) -> str:
    	S = list(S)
    	c, i, j = 0, 0, 0
    	f = {'(':1, ')':-1}
    	while i < len(S):
    		c += f[S[i]]
    		if c == 0:
    			del S[j]
    			del S[i-1]
    			i -= 2
    			j = i + 1
    		i += 1
    	return("".join(S))
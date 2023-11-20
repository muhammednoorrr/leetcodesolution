public class Solution {
    public string[] FindRelativeRanks(int[] score) {
        string[] res = new string[score.Length];
        PriorityQueue<int, int> pq = new();

        for(int i=0; i<score.Length; i++){
            pq.Enqueue(i, -score[i]);
        }

        if(pq.Count > 0){
            res[pq.Dequeue()] = "Gold Medal";
        }

        if(pq.Count > 0){
            res[pq.Dequeue()] = "Silver Medal";
        }
        
        if(pq.Count > 0){
            res[pq.Dequeue()] = "Bronze Medal";
        }
        
        for(int i=4; pq.Count > 0; i++){
            res[pq.Dequeue()] = $"{i}";
        }

        return res;
    }
}
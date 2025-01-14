import java.util.ArrayList;
import java.util.List;

public class Solution {
    public List<Integer> getRow(int rowIndex) {
        List<Integer> row = new ArrayList<>();
        for (int i = 0; i <= rowIndex; i++) {
            row.add(0, 1);
            for (int j = 1; j < row.size() - 1; j++) {
                row.set(j, row.get(j) + row.get(j + 1));
            }
        }
        
        return row;
    }

    public static void main(String[] args) {
        Solution solution = new Solution(); // Change the class name here
        int rowIndex = 3; // Change this to the desired rowIndex
        List<Integer> result = solution.getRow(rowIndex);
        System.out.println(result);
    }
}

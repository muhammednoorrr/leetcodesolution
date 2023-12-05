public class Solution {
    public string Interpret(string command) {
        // int i = 0;
        string result = "";
        // if command[i] == G, result = result + command[i]
        for (int i = 0; i < command.Length; i++)
        {
            char current = command[i];
            if (current == 'G')
            {
                result += "G";
            }

            // if command[i] == (, command[i + 1], then compare
            if (current == '(')
            {
                char next = command[i+1];
                // if (), then result = result + "o"
                if (next == ')')
                {
                    result += "o";
                    i += 1; // increment index accordingly
                } else { // if (a, then result = result + "al"
                    result += "al";
                    i += 2; // increment index accordingly
                }
            }
        }
        return result;
    }
}
public class Solution {
    public bool IsAcronym(IList<string> words, string s) {
        int i=0;
        char t;
        string acr="";
        foreach(string str in words){
            t=str[i];
            acr+=t;
        }
        if(acr== s){
            return true;
        }else{
            return false;
        }
    }
}
public class Solution {
    public bool IsAcronym(IList<string> words, string s) {
        int i=0;
        char temp;
        string acr="";
        foreach(string str in words){
            temp=str[i];
            acr+=temp;
        }
        if(acr== s){
            return true;
        }else{
            return false;
        }
    }
}
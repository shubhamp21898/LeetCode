public class Solution {
    public bool IsPalindrome(int x) {
        
        int idig=0,irev=0;
        int iTemp=x;
        if(x<0)
        {
            return false;
        }
        
       while(x!=0)
        {
            idig=x%10;
            irev=(irev*10)+idig;
            x=x/10;
        }
        
        if(iTemp==irev)
        {
           return true;
        }
        else
        {
            return false;
        }
        
    }
}
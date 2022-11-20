class Solution {
    public int[] shuffle(int[] nums, int n) {
        
        
        int[] ans=new int[2*n];
        int no=ans.length;
        
      
            for(int j=n,i=0,idx=0;idx<no;j++,i++){
                
                 ans[idx++]=nums[i];
                 ans[idx++]=nums[j];  
             
              
           
        }
        return ans;
    }
    
}
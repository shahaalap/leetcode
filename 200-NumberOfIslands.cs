public class Solution {
    
    int totalIslands = 0;
     Dictionary<string, bool> dict = new Dictionary<string,bool>();
    
    public int NumIslands(char[][] grid) {
       
        
                
        for(int i = 0; i< grid.Length; i++)
        {
            for(int j = 0; j< grid[i].Length; j++)
            {
                
                Traverse(i,j, grid);
            }
        }
        
        return totalIslands;
    }
    
    public void Traverse(int i , int j, char[][] grid, bool isRec = false)
    {
        if(i < 0 || j < 0 || i > grid.Length - 1 || j > grid[i].Length - 1) return;
        
        if(dict.ContainsKey(i.ToString() + j.ToString())) return;
                
        dict[i.ToString() + j.ToString()] = true;
                
        if(grid[i][j] == '1')
        {
            if(!isRec) ++totalIslands;
               
                    Traverse(i-1, j, grid, true);
             
                
               
                    Traverse(i+1, j, grid, true);
           
                
             
                    Traverse(i, j-1, grid, true);
              
                
               
                    Traverse(i, j+1, grid, true);
              
            
            }
    }
}

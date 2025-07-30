namespace _02.SpaceMission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            char[,]matrix=new char[n, n];
            int startRow = 0, startCol = 0;
            int row = 0, col = 0;
            for (int i = 0; i < n; i++)
            {
               char[]input=Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j]=input[j];
                    if (matrix[i, j]=='S')
                    {
                        startRow=i; startCol=j; 
                        row=i; col=j;
                    }
                }
            }
            int resources = 100;
            bool isOnTheMap=true;
            bool victory = false;
            while (resources>=5&&isOnTheMap&&!victory)
            {
                int nextRow = row, nextCol = col;
                string command = Console.ReadLine();

                if (command=="up") nextRow--;
                else if (command=="down") nextRow++;
                else if (command=="right") nextCol++;
                else if (command=="left") nextCol--;

                if (nextRow<0||nextRow>=n||nextCol<0||nextCol>=n)
                {
                    isOnTheMap = false;
                }
                else
                {
                    col = nextCol;
                    row = nextRow;
                    resources-=5;

                    if (matrix[nextRow, nextCol]=='R')
                    {
                        resources+=10;
                        if (resources>100) resources=100;
                    }
                    else if (matrix[nextRow, nextCol]=='M')
                    {
                        resources-=5;
                        matrix[nextRow, nextCol]='.';
                        if (resources<5) break;
                        
                    }
                    else if (matrix[nextRow, nextCol]=='P')
                    {
                        victory = true;
                    }
                   
                    
                } 
            }


            if (victory)
            {
                Console.WriteLine($"Mission accomplished! The spaceship reached Planet Eryndor with {resources} resources left.");
            }
            else
            {



                if (!isOnTheMap)
                {
                    Console.WriteLine("Mission failed! The spaceship was lost in space.");
                }
                else 
                {
                    Console.WriteLine("Mission failed! The spaceship was stranded in space.");
                }
          
                   matrix[row, col]='S';
            
            }
              
            matrix[startRow, startCol]='.';
            

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write(matrix[r, c]);

                 
                    if (c < matrix.GetLength(1) - 1)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine(); 
            }
        }

       
    }
}

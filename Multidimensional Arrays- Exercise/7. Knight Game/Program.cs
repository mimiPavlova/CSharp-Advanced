namespace _7._Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,]board=ReadMatrix();

            bool conflictsAreResolved = false;
            int removeKnightsCount = 0;
            while (!conflictsAreResolved)
            {
                int maxConflictsCount = 0, maxRow = -1, maxCol = -1;
                for (int i = 0; i <board.GetLength(0);  i++)
                {
                    for (int j = 0; j < board.GetLength(1); j++)
                    {                  
                        int conflicts=CountConflicts(board,i,j);
                        if (conflicts>maxConflictsCount)
                        {
                            maxConflictsCount = conflicts;
                            maxRow=i;
                            maxCol=j;
                        }
                    }
                }

                if (maxConflictsCount==0)
                {
                    conflictsAreResolved=true;
                }
                else
                {
                    board[maxRow, maxCol]='0';
                    removeKnightsCount++;   
                }
            }

            Console.WriteLine(removeKnightsCount);
        }
        static int[,] _moves = { { -2, 1 }, {-1, 2 }, {1,2 },
            {2,1,}, { 2,-1}, { 1,-2},{-1,-2 },{-2,-1 } };
        
        static int CountConflicts(char[,]matrix, int row, int col)
        {
            if (matrix[row, col]!='K') return 0;
            int conflicts = 0;
            for (int i = 0; i < _moves.GetLength(0); i++)
            {
                int nextRow = row+_moves[i, 0];
                if (nextRow<0||nextRow>=matrix.GetLength(0))
                {
                    continue;
                }
                int nextCol = col+_moves[i, 1];
                if (nextCol<0||nextCol>=matrix.GetLength(1))
                {
                    continue;
                }
                if (matrix[nextRow, nextCol]=='K')
                {
                    conflicts++;
                }
                
            }return conflicts;
        }
        private static char[,] ReadMatrix()
        {
            int n = int.Parse(Console.ReadLine());
            char[,] board = new char[n, n];
            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    board[i, j]=text[j];
                }
            }
            return board;
        }
    }
}

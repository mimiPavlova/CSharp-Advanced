namespace _02.TheSquirrel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string>moves=Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            (char[,]matrix, int row, int col)=ReadMatrix(n);
            int hazelnuts=0;
            bool isOnTheField=true;
            bool hasSteppedOnATrap=false;
            for (int i = 0; i < moves.Count; i++)
            {
                string move = moves[i];
                int nextRow=row, nextCol=col;
                switch (move)
                {
                    case "up": nextRow--;break;
                    case "down":nextRow++;break;
                    case "left":nextCol--; break;
                    case "right":nextCol++;break;
                }
                if (nextRow<0||nextCol<0||nextCol>=n||nextRow>=n)
                {
                    isOnTheField = false;
                   break;
                }
                else
                {
                    row=nextRow; col=nextCol;
                    if (matrix[nextRow, nextCol]=='h')
                    {
                        matrix[nextRow, nextCol] ='*';
                        hazelnuts++;
                        if (hazelnuts==3) break;
                    }
                    else if (matrix[nextRow, nextCol]=='t')
                    {
                        hasSteppedOnATrap = true;
                        break;
                    }
                    row=nextRow; col=nextCol;
                }
            }
            if (!isOnTheField)
            {
                Console.WriteLine("The squirrel is out of the field.");
            }
            else if (hasSteppedOnATrap)
            {
                Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
            }
            else if (hazelnuts<3)
            {
                Console.WriteLine("There are more hazelnuts to collect.");

            }
            else if (hazelnuts==3)
            {
                Console.WriteLine("Good job! You have collected all hazelnuts!");
            }
            Console.WriteLine($"Hazelnuts collected: {hazelnuts}");


        }
        private static (char[,], int startRow, int startCol) ReadMatrix(int n)
        {
            char[,]matrix=new char[n, n];
            int startRow = 0;
            int startCol = 0;
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j]=line[j];
                    if(matrix[i, j] =='s')
                    {
                        startRow=i; startCol=j;
                    }
                }
            }
            return (matrix, startRow, startCol);
        }
    }
}

static int CalcPath(string str)
{
    int x = 0, y = 0;
    for (int i = 0; i < str.Length; i++)
    {
        char dir = str[i];
        if (dir == 'W')
        {
            x--;
        }
        else if (dir == 'N')
        {
            y++;
        }
        else if (dir == 'S')
        {
            y--;
        }
        else
        {
            x++;
        }
    }
    return (int)Math.Sqrt((x * x) + (y * y));
}
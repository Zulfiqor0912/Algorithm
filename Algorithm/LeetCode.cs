namespace Algorithm;

internal class LeetCode
{
    public bool IsPalindrome(int x)
    {
        var a = 0;
        var c = x;
        if (x<0) return false;
        while (x != 0)
        {
            a = a * 10 + x % 10;
            x = x / 10;
        }
        
        return a == c ? true : false;
    }

    public int RomanToInt(string s)
    {
        int i = 0;
        int sum = 0;
        while (i < s.Length)
        {
            if (i+1!=s.Length)
            {
                if (s[i] == 'I' && s[i + 1] == 'V')
                {
                    sum += 4;
                    i += 2;
                }
                else if (s[i] == 'I' && s[i + 1] == 'X')
                {
                    sum += 9;
                    i += 2;
                }
                else if(s[i] == 'X' && s[i + 1] == 'L')
                {
                    sum += 40;
                    i += 2;
                }
                else if (s[i] == 'X' && s[i + 1] == 'C')
                {
                    sum += 90;
                    i += 2;
                }
                else if (s[i] == 'C' && s[i + 1] == 'D')
                {
                    sum += 400;
                    i += 2;
                }
                else if (s[i] == 'C' && s[i + 1] == 'M')
                {
                    sum += 900;
                    i += 2;
                }
                else 
                {
                    switch (s[i])
                    {
                        case 'I': sum += 1; break;
                        case 'V': sum += 5; break;
                        case 'X': sum += 10; break;
                        case 'L': sum += 50; break;
                        case 'C': sum += 100; break;
                        case 'D': sum += 500; break;
                        case 'M': sum += 1000; break;
                    }
                    i++;
                }

            }
            else {
                switch (s[i])
                {
                    case 'I': sum += 1; break;
                    case 'V': sum += 5; break;
                    case 'X': sum += 10; break;
                    case 'L': sum += 50; break;
                    case 'C': sum += 100; break;
                    case 'D': sum += 500; break;
                    case 'M': sum += 1000; break;
                }
                i++;
            }

        }
        return sum;
    }
    public int MirrorDistance(int n)
    {
        var x = n;
        var y = 0;
        while (n > 0)
        {
            y = y * 10 + n % 10;
            n /= 10;
        }
        return x > y ? x - y : y - x;
    }
    public int ScoreOfString(string s)
    {
        int score = 0;
        if (s.Length == 1) return (int)s[0];
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] > s[i + 1] && i + 1 != s.Length) score += (s[i] - s[i + 1]);
            else if(i + 1 != s.Length) score += (s[i + 1] - s[i]);
            else return score;
        }
        return score;
    }
}

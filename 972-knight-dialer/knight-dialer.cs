public sealed class Solution 
{
    private static int mod = 1_000_000_007;

    public int KnightDialer(int n) 
    {
        var arr = new long[10] {1,1,1,1,1,1,1,1,1,1};
        var temp = new long[10];

        for(int i = 1; i < n; i++) 
        {
            temp[0] = (arr[4] + arr[6]) % mod;
            temp[1] = (arr[6] + arr[8]) % mod;
            temp[2] = (arr[7] + arr[9]) % mod;
            temp[3] = (arr[4] + arr[8]) % mod;
            temp[4] = (arr[3] + arr[9] + arr[0]) % mod;
            temp[6] = (arr[1] + arr[7] + arr[0]) % mod;
            temp[7] = (arr[2] + arr[6]) % mod;
            temp[8] = (arr[1] + arr[3]) % mod;
            temp[9] = (arr[2] + arr[4]) % mod;

            Buffer.BlockCopy(temp, 0, arr, 0, temp.Length * sizeof(Int64));
        }

        Int64 sum = 0;
        for(int i = 0; i < 10; i++) 
        {
            sum += (arr[i] % mod);
        }
        return (int)(sum % mod);
    }
}
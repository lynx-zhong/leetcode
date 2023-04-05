namespace _2427._公因子的数目
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //**
            //给你两个正整数 a 和 b ，返回 a 和 b的公因子的数目。
            //如果 x 可以同时整除 a 和 b ，则认为 x是 a 和 b 的一个 公因子 。

            //示例 1：
            //输入：a = 12, b = 6
            //输出：4
            //解释：12 和 6 的公因子是 1、2、3、6 。

            //示例 2：
            //输入：a = 25, b = 30
            //输出：2
            //解释：25 和 30 的公因子是 1、5 。

            //来源：力扣（LeetCode）
            //链接：https://leetcode.cn/problems/number-of-common-factors
            //著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
            //**

            DateTime startTime = DateTime.Now;
            Console.WriteLine("次数:   " + CommonFactors(25,30));

            Console.WriteLine("耗时：   " + (DateTime.Now.Millisecond - startTime.Millisecond));
        }

        public static int CommonFactors(int a, int b)
        {
            int count = 0;
            for (int i = 1; i <= Math.Min(a,b); i++)
            {
                if (a%i == 0 && b%i == 0)
                {
                    count ++;
                }
            }

            return count;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace csTest
{
    public static class tapletest
    {
        public static void Run()
        {
            // タプル https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/builtin-types/value-tuples
            // 即席で利用できる構造体みたいなイメージなのかな
            // 単体では意味が読めないから使用は関数の返り値程度に留めておいた方が良さそう

            // 基本的な宣言方法
            // 変数名を指定していない時はitem1~が自動で付くみたい
            (int, int) taple1 = (0, 5);
            Console.WriteLine($"table1 value item1:{taple1.Item1},item2:{taple1.Item2},");

            (int val, int number) taple2 = (1, 8);
            Console.WriteLine($"table1 value item1:{taple2.val},item2:{taple2.number},");

            // taple1:(0, 5),taple2:(1, 8)って表示されるっぽい
            // tapleの値をとりあえず表示したいだけならこれで良さそう
            Console.WriteLine($"taple1:{taple1},taple2:{taple2}");

            (bool, int) taple3 = testmethod();
            // これはtrue タプルは内容一致判定が可能
            Console.WriteLine(taple3 == testmethod());
            taple3 = (taple3.Item1, 999);
            // これはfalse 1つでも値が違っていればOUT
            Console.WriteLine(taple3 == testmethod());

            int value;
            int number;

            // 代入先の変数をタプルの形で書くことによって一行で複数の変数にデータを渡すことができる
            (value, number) = taple2;
            Console.WriteLine($"value:{value},item2:{number},");
        }

        private static (bool, int) testmethod()
        {
            bool result1 = false;
            int result2 = 0;

            return (result1, result2);
        }
    }
}

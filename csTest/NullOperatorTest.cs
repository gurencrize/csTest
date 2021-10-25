using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace csTest
{
    class NullOperatorTest
    {
        public static void Run()
        {
            // Null条件演算子 https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/operators/member-access-operators#null-conditional-operators--and-


            // byte?型 byteの値かnullが入る
            byte? b = null;
            // これはnullになる
            WriteLine(b);

            b = 100;
            // 普通にbyteの値も入る 100が出力できる
            WriteLine(b);

            // 構造体もnull許容にできたりする
            sampledata data = null;
            // これはnull
            WriteLine($"data?.value={data?.value}");
            // dataがnullだからhello()は評価されない
            data?.hello();
            data = new sampledata { value = null };
            // これもnull
            WriteLine($"data?.value={data?.value}");
            // これは出力される
            data?.hello();

            // null条件演算子の右側は左側に入りうる値でないとダメ
            // WriteLine(b ?? "null"); b(byte型)がnullなら"null"(string)を返す これはダメ(コンパイルエラー)
        }

        private class sampledata
        {
            public byte? value;

            public void hello(){
                WriteLine("Hello World");
            }
        }
    }
}

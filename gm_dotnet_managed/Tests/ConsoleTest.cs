﻿using GmodNET.API;
using System;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class ConsoleTest : ITest
    {
        public Task<bool> Start(ILua lua, GetILuaFromLuaStatePointer lua_extructor, ModuleAssemblyLoadContext assembly_context)
        {
            TaskCompletionSource<bool> taskCompletion = new TaskCompletionSource<bool>();

            try
            {
                #region Write()
                // string
                Console.Write("string");
                Console.WriteLine();
                Console.Write((string)null);
                Console.WriteLine();
                // bool
                Console.Write(true);
                Console.WriteLine();
                Console.Write(false);
                Console.WriteLine();
                // char
                Console.Write('c');
                Console.WriteLine();
                // char[]
                Console.Write(new char[] { 'c', 'h', 'a', 'r', ' ', 'a', 'r', 'r', 'a', 'y' });
                Console.WriteLine();
                Console.Write((char[])null);
                Console.WriteLine();
                // char[] index length
                Console.Write(new char[] { 'c', 'h', 'a', 'r', ' ', 'a', 'r', 'r', 'a', 'y' }, 0, 10);
                Console.WriteLine();
                // ReadOnlySpan<char>
                Console.Out.Write(new ReadOnlySpan<char>(new char[] { 'R', 'e', 'a', 'd', 'O', 'n', 'l', 'y', 'S', 'p', 'a', 'n' }));
                Console.WriteLine();
                Console.Out.Write((ReadOnlySpan<char>)null);
                Console.WriteLine();
                // StringBuilder
                StringBuilder stringBuilder = new("☭");
                stringBuilder.Append(" USSR ");
                stringBuilder.Append("☭");
                Console.Write(stringBuilder);
                Console.WriteLine();
                Console.Write((StringBuilder)null);
                Console.WriteLine();
                // decimal
                Console.Write((decimal)1234);
                Console.WriteLine();
                // double
                Console.Write((double)1234);
                Console.WriteLine();
                // float
                Console.Write((float)1234.56789);
                Console.WriteLine();
                // int
                Console.Write(1234);
                Console.WriteLine();
                // uint
                Console.Write((uint)1234);
                Console.WriteLine();
                // long
                Console.Write(12345678901);
                Console.WriteLine();
                // ulong
                Console.Write((ulong)12345678901);
                Console.WriteLine();
                // object
                Console.Write(new object());
                Console.WriteLine();
                Console.Write((object)null);
                Console.WriteLine();
                #endregion
                #region WriteLine()
                // string
                Console.WriteLine("string");
                Console.WriteLine((string)null);
                // bool
                Console.WriteLine(true);
                Console.WriteLine(false);
                // char
                Console.WriteLine('c');
                // char[]
                Console.WriteLine(new char[] { 'c', 'h', 'a', 'r', ' ', 'a', 'r', 'r', 'a', 'y' });
                Console.WriteLine((char[])null);
                // char[] index length
                Console.WriteLine(new char[] { 'c', 'h', 'a', 'r', ' ', 'a', 'r', 'r', 'a', 'y' }, 0, 10);
                // ReadOnlySpan<char>
                Console.Out.WriteLine(new ReadOnlySpan<char>(new char[] { 'R', 'e', 'a', 'd', 'O', 'n', 'l', 'y', 'S', 'p', 'a', 'n' }));
                Console.Out.WriteLine((ReadOnlySpan<char>)null);
                // StringBuilder
                StringBuilder stringBuilderNewLine = new("☭");
                stringBuilderNewLine.Append(" USSR ");
                stringBuilderNewLine.Append("☭");
                Console.WriteLine(stringBuilderNewLine);
                Console.WriteLine((StringBuilder)null);
                // decimal
                Console.WriteLine((decimal)1234);
                // double
                Console.WriteLine((double)1234);
                // float
                Console.WriteLine((float)1234.56789);
                // int
                Console.WriteLine(1234);
                // uint
                Console.WriteLine((uint)1234);
                // long
                Console.WriteLine(12345678901);
                // ulong
                Console.WriteLine((ulong)12345678901);
                // object
                Console.WriteLine(new object());
                Console.WriteLine((object)null);
                #endregion

                #region Threaded WriteLine()
                Task asyncTask = Task.Run(() =>
                {
                    // string
                    Console.WriteLine("string");
                    Console.WriteLine((string)null);
                    // bool
                    Console.WriteLine(true);
                    Console.WriteLine(false);
                    // char
                    Console.WriteLine('c');
                    // char[]
                    Console.WriteLine(new char[] { 'c', 'h', 'a', 'r', ' ', 'a', 'r', 'r', 'a', 'y' });
                    Console.WriteLine((char[])null);
                    // char[] index length
                    Console.WriteLine(new char[] { 'c', 'h', 'a', 'r', ' ', 'a', 'r', 'r', 'a', 'y' }, 0, 10);
                    // ReadOnlySpan<char>
                    Console.Out.WriteLine(new ReadOnlySpan<char>(new char[] { 'R', 'e', 'a', 'd', 'O', 'n', 'l', 'y', 'S', 'p', 'a', 'n' }));
                    Console.Out.WriteLine((ReadOnlySpan<char>)null);
                    // StringBuilder
                    StringBuilder stringBuilderNewLine = new("☭");
                    stringBuilderNewLine.Append(" USSR ");
                    stringBuilderNewLine.Append("☭");
                    Console.WriteLine(stringBuilderNewLine);
                    Console.WriteLine((StringBuilder)null);
                    // decimal
                    Console.WriteLine((decimal)1234);
                    // double
                    Console.WriteLine((double)1234);
                    // float
                    Console.WriteLine((float)1234.56789);
                    // int
                    Console.WriteLine(1234);
                    // uint
                    Console.WriteLine((uint)1234);
                    // long
                    Console.WriteLine(12345678901);
                    // ulong
                    Console.WriteLine((ulong)12345678901);
                    // object
                    Console.WriteLine(new object());
                    Console.WriteLine((object)null);
                });
                asyncTask.Wait();
                #endregion
                #region Async WriteLine()
                Task asyncAwaitTask = Task.Run(async () =>
                {
                    // string
                    await Console.Out.WriteLineAsync("string");
                    await Console.Out.WriteLineAsync((string)null);
                    // char
                    await Console.Out.WriteLineAsync('c');
                    // char[]
                    await Console.Out.WriteLineAsync(new char[] { 'c', 'h', 'a', 'r', ' ', 'a', 'r', 'r', 'a', 'y' });
                    await Console.Out.WriteLineAsync((char[])null);
                    // char[] index length
                    await Console.Out.WriteLineAsync(new char[] { 'c', 'h', 'a', 'r', ' ', 'a', 'r', 'r', 'a', 'y' }, 0, 10);
                    // StringBuilder
                    StringBuilder stringBuilderNewLine = new("☭");
                    stringBuilderNewLine.Append(" USSR ");
                    stringBuilderNewLine.Append("☭");
                    await Console.Out.WriteLineAsync(stringBuilderNewLine);
                    await Console.Out.WriteLineAsync((StringBuilder)null);
                });
                asyncAwaitTask.Wait();
                #endregion

                taskCompletion.TrySetResult(true);
            }
            catch (Exception e)
            {
                taskCompletion.TrySetException(e);
            }

            return taskCompletion.Task;
        }
    }
}
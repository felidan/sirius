using System;

namespace Sirius.PrintHelper
{
    public static class PrintHelper
    {
        public static void Logo()
        {
            var _tempColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("   @@@@@@@@@@@@@@@@@@@@@@    @@@@@@@  @  @@@@@@@   @  @     @  @@@@@@@    @@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("                    @@@@@    @        @  @      @  @  @     @  @          @@@@@");
            Console.WriteLine("   @             @@@@@@@@    @        @  @      @  @  @     @  @          @@@@@@@@             @");
            Console.WriteLine("   @@         @@@@@@@@@@@    @@@@@@@  @  @@@@@@@   @  @     @  @@@@@@@    @@@@@@@@@@@         @@");
            Console.WriteLine("   @@@           @@@@@@@@          @  @  @ @       @  @     @        @    @@@@@@@@           @@@");
            Console.WriteLine("   @@@@@            @@@@@          @  @  @   @     @  @     @        @    @@@@@            @@@@@");
            Console.WriteLine("   @@@@@@@@@@          @@    @@@@@@@  @  @     @   @   @@@@@   @@@@@@@    @@          @@@@@@@@@@");
            Console.WriteLine("   @@@@@@@@@@@@@@@@@                                                           @@@@@@@@@@@@@@@@@");
            Console.WriteLine("   @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ Felipe Dantas @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("");
            Console.ForegroundColor = _tempColor;
        }
       
        public static void Menu()
        {
            
            Console.WriteLine("Converter");
            X("  - ["); Console.Write("convert"); X("|"); Console.Write("-c"); X("]"); X(" ["); Console.Write("64"); X("|"); Console.Write("-64"); X("|"); Console.Write("string"); X("|"); Console.Write("-s"); X("]");
            Console.WriteLine("");
            X("  - ["); Console.Write("format"); X("|"); Console.Write("-ft"); X("]"); X(" ["); Console.Write("json"); X("|"); Console.Write("-j"); X("|"); Console.Write("xml"); X("|"); Console.Write("-x"); X("]");
            Console.WriteLine("");
            X("  - ["); Console.Write("find"); X("|"); Console.Write("-f"); X("]"); X(" ["); Console.Write("content"); X("|"); Console.Write("-c"); X("|"); Console.Write("name"); X("|"); Console.Write("-n"); X("]");
            Console.WriteLine("");
            X("  - ["); Console.Write("program"); X("|"); Console.Write("-p"); X("]"); X(" ["); Console.Write("list"); X("|"); Console.Write("-l"); X("|"); Console.Write("start"); X("|"); Console.Write("-s"); X("|"); Console.Write("register"); X("|"); Console.Write("-r"); X("|"); Console.Write("delete"); X("|"); Console.Write("-d"); X("]");
            Console.WriteLine("");
            X("  - ["); Console.Write("new"); X("|"); Console.Write("-n"); X("]"); X(" ["); Console.Write("hash"); X("|"); Console.Write("-h"); X("]");
            Console.WriteLine("");
            X("  - ["); Console.Write("lock"); X("|"); Console.Write("-l"); X("]"); X(" ["); Console.Write("new"); X("|"); Console.Write("-n"); X("]");
            Console.WriteLine("");
            X("  - ["); Console.Write("config"); X("]");
            Console.WriteLine("");
        }

        private static string X(string str)
        {
            var _tempColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(str);
            Console.ForegroundColor = _tempColor;
            return "";
        }
    }
}
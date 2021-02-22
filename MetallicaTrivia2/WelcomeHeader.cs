using System;
using System.Collections.Generic;
using System.Text;

namespace MetallicaTrivia2
{
    class WelcomeHeader
    {
        public void Header()
        {
            ColorChange line = new ColorChange();
            line.DarkBlueCyanHead();
            line.DarkBlueDarkCyanHead();
            line.DarkBlueCyanHead();
            line.BlackWhiteMetallica();
            line.DarkBlueCyanHead();
            line.DarkBlueDarkCyanHead();
            line.DarkBlueCyanHead();
            line.BlackDarkGray();
        }

        public void Header2()
        {
            ColorChange line = new ColorChange();
            line.BBlack();
            line.FCyan();
            Console.WriteLine();
            Console.WriteLine(@"             /\                                                /\ ");
            Console.WriteLine(@"            / /\                                              /| \ ");
            Console.WriteLine(@"           / /  \                                            / |  \ ");
            Console.WriteLine(@"          / /  ,.----..-------.  ,-..--.   .--.   .--.,-------.| \`\ ");
            Console.WriteLine(@"         / /  /|  ___||__   __/\/ ,||  |  /|  |  /|  ||   ____||  \ ");
            Console.WriteLine(@"        /  \ /|| |___ \\ | |  \/ /|||  | / |  | / |  ||  |   / |   \ ");
            Console.WriteLine(@"       /    ` ||  ___|\\ | |  /  - ||  |/  |  |/  |  ||  |  /  |    \   ");
            Console.WriteLine(@"      /,~/    || |___ \\\| | /  /| ||  '--.|  '--.|  ||  '----.|  |\ \ ");
            Console.WriteLine(@"      ` /     ||_____|\\\|_|/__/ |_||_____||_____||__||._____.||  '-' \  ");
            Console.WriteLine(@"       /     /\\     \ \\\  \  \ | ||     ||     ||  ||       //\  ___ \   ");
            Console.WriteLine(@"      / /\/|/  \\_____\/  \__\__\\_||_____||_____||__|.______//  \|   \ \  ");
            Console.WriteLine(@"     / /    \  /                                              \  /\    \ \ ");
            Console.WriteLine(@"    / / ,/\/ \/                                                \/  \/\. \ \  ");
            Console.WriteLine(@"   / /./   \                                                       /   \.\ \ ");
            Console.WriteLine(@"  / //   ./                                                         \.   \\ \ ");
            Console.WriteLine(@"  \    ./                                                             \.    /    ");
            Console.WriteLine(@"   \ ./                                                                 \. /    ");
            Console.WriteLine(@"    `                                                                     ' ");
            line.BlackDarkGray();
        }

        public void Header3()
        {
            ColorChange line = new ColorChange();
            line.DarkBlueCyanHead();
            line.DarkBlueDarkCyanHead();
            line.DarkBlueCyanHead();
            line.BlackWhiteMetallicaStar();
            line.DarkBlueCyanHead();
            line.DarkBlueDarkCyanHead();
            line.DarkBlueCyanHead();
            line.BlackDarkGray();

        }
    }

}

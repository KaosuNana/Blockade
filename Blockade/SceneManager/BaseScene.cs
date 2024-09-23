using Blockade;
using System;

namespace SceneManager
{
    abstract class BaseScene : ISceneUpdate
    {
        protected int nowSelIndex;
        protected string strTitle;
        protected string strOne;

        public abstract void EnterJDoSomthing();

        public void Update()
        {
            Console.ForegroundColor = ConsoleColor.White;
            //显示标题
            Console.SetCursorPosition(Game.w / 2 - strTitle.Length, 5);
            Console.Write(strTitle);
            //显示下方的选项
            Console.SetCursorPosition(Game.w / 2 - strOne.Length, 8);
            Console.ForegroundColor = nowSelIndex == 0 ? ConsoleColor.Red : ConsoleColor.White;
            Console.Write(strOne);
            //Console.SetCursorPosition(Game.w / 2 - 4, 10);
            Console.SetCursorPosition(Game.w / 2 - strOne.Length, 10);
            Console.ForegroundColor = nowSelIndex == 1 ? ConsoleColor.Red : ConsoleColor.White;
            Console.Write("Exit Game");
            //检测输入
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.W:
                    --nowSelIndex;
                    if (nowSelIndex < 0)
                    {
                        nowSelIndex = 0;
                    }
                    break;
                case ConsoleKey.S:
                    ++nowSelIndex;
                    if (nowSelIndex > 1)
                    {
                        nowSelIndex = 1;
                    }
                    break;
                case ConsoleKey.J:
                    EnterJDoSomthing();
                    break;
            }
        }
    }
}

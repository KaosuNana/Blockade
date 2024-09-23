﻿using SceneManager;

namespace Blockade
{
    enum E_SceneType
    {
        /// <summary>
        /// 开始场景
        /// </summary>
        Begin,
        /// <summary>
        /// 游戏场景
        /// </summary>
        Game,
        /// <summary>
        /// 结束场景
        /// </summary>
        End,
    }

    internal class Game
    {
        public const int w = 80;
        public const int h = 20;

        public static ISceneUpdate nowScene;

        public Game() 
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(w, h);
            Console.SetBufferSize(w, h);

            ChangeScene(E_SceneType.Begin);
        }

        public void Start()
        {
            //游戏主循环 主要负责 游戏场景逻辑的更新
            while (true)
            {
                //判断当前游戏场景不为空 就更新
                if (nowScene != null)
                {
                    nowScene.Update();
                }
            }
        }

        public static void ChangeScene(E_SceneType type)
        {
            //切场景之前 应该把上一个场景的绘制内容擦掉
            Console.Clear();

            switch (type)
            {
                case E_SceneType.Begin:
                    nowScene = new BeginScene();
                    break;
                case E_SceneType.Game:
                    nowScene = new GameScene();
                    break;
                case E_SceneType.End:
                    nowScene = new EndScene();
                    break;
            }
        }
    }
}

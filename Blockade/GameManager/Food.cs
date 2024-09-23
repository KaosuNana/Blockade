using Blockade;

namespace GameManager
{
    internal class Food : GameObject
    {
        public Food(Snake snake)
        {
            RandomPos(snake);
        }

        public override void Draw()
        {
            Console.SetCursorPosition(pos.x, pos.y);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("¤");
        }

        public void RandomPos(Snake snake)
        {
            //随机位置
            Random r = new Random();
            int x = r.Next(2, Game.w / 2 - 1) * 2;
            int y = r.Next(1, Game.h - 4);
            pos = new Position(x, y);
            //得到蛇
            //如果重合 就会进if语句
            if (snake.CheckSamePos(pos))
            {
                RandomPos(snake);
            }
        }
    }
}

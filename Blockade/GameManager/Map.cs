using Blockade;

namespace GameManager
{
    internal class Map : IDraw
    {
        public Wall[] walls;

        public Map()
        {
            //宽是一个块两个字节，所以两面墙刚好是宽长
            //因为数组length-1所以除掉头尾还要-1
            walls = new Wall[Game.w + (Game.h - 3) * 2];
            int index = 0;
            for (int i = 0; i < Game.w; i += 2)
            {
                walls[index] = new Wall(i, 0);
                ++index;
                walls[index] = new Wall(i, Game.h - 2);
                ++index;
            }
            for (int i = 1; i < Game.h - 2; i++)
            {
                walls[index] = new Wall(0, i);
                ++index;
                walls[index] = new Wall(Game.w - 2, i);
                ++index;
            }
        }

        public void Draw()
        {
            for (int i = 0; i < walls.Length; i++)
            {
                walls[i].Draw();
            }
        }
    }
}

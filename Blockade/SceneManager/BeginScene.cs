using Blockade;

namespace SceneManager
{
    internal class BeginScene : BaseScene
    {
        public BeginScene()
        {
            nowSelIndex = 0;
            strTitle = "Blockade";
            strOne = "Begin Game";
        }

        public override void EnterJDoSomthing()
        {
            //按J键做什么的逻辑
            if (nowSelIndex == 0)
            {
                Game.ChangeScene(E_SceneType.Game);
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}

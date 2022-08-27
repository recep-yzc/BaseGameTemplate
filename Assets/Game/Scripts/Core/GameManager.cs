using Game.Events;

namespace Game
{
    [ScriptOrder(-9995)]
    public class GameManager : Listener
    {
        IEventSystem eventSystem = new EventSystem();

        public override void Listen(bool status)
        {
            if (status)
            {
                GameStatus_Start();
            }
            else
            {
                GameStatus_Stop();
            }
        }

        public void GameStatus_Start()
        {
            eventSystem.Publish(GameEvents.GameStatus_Start);
        }

        public void GameStatus_Stop()
        {
            eventSystem.Publish(GameEvents.GameStatus_Stop);
        }
    }
}
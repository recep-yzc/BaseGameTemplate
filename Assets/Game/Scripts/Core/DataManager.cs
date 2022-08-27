using UnityEngine;

namespace Game
{
    [ScriptOrder(-9998)]
    public class DataManager : MonoBehaviour
    {
        public GameData GameData { get; private set; }

        private void OnEnable()
        {
            InitData();
        }

        private void InitData()
        {
            GameData = GameData.Get();
            if (GameData == null)
            {
                GameData = new GameData();
                bool isSuccess = GameData.Register();
                if (!isSuccess) Debug.LogError("Currency Data Entity register error!");
            }

            GameData.Load();
        }
    }
}
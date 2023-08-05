using _Game.Scripts.UserInterface;
using UnityEngine;

namespace _Game.Scripts.Sequence
{
    public class Boot : MonoBehaviour
    {
        [SerializeField] private AppStateTypes startState;
        void Start()
        {
            BootGame();
        }

        private void BootGame()
        {
            PrepareUIManager();
            PrepareSequenceManager();
        }

        private void PrepareSequenceManager()
        {
            SequenceManager.Instance.InitializeAllAppStates();
            SequenceManager.Instance.ChangeState(startState);
        }

        private static void PrepareUIManager()
        {
            UIManager.Instance.InitializeUIManager();
        }
    }
}

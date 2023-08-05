using _Game.Scripts.Base.AppState;
using _Game.Scripts.Enums;
using _Game.Scripts.UserInterface;
using UnityEngine;

namespace _Game.Scripts.Sequence.AppStates
{
    public class LoadingState : AbstractAppState
    {
        [SerializeField] private float loadingTime;
        public override void Enter()
        {
            UIManager.Instance.EnableCanvas(CanvasTypes.Loading);
            Invoke("ExitLoading",loadingTime);
        }

        public override void Exit()
        {
            UIManager.Instance.DisableCanvas(CanvasTypes.Loading);
        }

        private void ExitLoading()
        {
            SequenceManager.Instance.ChangeState(AppStateTypes.InGame);
        }
    }
}

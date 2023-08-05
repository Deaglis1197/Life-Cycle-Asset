using _Game.Scripts.Base.AppState;
using _Game.Scripts.Enums;
using _Game.Scripts.Gameplay;
using _Game.Scripts.UserInterface;
using UnityEngine;

namespace _Game.Scripts.Sequence.AppStates
{
    public class GameResetState : AbstractAppState
    {
        [SerializeField] private PlayerController playerController;
        [SerializeField] private PlateSwapper PlateSwapper;

        public override void Enter()
        {
            UIManager.Instance.EnableCanvas(CanvasTypes.Loading);
            playerController.ResetPlayer();
            PlateSwapper.ResetPlates();
            SequenceManager.Instance.ChangeState(AppStateTypes.Loading);
        }

        public override void Exit()
        {
            UIManager.Instance.DisableCanvas(CanvasTypes.Loading);
        }
    }
}

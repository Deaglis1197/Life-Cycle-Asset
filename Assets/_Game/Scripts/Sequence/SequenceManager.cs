using System.Collections.Generic;
using _Game.Scripts.Base.AppState;
using _Game.Scripts.Base.Singleton;
using _Game.Scripts.Base.StateMachine;
using _Game.Scripts.UserInterface;
using UnityEngine;

namespace _Game.Scripts.Sequence
{
    public class SequenceManager : AbstractSingleton<SequenceManager>
    {
        [SerializeField] private List<AbstractAppState> AppStates;
        

        private readonly StateMachine appStateMachine = new StateMachine();

        public void InitializeAllAppStates()
        {
            foreach (var appState in AppStates)
            {
                appState.Initialize();
            }
        }

        public void ChangeState(AppStateTypes appStateTypes)
        {
            appStateMachine.ChangeState(GetAppState(appStateTypes));
        }

        public AbstractAppState GetAppState(AppStateTypes appStateType)
        {
            foreach (var appState in AppStates)
            {
                if (appState.appStateType == appStateType) return appState;
            }
            Debug.Log("App State Type not found!");
            return null;
        }
        
    }
}
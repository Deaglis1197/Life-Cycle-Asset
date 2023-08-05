using _Game.Scripts.Base.UserInterface;
using UnityEngine;

namespace _Game.Scripts.UserInterface.Canvases
{
    public class LoadingUI : AbstractBaseCanvas
    {
      
        public override void OnStart()
        {
            Debug.Log("LoadingUI Enabled");
        }
        
        public override void OnQuit()
        {
            Debug.Log("LoadingUI Disabled");
        }
        
    }
}

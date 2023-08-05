using _Game.Scripts.Base.UserInterface;
using TMPro;
using UnityEngine;

namespace _Game.Scripts.UserInterface.Canvases
{
    public class InGameUI : AbstractBaseCanvas
    {
        [SerializeField] private TMP_Text distanceText;

        public OnUIButtonClickEvent Pause;

        public void SetDistanceText(string distance) => distanceText.text = distance;
        public override void OnStart()
        {
            Debug.Log("InGameUI Enabled");
        }

        public override void OnQuit()
        {
            Debug.Log("InGameUI Disabled");
        }

        public void OnPauseClick()
        {
            Pause.Invoke();
        }
    }
}

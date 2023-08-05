using UnityEngine;

namespace _Game.Scripts.Gameplay
{
    public class Plate : MonoBehaviour
    {
        private PlateSwapper plateSwapper;

        private void OnTriggerEnter(Collider other)
        {
            plateSwapper.SwapPlate();
        }

        public void RegisterPlateSwapper(PlateSwapper plateSwapper) => this.plateSwapper = plateSwapper;
        
        
    }
}

using System.Collections.Generic;
using UnityEngine;

namespace _Game.Scripts.Gameplay
{
    public class PlateSwapper : MonoBehaviour
    {
        [SerializeField] private float zPosOffset;
        [SerializeField] private int plateSize;
        [SerializeField] private Plate platePrefab;

        private List<Plate> plateList=new List<Plate>();
        
        private Vector3 nextPos;
        private int currentPlate;
        void Start()
        {
            CreatePlates();
        }

        public void ResetPlates()
        {
            foreach (var plate in plateList)
            {
                Destroy(plate.gameObject);
            }
            plateList.Clear();
            CreatePlates();
        }

        private void CreatePlates()
        {
            nextPos = Vector3.zero;
            Plate createdPlate;
            for (int i = 0; i < plateSize; i++)
            {
                createdPlate = Instantiate(platePrefab, nextPos, Quaternion.identity);
                createdPlate.RegisterPlateSwapper(this);
                plateList.Add(createdPlate);
                nextPos.z += zPosOffset;
            }
            currentPlate = 0;
        }

        public void SwapPlate()
        {
            plateList[currentPlate].transform.position = nextPos;
            currentPlate++;
            if (currentPlate >= plateSize) currentPlate = 0;
            nextPos.z += zPosOffset;
        }
    }
}

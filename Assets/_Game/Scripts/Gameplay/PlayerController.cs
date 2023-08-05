using System;
using UnityEngine;

namespace _Game.Scripts.Gameplay
{
    public class PlayerController : MonoBehaviour
    {
        public Action<string> OnPositionChange;

        [SerializeField] private float forwardSpeed;
        [SerializeField] private float horizantalSpeed;
        [SerializeField] private float xOffset;

        public bool canControl;
        private Vector3 newPos;
        private Vector3 startPos;

        private void Start()
        {
            startPos = transform.position;
        }

        private void Update()
        {
            if (!canControl) return;
            Movement();
            SetDistance();
        }

        public void ResetPlayer()
        {
            transform.position = startPos;
        }
        private void SetDistance()
        {
            int pos = (int)transform.position.z;
            OnPositionChange.Invoke(pos.ToString());
        }
        
        private void Movement()
        {
            newPos = transform.position;
            newPos += transform.forward * Time.deltaTime * forwardSpeed;
            newPos += transform.right * Time.deltaTime * horizantalSpeed * Input.GetAxis("Horizontal");
            newPos.x = Math.Clamp(newPos.x, -xOffset, xOffset);
            transform.position = newPos;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enerlion
{
    [RequireComponent(typeof(UnitMotor))]
    public class PlayerController : MonoBehaviour
    {
        private Camera _camera;
        private UnitMotor _motor;

        [SerializeField] private LayerMask _movementMask;

        void Start()
        {
            _camera = Camera.main;
            _motor = GetComponent<UnitMotor>();
        }
        
        void Update()
        {
            if (Input.GetMouseButtonDown(1))
            {
                Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit, 100f, _movementMask))
                {
                    _motor.MoveToPoint(hit.point);
                }
            }

            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit, 100f))
                {

                }
            }
        }
    }
}

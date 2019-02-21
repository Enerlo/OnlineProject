using UnityEngine;
using UnityEngine.AI;

namespace Enerlion
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class UnitMotor : MonoBehaviour
    {
        NavMeshAgent _agent;

        void Start()
        {
            _agent = GetComponent<NavMeshAgent>();
        }

        public void MoveToPoint(Vector3 point)
        {
            _agent.SetDestination(point);
        }
    }
}

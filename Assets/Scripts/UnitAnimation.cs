using UnityEngine.AI;
using UnityEngine;

namespace Enerlion
{
    public class UnitAnimation : MonoBehaviour
    {
        [SerializeField] Animator _animator;
        [SerializeField] NavMeshAgent _agent;

        void FixedUpdate()
        {
            if (!_agent.hasPath)
            {
                _animator.SetBool("Moving", false);
            }
            else
            {
                _animator.SetBool("Moving", true);
            }
        }

        void Hit()
        {
        }

        void FootR()
        {
        }

        void FootL()
        {
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Lesson.FPS
{
    public class EnemyBehaviour : MonoBehaviour
    {
        [SerializeField] GameObject _player;
        [SerializeField] NavMeshAgent _agent; 

        // Start is called before the first frame update
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            _agent.SetDestination(_player.transform.position);
            //_agent.Move
        }
    }
}

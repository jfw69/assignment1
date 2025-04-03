using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{

    public Transform player; //players position
    private NavMeshAgent navMeshAgent; //component on the game object

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>(); // needed to make the enemy move
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null) // keep chasing
        {
            navMeshAgent.SetDestination(player.position); // who enemey is chasing
        }
    }
}

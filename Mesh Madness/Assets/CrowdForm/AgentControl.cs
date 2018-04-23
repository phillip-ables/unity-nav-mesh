using UnityEngine;
using UnityEngine.AI;

public class AgentControl : MonoBehaviour {

    public Transform home;
    NavMeshAgent agent;

    private void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
        agent.SetDestination(home.position);
    }
}

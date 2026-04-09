using UnityEngine;
using UnityEngine.AI;

public class SpriteFlipper : MonoBehaviour
{
    private NavMeshAgent agent;
    private SpriteRenderer spriteRenderer;

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    void Update()
    {
        // Check if the agent is moving
        if (agent.velocity.sqrMagnitude > 0.01f)
        {
            // Flip based on X direction
            if (agent.velocity.x > 0)
            {
                spriteRenderer.flipX = false;
            }
            else if (agent.velocity.x < 0)
            {
                spriteRenderer.flipX = true;
            }
        }
    }
}
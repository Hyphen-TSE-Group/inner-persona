using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


/**This script file is for an enemy AI in Unity game engine. 
It uses NavMeshAgent component to move the enemy game object. 
And has a public variable called “MobDistanceRun” which is used to set the distance
at which the enemy will start chasing the player. **/

public class EnemyAI : MonoBehaviour
{


    private NavMeshAgent Mob;
    
    public GameObject Player;
    public float MobDistanceRun = 10;



    // Start is called before the first frame update
    void Start()
    {
        Mob = GetComponent<NavMeshAgent>();
    
    }

/**This function is called every frame and checks the distance between the enemy and the player.
If the distance is less than “MobDistanceRun”, it sets the destination of NavMeshAgent component
to a position behind the enemy so that it can chase the player. **/

    void Update()
    {
        float distance = Vector3.Distance(transform.position, Player.transform.position);

        if(distance< MobDistanceRun){
            Vector3 dirToPlayer = transform.position - Player.transform.position;
            Vector3 newPos = transform.position -dirToPlayer;
            Mob.SetDestination(newPos);

        }


    }
}

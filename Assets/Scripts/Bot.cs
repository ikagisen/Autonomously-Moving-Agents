using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Bot : MonoBehaviour {

    public GameObject target;

    NavMeshAgent agent;

    void Start() {

        agent = GetComponent<NavMeshAgent>();
    }

    void Seek(Vector3 location) {

        agent.SetDestination(location);
    }

    void Flee(Vector3 location) {

        Vector3 fleeVector = location - transform.position;
        agent.SetDestination(transform.position - fleeVector);
    }

    void Update() {

        // Seek(target.transform.position);
        Flee(target.transform.position);
    }
}

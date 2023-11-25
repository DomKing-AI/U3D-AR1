using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class TestMove : MonoBehaviour {

	// Use this for initialization
	public Transform[] target;
	public NavMeshAgent agent;
	int index;
	
	protected virtual void Start()
	{
		index = 0;
	}
	
	protected virtual void Update()
	{
		if (agent && agent.enabled && index < target.Length && target[index])
		{
			agent.SetDestination(target[index].position);
		}
			
	}
	protected virtual void OnTriggerEnter(Collider other)
	{
		
		if (other.tag == "Node")
		{
			if (other.gameObject == target[index].gameObject && index > target.Length - 1)
			{
				index++;
				Debug.Log(index + "次碰撞");
			}
			if (index == 2)
			{
				index = 0;
			}
		}
	}
}

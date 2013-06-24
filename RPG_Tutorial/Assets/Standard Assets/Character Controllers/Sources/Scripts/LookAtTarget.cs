using UnityEngine;
using System.Collections;

public class LookAtTarget : MonoBehaviour {
	
	public Transform myCamera;
	public Transform player;
	public Transform target;
	public int rotationSpeed;
	
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		Targetting tg = (Targetting)player.GetComponent("Targetting");
		
		if(tg.selectedTarget != null)
		{
			target = tg.selectedTarget;
		}
		
		if(target != null)
		{
			myCamera.rotation = Quaternion.Slerp(myCamera.rotation, Quaternion.LookRotation(target.position - myCamera.position), rotationSpeed * Time.deltaTime);
			
			player.rotation = Quaternion.Slerp(player.rotation, Quaternion.LookRotation(target.position - player.position), rotationSpeed * Time.deltaTime);
		}
		
	}
}

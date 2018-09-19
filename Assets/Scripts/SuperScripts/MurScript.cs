using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MurScript : MonoBehaviour, SuperScript {

	public BuildingScript publicBuilding { set { building = value; } get { return building; } }
	public BuildingScript building;
	[Range(0.000001f,9999999)]
	public float timerCoef;

	private float timer;

	void Update(){
		if(IsUnderAttack())
		{
			
		}
	}

	public bool modifier()
	{
		// timer -= Time.deltaTime;
		// if (building.AddValue > 0 && timer < 0)
		// {
		// 	building.AddValue -= 1;
		// 	timer = 1;
		// }
		// return true;
		return false;
	}
	
	public bool UpgradeModifier()
	{
		return true;
	}

	private bool IsUnderAttack()
	{
		if (Random.Range(0,100 * (timer / timerCoef)) > building.AddValue)
			return true;
		return false;
	}
}
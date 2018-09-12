using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PierreScript : MonoBehaviour, SuperScript {

	public BuildingScript publicBuilding { set { building = value; } get { return building; } }
	public BuildingScript building;

	public bool modifier()
	{
		// timer -= Time.deltaTime;
		// if (building.AddValue > 0 && timer < 0)
		// {
		// 	building.AddValue -= 1;
		// 	timer = 1;
		// }
		// return true;
		return true;
	}
	
	public bool UpgradeModifier()
	{
		return true;
	}
}

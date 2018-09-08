using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillageScript : MonoBehaviour,SuperScript {

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
		return false;
	}
	
	public bool UpgradeModifier()
	{
		building.player.Boost = building.NextLevel.AddValue;
		return true;
	}
}

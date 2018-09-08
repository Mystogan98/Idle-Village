using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface SuperScript {
	BuildingScript publicBuilding { set; get; }

	bool modifier();
	bool UpgradeModifier();
}

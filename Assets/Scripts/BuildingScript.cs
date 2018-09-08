using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using System.Reflection;

public class BuildingScript : MonoBehaviour {

	[Header("General Info")]
	public string Name;
	public int level;
	[Space(10)]

	[Header("Ressource and Scripts")]
	public Ressources generatedRessource = Ressources.Wood;
	public double AddValue = 10;
	public PlayerRessources player;
	public BuildingScript NextLevel;
	public MonoBehaviour publicSuperScript;
	public GameObject upgradable, mesh;
	[Space(10)]

	[Header("Upgrade ressources")]
	public int UpgradeWood;
	public int UpgradeRock, UpgradeFood, UpgradeClay, UpgradeCopper, UpgradeIron, UpgradeHappiness, UpgradeCoal, UpgradeOil, UpgradeUranium;

	[HideInInspector]
	public SuperScript superScript;

	// Use this for initialization
	void Start () {
		if (superScript == null && publicSuperScript != null)
			superScript = (SuperScript) publicSuperScript;
	}
	
	// Update is called once per frame
	void Update () {
		if (upgradable != null)
		{
			if(RessourceCheck())
			{
				upgradable.SetActive(true);
				if (mesh != null && !mesh.activeInHierarchy)
					mesh.SetActive(true);
			}
			else
				upgradable.SetActive(false);
		}

		if(!superScript.modifier())
			return;
		RessourceUp();
	}

	// Upgrade the building when you click it
	void OnMouseUpAsButton()
	{
		if (NextLevel != null)
		{ 
			if (!RessourceCheck())
				return;
			if (!superScript.UpgradeModifier())
				return;
			// le UpgradeModifier doit prendre en compte la modification de villagescript
			RessourceDown();
			NextLevel.gameObject.SetActive(true);
			superScript.publicBuilding = NextLevel;
			upgradable.SetActive(false);
			this.gameObject.SetActive(false);
		}
	}

	void RessourceUp()
	{
		PropertyInfo prop =  player.GetType().GetProperty(generatedRessource.ToString());
		double actualValue = (double) prop.GetValue(player,null);
		double value = actualValue + ((AddValue * player.Boost) * Time.deltaTime);

		prop.SetValue(player, value ,null);
	}

	void RessourceDown()
	{
		player.Wood -= UpgradeWood;
		player.Rock -= UpgradeRock;
		player.Food -= UpgradeFood;
		player.Clay -= UpgradeClay;
		player.Copper -= UpgradeCopper;
		player.Iron -= UpgradeIron;
		player.Coal -= UpgradeCoal;
		player.Oil -= UpgradeOil;
		player.Uranium -= UpgradeUranium;
	}

	bool RessourceCheck()
	{
		if (player.Wood >= UpgradeWood && player.Rock >= UpgradeRock && player.Food >= UpgradeFood && player.Clay >= UpgradeClay && player.Copper >= UpgradeCopper && player.Iron >= UpgradeIron && player.Happiness >= UpgradeHappiness && player.Coal >= UpgradeCoal && player.Oil >= UpgradeOil && player.Uranium >= UpgradeUranium)
			return true;
		return false;
	}
}
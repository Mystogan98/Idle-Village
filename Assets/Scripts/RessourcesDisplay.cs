using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RessourcesDisplay : MonoBehaviour {
	public PlayerRessources player;

	public TextMeshProUGUI WoodText, RockText, FoodText, ClayText, CopperText, IronText, HappinessText, CoalText, OilText, UraniumText;
	//public Image WoodImage, RockImage, FoodImage, ClayImage, CopperImage, IronImage, HappinessImage, CoalImage, OilImage, UraniumImage;


	// Use this for initialization
	void Start () {
		Debug.Log("Nettoyer le LateUpdate !");
	}
	
	// Update is called once per frame
	void LateUpdate () {
		// Wood
		if (!WoodText.IsActive() && player.Wood > 0)
			WoodText.gameObject.SetActive(true);
		WoodText.text = ((int) player.Wood).ToString();
		// Rock
		if (!RockText.IsActive() && player.Rock > 0)
			RockText.gameObject.SetActive(true);
		RockText.text = ((int) player.Rock).ToString();
		// Food
		if (!FoodText.IsActive() && player.Food > 0)
			FoodText.gameObject.SetActive(true);
		FoodText.text = ((int) player.Food).ToString();
		// Clay
		if (!ClayText.IsActive() && player.Clay > 0)
			ClayText.gameObject.SetActive(true);
		ClayText.text = ((int) player.Clay).ToString();
		// Copper
		if (!CopperText.IsActive() && player.Copper > 0)
			CopperText.gameObject.SetActive(true);
		CopperText.text = ((int) player.Copper).ToString();
		// Iron
		if (!IronText.IsActive() && player.Iron > 0)
			IronText.gameObject.SetActive(true);
		IronText.text = ((int) player.Iron).ToString();
		// Happiness
		if (!HappinessText.IsActive() && player.Happiness > 0)
			HappinessText.gameObject.SetActive(true);
		HappinessText.text = ((int) player.Happiness).ToString();
		// Coal
		if (!CoalText.IsActive() && player.Coal > 0)
			CoalText.gameObject.SetActive(true);
		CoalText.text = ((int) player.Coal).ToString();
		// Oil
		if (!OilText.IsActive() && player.Oil > 0)
			OilText.gameObject.SetActive(true);
		OilText.text = ((int) player.Oil).ToString();
		// Uranium
		if (!UraniumText.IsActive() && player.Uranium > 0)
			UraniumText.gameObject.SetActive(true);
		UraniumText.text = ((int) player.Uranium).ToString();
	}
}

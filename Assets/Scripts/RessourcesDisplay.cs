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
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
		if (!WoodText.IsActive() && player.Wood > 0)
			WoodText.gameObject.SetActive(true);
		WoodText.text = ((int) player.Wood).ToString();
	}
}

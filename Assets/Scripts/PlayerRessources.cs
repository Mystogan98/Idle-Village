using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRessources : MonoBehaviour {

	public int StartingWood = 100, StartingRock = 100, StartingFood = 100, StartingClay = 100, StartingCopper = 0, StartingIron = 0, StartingHappiness = 0, StartingCoal = 0, StartingOil = 0, StartingUranium = 0;

	private double _Wood = 0, _Rock = 0, _Food = 0, _Clay = 0, _Copper = 0, _Iron = 0, _Happiness = 0, _Coal = 0, _Oil = 0, _Uranium = 0, _boost = 1;

	public double Wood {	  get { return _Wood; } 	set { if (value > 99999999) { _Wood = 99999999; } 	  else if (value < 0) { return; } else { _Wood = value; } } } 		// This prevent the value to go above 99.999.999 or below 0
	public double Rock { 	  get { return _Rock; } 	set { if (value > 99999999) { _Rock = 99999999; } 	  else if (value < 0) { return; } else { _Rock = value; } } }
	public double Food { 	  get { return _Food; } 	set { if (value > 99999999) { _Food = 99999999; } 	  else if (value < 0) { return; } else { _Food = value; } } }
	public double Clay {	  get { return _Clay; } 	set { if (value > 99999999) { _Clay = 99999999; }     else if (value < 0) { return; } else { _Clay = value; } } }
	public double Copper { 	  get { return _Copper; }   set { if (value > 99999999) { _Copper=99999999; }     else if (value < 0) { return; } else { _Copper = value; }}}
	public double Iron { 	  get { return _Iron; } 	set { if (value > 99999999) { _Iron = 99999999; } 	  else if (value < 0) { return; } else { _Iron = value; } } }
	public double Happiness { get { return _Happiness;} set { if (value > 99999999) { _Happiness = 99999999;} else if (value < 0) { return; } else { _Happiness=value;}}}
	public double Coal { 	  get { return _Coal; } 	set { if (value > 99999999) { _Coal = 99999999; } 	  else if (value < 0) { return; } else { _Coal = value; } } }
	public double Oil { 	  get { return _Oil; }	    set { if (value > 99999999) { _Oil = 99999999; } 	  else if (value < 0) { return; } else { _Oil = value;  } } }
	public double Uranium {   get { return _Uranium; }  set { if (value > 99999999) { _Uranium = 99999999; }  else if (value < 0) { return; } else { _Uranium = value;}}}
	public double Boost {     get { return _boost; }    set { _boost = value; }}
	

	// Use this for initialization
	void Start () {
		_Wood = StartingWood;
		_Rock = StartingRock;
		_Food = StartingFood;
		_Clay = StartingClay;
		_Copper = StartingCopper;
		_Iron = StartingIron;
		_Happiness = StartingHappiness;
		_Coal = StartingCoal;
		_Oil = StartingOil;
		_Uranium = StartingUranium;
	}
	
}

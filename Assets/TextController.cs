﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {bedroom, closet, bedroom_door, mirror, clothing, bedroom_door2, hallway, hall_door, bathroom, mirror_2, cell_phone, tooth_brush, mirror_3,
						hallway_1, kitchen_1, hallway_2, kitchen_2, fridge, computer, livingroom, purse, cat, keys, cat_2, front_door1, cat_food, front_door, leave};
	private States myState;
	int fixedhair=0;
	

	void Start () {
	myState = States.bedroom;
	fixedhair=0;
	}
	

	void Update () {
	print (myState);
	
			
			switch (myState)
	{
		case States.bedroom:
			bedroom();
			break;
		case States.closet:
			closet();
			break;
		case States.bedroom_door:
			bedroom_door();
			break;
		case States.mirror:
			mirror();
			break;
		case States.clothing:
			clothing();
			break;
		case States.bedroom_door2:
			bedroom_door2();
			break;
		case States.hallway:
			hallway();
			break;
		case States.hall_door:
			hall_door();
			break;
		case States.bathroom:
			bathroom();
			break;
		case States.mirror_2:
			mirror_2();
			break;
		case States.cell_phone:
			cell_phone();
			break;
		case States.tooth_brush:
			tooth_brush();
			break;
		case States.mirror_3:
			mirror_3();
			break;
		case States.hallway_1:
			hallway_1();
			break;
		case States.kitchen_1:
			kitchen_1();
			break;
		case States.hallway_2:
			hallway_2();
			break;
		case States.kitchen_2:
			kitchen_2();
			break;
		case States.fridge:
			fridge();
			break;
		case States.computer:
			computer();
			break;
		case States.livingroom:
			livingroom();
			break;
		case States.purse:
			purse();
			break;
		case States.cat:
			cat();
			break;
		case States.keys:
			keys();
			break;
		case States.cat_2:
			cat_2();
			break;
		case States.front_door1:
			front_door1();
			break;
		case States.cat_food:
			cat_food();
			break;
		case States.front_door:
			front_door();
			break;
		case States.leave:
			leave();
			break;
		}
		
	}
	
	void bedroom() {
		text.text = "You are at home in your bedroom and need to make your way to the door to leave for work.\n" +
					"You see the bedroom Door, a Mirror and the Closet\n\n" +
					"Press D to go to the Door, M to look at the Mirror, or C to C heck out the closet" ;
		if (Input.GetKeyDown(KeyCode.D)) {myState = States.bedroom_door;}
		else if (Input.GetKeyDown(KeyCode.M)) {myState = States.mirror;}
		else if (Input.GetKeyDown(KeyCode.C)) {myState = States.closet;}
	}
	
	void closet() {
		text.text = "So many clothes! I should pick something quickly so I can get to work but maybe I should check out my mirror first?\n\n" +
				"Press D to get Dressed, B to return to Bedroom" ;
		if (Input.GetKeyDown(KeyCode.D)) {myState = States.clothing;}
		else if (Input.GetKeyDown(KeyCode.B)) {myState = States.bedroom;}
	}
	
	void bedroom_door() {
		text.text = "I can't leave for work like this! I'm in my pjs! Unless I am dreaming <pinch>. Ouch! Nope\n\n" +
				"Press B to go go back to the Bedroom" ;
		if (Input.GetKeyDown(KeyCode.B)) {myState = States.bedroom;}
	}
	
	void mirror() {
		text.text = "I don't really have time to do my hair but maybe I can clip it up so I am not such a wreck. Gorgeous! But I better get back to getting ready to leave.\n\n" +
				"Press B to return to the Bedroom" ;
		if (Input.GetKeyDown(KeyCode.B)) {myState = States.bedroom;}
		fixedhair=1;
	}
	
	void clothing() {
		text.text = "This will have to do. I really should get going soon before I am late for work!\n\n" +
				"Press D to go to the Door" ;
		if (Input.GetKeyDown(KeyCode.D)) {myState = States.bedroom_door2;}
	}
	
	void bedroom_door2() {
		text.text = "Wait. When did I close my door?\n\n" +
				"Press O to Open the door" ;
		if (Input.GetKeyDown(KeyCode.O)) {myState = States.hallway;}
	}
	
	void hallway() {
		text.text = "You are in your very small hallway. You see a hallway door, the bathroom, and the way to the kitchen.\n" +
			"You should go to the bathroom before heading to the kitchen but you are curious about that door that you don't think was there before.\n\n" +
				"Press H to check out the Hall door, Press B to go into the Bathroom" ;
		if (Input.GetKeyDown(KeyCode.H)) {myState = States.hall_door;}
		else if (Input.GetKeyDown(KeyCode.B)) {myState = States.bathroom;}

	}
	
	void hall_door() {
		text.text = "You are at home in your bedroom and need to make your way to the door to leave for work.\n" +
			"You see the bedroom Door, a Mirror and the Closet\n\n" +
				"Press D to go to the Door, M to look at the Mirror, or C to C heck out the closet" ;
		if (Input.GetKeyDown(KeyCode.D)) {myState = States.bedroom_door;}
		else if (Input.GetKeyDown(KeyCode.M)) {myState = States.mirror;}
		else if (Input.GetKeyDown(KeyCode.C)) {myState = States.closet;}
	}
	
	void bathroom() {
		text.text = "You are at home in your bedroom and need to make your way to the door to leave for work.\n" +
			"You see the bedroom Door, a Mirror and the Closet\n\n" +
				"Press D to go to the Door, M to look at the Mirror, or C to C heck out the closet" ;
		if (Input.GetKeyDown(KeyCode.M)) {myState = States.mirror_2;}
		else if (Input.GetKeyDown(KeyCode.C)) {myState = States.cell_phone;}
	}
	
	
	
	void mirror_2() {
		text.text = "You are at home in your bedroom and need to make your way to the door to leave for work.\n" +
			"You see the bedroom Door, a Mirror and the Closet\n\n" +
				"Press D to go to the Door, M to look at the Mirror, or C to C heck out the closet" ;
		if (Input.GetKeyDown(KeyCode.B)) {myState = States.bathroom;}

	}
	
	void cell_phone() {
		text.text = "You are at home in your bedroom and need to make your way to the door to leave for work.\n" +
			"You see the bedroom Door, a Mirror and the Closet\n\n" +
				"Press D to go to the Door, M to look at the Mirror, or C to C heck out the closet" ;
		if (Input.GetKeyDown(KeyCode.H)) {myState = States.hallway_1;}
		else if (Input.GetKeyDown(KeyCode.B)) {myState = States.tooth_brush;}
	}
	
	void tooth_brush() {
		text.text = "You are at home in your bedroom and need to make your way to the door to leave for work.\n" +
			"You see the bedroom Door, a Mirror and the Closet\n\n" +
				"Press D to go to the Door, M to look at the Mirror, or C to C heck out the closet" ;
		if (Input.GetKeyDown(KeyCode.M)) {myState = States.mirror_3;}
		else if (Input.GetKeyDown(KeyCode.H)) {myState = States.hallway_2;}
}
	
	void mirror_3() {
		text.text = "You are at home in your bedroom and need to make your way to the door to leave for work.\n" +
			"You see the bedroom Door, a Mirror and the Closet\n\n" +
				"Press D to go to the Door, M to look at the Mirror, or C to C heck out the closet" ;
		if (Input.GetKeyDown(KeyCode.H)) {myState = States.hallway_2;}

	}
	
	void hallway_1() {
		text.text = "You are at home in your bedroom and need to make your way to the door to leave for work.\n" +
			"You see the bedroom Door, a Mirror and the Closet\n\n" +
				"Press D to go to the Door, M to look at the Mirror, or C to C heck out the closet" ;
		if (Input.GetKeyDown(KeyCode.B)) {myState = States.tooth_brush;}
		else if (Input.GetKeyDown(KeyCode.K)) {myState = States.kitchen_1;}

	}
	
	void kitchen_1() {
		text.text = "You are at home in your bedroom and need to make your way to the door to leave for work.\n" +
			"You see the bedroom Door, a Mirror and the Closet\n\n" +
				"Press D to go to the Door, M to look at the Mirror, or C to C heck out the closet" ;
		if (Input.GetKeyDown(KeyCode.B)) {myState = States.tooth_brush;}

	}
	
	void hallway_2() {
		text.text = "You are at home in your bedroom and need to make your way to the door to leave for work.\n" +
			"You see the bedroom Door, a Mirror and the Closet\n\n" +
				"Press D to go to the Door, M to look at the Mirror, or C to C heck out the closet" ;
		if (Input.GetKeyDown(KeyCode.K)) {myState = States.kitchen_2;}

	}
	
	void kitchen_2() {
		text.text = "You are at home in your bedroom and need to make your way to the door to leave for work.\n" +
			"You see the bedroom Door, a Mirror and the Closet\n\n" +
				"Press D to go to the Door, M to look at the Mirror, or C to C heck out the closet" ;
		if (Input.GetKeyDown(KeyCode.F)) {myState = States.fridge;}
		else if (Input.GetKeyDown(KeyCode.C)) {myState = States.computer;}
		else if (Input.GetKeyDown(KeyCode.L)) {myState = States.livingroom;}
	}
	
	void fridge() {
		text.text = "You are at home in your bedroom and need to make your way to the door to leave for work.\n" +
			"You see the bedroom Door, a Mirror and the Closet\n\n" +
				"Press D to go to the Door, M to look at the Mirror, or C to C heck out the closet" ;
		if (Input.GetKeyDown(KeyCode.C)) {myState = States.computer;}
		else if (Input.GetKeyDown(KeyCode.K)) {myState = States.kitchen_2;}
	}
	
	void computer() {
		text.text = "You are at home in your bedroom and need to make your way to the door to leave for work.\n" +
			"You see the bedroom Door, a Mirror and the Closet\n\n" +
				"Press D to go to the Door, M to look at the Mirror, or C to C heck out the closet" ;
		if (Input.GetKeyDown(KeyCode.F)) {myState = States.fridge;}
		else if (Input.GetKeyDown(KeyCode.L)) {myState = States.livingroom;}
		else if (Input.GetKeyDown(KeyCode.K)) {myState = States.kitchen_2;}
	}
	
	void livingroom() {
		text.text = "You are at home in your bedroom and need to make your way to the door to leave for work.\n" +
			"You see the bedroom Door, a Mirror and the Closet\n\n" +
				"Press D to go to the Door, M to look at the Mirror, or C to C heck out the closet" ;
		if (Input.GetKeyDown(KeyCode.K)) {myState = States.kitchen_2;}
		else if (Input.GetKeyDown(KeyCode.T)) {myState = States.cat;} // theo
		else if (Input.GetKeyDown(KeyCode.C)) {myState = States.computer;}
		else if (Input.GetKeyDown(KeyCode.P)) {myState = States.purse;}
	}
	
	void purse() {
		text.text = "You are at home in your bedroom and need to make your way to the door to leave for work.\n" +
			"You see the bedroom Door, a Mirror and the Closet\n\n" +
				"Press D to go to the Door, M to look at the Mirror, or C to C heck out the closet" ;
		if (Input.GetKeyDown(KeyCode.K)) {myState = States.keys;}
	}
	
	void cat() {
		text.text = "You are at home in your bedroom and need to make your way to the door to leave for work.\n" +
			"You see the bedroom Door, a Mirror and the Closet\n\n" +
				"Press D to go to the Door, M to look at the Mirror, or C to C heck out the closet" ;
		if (Input.GetKeyDown(KeyCode.L)) {myState = States.livingroom;}

	}
	
	void keys() {
		text.text = "You are at home in your bedroom and need to make your way to the door to leave for work.\n" +
			"You see the bedroom Door, a Mirror and the Closet\n\n" +
				"Press D to go to the Door, M to look at the Mirror, or C to C heck out the closet" ;
		if (Input.GetKeyDown(KeyCode.C)) {myState = States.cat_2;} //chaos

	}
	
	void cat_2() {
		text.text = "You are at home in your bedroom and need to make your way to the door to leave for work.\n" +
			"You see the bedroom Door, a Mirror and the Closet\n\n" +
				"Press D to go to the Door, M to look at the Mirror, or C to C heck out the closet" ;
		if (Input.GetKeyDown(KeyCode.F)) {myState = States.front_door;}
		else if (Input.GetKeyDown(KeyCode.C)) {myState = States.cat_food;}

	}
	
	void front_door1() {
		text.text = "You are at home in your bedroom and need to make your way to the door to leave for work.\n" +
			"You see the bedroom Door, a Mirror and the Closet\n\n" +
				"Press D to go to the Door, M to look at the Mirror, or C to C heck out the closet" ;
		if (Input.GetKeyDown(KeyCode.C)) {myState = States.cat_2;}

	}
	
	void cat_food() {
		text.text = "You are at home in your bedroom and need to make your way to the door to leave for work.\n" +
			"You see the bedroom Door, a Mirror and the Closet\n\n" +
				"Press D to go to the Door, M to look at the Mirror, or C to C heck out the closet" ;
		if (Input.GetKeyDown(KeyCode.F)) {myState = States.front_door;}

	}
	
	void front_door() {
		text.text = "You are at home in your bedroom and need to make your way to the door to leave for work.\n" +
			"You see the bedroom Door, a Mirror and the Closet\n\n" +
				"Press D to go to the Door, M to look at the Mirror, or C to C heck out the closet" ;
		if (Input.GetKeyDown(KeyCode.L)) {myState = States.leave;}

	}
	
	void leave() {
		text.text = "You are at home in your bedroom and need to make your way to the door to leave for work.\n" +
			"You see the bedroom Door, a Mirror and the Closet\n\n" +
				"Press D to go to the Door, M to look at the Mirror, or C to C heck out the closet" ;
		if (Input.GetKeyDown(KeyCode.D)) {myState = States.bedroom_door;} // restart
		else if (Input.GetKeyDown(KeyCode.M)) {myState = States.mirror;} // exit

	}
}

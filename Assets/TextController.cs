using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {bedroom, closet, bedroom_door, mirror, clothing, bedroom_door2, hallway, hall_door, bathroom, mirror_2, cell_phone, tooth_brush, mirror_3,
						hallway_1, kitchen_1, hallway_2, kitchen_2, fridge, computer, livingroom, purse, cat, keys, cat_2, front_door1, cat_food, front_door, leave};
	private States myState;
	private int fixedhair=0;
	private int checkedWeather=0;
	private int hiToTheo=0;


	void Start () {
	myState = States.bedroom;
	fixedhair=0;
	checkedWeather=0;
	hiToTheo=0;
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
		text.text = "You are at home in your bedroom and need to make your way to the door to leave for work." +
					"You see the bedroom Door, a Mirror and the Closet\n\n" +
					"Press D to go to the Door, M to look at the Mirror, or C to Check out the closet" ;
		if (Input.GetKeyDown(KeyCode.D)) {myState = States.bedroom_door;}
		else if (Input.GetKeyDown(KeyCode.M)) {myState = States.mirror;}
		else if (Input.GetKeyDown(KeyCode.C)) {myState = States.closet;}
	}

	void closet() {
		text.text = "So many clothes! I should pick something quickly so I can get to work but maybe I should check out my mirror first?\n\n" +
				"Press D to get Dressed, Backspace to return to Bedroom" ;
		if (Input.GetKeyDown(KeyCode.D)) {myState = States.clothing;}
		else if (Input.GetKeyDown(KeyCode.Backspace)) {myState = States.bedroom;}
	}

	void bedroom_door() {
		text.text = "I can't leave for work like this! I'm in my pjs! Unless I am dreaming <pinch>. Ouch! Nope\n\n" +
				"Press Backspace to go go back to the Bedroom" ;
		if (Input.GetKeyDown(KeyCode.Backspace)) {myState = States.bedroom;}
	}

	void mirror() {
		text.text = "I don't really have time to do my hair but maybe I can clip it up so I am not such a wreck. Gorgeous! But I better get back to getting ready to leave.\n\n" +
			"Press Backspace to return to the Bedroom" ;
		if (Input.GetKeyDown(KeyCode.Backspace)) {myState = States.bedroom;}
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
		text.text = "You are in your very small hallway. You see a hallway door, the bathroom, and the way to the kitchen. " +
			"You should go to the bathroom before heading to the kitchen but you are curious about that door that you don't think was there before.\n\n" +
				"Press H to check out the Hall door, Press B to go into the Bathroom" ;
		if (Input.GetKeyDown(KeyCode.H)) {myState = States.hall_door;}
		else if (Input.GetKeyDown(KeyCode.B)) {myState = States.bathroom;}

	}

	void hall_door() {
		text.text = "The door is made of solid wood. You try the knob, but it's locked. What could be on the other side. You are curious, but have to get ready for work!\n\n" +
			"Press Backspace to go back to the Hallway" ;
		if (Input.GetKeyDown(KeyCode.Backspace)) {myState = States.hallway;}
	}

	void bathroom() {
		text.text = "There is never enough room in here. And it always seems to be dirty, and a catch all for everything. " +
			"Looking at the counter you see your cell phone. You also see a note on the mirror.\n\n" +
				"Press C to pick up your Cell phone, Press M to look at the Mirror" ;
		if (Input.GetKeyDown(KeyCode.M)) {myState = States.mirror_2;}
		else if (Input.GetKeyDown(KeyCode.C)) {myState = States.cell_phone;}
	}



	void mirror_2() {
		text.text = "You walk towards the mirror to read the note. " +
			"The note says: You look fab today! Keep on Keepin' On. \n Where you drinking last night?\n\n" +
				"Press Backspace to step away from the mirror." ;
		if (Input.GetKeyDown(KeyCode.Backspace)) {myState = States.bathroom;}

	}

	void cell_phone() {
		text.text = "Thank goodness! I was looking for this! I thought I lost it. " +
			"You see your tooth brush sitting on the counter with the toothpaste.\n\n" +
				"Press H to leave without brushing your teeth, press B to brush your teeth." ;
		if (Input.GetKeyDown(KeyCode.H)) {myState = States.hallway_1;}
		else if (Input.GetKeyDown(KeyCode.B)) {myState = States.tooth_brush;}
	}

	void tooth_brush() {
		text.text = "*brush brush brush*\n" +
			"Ahh! Much better. I should put this toothbrush away, but it so much effort.\n\n" +
				"Press P to put away the tooth brush, Press L to leave the tooth brush on the counter and go to the hallway" ;
		if (Input.GetKeyDown(KeyCode.P)) {myState = States.mirror_3;}
		else if (Input.GetKeyDown(KeyCode.L)) {myState = States.hallway_2;}
}

	void mirror_3() {
		text.text = "Opening the medicine cabinet you put the tooth brush and tooth paste away. Closing the cabinet, you check yourself out in the mirror. Shooting finger guns at yourself you say... \n" +
			"How you doin'?\n\n" +
				"Press H to go back out into the hallway. " ;
		if (Input.GetKeyDown(KeyCode.H)) {myState = States.hallway_2;}

	}

	void hallway_1() {
		text.text = "I should really brush my teeth before going to work. " +
			"You see the way to the bathroom and the way to the kitchen\n\n" +
				"Press Backspace to go back to the bathroom and brush teeth, Press K to go to the kitchen." ;
		if (Input.GetKeyDown(KeyCode.Backspace)) {myState = States.tooth_brush;}
		else if (Input.GetKeyDown(KeyCode.K)) {myState = States.kitchen_1;}

	}

	void kitchen_1() {
		text.text = "Yuck! I really need to brush my teeth\n\n" +
				"Press B to go brush your teeth (I mean, come on!)" ;
		if (Input.GetKeyDown(KeyCode.B)) {myState = States.tooth_brush;}

	}

	void hallway_2() {
		text.text = "Maybe I should have a shower, but I really have to get going. I'll have a nice long shower tonight. \n\n" +
				"Press K to go into the kitchen. " ;
		if (Input.GetKeyDown(KeyCode.K)) {myState = States.kitchen_2;}

	}

	void kitchen_2() {
		text.text = "I am not really sure why I call this a kitchen. Really it's one room. It shold be called 'The rest of the apartment' because it literally is 'The rest of the apartment'\nYou see the fridge, computer and sofa all with a few paces\n\n" +
				"Press F to check out the Fridge, C to go to the Computer and L to go to the 'Livingroom'" ;
		if (Input.GetKeyDown(KeyCode.F)) {myState = States.fridge;}
		else if (Input.GetKeyDown(KeyCode.C)) {myState = States.computer;}
		else if (Input.GetKeyDown(KeyCode.L)) {myState = States.livingroom;}
	}

	void fridge() {
		text.text = "There is not really enough time for breakfast this morning. Not that is any ever really in the fridge. You open it anyway. Nope, nothing there. \n\n" +
			"Press Backspace to step away from the fridge, Press C to go to the Computer." ;
		if (Input.GetKeyDown(KeyCode.C)) {myState = States.computer;}
		else if (Input.GetKeyDown(KeyCode.Backspace)) {myState = States.kitchen_2;}
	}

	void computer() {
		text.text = "You sit down at the computer and double check the weather a few times before flicking off the screen. You really should get going. \n\n" + "Press F to check out the Fridge, Backspace to go to the Kitchen and L to go to the 'Livingroom'" ;
		if (Input.GetKeyDown(KeyCode.F)) {myState = States.fridge;}
		else if (Input.GetKeyDown(KeyCode.L)) {myState = States.livingroom;}
		else if (Input.GetKeyDown(KeyCode.Backspace)) {myState = States.kitchen_2;}
	}

	void livingroom() {
		text.text = "From the livingroom you can see the computer and the kitchen. You also notice Theo the cat waiting patiently to be petted. Your purse is on the coffee table.\n\n" + "Press Backspace to go to the Kitchen, C to go to the Computer, P to grab your Purse, or T to say Good-Morning to Theo the Cat" ;
		if (Input.GetKeyDown(KeyCode.Backspace)) {myState = States.kitchen_2;}
		else if (Input.GetKeyDown(KeyCode.T)) {myState = States.cat;} // theo
		else if (Input.GetKeyDown(KeyCode.C)) {myState = States.computer;}
		else if (Input.GetKeyDown(KeyCode.P)) {myState = States.purse;}
	}

	void purse() {
		text.text = "You grab your purse. It pretty much has everything you need in it and more. You have often called it your Mary Poppins purse because you can reach in looking for one thing and pull out something interesting that you have no idea why it would even be in there in the first place. Your keys are likely to be in there.\n\n" +
				"Press K to rifle through your purse to look for your keys" ;
		if (Input.GetKeyDown(KeyCode.K)) {myState = States.keys;}
	}

	void cat() {
		text.text = "Hello Theo my little squeeker! How are you this morning? Theo squeeks his little meow. I have to go to work little buddy. \n\n" +
			"Press Backspace to go back to the 'Livingroom'" ;
		if (Input.GetKeyDown(KeyCode.Backspace)) {myState = States.livingroom;}

	}

	void keys() {
		text.text = "Nail polish? Lens cleaner, screw driver, coffee lid, one loose cough drop, and ... Success! My keys! You hear Chaos the cat howl from the other room. You should go check what the big orange cat is howling about.\n\n" +
				"Press C to talk to Chaos the Cat" ;
		if (Input.GetKeyDown(KeyCode.C)) {myState = States.cat_2;} //chaos

	}

	void cat_2() {
		text.text = "Hey big guy! What the problem? You need some breakfast?\n\n" +
				"Press D to head out head out the front Door, Press F to Fill the cat bowl with crunchy food." ;
		if (Input.GetKeyDown(KeyCode.D)) {myState = States.front_door1;}
		else if (Input.GetKeyDown(KeyCode.F)) {myState = States.cat_food;}

	}

	void front_door1() {
		text.text = "You try to head out the door but Chaos scoots under your feet and runs back to his bowl meowing the entire time.\n\n" +
				"Press C to talk to Chaos the Cat" ;
		if (Input.GetKeyDown(KeyCode.C)) {myState = States.cat_2;}

	}

	void cat_food() {
		text.text = "Petting Chaos on the head you decide you better feed him before he trips you. I wasn't going to leave without feeding you! I was just getting my shoes on first. You put some crunchies in the cat dish. I should really get going now!\n\n" +
				"Press D to head out the front door" ;
		if (Input.GetKeyDown(KeyCode.D)) {myState = States.front_door;}

	}

	void front_door() {
		text.text = "You get to the door, put on your shoes, grab a sweater and head outside.\n\n" +
				"Press L to lock the door and head off to work! Finally!" ;
		if (Input.GetKeyDown(KeyCode.L)) {myState = States.leave;}

	}

	void leave() {
		text.text = "Off to work I go!\n\nThanks for Playing! This was made for a beginner course in Unity Development." +
				"Press P to Play again" ;
		if (Input.GetKeyDown(KeyCode.P)) {Start();} // restart
		// maybe something in here to go to screen showing time choices etc
	}
}

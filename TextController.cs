﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;

	private enum States { title_screen, cell, cell_return, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, 
							corridor_0, stairs_0, showers_0, bobby_pins, corridor_return, corridor_1, stairs_1, storage_0, lock_2, 
							storage_1, lock_3, selection_0, item_1, item_2, item_3, item_4, 
							selection_1_item_1, selection_1_item_2, selection_1_item_3, selection_1_item_4, 
							corridor_2_item_1, corridor_2_item_2, corridor_2_item_3, corridor_2_item_4, 
							selection_2_item_1, selection_2_item_2, selection_2_item_3, selection_2_item_4, 
							corridor_3_item_1_2, corridor_3_item_1_3, corridor_3_item_1_4, 
							corridor_3_item_2_1, corridor_3_item_2_3, corridor_3_item_2_4, 
							corridor_3_item_3_1, corridor_3_item_3_2, corridor_3_item_3_4, 
							corridor_3_item_4_1, corridor_3_item_4_2, corridor_3_item_4_3, 
							selection_3_item_1, selection_3_item_2, selection_3_item_3, selection_3_item_4, 
							corridor_4_item_1_2_3, corridor_4_item_1_3_2, corridor_4_item_1_2_4, corridor_4_item_1_4_2, corridor_4_item_1_3_4, corridor_4_item_1_4_3,  
							corridor_4_item_2_1_3, corridor_4_item_2_3_1, corridor_4_item_2_1_4, corridor_4_item_2_4_1, corridor_4_item_2_3_4, corridor_4_item_1_4_3, 
							corridor_4_item_3_1_2, corridor_4_item_3_2_1, corridor_4_item_3_1_4, corridor_4_item_3_4_1, corridor_4_item_3_2_4, corridor_4_item_3_4_2, 
							corridor_4_item_4_1_2, corridor_4_item_4_2_1, corridor_4_item_4_1_3, corridor_4_item_4_3_1, corridor_4_item_4_2_3, corridor_4_item_4_3_2, 
							game_over_0, showers_1, 
							stairs_2_item_1, stairs_2_item_2, stairs_2_item_3, stairs_2_item_4,
							stairs_2_item_1_2, stairs_2_item_1_3, stairs_2_item_1_4, 
							stairs_2_item_1_2, stairs_2_item_1_3, stairs_2_item_1_4, 
							stairs_2_item_1_2, stairs_2_item_1_3, stairs_2_item_1_4, 
							stairs_2_item_1_2, stairs_2_item_1_3, stairs_2_item_1_4,  
							stairs_2_use_item_1, stairs_2_use_item_2, stairs_3,
							barracks_0_item_1, barracks_0_item_2, barracks_0_item_3, barracks_0_item_4, 
							barracks_0_item_1_2, barracks_0_item_1_3, barracks_0_item_1_4, 
							barracks_0_item_2_1, barracks_0_item_2_3, barracks_0_item_2_4, 
							barracks_0_item_3_1, barracks_0_item_3_2, barracks_0_item_3_4, 
							closet_0, lock_4, use_item_3, custodian_0, use_item_4, custodian_1, custodian_2,  
							closet_1, lock_5, uniform_0, court_0, gate_0, game_over_1, gate_1, freedom};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.title_screen;
	}

	// Update is called once per frame
	void Update() {
		print(myState);
		if (myState == States.title_screen) {
			state_title_screen();
		} else if (myState == States.cell) {
			state_cell();
		} else if (myState == States.lock_0) {
			state_lock_0();
		} else if (myState == States.sheets_0) {
			state_sheets_0();
		} else if (myState == States.cell_return) {
			state_cell_return();
		} else if (myState == States.mirror) {
			state_mirror();
		} else if (myState == States.cell_mirror) {
			state_cell_mirror();
		} else if (myState == States.sheets_1) {
			state_sheets_1();
		} else if (myState == States.lock_1) {
			state_lock_1();
		} else if (myState == States.corridor_0) {
			state_corridor_0();
		} else if (myState == States.stairs_0) {
			state_stairs_0();
		} else if (myState == States.corridor_return) {
			state_corridor_return();
		} else if (myState == States.storage_0) {
			state_storage_0();
		} else if (myState == States.lock_2) {
			state_lock_2();
		} else if (myState == States.showers_0) {
			state_showers_0();
		} else if (myState == States.bobby_pins) {
			state_bobby_pins();
		} else if (myState == States.corridor_1) {
			state_corridor_1();
		} else if (myState == States.showers_1) {
			state_showers_1();
		} else if (myState == States.storage_1) {
			state_storage_1();
		} else if (myState == States.stairs_1) {
			state_stairs_1();
		} else if (myState == States.lock_3) {
			state_lock_3();
		} else if (myState == States.selection_0) {
			state_selection_0();
		}
	}
		
		void state_title_screen () {
			text.text = "Escape from the Booty Warrior \n\n" +
						"Press Space key to begin";
			if (Input.GetKeyDown(KeyCode.Space)) {
			myState = States.cell;
			}
		}
		
		void state_cell () {
			text.text = "You are in danger of having a night with the Booty Warrior after a confrontation in the weight room. " +
						"Nothing comes between the Booty Warrior and getting his booty. You can either do business " +
						"with his the easy way or the hard way. You decided the easy way and picked tomorrow night. " +
						"Now you have to escape from your prison cell before it's too late! There are some dirty bed sheets, " +
						"a mirror on the wall, and the door is locked from outside. \n\n" +
						"Press S to View Sheets, Press M to view Mirrors and L to view Lock";
			if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.sheets_0;
		} else if (Input.GetKeyDown(KeyCode.M)) {
			myState = States.mirror;
		} else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_0; 
		}
		}
		
		void state_lock_0 () {
			text.text = "You look at the lock from the inside of your cell. " +
						"There is an overwhelming shadow surrounding the lock, so it is difficult to inspect " +
						"any signs of wear and tear from the lock. " +
						"You are forced to turn back and check your surroundings for any useful tools. \n\n" +
						"Press R to return to your cell!";
			if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell_return;
			}
		}
		
		void state_sheets_0 () {
			text.text = "You have been in prison for awhile haven't you? " +
						"The staff never cleans your sheets and you have all the time in the world to rub one off. " +
						"It's not like you got anyhting else better to do, " +
						"other than schedule unwanted play dates with fellow inmates. \n\n" +
						"Press R to return to your cell!";
			if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell_return;
			}
		}
		
		void state_cell_return () {
			text.text = "You cannot afford to procrasinate the rest of the night. " +
						"There has to be a way out of here! " +
						"You have to be creative with your surroundings. \n\n" +
						"Press S to View Sheets, Press M to view Mirrors and L to view Lock";
		if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.sheets_0;
		} else if (Input.GetKeyDown(KeyCode.M)) {
			myState = States.mirror;
		} else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_0; 
		}
		}
		
		void state_mirror () {
			text.text = "The mirror is small, but it is wide enough to fit through the cells. " +
						"This can be useful for exploring corners and checking your rear. \n\n" +
						"Press T to take mirror!";
			if (Input.GetKeyDown(KeyCode.T)) {
			myState = States.cell_mirror;
			}
		}
		
		void state_cell_mirror () {
			text.text = "You detach the mirror from the wall and begin to think about your next step in leaving your cell. " +
						"You check left and right from the wall and see only your bed and the lock from outside. \n\n" +
						"Press S to view Sheets and L to view Lock!";
		if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.sheets_1;
		} else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_1;
		}
		}
		
		void state_sheets_1 () {
			text.text = "What are you doing looking at your bed sheets? " +
						"Now is not the right time to rub one off. You got to escape now! \n\n" +
						"Press L to view Lock!";
		if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_1;
		} 
		}
		
		void state_lock_1 () {
			text.text = "You use the mirror to inspect the lock from the outside where there is more light. " +
						"Your eyes open wide when you found a loose bolt on the lock. " +
						"You can try to bust open the lock by shaking cell. \n\n" +
						"Press S to shake your cell!";
		if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.corridor_0;
		} 
		}
		
		void state_corridor_0 () {
			text.text = "You bust the lock open and quickly make your way to the corridor. " +
						"You still have your mirror on hand to check for corners as you rush on your tip toes. " +
						"You successfully made it to the corridor and find yourself in a division. You see stairs " +
						"engulfed in darkness, an open door to the showers, and a door leading to the storage. \n\n" +
						"Press D to view Stairs, Press S to go to Showers and C to view Storage";
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_0;
		} else if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.showers_0;
		} else if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.storage_0; 
		}
		}
		
		void state_stairs_0 () {
			text.text = "You inspect the stairs, the overwhelmingly darkness makes you feel afraid to go any further. " +
						"There is not enough natural light to reflect off the mirror to use downstairs. You decide " +
						"to turn back to the corridor to see if you can find a weapon or source of light \n\n" +
						"Press R to return to the corridor!";
			if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_return;
			}
		}
		
		void state_corridor_return () {
			text.text = "You return back to the corridor frantically thinking for a way out. " +
						"You remain in the division you were leading to the stairs, showers, or storage. " +
						"You have to act quickly before the guards find out left your cell. \n\n" +
						"Press D to view Stairs, Press S to go to Showers and C to view Storage";
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_0;
		} else if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.showers_0;
		} else if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.storage_0; 
		}
		}
		
		void state_storage_0 () {
			text.text = "You sneak pass the door leading to the storage. " +
						"You recognize that this is the storage used for ceiling contraband. " +
						"You find a lock attached to the storage. \n\n" +
						"Press L to inspect to the lock!";
			if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_2;
			}
		}
		
		void state_lock_2 () {
			text.text = "You inspect the lock and find there are no loose bolts. " +
						"Shaking the handles won't do you any good. " +
						"You decided to retreat back to the corridor to find anything useful. \n\n" +
						"Press R to return to the corridor!";
			if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_return;
			}
		}
		
		void state_showers_0 () {
			text.text = "You sneak pass the door entering the showers. " +
						"This is where the Booty Warrior and other inmates hunt for their next prey. " +
						"You were at least lucky that he caught you with your clothes on. " +
						"You search for every corner of the shower for something useful. " +
						"Less than a minute after your thorough search you found left over bobby pins on the floor. " +
						"You figured they will come in handy for your escape so you decided to take them. \n\n" +
						"Press T to take to the bobby pins!";
			if (Input.GetKeyDown(KeyCode.T)) {
			myState = States.bobby_pins;
			}
		}
		
		void state_bobby_pins () {
			text.text = "After collecting the bobby pins you decide to head back to the corridor before " +
						"you become someone else's one-night stand. " +
						"Without a moment's hesitation you made it pass the door. \n\n" +
						"Press R to return to the corridor!";
			if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_1;
			}
		}
		
		void state_corridor_1 () {
			text.text = "You return back to the corridor feeling confident you're thinking in the right direction. " +
						"You are still figuring out the missing piece of the puzzle as you stare down each path. " +
						"You cannot stall for any longer, you have to act quick! \n\n" +
						"Press D to view Stairs, Press S to go to Showers and C to view Storage";
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_1;
		} else if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.showers_1;
		} else if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.storage_1; 
		}
		}
		
		void state_stairs_1 () {
			text.text = "You inspect the stairs, the overwhelmingly darkness makes you feel afraid to go any further. " +
						"There is not enough natural light to reflect off the mirror to use downstairs. You decide " +
						"to turn back to the corridor to see if you can find a weapon or source of light \n\n" +
						"Press R to return to the corridor!";
			if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_1;
			}
		}
		
		void state_showers_1 () {
			text.text = "What are you doing? Do you want to become someone's late night snack? " +
						"Turn around now! " +
						"Now is not the time to give up! \n\n" +
						"Press R to return to the corridor!";
			if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_1;
			}
		}
		
		void state_storage_1 () {
			text.text = "You sneak pass the door leading to the storage. " +
						"You recognize that this is the storage used for ceiling contraband. " +
						"You find a lock attached to the storage. \n\n" +
						"Press L to inspect to the lock!";
			if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_3;
			}
		}
		
		void state_lock_3 () {
			text.text = "You inspect the lock and find there are no loose bolts, " +
						"however, you insert one of the bobby pins you found in the shower and " +
						"discover that it's a perfect fit. You are then able to lock pick the door. \n\n" +
						"Press P to return to pick the lock!";
			if (Input.GetKeyDown(KeyCode.P)) {
			myState = States.selection_0;
			}
		}
		
		void state_selection_0 () {
			text.text = "You successfully picked the lock. Clutch! " +
						"Once you open the storage you were able to find 4 items. Inspections must have been " +
						"slow this week. In front of you are a lighter, a flaslight, a screwdriver, and " +
						"a pair of golden brass knuckles. You began strategically choosing each item. \n\n" +
						"Press 1 to grab Lighter, Press 2 to grab Flaslight, Press 3 to grab Screwdriver, " +
						"and Press 4 to grab Brass knuckles!";
		if (Input.GetKeyDown(KeyCode.Alpha1)) {
			myState = States.selection_1_item_1;
		} else if (Input.GetKeyDown(KeyCode.Alpha2)) {
			myState = States.selection_1_item_2;
		} else if (Input.GetKeyDown(KeyCode.Alpha3)) {
			myState = States.selection_1_item_3; 
		} else if (Input.GetKeyDown(KeyCode.Alpha4)) {
			myState = States.selection_1_item_4; 
		}
		}
		
		void state_selection_1_item_1 () {
			text.text = "Choose to pick up the lighter, wise choice! " +
						"The room is still quiet. You figured you can grab another item for insurance. " +
						"You double check with your mirror to be safe. \n\n" +
						"Press 2 to grab Flaslight, Press 3 to grab Screwdriver, Press 4 to grab Brass knuckles, " +
						"or Press R to return to the corridor!";
		if (Input.GetKeyDown(KeyCode.Alpha2)) {
			myState = States.selection_2_item_1_2;
		} else if (Input.GetKeyDown(KeyCode.Alpha3)) {
			myState = States.selection_2_item_1_3;
		} else if (Input.GetKeyDown(KeyCode.Alpha4)) {
			myState = States.selection_2_item_1_4; 
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2_item_1; 
		}
		}
		
}

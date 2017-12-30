using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;

	private enum States { title_screen, cell, cell_return, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, 
							corridor_0, stairs_0, showers_0, corridor_return, storage_0, lock_2, storage_1, lock_3, 
							selection_0, item_1, item_2, item_3, item_4, 
							selection_1_item_1, selection_1_item_2, selection_1_item_3, selection_1_item_4, 
							selection_2_item_1, selection_2_item_2, selection_2_item_3, selection_2_item_4, 
							selection_3_item_1, selection_3_item_2, selection_3_item_3, selection_3_item_4,
							corridor_1, showers_1, corridor_return, stairs_1, freedom};
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
		} //else if (myState == States.corridor_0) {
			//state_corridor_0();
		//}
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
						"with him the easy way or the hard way. You decided the easy way and picked tomorrow night. " +
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
						"The security never cleans your sheets and you have all the time in the world to rub one off. " +
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
		
} 

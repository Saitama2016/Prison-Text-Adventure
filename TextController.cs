using System.Collections;
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
							selection_2_item_1_2, selection_2_item_1_3, selection_2_item_1_4, 
							selection_2_item_2_1, selection_2_item_2_3, selection_2_item_2_4, 
							selection_2_item_3_1, selection_2_item_3_2, selection_2_item_3_4, 
							selection_2_item_4_1, selection_2_item_4_2, selection_2_item_4_3, 
							corridor_2_item_1_2, corridor_2_item_1_3, corridor_2_item_1_4, 
							corridor_2_item_2_1, corridor_2_item_2_3, corridor_2_item_2_4, 
							corridor_2_item_3_1, corridor_2_item_3_2, corridor_2_item_3_4, 
							corridor_2_item_4_1, corridor_2_item_4_2, corridor_2_item_4_3, 
							selection_3_item_1_2_3, selection_3_item_1_3_2, selection_3_item_1_2_4, selection_3_item_1_4_2, selection_3_item_1_3_4, selection_3_item_1_4_3, 
							selection_3_item_2_1_3, selection_3_item_2_3_1, selection_3_item_2_1_4, selection_3_item_2_4_1, selection_3_item_2_3_4, selection_3_item_2_4_3, 
							selection_3_item_3_1_2, selection_3_item_3_2_1, selection_3_item_3_1_4, selection_3_item_3_4_1, selection_3_item_3_2_4, selection_3_item_3_4_2, 
							selection_3_item_4_1_2, selection_3_item_4_2_1, selection_3_item_4_1_3, selection_3_item_4_3_1, selection_3_item_4_2_3, selection_3_item_4_3_2, 
							corridor_2_item_1_2_3, corridor_2_item_1_3_2, corridor_2_item_1_2_4, corridor_2_item_1_4_2, corridor_2_item_1_3_4, corridor_2_item_1_4_3,  
							corridor_2_item_2_1_3, corridor_2_item_2_3_1, corridor_2_item_2_1_4, corridor_2_item_2_4_1, corridor_2_item_2_3_4, corridor_2_item_2_4_3, 
							corridor_2_item_3_1_2, corridor_2_item_3_2_1, corridor_2_item_3_1_4, corridor_2_item_3_4_1, corridor_2_item_3_2_4, corridor_2_item_3_4_2, 
							corridor_2_item_4_1_2, corridor_2_item_4_2_1, corridor_2_item_4_1_3, corridor_2_item_4_3_1, corridor_2_item_4_2_3, corridor_2_item_4_3_2, 
							game_over_0, showers_1, 
							stairs_2_item_1, stairs_2_item_2, stairs_2_item_3, stairs_2_item_4,
							stairs_2_item_1_2, stairs_2_item_1_3, stairs_2_item_1_4, 
							stairs_2_item_2_1, stairs_2_item_2_3, stairs_2_item_2_4, 
							stairs_2_item_3_1, stairs_2_item_3_2, stairs_2_item_3_4, 
							stairs_2_item_4_1, stairs_2_item_4_2, stairs_2_item_4_3, 
							stairs_2_item_1_2_3, stairs_2_item_1_3_2, stairs_2_item_1_2_4, stairs_2_item_1_4_2, stairs_2_item_1_3_4, stairs_2_item_1_4_3, 
							stairs_2_item_2_1_3, stairs_2_item_2_3_1, stairs_2_item_2_1_4, stairs_2_item_2_4_1, stairs_2_item_2_3_4, stairs_2_item_2_4_3, 
							stairs_2_item_3_1_2, stairs_2_item_3_2_1, stairs_2_item_3_2_4, stairs_2_item_3_4_2, stairs_2_item_3_1_4, stairs_2_item_3_4_1, 
							stairs_2_item_4_1_2, stairs_2_item_4_2_1, stairs_2_item_4_1_3, stairs_2_item_4_3_1, stairs_2_item_4_2_3, stairs_2_item_4_3_2, 
							stairs_3_item_1, stairs_3_item_2, stairs_3_item_3, stairs_3_item_4, 
							stairs_3_item_1_2a, stairs_3_item_1_2b, stairs_3_item_1_3, stairs_3_item_1_4,  
							stairs_3_item_2_1a, stairs_3_item_2_1b, stairs_3_item_2_3, stairs_3_item_2_4, 
							stairs_3_item_3_1, stairs_3_item_3_2, stairs_3_item_3_4, 
							stairs_3_item_4_1, stairs_3_item_4_2, stairs_3_item_4_3, 
							stairs_3_item_1_2_3a, stairs_3_item_1_2_3b, stairs_3_item_1_2_4a, stairs_3_item_1_2_4b, stairs_3_item_1_3_2a, stairs_3_item_1_3_2b, stairs_3_item_1_3_4, 
							stairs_3_item_1_4_2a, stairs_3_item_1_4_2b, stairs_3_item_1_4_3,  
							stairs_3_item_2_1_3a, stairs_3_item_2_1_3b, stairs_3_item_2_1_4a, stairs_3_item_2_1_4b, stairs_3_item_2_3_1a, stairs_3_item_2_3_1b, stairs_3_item_2_3_4, 
							stairs_3_item_2_4_1a, stairs_3_item_2_4_1b, stairs_3_item_2_4_3, 
							stairs_3_item_3_1_2a, stairs_3_item_3_1_2b, stairs_3_item_3_1_4, stairs_3_item_3_2_1a, stairs_3_item_3_2_1b, stairs_3_item_3_2_4,  
							stairs_3_item_3_4_1, stairs_3_item_3_4_2,  
							stairs_3_item_4_1_2a, stairs_3_item_4_1_2b, stairs_3_item_4_1_3, stairs_3_item_4_2_1a, stairs_3_item_4_2_1b, stairs_3_item_4_2_3, 
							stairs_3_item_4_3_1, stairs_3_item_4_3_2, 
							barracks_0_item_1, barracks_0_item_2, barracks_0_item_3, barracks_0_item_4, 
							barracks_0_item_1_2, barracks_0_item_1_3, barracks_0_item_1_4, 
							barracks_0_item_2_1, barracks_0_item_2_3, barracks_0_item_2_4, 
							barracks_0_item_3_1, barracks_0_item_3_2, barracks_0_item_3_4, 
							barracks_0_item_4_1, barracks_0_item_4_2, barracks_0_item_4_3, 
							barracks_0_item_1_2_3, barracks_0_item_1_3_2, barracks_0_item_1_2_4, barracks_0_item_1_4_2, barracks_0_item_1_3_4, barracks_0_item_1_4_3, 
							barracks_0_item_2_1_3, barracks_0_item_2_3_1, barracks_0_item_2_1_4, barracks_0_item_2_4_1, barracks_0_item_2_3_4, barracks_0_item_2_4_3, 
							barracks_0_item_3_1_2, barracks_0_item_3_2_1, barracks_0_item_3_1_4, barracks_0_item_3_4_1, barracks_0_item_3_2_4, barracks_0_item_3_4_2, 
							barracks_0_item_4_1_2, barracks_0_item_4_2_1, barracks_0_item_4_1_3, barracks_0_item_4_3_1, barracks_0_item_4_2_3, barracks_0_item_4_3_2, 
							closet_0_item_1, closet_0_item_2, closet_0_item_3, closet_0_item_4,
							closet_0_item_1_2, closet_0_item_1_3, closet_0_item_1_4, 
 							closet_0_item_2_1, closet_0_item_2_3, closet_0_item_2_4, 
 							closet_0_item_3_1, closet_0_item_3_2, closet_0_item_3_4, 
 							closet_0_item_4_1, closet_0_item_4_2, closet_0_item_4_3, 
 							closet_0_item_1_2_3, closet_0_item_1_3_2, closet_0_item_1_2_4, closet_0_item_1_4_2, closet_0_item_1_3_4, closet_0_item_1_4_3, 
 							closet_0_item_2_1_3, closet_0_item_2_3_1, closet_0_item_2_1_4, closet_0_item_2_4_1, closet_0_item_2_3_4, closet_0_item_2_4_3, 
 							closet_0_item_3_1_2, closet_0_item_3_2_1, closet_0_item_3_1_4, closet_0_item_3_4_1, closet_0_item_3_2_4, closet_0_item_3_4_2, 
 							closet_0_item_4_1_2, closet_0_item_4_2_1, closet_0_item_4_1_3, closet_0_item_4_3_1, closet_0_item_4_2_3, closet_0_item_4_3_2, 
							lock_4_item_1, lock_4_item_2, lock_4_item_3, lock_4_item_4,  
							lock_4_item_1_2, lock_4_item_1_3, lock_4_item_1_4, 
							lock_4_item_2_1, lock_4_item_2_3, lock_4_item_2_4, 
							lock_4_item_3_1, lock_4_item_3_2, lock_4_item_3_4, 
							lock_4_item_4_1, lock_4_item_4_2, lock_4_item_4_3,
							lock_4_item_1_2_3, lock_4_item_1_3_2, lock_4_item_1_2_4, lock_4_item_1_4_2, lock_4_item_1_3_4, lock_4_item_1_4_3, 
							lock_4_item_2_1_3, lock_4_item_2_1_4, lock_4_item_2_3_1, lock_4_item_2_3_4, lock_4_item_2_4_1, lock_4_item_2_4_3, 
							lock_4_item_3_1_2, lock_4_item_3_1_4, lock_4_item_3_2_1, lock_4_item_3_2_4, lock_4_item_3_4_1, lock_4_item_3_4_2, 
							lock_4_item_4_1_2, lock_4_item_4_1_3, lock_4_item_4_2_1, lock_4_item_4_2_3, lock_4_item_4_3_1, lock_4_item_4_3_2, 
							use_item_3, 
							custodian_0, 
							custodian_0_item_4, 
							custodian_0_item_1_4, custodian_0_item_2_4, custodian_0_item_3_4, 
							custodian_0_item_4_1, custodian_0_item_4_2, custodian_0_item_4_3, 
							custodian_0_item_1_2_4, custodian_0_item_1_4_2, custodian_0_item_1_3_4, custodian_0_item_1_4_3, 
							custodian_0_item_2_1_4, custodian_0_item_2_4_1, custodian_0_item_2_3_4, custodian_0_item_2_4_3, 
							custodian_0_item_3_1_4, custodian_0_item_3_4_1, custodian_0_item_3_2_4, custodian_0_item_3_4_2, 
							custodian_0_item_4_1_2, custodian_0_item_4_2_1, custodian_0_item_4_1_3, custodian_0_item_4_3_1, custodian_0_item_4_2_3, custodian_0_item_4_3_2, 
							use_item_4, keys_0, custodian_1, keys_1, game_over_1,  
							closet_1, lock_5, uniform_0, court_0, gate_0, game_over_2, freedom};
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
		} else if (myState == States.selection_1_item_1) {
			state_selection_1_item_1();
		} else if (myState == States.selection_1_item_2) {
			state_selection_1_item_2();
		} else if (myState == States.selection_1_item_3) {
			state_selection_1_item_3();
		} else if (myState == States.selection_1_item_4) {
			state_selection_1_item_4();
		} else if (myState == States.selection_2_item_1_2) {
			state_selection_2_item_1_2();
		} else if (myState == States.selection_2_item_1_3) {
			state_selection_2_item_1_3();
		} else if (myState == States.selection_2_item_1_4) {
			state_selection_2_item_1_4();
		} else if (myState == States.selection_2_item_2_1) {
			state_selection_2_item_2_1();
		} else if (myState == States.selection_2_item_2_3) {
			state_selection_2_item_2_3();
		} else if (myState == States.selection_2_item_2_4) {
			state_selection_2_item_2_4();
		} else if (myState == States.selection_2_item_3_1) {
			state_selection_2_item_3_1();
		} else if (myState == States.selection_2_item_3_2) {
			state_selection_2_item_3_2();
		} else if (myState == States.selection_2_item_3_4) {
			state_selection_2_item_3_4();
		} else if (myState == States.selection_2_item_4_1) {
			state_selection_2_item_4_1();
		} else if (myState == States.selection_2_item_4_2) {
			state_selection_2_item_4_2();
		} else if (myState == States.selection_2_item_4_3) {
			state_selection_2_item_4_3();
		} else if (myState == States.selection_3_item_1_2_3) {
			state_selection_3_item_1_2_3();
		} else if (myState == States.selection_3_item_1_2_4) {
			state_selection_3_item_1_2_4();
		} else if (myState == States.selection_3_item_1_3_2) {
			state_selection_3_item_1_3_2();
		} else if (myState == States.selection_3_item_1_3_4) {
			state_selection_3_item_1_3_4();
		} else if (myState == States.selection_3_item_1_4_2) {
			state_selection_3_item_1_4_2();
		} else if (myState == States.selection_3_item_1_4_3) {
			state_selection_3_item_1_4_3();
		} else if (myState == States.selection_3_item_2_1_3) {
			state_selection_3_item_2_1_3();
		} else if (myState == States.selection_3_item_2_1_4) {
			state_selection_3_item_2_1_4();
		} else if (myState == States.selection_3_item_2_3_1) {
			state_selection_3_item_2_3_1();
		} else if (myState == States.selection_3_item_2_3_4) {
			state_selection_3_item_2_3_4();
		} else if (myState == States.selection_3_item_2_4_1) {
			state_selection_3_item_2_4_1();
		} else if (myState == States.selection_3_item_2_4_3) {
			state_selection_3_item_2_4_3();
		} else if (myState == States.selection_3_item_3_1_2) {
			state_selection_3_item_3_1_2();
		} else if (myState == States.selection_3_item_3_1_4) {
			state_selection_3_item_3_1_4();
		} else if (myState == States.selection_3_item_3_2_1) {
			state_selection_3_item_3_2_1();
		} else if (myState == States.selection_3_item_3_2_4) {
			state_selection_3_item_3_2_4();
		} else if (myState == States.selection_3_item_3_4_1) {
			state_selection_3_item_3_4_1();
		} else if (myState == States.selection_3_item_3_4_2) {
			state_selection_3_item_3_4_2();
		} else if (myState == States.selection_3_item_4_1_2) {
			state_selection_3_item_4_1_2();
		} else if (myState == States.selection_3_item_4_1_3) {
			state_selection_3_item_4_1_3();
		} else if (myState == States.selection_3_item_4_2_1) {
			state_selection_3_item_4_2_1();
		} else if (myState == States.selection_3_item_4_2_3) {
			state_selection_3_item_4_2_3();
		} else if (myState == States.selection_3_item_4_3_1) {
			state_selection_3_item_4_3_1();
		} else if (myState == States.selection_3_item_4_3_2) {
			state_selection_3_item_4_3_2();
		} else if (myState == States.game_over_0) {
			state_game_over_0();
		} else if (myState == States.corridor_2_item_1) {
			state_corridor_2_item_1();
		} else if (myState == States.corridor_2_item_2) {
			state_corridor_2_item_2();
		} else if (myState == States.corridor_2_item_3) {
			state_corridor_2_item_3();
		} else if (myState == States.corridor_2_item_4) {
			state_corridor_2_item_4();
		} else if (myState == States.corridor_2_item_1_2) {
			state_corridor_2_item_1_2();
		} else if (myState == States.corridor_2_item_1_3) {
			state_corridor_2_item_1_3();
		} else if (myState == States.corridor_2_item_1_4) {
			state_corridor_2_item_1_4();
		} else if (myState == States.corridor_2_item_2_1) {
			state_corridor_2_item_2_1();
		} else if (myState == States.corridor_2_item_2_3) {
			state_corridor_2_item_2_3();
		} else if (myState == States.corridor_2_item_2_4) {
			state_corridor_2_item_2_4();
		} else if (myState == States.corridor_2_item_3_1) {
			state_corridor_2_item_3_1();
		} else if (myState == States.corridor_2_item_3_2) {
			state_corridor_2_item_3_2();
		} else if (myState == States.corridor_2_item_3_4) {
			state_corridor_2_item_3_4();
		} else if (myState == States.corridor_2_item_4_1) {
			state_corridor_2_item_4_1();
		} else if (myState == States.corridor_2_item_4_2) {
			state_corridor_2_item_4_2();
		} else if (myState == States.corridor_2_item_4_3) {
			state_corridor_2_item_4_3();
		} else if (myState == States.corridor_2_item_1_2_3) {
			state_corridor_2_item_1_2_3();
		} else if (myState == States.corridor_2_item_1_2_4) {
			state_corridor_2_item_1_2_4();
		} else if (myState == States.corridor_2_item_1_3_2) {
			state_corridor_2_item_1_3_2();
		} else if (myState == States.corridor_2_item_1_3_4) {
			state_corridor_2_item_1_3_4();
		} else if (myState == States.corridor_2_item_1_4_2) {
			state_corridor_2_item_1_4_2();
		} else if (myState == States.corridor_2_item_1_4_3) {
			state_corridor_2_item_1_4_3();
		} else if (myState == States.corridor_2_item_2_1_3) {
			state_corridor_2_item_2_1_3();
		} else if (myState == States.corridor_2_item_2_1_4) {
			state_corridor_2_item_2_1_4();
		} else if (myState == States.corridor_2_item_2_3_1) {
			state_corridor_2_item_2_3_1();
		} else if (myState == States.corridor_2_item_2_3_4) {
			state_corridor_2_item_2_3_4();
		} else if (myState == States.corridor_2_item_2_4_1) {
			state_corridor_2_item_2_4_1();
		} else if (myState == States.corridor_2_item_2_4_3) {
			state_corridor_2_item_2_4_3();
		} else if (myState == States.corridor_2_item_3_1_2) {
			state_corridor_2_item_3_1_2();
		} else if (myState == States.corridor_2_item_3_1_4) {
			state_corridor_2_item_3_1_4();
		} else if (myState == States.corridor_2_item_3_2_1) {
			state_corridor_2_item_3_2_1();
		} else if (myState == States.corridor_2_item_3_2_4) {
			state_corridor_2_item_3_2_4();
		} else if (myState == States.corridor_2_item_3_4_1) {
			state_corridor_2_item_3_4_1();
		} else if (myState == States.corridor_2_item_3_4_2) {
			state_corridor_2_item_3_4_2();
		} else if (myState == States.corridor_2_item_4_1_2) {
			state_corridor_2_item_4_1_2();
		} else if (myState == States.corridor_2_item_4_1_3) {
			state_corridor_2_item_4_1_3();
		} else if (myState == States.corridor_2_item_4_2_1) {
			state_corridor_2_item_4_2_1();
		} else if (myState == States.corridor_2_item_4_2_3) {
			state_corridor_2_item_4_2_3();
		} else if (myState == States.corridor_2_item_4_3_1) {
			state_corridor_2_item_4_3_1();
		} else if (myState == States.corridor_2_item_4_3_2) {
			state_corridor_2_item_4_3_2();
		} else if (myState == States.stairs_2_item_1) {
			state_stairs_2_item_1();
		} else if (myState == States.stairs_2_item_2) {
			state_stairs_2_item_2();
		} else if (myState == States.stairs_2_item_3) {
			state_stairs_2_item_3();
		} else if (myState == States.stairs_2_item_4) {
			state_stairs_2_item_4();
		} else if (myState == States.stairs_2_item_1_2) {
			state_stairs_2_item_1_2();
		} else if (myState == States.stairs_2_item_1_3) {
			state_stairs_2_item_1_3();
		} else if (myState == States.stairs_2_item_1_4) {
			state_stairs_2_item_1_4();
		} else if (myState == States.stairs_2_item_2_1) {
			state_stairs_2_item_2_1();
		} else if (myState == States.stairs_2_item_2_3) {
			state_stairs_2_item_2_3();
		} else if (myState == States.stairs_2_item_2_4) {
			state_stairs_2_item_2_4();
		} else if (myState == States.stairs_2_item_3_1) {
			state_stairs_2_item_3_1();
		} else if (myState == States.stairs_2_item_3_2) {
			state_stairs_2_item_3_2();
		} else if (myState == States.stairs_2_item_3_4) {
			state_stairs_2_item_3_4();
		} else if (myState == States.stairs_2_item_4_1) {
			state_stairs_2_item_4_1();
		} else if (myState == States.stairs_2_item_4_2) {
			state_stairs_2_item_4_2();
		} else if (myState == States.stairs_2_item_4_3) {
			state_stairs_2_item_4_3();
		} else if (myState == States.stairs_2_item_1_2_3) {
			state_stairs_2_item_1_2_3();
		} else if (myState == States.stairs_2_item_1_2_4) {
			state_stairs_2_item_1_2_4();
		} else if (myState == States.stairs_2_item_1_3_2) {
			state_stairs_2_item_1_3_2();
		} else if (myState == States.stairs_2_item_1_3_4) {
			state_stairs_2_item_1_3_4();
		} else if (myState == States.stairs_2_item_1_4_2) {
			state_stairs_2_item_1_4_2();
		} else if (myState == States.stairs_2_item_1_4_3) {
			state_stairs_2_item_1_4_3();
		} else if (myState == States.stairs_2_item_2_1_3) {
			state_stairs_2_item_2_1_3();
		} else if (myState == States.stairs_2_item_2_1_4) {
			state_stairs_2_item_2_1_4();
		} else if (myState == States.stairs_2_item_2_3_1) {
			state_stairs_2_item_2_3_1();
		} else if (myState == States.stairs_2_item_2_3_4) {
			state_stairs_2_item_2_3_4();
		} else if (myState == States.stairs_2_item_2_4_1) {
			state_stairs_2_item_2_4_1();
		} else if (myState == States.stairs_2_item_2_4_3) {
			state_stairs_2_item_2_4_3();
		} else if (myState == States.stairs_2_item_3_1_2) {
			state_stairs_2_item_3_1_2();
		} else if (myState == States.stairs_2_item_3_1_4) {
			state_stairs_2_item_3_1_4();
		} else if (myState == States.stairs_2_item_3_2_1) {
			state_stairs_2_item_3_2_1();
		} else if (myState == States.stairs_2_item_3_2_4) {
			state_stairs_2_item_3_2_4();
		} else if (myState == States.stairs_2_item_3_4_1) {
			state_stairs_2_item_3_4_1();
		} else if (myState == States.stairs_2_item_3_4_2) {
			state_stairs_2_item_3_4_2();
		} else if (myState == States.stairs_2_item_4_1_2) {
			state_stairs_2_item_4_1_2();
		} else if (myState == States.stairs_2_item_4_1_3) {
			state_stairs_2_item_4_1_3();
		} else if (myState == States.stairs_2_item_4_2_1) {
			state_stairs_2_item_4_2_1();
		} else if (myState == States.stairs_2_item_4_2_3) {
			state_stairs_2_item_4_2_3();
		} else if (myState == States.stairs_2_item_4_3_1) {
			state_stairs_2_item_4_3_1();
		} else if (myState == States.stairs_2_item_4_3_2) {
			state_stairs_2_item_4_3_2();
		} else if (myState == States.stairs_3_item_1) {
			state_stairs_3_item_1();
		} else if (myState == States.stairs_3_item_2) {
			state_stairs_3_item_2();
		} else if (myState == States.stairs_3_item_3) {
			state_stairs_3_item_3();
		} else if (myState == States.stairs_3_item_4) {
			state_stairs_3_item_4();
		} else if (myState == States.stairs_3_item_1_2a) {
			state_stairs_3_item_1_2a();
		} else if (myState == States.stairs_3_item_1_2b) {
			state_stairs_3_item_1_2b();
		} else if (myState == States.stairs_3_item_1_3) {
			state_stairs_3_item_1_3();
		} else if (myState == States.stairs_3_item_1_4) {
			state_stairs_3_item_1_4();
		} else if (myState == States.stairs_3_item_2_1a) {
			state_stairs_3_item_2_1a();
		} else if (myState == States.stairs_3_item_2_1b) {
			state_stairs_3_item_2_1b();
		} else if (myState == States.stairs_3_item_2_3) {
			state_stairs_3_item_2_3();
		} else if (myState == States.stairs_3_item_2_4) {
			state_stairs_3_item_2_4();
		} else if (myState == States.stairs_3_item_3_1) {
			state_stairs_3_item_3_1();
		} else if (myState == States.stairs_3_item_3_2) {
			state_stairs_3_item_3_2();
		} else if (myState == States.stairs_3_item_3_4) {
			state_stairs_3_item_3_4();
		} else if (myState == States.stairs_3_item_4_1) {
			state_stairs_3_item_4_1();
		} else if (myState == States.stairs_3_item_4_2) {
			state_stairs_3_item_4_2();
		} else if (myState == States.stairs_3_item_4_3) {
			state_stairs_3_item_4_3();
		} else if (myState == States.stairs_3_item_1_2_3a) {
			state_stairs_3_item_1_2_3a();
		} else if (myState == States.stairs_3_item_1_2_3b) {
			state_stairs_3_item_1_2_3b();
		} else if (myState == States.stairs_3_item_1_2_4a) {
			state_stairs_3_item_1_2_4a();
		} else if (myState == States.stairs_3_item_1_2_4b) {
			state_stairs_3_item_1_2_4b();
		} else if (myState == States.stairs_3_item_1_3_2a) {
			state_stairs_3_item_1_3_2a();
		} else if (myState == States.stairs_3_item_1_3_2b) {
			state_stairs_3_item_1_3_2b();
		} else if (myState == States.stairs_3_item_1_3_4) {
			state_stairs_3_item_1_3_4();
		} else if (myState == States.stairs_3_item_1_4_2a) {
			state_stairs_3_item_1_4_2a();
		} else if (myState == States.stairs_3_item_1_4_2b) {
			state_stairs_3_item_1_4_2b();
		} else if (myState == States.stairs_3_item_1_4_3) {
			state_stairs_3_item_1_4_3();
		} else if (myState == States.stairs_3_item_2_1_3a) {
			state_stairs_3_item_2_1_3a();
		} else if (myState == States.stairs_3_item_2_1_3b) {
			state_stairs_3_item_2_1_3b();
		} else if (myState == States.stairs_3_item_2_1_4a) {
			state_stairs_3_item_2_1_4a();
		} else if (myState == States.stairs_3_item_2_1_4b) {
			state_stairs_3_item_2_1_4b();
		} else if (myState == States.stairs_3_item_2_3_1a) {
			state_stairs_3_item_2_3_1a();
		} else if (myState == States.stairs_3_item_2_3_1b) {
			state_stairs_3_item_2_3_1b();
		} else if (myState == States.stairs_3_item_2_3_4) {
			state_stairs_3_item_2_3_4();
		} else if (myState == States.stairs_3_item_2_4_1a) {
			state_stairs_3_item_2_4_1a();
		} else if (myState == States.stairs_3_item_2_4_1b) {
			state_stairs_3_item_2_4_1b();
		} else if (myState == States.stairs_3_item_2_4_3) {
			state_stairs_3_item_2_4_3();
		} else if (myState == States.stairs_3_item_3_1_2a) {
			state_stairs_3_item_3_1_2a();
		} else if (myState == States.stairs_3_item_3_1_2b) {
			state_stairs_3_item_3_1_2b();
		} else if (myState == States.stairs_3_item_3_1_4) {
			state_stairs_3_item_3_1_4();
		} else if (myState == States.stairs_3_item_3_2_1a) {
			state_stairs_3_item_3_2_1a();
		} else if (myState == States.stairs_3_item_3_2_1b) {
			state_stairs_3_item_3_2_1b();
		} else if (myState == States.stairs_3_item_3_2_4) {
			state_stairs_3_item_3_2_4();
		} else if (myState == States.stairs_3_item_3_4_1) {
			state_stairs_3_item_3_4_1();
		} else if (myState == States.stairs_3_item_3_4_2) {
			state_stairs_3_item_3_4_2();
		} else if (myState == States.stairs_3_item_4_1_2a) {
			state_stairs_3_item_4_1_2a();
		} else if (myState == States.stairs_3_item_4_1_2b) {
			state_stairs_3_item_4_1_2b();
		} else if (myState == States.stairs_3_item_4_1_3) {
			state_stairs_3_item_4_1_3();
		} else if (myState == States.stairs_3_item_4_2_1a) {
			state_stairs_3_item_4_2_1a();
		} else if (myState == States.stairs_3_item_4_2_1b) {
			state_stairs_3_item_4_2_1b();
		} else if (myState == States.stairs_3_item_4_2_3) {
			state_stairs_3_item_4_2_3();
		} else if (myState == States.stairs_3_item_4_3_1) {
			state_stairs_3_item_4_3_1();
		} else if (myState == States.stairs_3_item_4_3_2) {
			state_stairs_3_item_4_3_2();
		} else if (myState == States.barracks_0_item_1) {
			state_barracks_0_item_1();
		} else if (myState == States.barracks_0_item_2) {
			state_barracks_0_item_2();
		} else if (myState == States.barracks_0_item_3) {
			state_barracks_0_item_3();
		} else if (myState == States.barracks_0_item_4) {
			state_barracks_0_item_4();
		} else if (myState == States.barracks_0_item_1_2) {
			state_barracks_0_item_1_2();
		} else if (myState == States.barracks_0_item_1_3) {
			state_barracks_0_item_1_3();
		} else if (myState == States.barracks_0_item_1_4) {
			state_barracks_0_item_1_4();
		} else if (myState == States.barracks_0_item_2_1) {
			state_barracks_0_item_2_1();
		} else if (myState == States.barracks_0_item_2_3) {
			state_barracks_0_item_2_3();
		} else if (myState == States.barracks_0_item_2_4) {
			state_barracks_0_item_2_4();
		} else if (myState == States.barracks_0_item_3_1) {
			state_barracks_0_item_3_1();
		} else if (myState == States.barracks_0_item_3_2) {
			state_barracks_0_item_3_2();
		} else if (myState == States.barracks_0_item_3_4) {
			state_barracks_0_item_3_4();
		} else if (myState == States.barracks_0_item_4_1) {
			state_barracks_0_item_4_1();
		} else if (myState == States.barracks_0_item_4_2) {
			state_barracks_0_item_4_2();
		} else if (myState == States.barracks_0_item_4_3) {
			state_barracks_0_item_4_3();
		} else if (myState == States.barracks_0_item_1_2_3) {
			state_barracks_0_item_1_2_3();
		} else if (myState == States.barracks_0_item_1_2_4) {
			state_barracks_0_item_1_2_4();
		} else if (myState == States.barracks_0_item_1_3_2) {
			state_barracks_0_item_1_3_2();
		} else if (myState == States.barracks_0_item_1_3_4) {
			state_barracks_0_item_1_3_4();
		} else if (myState == States.barracks_0_item_1_4_2) {
			state_barracks_0_item_1_4_2();
		} else if (myState == States.barracks_0_item_1_4_3) {
			state_barracks_0_item_1_4_3();
		} else if (myState == States.barracks_0_item_2_1_3) {
			state_barracks_0_item_2_1_3();
		} else if (myState == States.barracks_0_item_2_1_4) {
			state_barracks_0_item_2_1_4();
		} else if (myState == States.barracks_0_item_2_3_1) {
			state_barracks_0_item_2_3_1();
		} else if (myState == States.barracks_0_item_2_3_4) {
			state_barracks_0_item_2_3_4();
		} else if (myState == States.barracks_0_item_2_4_1) {
			state_barracks_0_item_2_4_1();
		} else if (myState == States.barracks_0_item_2_4_3) {
			state_barracks_0_item_2_4_3();
		} else if (myState == States.barracks_0_item_3_1_2) {
			state_barracks_0_item_3_1_2();
		} else if (myState == States.barracks_0_item_3_1_4) {
			state_barracks_0_item_3_1_4();
		} else if (myState == States.barracks_0_item_3_2_1) {
			state_barracks_0_item_3_2_1();
		} else if (myState == States.barracks_0_item_3_2_4) {
			state_barracks_0_item_3_2_4();
		} else if (myState == States.barracks_0_item_3_4_1) {
			state_barracks_0_item_3_4_1();
		} else if (myState == States.barracks_0_item_3_4_2) {
			state_barracks_0_item_3_4_2();
		} else if (myState == States.barracks_0_item_4_1_2) {
			state_barracks_0_item_4_1_2();
		} else if (myState == States.barracks_0_item_4_1_3) {
			state_barracks_0_item_4_1_3();
		} else if (myState == States.barracks_0_item_4_2_1) {
			state_barracks_0_item_4_2_1();
		} else if (myState == States.barracks_0_item_4_2_3) {
			state_barracks_0_item_4_2_3();
		} else if (myState == States.barracks_0_item_4_3_1) {
			state_barracks_0_item_4_3_1();
		} else if (myState == States.barracks_0_item_4_3_2) {
			state_barracks_0_item_4_3_2();
		} else if (myState == States.closet_0_item_1) {
			state_closet_0_item_1();
		} else if (myState == States.closet_0_item_2) {
			state_closet_0_item_2();
		} else if (myState == States.closet_0_item_3) {
			state_closet_0_item_3();
		} else if (myState == States.closet_0_item_4) {
			state_closet_0_item_4();
		} else if (myState == States.closet_0_item_1_2) {
			state_closet_0_item_1_2();
		} else if (myState == States.closet_0_item_1_3) {
			state_closet_0_item_1_3();
		} else if (myState == States.closet_0_item_1_4) {
			state_closet_0_item_1_4();
		} else if (myState == States.closet_0_item_2_1) {
			state_closet_0_item_2_1();
		} else if (myState == States.closet_0_item_2_3) {
			state_closet_0_item_2_3();
		} else if (myState == States.closet_0_item_2_4) {
			state_closet_0_item_2_4();
		} else if (myState == States.closet_0_item_3_1) {
			state_closet_0_item_3_1();
		} else if (myState == States.closet_0_item_3_2) {
			state_closet_0_item_3_2();
		} else if (myState == States.closet_0_item_3_4) {
			state_closet_0_item_3_4();
		} else if (myState == States.closet_0_item_4_1) {
			state_closet_0_item_4_1();
		} else if (myState == States.closet_0_item_4_2) {
			state_closet_0_item_4_2();
		} else if (myState == States.closet_0_item_4_3) {
			state_closet_0_item_4_3();
		} else if (myState == States.closet_0_item_1_2_3) {
			state_closet_0_item_1_2_3();
		} else if (myState == States.closet_0_item_1_2_4) {
			state_closet_0_item_1_2_4();
		} else if (myState == States.closet_0_item_1_3_2) {
			state_closet_0_item_1_3_2();
		} else if (myState == States.closet_0_item_1_3_4) {
			state_closet_0_item_1_3_4();
		} else if (myState == States.closet_0_item_1_4_2) {
			state_closet_0_item_1_4_2();
		} else if (myState == States.closet_0_item_1_4_3) {
			state_closet_0_item_1_4_3();
		} else if (myState == States.closet_0_item_2_1_3) {
			state_closet_0_item_2_1_3();
		} else if (myState == States.closet_0_item_2_1_4) {
			state_closet_0_item_2_1_4();
		} else if (myState == States.closet_0_item_2_3_1) {
			state_closet_0_item_2_3_1();
		} else if (myState == States.closet_0_item_2_3_4) {
			state_closet_0_item_2_3_4();
		} else if (myState == States.closet_0_item_2_4_1) {
			state_closet_0_item_2_4_1();
		} else if (myState == States.closet_0_item_2_4_3) {
			state_closet_0_item_2_4_3();
		} else if (myState == States.closet_0_item_3_1_2) {
			state_closet_0_item_3_1_2();
		} else if (myState == States.closet_0_item_3_1_4) {
			state_closet_0_item_3_1_4();
		} else if (myState == States.closet_0_item_3_2_1) {
			state_closet_0_item_3_2_1();
		} else if (myState == States.closet_0_item_3_2_4) {
			state_closet_0_item_3_2_4();
		} else if (myState == States.closet_0_item_3_4_1) {
			state_closet_0_item_3_4_1();
		} else if (myState == States.closet_0_item_3_4_2) {
			state_closet_0_item_3_4_2();
		} else if (myState == States.closet_0_item_4_1_2) {
			state_closet_0_item_4_1_2();
		} else if (myState == States.closet_0_item_4_1_3) {
			state_closet_0_item_4_1_3();
		} else if (myState == States.closet_0_item_4_2_1) {
			state_closet_0_item_4_2_1();
		} else if (myState == States.closet_0_item_4_2_3) {
			state_closet_0_item_4_2_3();
		} else if (myState == States.closet_0_item_4_3_1) {
			state_closet_0_item_4_3_1();
		} else if (myState == States.closet_0_item_4_3_2) {
			state_closet_0_item_4_3_2();
		} else if (myState == States.lock_4_item_1) {
			state_lock_4_item_1();
		} else if (myState == States.lock_4_item_2) {
			state_lock_4_item_2();
		} else if (myState == States.lock_4_item_3) {
			state_lock_4_item_3();
		} else if (myState == States.lock_4_item_4) {
			state_lock_4_item_4();
		} else if (myState == States.lock_4_item_1_2) {
			state_lock_4_item_1_2();
		} else if (myState == States.lock_4_item_1_3) {
			state_lock_4_item_1_3();
		} else if (myState == States.lock_4_item_1_4) {
			state_lock_4_item_1_4();
		} else if (myState == States.lock_4_item_2_1) {
			state_lock_4_item_2_1();
		} else if (myState == States.lock_4_item_2_3) {
			state_lock_4_item_2_3();
		} else if (myState == States.lock_4_item_2_4) {
			state_lock_4_item_2_4();
		} else if (myState == States.lock_4_item_3_1) {
			state_lock_4_item_3_1();
		} else if (myState == States.lock_4_item_3_2) {
			state_lock_4_item_3_2();
		} else if (myState == States.lock_4_item_3_4) {
			state_lock_4_item_3_4();
		} else if (myState == States.lock_4_item_4_1) {
			state_lock_4_item_4_1();
		} else if (myState == States.lock_4_item_4_2) {
			state_lock_4_item_4_2();
		} else if (myState == States.lock_4_item_4_3) {
			state_lock_4_item_4_3();
		} else if (myState == States.lock_4_item_1_2_3) {
			state_lock_4_item_1_2_3();
		} else if (myState == States.lock_4_item_1_2_4) {
			state_lock_4_item_1_2_4();
		} else if (myState == States.lock_4_item_1_3_2) {
			state_lock_4_item_1_3_2();
		} else if (myState == States.lock_4_item_1_3_4) {
			state_lock_4_item_1_3_4();
		} else if (myState == States.lock_4_item_1_4_2) {
			state_lock_4_item_1_4_2();
		} else if (myState == States.lock_4_item_1_4_3) {
			state_lock_4_item_1_4_3();
		} else if (myState == States.lock_4_item_2_1_3) {
			state_lock_4_item_2_1_3();
		} else if (myState == States.lock_4_item_2_1_4) {
			state_lock_4_item_2_1_4();
		} else if (myState == States.lock_4_item_2_3_1) {
			state_lock_4_item_2_3_1();
		} else if (myState == States.lock_4_item_2_3_4) {
			state_lock_4_item_2_3_4();
		} else if (myState == States.lock_4_item_2_4_1) {
			state_lock_4_item_2_4_1();
		} else if (myState == States.lock_4_item_2_4_3) {
			state_lock_4_item_2_4_3();
		} else if (myState == States.lock_4_item_3_1_2) {
			state_lock_4_item_3_1_2();
		} else if (myState == States.lock_4_item_3_1_4) {
			state_lock_4_item_3_1_4();
		} else if (myState == States.lock_4_item_3_2_1) {
			state_lock_4_item_3_2_1();
		} else if (myState == States.lock_4_item_3_2_4) {
			state_lock_4_item_3_2_4();
		} else if (myState == States.lock_4_item_3_4_1) {
			state_lock_4_item_3_4_1();
		} else if (myState == States.lock_4_item_3_4_2) {
			state_lock_4_item_3_4_2();
		} else if (myState == States.lock_4_item_4_1_2) {
			state_lock_4_item_4_1_2();
		} else if (myState == States.lock_4_item_4_1_3) {
			state_lock_4_item_4_1_3();
		} else if (myState == States.lock_4_item_4_2_1) {
			state_lock_4_item_4_2_1();
		} else if (myState == States.lock_4_item_4_2_3) {
			state_lock_4_item_4_2_3();
		} else if (myState == States.lock_4_item_4_3_1) {
			state_lock_4_item_4_3_1();
		} else if (myState == States.lock_4_item_4_3_2) {
			state_lock_4_item_4_3_2();
		} else if (myState == States.use_item_3) {
			state_use_item_3();
		} else if (myState == States.lock_4_item_4_1) {
			state_lock_4_item_4_1();
		} else if (myState == States.custodian_0) {
			state_custodian_0();
		} else if (myState == States.custodian_0_item_1_4) {
			state_custodian_0_item_1_4();
		} else if (myState == States.custodian_0_item_2_4) {
			state_custodian_0_item_2_4();
		} else if (myState == States.custodian_0_item_3_4) {
			state_custodian_0_item_3_4();
		} else if (myState == States.custodian_0_item_4_1) {
			state_custodian_0_item_4_1();
		} else if (myState == States.custodian_0_item_4_2) {
			state_custodian_0_item_4_2();
		} else if (myState == States.custodian_0_item_4_3) {
			state_custodian_0_item_4_3();
		} else if (myState == States.custodian_0_item_1_2_4) {
			state_custodian_0_item_1_2_4();
		} else if (myState == States.custodian_0_item_1_3_4) {
			state_custodian_0_item_1_3_4();
		} else if (myState == States.custodian_0_item_1_4_2) {
			state_custodian_0_item_1_4_2();
		} else if (myState == States.custodian_0_item_1_4_3) {
			state_custodian_0_item_1_4_3();
		} else if (myState == States.custodian_0_item_2_1_4) {
			state_custodian_0_item_2_1_4();
		} else if (myState == States.custodian_0_item_2_3_4) {
			state_custodian_0_item_2_3_4();
		} else if (myState == States.custodian_0_item_2_4_1) {
			state_custodian_0_item_2_4_1();
		} else if (myState == States.custodian_0_item_2_4_3) {
			state_custodian_0_item_2_4_3();
		} else if (myState == States.custodian_0_item_3_1_4) {
			state_custodian_0_item_3_1_4();
		} else if (myState == States.custodian_0_item_3_2_4) {
			state_custodian_0_item_3_2_4();
		} else if (myState == States.custodian_0_item_3_4_1) {
			state_custodian_0_item_3_4_1();
		} else if (myState == States.custodian_0_item_3_4_2) {
			state_custodian_0_item_3_4_2();
		} else if (myState == States.custodian_0_item_4_1_2) {
			state_custodian_0_item_4_1_2();
		} else if (myState == States.custodian_0_item_4_1_3) {
			state_custodian_0_item_4_1_3();
		} else if (myState == States.custodian_0_item_4_2_1) {
			state_custodian_0_item_4_2_1();
		} else if (myState == States.custodian_0_item_4_2_3) {
			state_custodian_0_item_4_2_3();
		} else if (myState == States.custodian_0_item_4_3_1) {
			state_custodian_0_item_4_3_1();
		} else if (myState == States.custodian_0_item_4_3_2) {
			state_custodian_0_item_4_3_2();
		} else if (myState == States.use_item_4) {
			state_use_item_4();
		} else if (myState == States.keys_0) {
			state_keys_0();
		} else if (myState == States.custodian_1) {
			state_custodian_1();
		} else if (myState == States.keys_1) {
			state_keys_1();
		} else if (myState == States.game_over_1) {
			state_game_over_1();
		} else if (myState == States.closet_1) {
			state_closet_1();
		} else if (myState == States.lock_5) {
			state_lock_5();
		} else if (myState == States.uniform_0) {
			state_uniform_0();
		} else if (myState == States.court_0) {
			state_court_0();
		} else if (myState == States.gate_0) {
			state_gate_0();
		} else if (myState == States.game_over_2) {
			state_game_over_2();
		} else if (myState == States.freedom) {
			state_freedom();
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
						"Press 1 to grab the Lighter, Press 2 to grab the Flaslight, Press 3 to grab the Screwdriver, " +
						"and Press 4 to grab the Brass knuckles!";
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
			text.text = "You choose to pick up the Lighter, without a joint? " +
						"The room is still quiet. You figure you can grab another item for insurance. " +
						"You double check your mirror to be safe. \n\n" +
						"Press 2 to grab the Flaslight, Press 3 to grab the Screwdriver, Press 4 to grab the Brass knuckles, " +
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
		
		void state_selection_1_item_2 () {
			text.text = "You choose to pick up the Flashlight, wise choice! " +
						"The room is still quiet. You figure you can grab another item for insurance. " +
						"You double check your mirror to be safe. \n\n" +
						"Press 1 to grab the Lighter, Press 3 to grab the Screwdriver, Press 4 to grab the Brass knuckles, " +
						"or Press R to return to the corridor!";
		if (Input.GetKeyDown(KeyCode.Alpha1)) {
			myState = States.selection_2_item_2_1;
		} else if (Input.GetKeyDown(KeyCode.Alpha3)) {
			myState = States.selection_2_item_2_3;
		} else if (Input.GetKeyDown(KeyCode.Alpha4)) {
			myState = States.selection_2_item_2_4; 
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2_item_2; 
		}
		}
		
		void state_selection_1_item_3 () {
			text.text = "You choose to pick up the Screwdriver, it's got a nice grip! " +
						"The room is still quiet. You figure you can grab another item for insurance. " +
						"You double check your mirror to be safe. \n\n" +
						"Press 1 to grab the Lighter, Press 2 to grab the Flashlight, Press 4 to grab the Brass knuckles, " +
						"or Press R to return to the corridor!";
		if (Input.GetKeyDown(KeyCode.Alpha1)) {
			myState = States.selection_2_item_3_1;
		} else if (Input.GetKeyDown(KeyCode.Alpha2)) {
			myState = States.selection_2_item_3_2;
		} else if (Input.GetKeyDown(KeyCode.Alpha4)) {
			myState = States.selection_2_item_3_4; 
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2_item_3; 
		}
		}
		
		void state_selection_1_item_4 () {
			text.text = "You choose to pick up the Brass knuckles, they are a perfect fit! " +
						"The room is still quiet. You figure you can grab another item for insurance. " +
						"You double check your mirror to be safe. \n\n" +
						"Press 1 to grab the Lighter, Press 2 to grab the Flashlight, Press 3 to grab the Screwdriver, " +
						"or Press R to return to the corridor!";
		if (Input.GetKeyDown(KeyCode.Alpha1)) {
			myState = States.selection_2_item_4_1;
		} else if (Input.GetKeyDown(KeyCode.Alpha2)) {
			myState = States.selection_2_item_4_2;
		} else if (Input.GetKeyDown(KeyCode.Alpha3)) {
			myState = States.selection_2_item_4_3; 
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2_item_4; 
		}
		}
		
		void state_selection_2_item_1_2 () {
			text.text = "You choose to pick up the Flashlight! " +
						"You hear soft footsteps down the hall. You check your mirror to see no one is around the corner. " +
						"However, it is too dark to see pass 20 ft. You are confident you can grab another item. \n\n" +
						"Press 3 to grab the Screwdriver, Press 4 to grab the Brass knuckles, " +
						"or Press R to return to the corridor!";
		if (Input.GetKeyDown(KeyCode.Alpha3)) {
			myState = States.selection_3_item_1_2_3;
		} else if (Input.GetKeyDown(KeyCode.Alpha4)) {
			myState = States.selection_3_item_1_2_4;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2_item_1_2; 
		}
		}
		
		void state_selection_2_item_1_3 () {
			text.text = "You choose to pick up the Screwdriver, it's sharp tip can come in handy! " +
						"You hear soft footsteps down the hall. You check your mirror to see no one is around the corner. " +
						"However, it is too dark to see pass 20 ft. You are confident you can grab another item. \n\n" +
						"Press 2 to grab the Flashlight, Press 4 to grab the Brass knuckles, " +
						"or Press R to return to the corridor!";
		if (Input.GetKeyDown(KeyCode.Alpha2)) {
			myState = States.selection_3_item_1_3_2;
		} else if (Input.GetKeyDown(KeyCode.Alpha4)) {
			myState = States.selection_3_item_1_3_4;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2_item_1_3; 
		}
		}
		
		void state_selection_2_item_1_4 () {
			text.text = "You choose to pick up the Brass knuckles, you're not going out without a fight! " +
						"You hear soft footsteps down the hall. You check your mirror to see no one is around the corner. " +
						"However, it is too dark to see pass 20 ft. You are confident you can grab another item. \n\n" +
						"Press 2 to grab the Flashlight, Press 3 to grab the Screwdriver, " +
						"or Press R to return to the corridor!";
		if (Input.GetKeyDown(KeyCode.Alpha2)) {
			myState = States.selection_3_item_1_4_2;
		} else if (Input.GetKeyDown(KeyCode.Alpha3)) {
			myState = States.selection_3_item_1_4_3;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2_item_1_4; 
		}
		}
		
		void state_selection_2_item_2_1 () {
			text.text = "You choose to pick up the Lighter, without a joint? " +
						"You hear soft footsteps down the hall. You check your mirror to see no one is around the corner. " +
						"However, it is too dark to see pass 20 ft. You are confident you can grab another item. \n\n" +
						"Press 3 to grab the Screwdriver, Press 4 to grab the Brass knuckles, " +
						"or Press R to return to the corridor!";
		if (Input.GetKeyDown(KeyCode.Alpha3)) {
			myState = States.selection_3_item_2_1_3;
		} else if (Input.GetKeyDown(KeyCode.Alpha4)) {
			myState = States.selection_3_item_2_1_4;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2_item_2_1; 
		}
		}
		
		void state_selection_2_item_2_3 () {
			text.text = "You choose to pick up the Screwdriver. You prefer a tactical style! " +
						"You hear soft footsteps down the hall. You check your mirror to see no one is around the corner. " +
						"However, it is too dark to see pass 20 ft. You are confident you can grab another item. \n\n" +
						"Press 1 to grab the Lighter, Press 4 to grab the Brass knuckles, " +
						"or Press R to return to the corridor!";
		if (Input.GetKeyDown(KeyCode.Alpha1)) {
			myState = States.selection_3_item_2_3_1;
		} else if (Input.GetKeyDown(KeyCode.Alpha4)) {
			myState = States.selection_3_item_2_3_4;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2_item_2_3; 
		}
		}
		
		void state_selection_2_item_2_4 () {
			text.text = "You choose to pick up the Brass knuckles, you plan to catch your opponent off guard! " +
						"You hear soft footsteps down the hall. You check your mirror to see no one is around the corner. " +
						"However, it is too dark to see pass 20 ft. You are confident you can grab another item. \n\n" +
						"Press 1 to grab the Lighter, Press 3 to grab the Screwdriver, " +
						"or Press R to return to the corridor!";
		if (Input.GetKeyDown(KeyCode.Alpha1)) {
			myState = States.selection_3_item_2_4_1;
		} else if (Input.GetKeyDown(KeyCode.Alpha4)) {
			myState = States.selection_3_item_2_4_3;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2_item_2_4; 
		}
		}
		
		void state_selection_2_item_3_1 () {
			text.text = "You choose to pick up the Lighter, without a joint? " +
						"You hear soft footsteps down the hall. You check your mirror to see no one is around the corner. " +
						"However, it is too dark to see pass 20 ft. You are confident you can grab another item. \n\n" +
						"Press 2 to grab the Flashlight, Press 4 to grab the Brass knuckles, " +
						"or Press R to return to the corridor!";
		if (Input.GetKeyDown(KeyCode.Alpha2)) {
			myState = States.selection_3_item_3_1_2;
		} else if (Input.GetKeyDown(KeyCode.Alpha4)) {
			myState = States.selection_3_item_3_1_4;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2_item_3_1; 
		}
		}
		
		void state_selection_2_item_3_2 () {
			text.text = "You choose to pick up the Flaslight! " +
						"You hear soft footsteps down the hall. You check your mirror to see no one is around the corner. " +
						"However, it is too dark to see pass 20 ft. You are confident you can grab another item. \n\n" +
						"Press 1 to grab the Lighter, Press 4 to grab the Brass knuckles, " +
						"or Press R to return to the corridor!";
		if (Input.GetKeyDown(KeyCode.Alpha1)) {
			myState = States.selection_3_item_3_2_1;
		} else if (Input.GetKeyDown(KeyCode.Alpha4)) {
			myState = States.selection_3_item_3_2_4;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2_item_3_2; 
		}
		}
		
		void state_selection_2_item_3_4 () {
			text.text = "You choose to pick up the Brass knuckles, so you're a brawler? " +
						"You hear soft footsteps down the hall. You check your mirror to see no one is around the corner. " +
						"However, it is too dark to see pass 20 ft. You are confident you can grab another item. \n\n" +
						"Press 1 to grab the Lighter, Press 2 to grab the Flashlight, " +
						"or Press R to return to the corridor!";
		if (Input.GetKeyDown(KeyCode.Alpha1)) {
			myState = States.selection_3_item_3_4_1;
		} else if (Input.GetKeyDown(KeyCode.Alpha2)) {
			myState = States.selection_3_item_3_4_2;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2_item_3_4; 
		}
		}
		
		void state_selection_2_item_4_1 () {
			text.text = "You choose to pick up the Lighter, without a joint? " +
						"You hear soft footsteps down the hall. You check your mirror to see no one is around the corner. " +
						"However, it is too dark to see pass 20 ft. You are confident you can grab another item. \n\n" +
						"Press 2 to grab the Flashlight, Press 3 to grab the Screwdriver, " +
						"or Press R to return to the corridor!";
		if (Input.GetKeyDown(KeyCode.Alpha2)) {
			myState = States.selection_3_item_4_1_2;
		} else if (Input.GetKeyDown(KeyCode.Alpha3)) {
			myState = States.selection_3_item_4_1_3;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2_item_4_1; 
		}
		}
		
		void state_selection_2_item_4_2 () {
			text.text = "You choose to pick up the Flashlight, better to dodge a fight! " +
						"You hear soft footsteps down the hall. You check your mirror to see no one is around the corner. " +
						"However, it is too dark to see pass 20 ft. You are confident you can grab another item. \n\n" +
						"Press 1 to grab the Lighter, Press 3 to grab the Screwdriver, " +
						"or Press R to return to the corridor!";
		if (Input.GetKeyDown(KeyCode.Alpha1)) {
			myState = States.selection_3_item_4_2_1;
		} else if (Input.GetKeyDown(KeyCode.Alpha3)) {
			myState = States.selection_3_item_4_2_3;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2_item_4_2; 
		}
		}
		
		void state_selection_2_item_4_3 () {
			text.text = "You choose to pick up the Screwdriver, you prefer to end it quick! " +
						"You hear soft footsteps down the hall. You check your mirror to see no one is around the corner. " +
						"However, it is too dark to see pass 20 ft. You are confident you can grab another item. \n\n" +
						"Press 1 to grab the Lighter, Press 2 to grab the Flashlight, " +
						"or Press R to return to the corridor!";
		if (Input.GetKeyDown(KeyCode.Alpha1)) {
			myState = States.selection_3_item_4_3_1;
		} else if (Input.GetKeyDown(KeyCode.Alpha2)) {
			myState = States.selection_3_item_4_3_2;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2_item_4_3; 
		}
		}
		
		void state_selection_3_item_1_2_3 () {
			text.text = "You choose to pick up the Screwdriver, better to have it and not need it. " +
						"You hear footsteps growing louder down the hall. Your adrenaline starts pumping. " +
						"You are not sure if you can grab another item and escape. \n\n" +
						"Press 4 to grab the Brass knuckles, " +
						"or Press R to return to the corridor!";
		if (Input.GetKeyDown(KeyCode.Alpha4)) {
			myState = States.game_over_0;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2_item_1_2_3; 
		}
		}
		
		void state_selection_3_item_1_2_4 () {
			text.text = "You choose to pick up the Brass knuckles, better to have it and not need it. " +
						"You hear footsteps growing louder down the hall. Your adrenaline starts pumping. " +
						"You are not sure if you can grab another item and escape. \n\n" +
						"Press 3 to grab the Screwdriver, " +
						"or Press R to return to the corridor!";
		if (Input.GetKeyDown(KeyCode.Alpha3)) {
			myState = States.game_over_0;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2_item_1_2_4; 
		}
		}
		
		void state_selection_3_item_1_3_2 () {
			text.text = "You choose to pick up the Flashlight, you prefer a tactical style! " +
						"You hear footsteps growing louder down the hall. Your adrenaline starts pumping. " +
						"You are not sure if you can grab another item and escape. \n\n" +
						"Press 4 to grab the Brass knuckles, " +
						"or Press R to return to the corridor!";
		if (Input.GetKeyDown(KeyCode.Alpha4)) {
			myState = States.game_over_0;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2_item_1_3_2; 
		}
		}
		
		void state_selection_3_item_1_3_4 () {
			text.text = "You choose to pick up the Brass knuckles, you like to take care of things up close and personal! " +
						"You hear footsteps growing louder down the hall. Your adrenaline starts pumping. " +
						"You are not sure if you can grab another item and escape. \n\n" +
						"Press 2 to grab the Flashlight, " +
						"or Press R to return to the corridor!";
		if (Input.GetKeyDown(KeyCode.Alpha2)) {
			myState = States.game_over_0;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2_item_1_3_4; 
		}
		}
		
		void state_selection_3_item_1_4_2 () {
			text.text = "You choose to pick up the Flashlight, easier to grip one hand and swing with the other. " +
						"You hear footsteps growing louder down the hall. Your adrenaline starts pumping. " +
						"You are not sure if you can grab another item and escape. \n\n" +
						"Press 3 to grab the Screwdriver, " +
						"or Press R to return to the corridor!";
		if (Input.GetKeyDown(KeyCode.Alpha3)) {
			myState = States.game_over_0;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2_item_1_4_2; 
		}
		}
		
		void state_selection_3_item_1_4_3 () {
			text.text = "You choose to pick up the Screwdriver, maybe to quickly end a fight? " +
						"You hear footsteps growing louder down the hall. Your adrenaline starts pumping. " +
						"You are not sure if you can grab another item and escape. \n\n" +
						"Press 2 to grab the Flashlight, " +
						"or Press R to return to the corridor!";
		if (Input.GetKeyDown(KeyCode.Alpha2)) {
			myState = States.game_over_0;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2_item_1_4_3; 
		}
		}
		
		void state_selection_3_item_2_1_3 () {
			text.text = "You choose to pick up the Screwdriver, better to have it and not need it. " +
						"You hear footsteps growing louder down the hall. Your adrenaline starts pumping. " +
						"You are not sure if you can grab another item and escape. \n\n" +
						"Press 4 to grab the Brass knuckles, " +
						"or Press R to return to the corridor!";
		if (Input.GetKeyDown(KeyCode.Alpha4)) {
			myState = States.game_over_0;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2_item_2_1_3; 
		}
		}
		
		void state_selection_3_item_2_1_4 () {
			text.text = "You choose to pick up the Brass knuckles, better to have it and not need it. " +
						"You hear footsteps growing louder down the hall. Your adrenaline starts pumping. " +
						"You are not sure if you can grab another item and escape. \n\n" +
						"Press 3 to grab the Screwdriver, " +
						"or Press R to return to the corridor!";
		if (Input.GetKeyDown(KeyCode.Alpha3)) {
			myState = States.game_over_0;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2_item_2_1_4; 
		}
		}
		
		void state_selection_3_item_2_3_1 () {
			text.text = "You choose to pick up the Lighter, without having a joint? " +
						"You hear footsteps growing louder down the hall. Your adrenaline starts pumping. " +
						"You are not sure if you can grab another item and escape. \n\n" +
						"Press 4 to grab the Brass knuckles, " +
						"or Press R to return to the corridor!";
		if (Input.GetKeyDown(KeyCode.Alpha4)) {
			myState = States.game_over_0;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2_item_2_3_1; 
		}
		}
		
		void state_selection_3_item_2_3_4 () {
			text.text = "You choose to pick up the Brass knuckles, better to have it and not need it. " +
						"You hear footsteps growing louder down the hall. Your adrenaline starts pumping. " +
						"You are not sure if you can grab another item and escape. \n\n" +
						"Press 1 to grab the Lighter, " +
						"or Press R to return to the corridor!";
		if (Input.GetKeyDown(KeyCode.Alpha1)) {
			myState = States.game_over_0;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2_item_2_3_4; 
		}
		}
		
		void state_selection_3_item_2_4_1 () {
			text.text = "You choose to pick up the Lighter, without having a joint? " +
						"You hear footsteps growing louder down the hall. Your adrenaline starts pumping. " +
						"You are not sure if you can grab another item and escape. \n\n" +
						"Press 3 to grab the Screwdriver, " +
						"or Press R to return to the corridor!";
		if (Input.GetKeyDown(KeyCode.Alpha3)) {
			myState = States.game_over_0;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2_item_2_4_1; 
		}
		}
		
		void state_selection_3_item_2_4_3 () {
			text.text = "You choose to pick up the Screwdriver, don't want to get your fist dirty. " +
						"You hear footsteps growing louder down the hall. Your adrenaline starts pumping. " +
						"You are not sure if you can grab another item and escape. \n\n" +
						"Press 1 to grab the Lighter, " +
						"or Press R to return to the corridor!";
		if (Input.GetKeyDown(KeyCode.Alpha1)) {
			myState = States.game_over_0;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2_item_2_4_3; 
		}
		}
		
		void state_selection_3_item_3_1_2 () {
			text.text = "You choose to pick up the Flashlight! " +
						"You hear footsteps growing louder down the hall. Your adrenaline starts pumping. " +
						"You are not sure if you can grab another item and escape. \n\n" +
						"Press 4 to grab the Brass knuckles, " +
						"or Press R to return to the corridor!";
		if (Input.GetKeyDown(KeyCode.Alpha4)) {
			myState = States.game_over_0;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2_item_3_1_2; 
		}
		}
		
		void state_selection_3_item_3_1_4 () {
			text.text = "You choose to pick up the Brass knuckles, they won't see you coming. " +
						"You hear footsteps growing louder down the hall. Your adrenaline starts pumping. " +
						"You are not sure if you can grab another item and escape. \n\n" +
						"Press 2 to grab the Flashlight, " +
						"or Press R to return to the corridor!";
		if (Input.GetKeyDown(KeyCode.Alpha2)) {
			myState = States.game_over_0;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2_item_3_1_4; 
		}
		}
		
		void state_selection_3_item_3_2_1 () {
			text.text = "You choose to pick up the Lighter! " +
						"You hear footsteps growing louder down the hall. Your adrenaline starts pumping. " +
						"You are not sure if you can grab another item and escape. \n\n" +
						"Press 4 to grab the Brass knuckles, " +
						"or Press R to return to the corridor!";
		if (Input.GetKeyDown(KeyCode.Alpha4)) {
			myState = States.game_over_0;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2_item_3_2_1; 
		}
		}
		
		void state_selection_3_item_3_2_4 () {
			text.text = "You choose to pick up the Brass knuckles, you don't mind getting your hands dirty. " +
						"You hear footsteps growing louder down the hall. Your adrenaline starts pumping. " +
						"You are not sure if you can grab another item and escape. \n\n" +
						"Press 1 to grab the Lighter, " +
						"or Press R to return to the corridor!";
		if (Input.GetKeyDown(KeyCode.Alpha1)) {
			myState = States.game_over_0;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2_item_3_2_4; 
		}
		}
		
		void state_selection_3_item_3_4_1 () {
			text.text = "You choose to pick up the Lighter! " +
						"You hear footsteps growing louder down the hall. Your adrenaline starts pumping. " +
						"You are not sure if you can grab another item and escape. \n\n" +
						"Press 2 to grab the Flashlight, " +
						"or Press R to return to the corridor!";
		if (Input.GetKeyDown(KeyCode.Alpha2)) {
			myState = States.game_over_0;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2_item_3_4_1; 
		}
		}
		
		void state_selection_3_item_3_4_2 () {
			text.text = "You choose to pick up the Flashlight! " +
						"You hear footsteps growing louder down the hall. Your adrenaline starts pumping. " +
						"You are not sure if you can grab another item and escape. \n\n" +
						"Press 1 to grab the Lighter, " +
						"or Press R to return to the corridor!";
		if (Input.GetKeyDown(KeyCode.Alpha1)) {
			myState = States.game_over_0;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2_item_3_4_2; 
		}
		}
		
		void state_selection_3_item_4_1_2 () {
			text.text = "You choose to pick up the Flashlight! " +
						"You hear footsteps growing louder down the hall. Your adrenaline starts pumping. " +
						"You are not sure if you can grab another item and escape. \n\n" +
						"Press 3 to grab the Screwdriver, " +
						"or Press R to return to the corridor!";
		if (Input.GetKeyDown(KeyCode.Alpha3)) {
			myState = States.game_over_0;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2_item_4_1_2; 
		}
		}
		
		void state_selection_3_item_4_1_3 () {
			text.text = "You choose to pick up the Screwdriver! " +
						"You hear footsteps growing louder down the hall. Your adrenaline starts pumping. " +
						"You are not sure if you can grab another item and escape. \n\n" +
						"Press 2 to grab the Flashlight, " +
						"or Press R to return to the corridor!";
		if (Input.GetKeyDown(KeyCode.Alpha2)) {
			myState = States.game_over_0;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2_item_4_1_3; 
		}
		}
		
		void state_selection_3_item_4_2_1 () {
			text.text = "You choose to pick up the Lighter! " +
						"You hear footsteps growing louder down the hall. Your adrenaline starts pumping. " +
						"You are not sure if you can grab another item and escape. \n\n" +
						"Press 3 to grab the Screwdriver, " +
						"or Press R to return to the corridor!";
		if (Input.GetKeyDown(KeyCode.Alpha3)) {
			myState = States.game_over_0;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2_item_4_2_1; 
		}
		}
		
		void state_selection_3_item_4_2_3 () {
			text.text = "You choose to pick up the Screwdriver! " +
						"You hear footsteps growing louder down the hall. Your adrenaline starts pumping. " +
						"You are not sure if you can grab another item and escape. \n\n" +
						"Press 1 to grab the Lighter, " +
						"or Press R to return to the corridor!";
		if (Input.GetKeyDown(KeyCode.Alpha1)) {
			myState = States.game_over_0;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2_item_4_2_3; 
		}
		}
		
		void state_selection_3_item_4_3_1 () {
			text.text = "You choose to pick up the Lighter! " +
						"You hear footsteps growing louder down the hall. Your adrenaline starts pumping. " +
						"You are not sure if you can grab another item and escape. \n\n" +
						"Press 2 to grab the Flashlight, " +
						"or Press R to return to the corridor!";
		if (Input.GetKeyDown(KeyCode.Alpha2)) {
			myState = States.game_over_0;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2_item_4_3_1; 
		}
		}
		
		void state_selection_3_item_4_3_2 () {
			text.text = "You choose to pick up the Flashlight! " +
						"You hear footsteps growing louder down the hall. Your adrenaline starts pumping. " +
						"You are not sure if you can grab another item and escape. \n\n" +
						"Press 1 to grab the Lighter, " +
						"or Press R to return to the corridor!";
		if (Input.GetKeyDown(KeyCode.Alpha1)) {
			myState = States.game_over_0;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2_item_4_3_2; 
		}
		}
		
		void state_game_over_0 () {
			text.text = "You decided to pick up the last item in the storage but the guards rush in around the corner. " +
						"You are detained and sent back to your cell. " +
						"You lost your chance to escape the Booty Warrior. \n\n" +
						"GAME OVER! Press P to play again!";
		if (Input.GetKeyDown(KeyCode.P)) {
			myState = States.cell;
		} 
		}
		
		void state_corridor_2_item_1 () {
			text.text = "You managed to escape the guards who were creeping around the halls. " +
						"It's too dangerous to go back to the storage. What are you planning to do with a Lighter and no joint? " +
						"Oh well, you have to move forward before the guards come back. \n\n" +
						"Press D to go to the Stairs!";
		 if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_2_item_1; 
		}
		}
		
		void state_corridor_2_item_2 () {
			text.text = "You managed to escape the guards who were creeping around the halls. " +
						"It's too dangerous to go back. Are your sure a flashlight is enough? " +
						"Oh well, you have to move forward before the guards come back. \n\n" +
						"Press D to go to the Stairs!";
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_2_item_2; 
		}
		}
		
		void state_corridor_2_item_3 () {
			text.text = "You managed to escape the guards who were creeping around the halls. " +
						"It's too dangerous to go back. What are you going to do with a screwdriver and no light? " +
						"Oh well, you have to move forward before the guards come back. \n\n" +
						"Press D to go to the Stairs!";
		 if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_2_item_3; 
		}
		}
		
		void state_corridor_2_item_4 () {
			text.text = "You managed to escape the guards who were creeping around the halls. " +
						"It's too dangerous to go back, those golden rings can only do so much. " +
						"Oh well, you have to move forward before the guards come back. \n\n" +
						"Press D to go to the Stairs!";
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_2_item_4; 
		}
		}
		
		void state_corridor_2_item_1_2 () {
			text.text = "You managed to escape the guards who were around the corner. " +
						"It's too dangerous to go back, you couldn't grab a weapon? " +
						"Oh well, you have to move forward before the guards come back. \n\n" +
						"Press D to go to the Stairs!";
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_2_item_1_2; 
		}
		}
		
		void state_corridor_2_item_1_3 () {
			text.text = "You managed to escape the guards who were around the corner. " +
						"You could have shanked a guard but you played it safe. " +
						"Great job, now you have to move forward before the guards come back. \n\n" +
						"Press D to go to the Stairs!";
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_2_item_1_3; 
		}
		}
		
		void state_corridor_2_item_1_4 () {
			text.text = "You managed to escape the guards who were around the corner. " +
						"You could have knocked one of them out for the hell of it, but you played it cool. " +
						"You have to move forward before the guards come back. \n\n" +
						"Press D to go to the Stairs!";
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_2_item_1_4; 
		}
		}
		
		void state_corridor_2_item_2_1 () {
			text.text = "You managed to escape the guards who were around the corner. " +
						"You should have grabbed a weapon when you had the chance! " +
						"Oh well, you have to move forward before the guards come back. \n\n" +
						"Press D to go to the Stairs!";
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_2_item_2_1; 
		}
		}
		
		void state_corridor_2_item_2_3 () {
			text.text = "You managed to escape the guards who were around the corner. " +
						"You could have shanked a guard, but you played it safe. " +
						"Great job, now you have to move forward before the guards come back. \n\n" +
						"Press D to go to the Stairs!";
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_2_item_2_3; 
		}
		}
		
		void state_corridor_2_item_2_4 () {
			text.text = "You managed to escape the guards who were around the corner. " +
						"You could have knocked out a guard, but you played it safe. " +
						"Good job, now you have to move forward before the guards come back. \n\n" +
						"Press D to go to the Stairs!";
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_2_item_2_4; 
		}
		}
		
		void state_corridor_2_item_3_1 () {
			text.text = "You managed to escape the guards who were around the corner. " +
						"You could have shanked a guard, but you played it safe. " +
						"Great job, now you have to move forward before the guards come back. \n\n" +
						"Press D to go to the Stairs!";
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_2_item_3_1; 
		}
		}
		
		void state_corridor_2_item_3_2 () {
			text.text = "You managed to escape the guards who were around the corner. " +
						"You could have shanked a guard, but you played it safe. " +
						"Great job, now you have to move forward before the guards come back. \n\n" +
						"Press D to go to the Stairs!";
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_2_item_3_2; 
		}
		}
		
		void state_corridor_2_item_3_4 () {
			text.text = "You managed to escape the guards who were around the corner. " +
						"You could have shanked a guard, but you played it safe. " +
						"Great job, now you have to move forward before the guards come back. \n\n" +
						"Press D to go to the Stairs!";
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_2_item_3_4; 
		}
		}
		
		void state_corridor_2_item_4_1 () {
			text.text = "You managed to escape the guards who were around the corner. " +
						"You could have knocked out a guard, but you played it safe. " +
						"Good job, now you have to move forward before the guards come back. \n\n" +
						"Press D to go to the Stairs!";
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_2_item_4_1; 
		}
		}
		
		void state_corridor_2_item_4_2 () {
			text.text = "You managed to escape the guards who were around the corner. " +
						"You could have knocked out a guard, but you played it safe. " +
						"Good job, now you have to move forward before the guards come back. \n\n" +
						"Press D to go to the Stairs!";
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_2_item_4_2; 
		}
		}
		
		void state_corridor_2_item_4_3 () {
			text.text = "You managed to escape the guards who were around the corner. " +
						"You could have shanked a guard, but you played it safe. " +
						"Great job, now you have to move forward before the guards come back. \n\n" +
						"Press D to go to the Stairs!";
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_2_item_4_3; 
		}
		}
		
		void state_corridor_2_item_1_2_3 () {
			text.text = "You managed to narrowly escape the guards who were around the corner. " +
						"You could have shanked a guard, but you played it safe. " +
						"Great job, now you have to move forward before the guards come back. \n\n" +
						"Press D to go to the Stairs!";
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_2_item_1_2_3; 
		}
		}
		
		void state_corridor_2_item_1_2_4 () {
			text.text = "You managed to narrowly escape the guards who were around the corner. " +
						"You could have knocked out a guard, but you played it safe. " +
						"Great job, now you have to move forward before the guards come back. \n\n" +
						"Press D to go to the Stairs!";
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_2_item_1_2_4; 
		}
		}
		
		void state_corridor_2_item_1_3_2 () {
			text.text = "You managed to narrowly escape the guards who were around the corner. " +
						"You could have shanked a guard, but you played it safe. " +
						"Great job, now you have to move forward before the guards come back. \n\n" +
						"Press D to go to the Stairs!";
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_2_item_1_3_2; 
		}
		}
		
		void state_corridor_2_item_1_3_4 () {
			text.text = "You managed to narrowly escape the guards who were around the corner. " +
						"You could have shanked a guard, but you played it safe. " +
						"Great job, now you have to move forward before the guards come back. \n\n" +
						"Press D to go to the Stairs!";
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_2_item_1_3_4; 
		}
		}
		
		void state_corridor_2_item_1_4_2 () {
			text.text = "You managed to narrowly escape the guards who were around the corner. " +
						"You could have knocked out a guard, but you played it safe. " +
						"Great job, now you have to move forward before the guards come back. \n\n" +
						"Press D to go to the Stairs!";
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_2_item_1_4_2; 
		}
		}
		
		void state_corridor_2_item_1_4_3 () {
			text.text = "You managed to narrowly escape the guards who were around the corner. " +
						"You could have shanked a guard, but you played it safe. " +
						"Great job, now you have to move forward before the guards come back. \n\n" +
						"Press D to go to the Stairs!";
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_2_item_1_4_3; 
		}
		}
		
		void state_corridor_2_item_2_1_3 () {
			text.text = "You managed to narrowly escape the guards who were around the corner. " +
						"You could have shanked a guard, but you played it safe. " +
						"Great job, now you have to move forward before the guards come back. \n\n" +
						"Press D to go to the Stairs!";
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_2_item_2_1_3; 
		}
		}
		
		void state_corridor_2_item_2_1_4 () {
			text.text = "You managed to narrowly escape the guards who were around the corner. " +
						"You could have knocked out a guard, but you played it safe. " +
						"Great job, now you have to move forward before the guards come back. \n\n" +
						"Press D to go to the Stairs!";
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_2_item_2_1_4; 
		}
		}
		
		void state_corridor_2_item_2_3_1 () {
			text.text = "You managed to narrowly escape the guards who were around the corner. " +
						"You could have shanked a guard, but you played it safe. " +
						"Great job, now you have to move forward before the guards come back. \n\n" +
						"Press D to go to the Stairs!";
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_2_item_2_3_1; 
		}
		}
		
		void state_corridor_2_item_2_3_4 () {
			text.text = "You managed to narrowly escape the guards who were around the corner. " +
						"You could have shanked a guard, but you played it safe. " +
						"Great job, now you have to move forward before the guards come back. \n\n" +
						"Press D to go to the Stairs!";
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_2_item_2_3_4; 
		}
		}
		
		void state_corridor_2_item_2_4_1 () {
			text.text = "You managed to narrowly escape the guards who were around the corner. " +
						"You could have knocked out a guard, but you played it safe. " +
						"Great job, now you have to move forward before the guards come back. \n\n" +
						"Press D to go to the Stairs!";
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_2_item_2_4_1; 
		}
		}
		
		void state_corridor_2_item_2_4_3 () {
			text.text = "You managed to narrowly escape the guards who were around the corner. " +
						"You could have shanked a guard, but you played it safe. " +
						"Great job, now you have to move forward before the guards come back. \n\n" +
						"Press D to go to the Stairs!";
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_2_item_2_4_3; 
		}
		}
		
		void state_corridor_2_item_3_1_2 () {
			text.text = "You managed to narrowly escape the guards who were around the corner. " +
						"You could have shanked a guard, but you played it safe. " +
						"Great job, now you have to move forward before the guards come back. \n\n" +
						"Press D to go to the Stairs!";
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_2_item_3_1_2; 
		}
		}
		
		void state_corridor_2_item_3_1_4 () {
			text.text = "You managed to narrowly escape the guards who were around the corner. " +
						"You could have shanked a guard, but you played it safe. " +
						"Great job, now you have to move forward before the guards come back. \n\n" +
						"Press D to go to the Stairs!";
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_2_item_3_1_4; 
		}
		}
		
		void state_corridor_2_item_3_2_1 () {
			text.text = "You managed to narrowly escape the guards who were around the corner. " +
						"You could have shanked a guard, but you played it safe. " +
						"Great job, now you have to move forward before the guards come back. \n\n" +
						"Press D to go to the Stairs!";
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_2_item_3_2_1; 
		}
		}
		
		void state_corridor_2_item_3_2_4 () {
			text.text = "You managed to narrowly escape the guards who were around the corner. " +
						"You could have shanked a guard, but you played it safe. " +
						"Great job, now you have to move forward before the guards come back. \n\n" +
						"Press D to go to the Stairs!";
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_2_item_3_2_4; 
		}
		}
		
		void state_corridor_2_item_3_4_1 () {
			text.text = "You managed to narrowly escape the guards who were around the corner. " +
						"You could have shanked a guard, but you played it safe. " +
						"Great job, now you have to move forward before the guards come back. \n\n" +
						"Press D to go to the Stairs!";
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_2_item_3_4_1; 
		}
		}
		
		void state_corridor_2_item_3_4_2 () {
			text.text = "You managed to narrowly escape the guards who were around the corner. " +
						"You could have shanked a guard, but you played it safe. " +
						"Great job, now you have to move forward before the guards come back. \n\n" +
						"Press D to go to the Stairs!";
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_2_item_3_4_2; 
		}
		}
		
		void state_corridor_2_item_4_1_2 () {
			text.text = "You managed to narrowly escape the guards who were around the corner. " +
						"You could have knocked out a guard, but you played it safe. " +
						"Great job, now you have to move forward before the guards come back. \n\n" +
						"Press D to go to the Stairs!";
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_2_item_4_1_2; 
		}
		}
		
		void state_corridor_2_item_4_1_3 () {
			text.text = "You managed to narrowly escape the guards who were around the corner. " +
						"You could have shanked a guard, but you played it safe. " +
						"Great job, now you have to move forward before the guards come back. \n\n" +
						"Press D to go to the Stairs!";
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_2_item_4_1_3; 
		}
		}
		
		void state_corridor_2_item_4_2_1 () {
			text.text = "You managed to narrowly escape the guards who were around the corner. " +
						"You could have knocked out a guard, but you played it safe. " +
						"Great job, now you have to move forward before the guards come back. \n\n" +
						"Press D to go to the Stairs!";
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_2_item_4_2_1; 
		}
		}
		
		void state_corridor_2_item_4_2_3 () {
			text.text = "You managed to narrowly escape the guards who were around the corner. " +
						"You could have shanked a guard, but you played it safe. " +
						"Great job, now you have to move forward before the guards come back. \n\n" +
						"Press D to go to the Stairs!";
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_2_item_4_2_3; 
		}
		}
		
		void state_corridor_2_item_4_3_1 () {
			text.text = "You managed to narrowly escape the guards who were around the corner. " +
						"You could have shanked a guard, but you played it safe. " +
						"Great job, now you have to move forward before the guards come back. \n\n" +
						"Press D to go to the Stairs!";
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_2_item_4_3_1; 
		}
		}
		
		void state_corridor_2_item_4_3_2 () {
			text.text = "You managed to narrowly escape the guards who were around the corner. " +
						"You could have shanked a guard, but you played it safe. " +
						"Great job, now you have to move forward before the guards come back. \n\n" +
						"Press D to go to the Stairs!";
		if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.stairs_2_item_4_3_2; 
		}
		}
		
		void state_stairs_2_item_1 () {
			text.text = "You approached the stairs overwhelming with darkness. " +
						"You have a fully functional Lighter at your disposal. " +
						"You are able to clear a portion of the shadow using the Lighter. \n\n" +
						"Press U to use the Lighter!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.stairs_3_item_1; 
		}
		}
		
		void state_stairs_2_item_2 () {
			text.text = "You approached the stairs overwhelming with darkness. " +
						"You have a fully functional Flashlight at your disposal. " +
						"You are able to clear a portion of the shadow using the Flashlight. \n\n" +
						"Press U to use the Flashlight!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.stairs_3_item_2; 
		}
		}
		
		void state_stairs_2_item_3 () {
			text.text = "You approached the stairs overwhelming with darkness. " +
						"You have a sharp Screwdriver at your disposal. " +
						"You feel confident to continue down the stairs. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.stairs_3_item_3; 
		}
		}
		
		void state_stairs_2_item_4 () {
			text.text = "You approached the stairs overwhelming with darkness. " +
						"You have a shiny pair of Brass knuckles at your disposal. " +
						"You feel confident to continue down the stairs. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.stairs_3_item_4; 
		}
		}
		
		void state_stairs_2_item_1_2 () {
			text.text = "You approached the stairs overwhelming with darkness. " +
						"You have a fully functional Lighter and Flashlight at your disposal. " +
						"You are able to clear the shadow using a Lighter or a Flashlight. \n\n" +
						"Press L to use the Lighter, or Press F to use the Flashlight!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.stairs_3_item_1_2a; 
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.stairs_3_item_1_2b; 
		}
		}
		
		void state_stairs_2_item_1_3 () {
			text.text = "You approached the stairs overwhelming with darkness. " +
						"You have a fully functional Lighter at your disposal. " +
						"You are able to clear a portion of the shadow using the Lighter. \n\n" +
						"Press U to use the Lighter!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.stairs_3_item_1_3; 
		}
		}
		
		void state_stairs_2_item_1_4 () {
			text.text = "You approached the stairs overwhelming with darkness. " +
						"You have a fully functional Lighter at your disposal. " +
						"You are able to clear a portion of the shadow using the Lighter. \n\n" +
						"Press U to use the Lighter!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.stairs_3_item_1_4; 
		}
		}
		
		void state_stairs_2_item_2_1 () {
			text.text = "You approached the stairs overwhelming with darkness. " +
						"You have a fully functional Lighter and Flashlight at your disposal. " +
						"You are able to clear the shadow using a Lighter or a Flashlight. \n\n" +
						"Press L to use the Lighter, or Press F to use the Flashlight!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.stairs_3_item_2_1a; 
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.stairs_3_item_2_1b; 
		}
		}
		
		void state_stairs_2_item_2_3 () {
			text.text = "You approached the stairs overwhelming with darkness. " +
						"You have a fully functional Flashlight at your disposal. " +
						"You are able to clear a portion of the shadow using the Flashlight. \n\n" +
						"Press U to use the Flashlight!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.stairs_3_item_2_3; 
		}
		}
		
		void state_stairs_2_item_2_4 () {
			text.text = "You approached the stairs overwhelming with darkness. " +
						"You have a fully functional Flashlight at your disposal. " +
						"You are able to clear a portion of the shadow using the Flashlight. \n\n" +
						"Press U to use the Flashlight!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.stairs_3_item_2_4; 
		}
		}
		
		void state_stairs_2_item_3_1 () {
			text.text = "You approached the stairs overwhelming with darkness. " +
						"You have a fully functional Lighter at your disposal. " +
						"You are able to clear a portion of the shadow using the Lighter. \n\n" +
						"Press U to use the Lighter!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.stairs_3_item_3_1; 
		}
		}
		
		void state_stairs_2_item_3_2 () {
			text.text = "You approached the stairs overwhelming with darkness. " +
						"You have a fully functional Flashlight at your disposal. " +
						"You are able to clear a portion of the shadow using the Flashlight. \n\n" +
						"Press U to use the Flashlight!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.stairs_3_item_3_2; 
		}
		}
		
		void state_stairs_2_item_3_4 () {
			text.text = "You approached the stairs overwhelming with darkness. " +
						"You have a sharp Screwdriver and shiny Brass knuckles at your disposal. " +
						"You feel confident to continue down the stairs. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.stairs_3_item_3_4; 
		}
		}
		
		void state_stairs_2_item_4_1 () {
			text.text = "You approached the stairs overwhelming with darkness. " +
						"You have a fully functional Lighter at your disposal. " +
						"You are able to clear a portion of the shadow using the Lighter. \n\n" +
						"Press U to use the Lighter!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.stairs_3_item_4_1; 
		}
		}
		
		void state_stairs_2_item_4_2 () {
			text.text = "You approached the stairs overwhelming with darkness. " +
						"You have a fully functional Flashlight at your disposal. " +
						"You are able to clear a portion of the shadow using the Flashlight. \n\n" +
						"Press U to use the Flashlight!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.stairs_3_item_4_2; 
		}
		}
		
		void state_stairs_2_item_4_3 () {
			text.text = "You approached the stairs overwhelming with darkness. " +
						"You have a sharp Screwdriver and shiny Brass knuckles at your disposal. " +
						"You feel confident to continue down the stairs. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.stairs_3_item_4_3; 
		}
		}
		
		void state_stairs_2_item_1_2_3 () {
			text.text = "You approached the stairs overwhelming with darkness. " +
						"You have a fully functional Lighter and Flashlight at your disposal. " +
						"You are able to clear the shadow using a Lighter or a Flashlight. \n\n" +
						"Press L to use the Lighter, or Press F to use the Flashlight!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.stairs_3_item_1_2_3a; 
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.stairs_3_item_1_2_3b; 
		}
		}
		
		void state_stairs_2_item_1_2_4 () {
			text.text = "You approached the stairs overwhelming with darkness. " +
						"You have a fully functional Lighter and Flashlight at your disposal. " +
						"You are able to clear the shadow using a Lighter or a Flashlight. \n\n" +
						"Press L to use the Lighter, or Press F to use the Flashlight!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.stairs_3_item_1_2_4a; 
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.stairs_3_item_1_2_4b; 
		}
		}
		
		void state_stairs_2_item_1_3_2 () {
			text.text = "You approached the stairs overwhelming with darkness. " +
						"You have a fully functional Lighter and Flashlight at your disposal. " +
						"You are able to clear the shadow using a Lighter or a Flashlight. \n\n" +
						"Press L to use the Lighter, or Press F to use the Flashlight!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.stairs_3_item_1_3_2a; 
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.stairs_3_item_1_3_2b; 
		}
		}
		
		void state_stairs_2_item_1_3_4 () {
			text.text = "You approached the stairs overwhelming with darkness. " +
						"You have a fully functional Lighter at your disposal. " +
						"You are able to clear a portion of the shadow using the Lighter. \n\n" +
						"Press U to use the Lighter!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.stairs_3_item_1_3_4; 
		}
		}
		
		void state_stairs_2_item_1_4_2 () {
			text.text = "You approached the stairs overwhelming with darkness. " +
						"You have a fully functional Lighter and Flashlight at your disposal. " +
						"You are able to clear the shadow using a Lighter or a Flashlight. \n\n" +
						"Press L to use the Lighter, or Press F to use the Flashlight!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.stairs_3_item_1_4_2a; 
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.stairs_3_item_1_4_2b; 
		}
		}
		
		void state_stairs_2_item_1_4_3 () {
			text.text = "You approached the stairs overwhelming with darkness. " +
						"You have a fully functional Lighter at your disposal. " +
						"You are able to clear a portion of the shadow using the Lighter. \n\n" +
						"Press U to use the Lighter!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.stairs_3_item_1_4_3; 
		}
		}
		
		void state_stairs_2_item_2_1_3 () {
			text.text = "You approached the stairs overwhelming with darkness. " +
						"You have a fully functional Lighter and Flashlight at your disposal. " +
						"You are able to clear the shadow using a Lighter or a Flashlight. \n\n" +
						"Press L to use the Lighter, or Press F to use the Flashlight!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.stairs_3_item_2_1_3a; 
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.stairs_3_item_2_1_3b; 
		}
		}
		
		void state_stairs_2_item_2_1_4 () {
			text.text = "You approached the stairs overwhelming with darkness. " +
						"You have a fully functional Lighter and Flashlight at your disposal. " +
						"You are able to clear the shadow using a Lighter or a Flashlight. \n\n" +
						"Press L to use the Lighter, or Press F to use the Flashlight!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.stairs_3_item_2_1_4a; 
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.stairs_3_item_2_1_4b; 
		}
		}
		
		void state_stairs_2_item_2_3_1 () {
			text.text = "You approached the stairs overwhelming with darkness. " +
						"You have a fully functional Lighter and Flashlight at your disposal. " +
						"You are able to clear the shadow using a Lighter or a Flashlight. \n\n" +
						"Press L to use the Lighter, or Press F to use the Flashlight!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.stairs_3_item_2_3_1a; 
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.stairs_3_item_2_3_1b; 
		}
		}
		
		void state_stairs_2_item_2_3_4 () {
			text.text = "You approached the stairs overwhelming with darkness. " +
						"You have a fully functional Lighter at your disposal. " +
						"You are able to clear a portion of the shadow using the Lighter. \n\n" +
						"Press U to use the Flashlight!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.stairs_3_item_2_3_4; 
		}
		}
		
		void state_stairs_2_item_2_4_1 () {
			text.text = "You approached the stairs overwhelming with darkness. " +
						"You have a fully functional Lighter and Flashlight at your disposal. " +
						"You are able to clear the shadow using a Lighter or a Flashlight. \n\n" +
						"Press L to use the Lighter, or Press F to use the Flashlight!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.stairs_3_item_2_4_1a; 
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.stairs_3_item_2_4_1b; 
		}
		}
		
		void state_stairs_2_item_2_4_3 () {
			text.text = "You approached the stairs overwhelming with darkness. " +
						"You have a fully functional Lighter at your disposal. " +
						"You are able to clear a portion of the shadow using the Lighter. \n\n" +
						"Press U to use the Flashlight!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.stairs_3_item_2_4_3; 
		}
		}
		
		void state_stairs_2_item_3_1_2 () {
			text.text = "You approached the stairs overwhelming with darkness. " +
						"You have a fully functional Lighter and Flashlight at your disposal. " +
						"You are able to clear the shadow using a Lighter or a Flashlight. \n\n" +
						"Press L to use the Lighter, or Press F to use the Flashlight!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.stairs_3_item_3_1_2a; 
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.stairs_3_item_3_1_2b; 
		}
		}
		
		void state_stairs_2_item_3_1_4 () {
			text.text = "You approached the stairs overwhelming with darkness. " +
						"You have a fully functional Lighter at your disposal. " +
						"You are able to clear a portion of the shadow using the Lighter. \n\n" +
						"Press U to use the Flashlight!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.stairs_3_item_3_1_4; 
		}
		}
		
		void state_stairs_2_item_3_2_1 () {
			text.text = "You approached the stairs overwhelming with darkness. " +
						"You have a fully functional Lighter and Flashlight at your disposal. " +
						"You are able to clear the shadow using a Lighter or a Flashlight. \n\n" +
						"Press L to use the Lighter, or Press F to use the Flashlight!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.stairs_3_item_3_2_1a; 
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.stairs_3_item_3_2_1b; 
		}
		}
		
		void state_stairs_2_item_3_2_4 () {
			text.text = "You approached the stairs overwhelming with darkness. " +
						"You have a fully functional Flashlight at your disposal. " +
						"You are able to clear the shadow using the Flashlight. \n\n" +
						"Press U to use the Flashlight!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.stairs_3_item_3_2_4; 
		}
		}
		
		void state_stairs_2_item_3_4_1 () {
			text.text = "You approached the stairs overwhelming with darkness. " +
						"You have a fully functional Lighter at your disposal. " +
						"You are able to clear a portion of the shadow using the Lighter. \n\n" +
						"Press U to use the Lighter!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.stairs_3_item_3_4_1; 
		}
		}
		
		void state_stairs_2_item_3_4_2 () {
			text.text = "You approached the stairs overwhelming with darkness. " +
						"You have a fully functional Flashlight at your disposal. " +
						"You are able to clear the shadow using the Flashlight. \n\n" +
						"Press U to use the Flashlight!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.stairs_3_item_3_4_2; 
		}
		}
		
		void state_stairs_2_item_4_1_2 () {
			text.text = "You approached the stairs overwhelming with darkness. " +
						"You have a fully functional Lighter and Flashlight at your disposal. " +
						"You are able to clear the shadow using a Lighter or a Flashlight. \n\n" +
						"Press L to use the Lighter, or Press F to use the Flashlight!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.stairs_3_item_4_1_2a; 
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.stairs_3_item_4_1_2b; 
		}
		}
		
		void state_stairs_2_item_4_1_3 () {
			text.text = "You approached the stairs overwhelming with darkness. " +
						"You have a fully functional Lighter at your disposal. " +
						"You are able to clear a portion of the shadow using the Lighter. \n\n" +
						"Press U to use the Lighter!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.stairs_3_item_4_1_3; 
		}
		}
		
		void state_stairs_2_item_4_2_1 () {
			text.text = "You approached the stairs overwhelming with darkness. " +
						"You have a fully functional Lighter and Flashlight at your disposal. " +
						"You are able to clear the shadow using a Lighter or a Flashlight. \n\n" +
						"Press L to use the Lighter, or Press F to use the Flashlight!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.stairs_3_item_4_2_1a; 
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.stairs_3_item_4_2_1b; 
		}
		}
		
		void state_stairs_2_item_4_2_3 () {
			text.text = "You approached the stairs overwhelming with darkness. " +
						"You have a fully functional Lighter at your disposal. " +
						"You are able to clear a portion of the shadow using the Flashlight. \n\n" +
						"Press U to use the Flashlight!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.stairs_3_item_4_2_3; 
		}
		}
		
		void state_stairs_2_item_4_3_1 () {
			text.text = "You approached the stairs overwhelming with darkness. " +
						"You have a fully functional Lighter at your disposal. " +
						"You are able to clear a portion of the shadow using the Lighter. \n\n" +
						"Press U to use the Lighter!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.stairs_3_item_4_3_1; 
		}
		}
		
		void state_stairs_2_item_4_3_2 () {
			text.text = "You approached the stairs overwhelming with darkness. " +
						"You have a fully functional Lighter at your disposal. " +
						"You are able to clear a portion of the shadow using the Flashlight. \n\n" +
						"Press U to use the Flashlight!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.stairs_3_item_4_3_2; 
		}
		}
		
		void state_stairs_3_item_1 () {
			text.text = "The sparks from the Lighter ignite a small flame. " +
						"You feel the heat radiate on your fingetips. " +
						"You are able to see a small radius of leading downstairs. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_1; 
		}
		}
		
		void state_stairs_3_item_2 () {
			text.text = "You tap on the center of the Flashlight, illuminating a bright white ray. " +
						"The light creates a divide to separate the shadow surrounding the stairs. " +
						"You are concerned the brightness of the Flashlight will give away your position so you move quick. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_2; 
		}
		}
		
		void state_stairs_3_item_3 () {
			text.text = "You approached the stairs overwhelming with darkness, however, with a weapon on hand " +
						"you feel confident you can continue downstairs. " +
						"You grip on the handles to your left make continue your path. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_3; 
		}
		}
		
		void state_stairs_3_item_4 () {
			text.text = "You approached the stairs overwhelming with darkness, however, with a weapon on hand " +
						"you feel confident you can continue downstairs. " +
						"You grip on the handles to your left make continue your path. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_4; 
		}
		}
		
		void state_stairs_3_item_1_2a () {
			text.text = "The sparks from the Lighter ignite a small flame. " +
						"You feel the heat radiate on your fingetips. " +
						"You are able to see a small radius of leading downstairs. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_1_2; 
		}
		}
		
		void state_stairs_3_item_1_2b () {
			text.text = "You tap on the center of the Flashlight, illuminating a bright white ray. " +
						"The light creates a divide to separate the shadow surrounding the stairs. " +
						"You are concerned the brightness of the Flashlight will give away your position so you move quick. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_1_2; 
		}
		}
		
		void state_stairs_3_item_1_3 () {
			text.text = "The sparks from the Lighter ignite a small flame. " +
						"You feel the heat radiate on your fingetips. " +
						"You are able to see a small radius of leading downstairs. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_1_3; 
		}
		}
		
		void state_stairs_3_item_1_4 () {
			text.text = "The sparks from the Lighter ignite a small flame. " +
						"You feel the heat radiate on your fingetips. " +
						"You are able to see a small radius of leading downstairs. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_1_4; 
		}
		}
		
		void state_stairs_3_item_2_1a () {
			text.text = "The sparks from the Lighter ignite a small flame. " +
						"You feel the heat radiate on your fingetips. " +
						"You are able to see a small radius of leading downstairs. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_2_1; 
		}
		}
		
		void state_stairs_3_item_2_1b () {
			text.text = "You tap on the center of the Flashlight, illuminating a bright white ray. " +
						"The light creates a divide to separate the shadow surrounding the stairs. " +
						"You are concerned the brightness of the Flashlight will give away your position so you move quick. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_2_1; 
		}
		}
		
		void state_stairs_3_item_2_3 () {
			text.text = "You tap on the center of the Flashlight, illuminating a bright white ray. " +
						"The light creates a divide to separate the shadow surrounding the stairs. " +
						"You are concerned the brightness of the Flashlight will give away your position so you move quick. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_2_3; 
		}
		}
		
		void state_stairs_3_item_2_4 () {
			text.text = "You tap on the center of the Flashlight, illuminating a bright white ray. " +
						"The light creates a divide to separate the shadow surrounding the stairs. " +
						"You are concerned the brightness of the Flashlight will give away your position so you move quick. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_2_4; 
		}
		}
		
		void state_stairs_3_item_3_1 () {
			text.text = "The sparks from the Lighter ignite a small flame. " +
						"You feel the heat radiate on your fingetips. " +
						"You are able to see a small radius of leading downstairs. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_3_1; 
		}
		}
		
		void state_stairs_3_item_3_2 () {
			text.text = "You tap on the center of the Flashlight, illuminating a bright white ray. " +
						"The light creates a divide to separate the shadow surrounding the stairs. " +
						"You are concerned the brightness of the Flashlight will give away your position so you move quick. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_3_2; 
		}
		}
		
		void state_stairs_3_item_3_4 () {
			text.text = "You approached the stairs overwhelming with darkness, however, with a weapon on hand " +
						"you feel confident you can continue downstairs. " +
						"You grip on the handles to your left make continue your path. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_3_4; 
		}
		}
		
		void state_stairs_3_item_4_1 () {
			text.text = "The sparks from the Lighter ignite a small flame. " +
						"You feel the heat radiate on your fingetips. " +
						"You are able to see a small radius of leading downstairs. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_4_1; 
		}
		}
		
		void state_stairs_3_item_4_2 () {
			text.text = "You tap on the center of the Flashlight, illuminating a bright white ray. " +
						"The light creates a divide to separate the shadow surrounding the stairs. " +
						"You are concerned the brightness of the Flashlight will give away your position so you move quick. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_4_2; 
		}
		}
		
		void state_stairs_3_item_4_3 () {
			text.text = "You approached the stairs overwhelming with darkness, however, with a weapon on hand " +
						"you feel confident you can continue downstairs. " +
						"You grip on the handles to your left make continue your path. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_4_3; 
		}
		}
		
		void state_stairs_3_item_1_2_3a () {
			text.text = "The sparks from the Lighter ignite a small flame. " +
						"You feel the heat radiate on your fingetips. " +
						"You are able to see a small radius of leading downstairs. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_1_2_3; 
		}
		}
		
		void state_stairs_3_item_1_2_3b () {
			text.text = "You tap on the center of the Flashlight, illuminating a bright white ray. " +
						"The light creates a divide to separate the shadow surrounding the stairs. " +
						"You are concerned the brightness of the Flashlight will give away your position so you move quick. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_1_2_3; 
		}
		}
		
		void state_stairs_3_item_1_2_4a () {
			text.text = "The sparks from the Lighter ignite a small flame. " +
						"You feel the heat radiate on your fingetips. " +
						"You are able to see a small radius of leading downstairs. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_1_2_4; 
		}
		}
		
		void state_stairs_3_item_1_2_4b () {
			text.text = "You tap on the center of the Flashlight, illuminating a bright white ray. " +
						"The light creates a divide to separate the shadow surrounding the stairs. " +
						"You are concerned the brightness of the Flashlight will give away your position so you move quick. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_1_2_4; 
		}
		}
		
		void state_stairs_3_item_1_3_2a () {
			text.text = "The sparks from the Lighter ignite a small flame. " +
						"You feel the heat radiate on your fingetips. " +
						"You are able to see a small radius of leading downstairs. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_1_3_2; 
		}
		}
		
		void state_stairs_3_item_1_3_2b () {
			text.text = "You tap on the center of the Flashlight, illuminating a bright white ray. " +
						"The light creates a divide to separate the shadow surrounding the stairs. " +
						"You are concerned the brightness of the Flashlight will give away your position so you move quick. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_1_3_2; 
		}
		}
		
		void state_stairs_3_item_1_3_4 () {
			text.text = "The sparks from the Lighter ignite a small flame. " +
						"You feel the heat radiate on your fingetips. " +
						"You are able to see a small radius of leading downstairs. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_1_3_4; 
		}
		}
		
		void state_stairs_3_item_1_4_2a () {
			text.text = "The sparks from the Lighter ignite a small flame. " +
						"You feel the heat radiate on your fingetips. " +
						"You are able to see a small radius of leading downstairs. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_1_4_2; 
		}
		}
		
		void state_stairs_3_item_1_4_2b () {
			text.text = "You tap on the center of the Flashlight, illuminating a bright white ray. " +
						"The light creates a divide to separate the shadow surrounding the stairs. " +
						"You are concerned the brightness of the Flashlight will give away your position so you move quick. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_1_4_2; 
		}
		}
		
		void state_stairs_3_item_1_4_3 () {
			text.text = "The sparks from the Lighter ignite a small flame. " +
						"You feel the heat radiate on your fingetips. " +
						"You are able to see a small radius of leading downstairs. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_1_4_3; 
		}
		}
		
		void state_stairs_3_item_2_1_3a () {
			text.text = "The sparks from the Lighter ignite a small flame. " +
						"You feel the heat radiate on your fingetips. " +
						"You are able to see a small radius of leading downstairs. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_2_1_3; 
		}
		}
		
		void state_stairs_3_item_2_1_3b () {
			text.text = "You tap on the center of the Flashlight, illuminating a bright white ray. " +
						"The light creates a divide to separate the shadow surrounding the stairs. " +
						"You are concerned the brightness of the Flashlight will give away your position so you move quick. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_2_1_3; 
		}
		}
		
		void state_stairs_3_item_2_1_4a () {
			text.text = "The sparks from the Lighter ignite a small flame. " +
						"You feel the heat radiate on your fingetips. " +
						"You are able to see a small radius of leading downstairs. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_2_1_4; 
		}
		}
		
		void state_stairs_3_item_2_1_4b () {
			text.text = "You tap on the center of the Flashlight, illuminating a bright white ray. " +
						"The light creates a divide to separate the shadow surrounding the stairs. " +
						"You are concerned the brightness of the Flashlight will give away your position so you move quick. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_2_1_4; 
		}
		}
		
		void state_stairs_3_item_2_3_1a () {
			text.text = "The sparks from the Lighter ignite a small flame. " +
						"You feel the heat radiate on your fingetips. " +
						"You are able to see a small radius of leading downstairs. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_2_3_1; 
		}
		}
		
		void state_stairs_3_item_2_3_1b () {
			text.text = "You tap on the center of the Flashlight, illuminating a bright white ray. " +
						"The light creates a divide to separate the shadow surrounding the stairs. " +
						"You are concerned the brightness of the Flashlight will give away your position so you move quick. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_2_3_1; 
		}
		}
		
		void state_stairs_3_item_2_3_4 () {
			text.text = "You tap on the center of the Flashlight, illuminating a bright white ray. " +
						"The light creates a divide to separate the shadow surrounding the stairs. " +
						"You are concerned the brightness of the Flashlight will give away your position so you move quick. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_2_3_4; 
		}
		}
		
		void state_stairs_3_item_2_4_1a () {
			text.text = "The sparks from the Lighter ignite a small flame. " +
						"You feel the heat radiate on your fingetips. " +
						"You are able to see a small radius of leading downstairs. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_2_4_1; 
		}
		}
		
		void state_stairs_3_item_2_4_1b () {
			text.text = "You tap on the center of the Flashlight, illuminating a bright white ray. " +
						"The light creates a divide to separate the shadow surrounding the stairs. " +
						"You are concerned the brightness of the Flashlight will give away your position so you move quick. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_2_4_1; 
		}
		}
		
		void state_stairs_3_item_2_4_3 () {
			text.text = "You tap on the center of the Flashlight, illuminating a bright white ray. " +
						"The light creates a divide to separate the shadow surrounding the stairs. " +
						"You are concerned the brightness of the Flashlight will give away your position so you move quick. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_2_4_3; 
		}
		}
		
		void state_stairs_3_item_3_1_2a () {
			text.text = "The sparks from the Lighter ignite a small flame. " +
						"You feel the heat radiate on your fingetips. " +
						"You are able to see a small radius of leading downstairs. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_3_1_2; 
		}
		}
		
		void state_stairs_3_item_3_1_2b () {
			text.text = "You tap on the center of the Flashlight, illuminating a bright white ray. " +
						"The light creates a divide to separate the shadow surrounding the stairs. " +
						"You are concerned the brightness of the Flashlight will give away your position so you move quick. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_3_1_2; 
		}
		}
		
		void state_stairs_3_item_3_1_4 () {
			text.text = "The sparks from the Lighter ignite a small flame. " +
						"You feel the heat radiate on your fingetips. " +
						"You are able to see a small radius of leading downstairs. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_3_1_4; 
		}
		}
		
		void state_stairs_3_item_3_2_1a () {
			text.text = "The sparks from the Lighter ignite a small flame. " +
						"You feel the heat radiate on your fingetips. " +
						"You are able to see a small radius of leading downstairs. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_3_2_1; 
		}
		}
		
		void state_stairs_3_item_3_2_1b () {
			text.text = "You tap on the center of the Flashlight, illuminating a bright white ray. " +
						"The light creates a divide to separate the shadow surrounding the stairs. " +
						"You are concerned the brightness of the Flashlight will give away your position so you move quick. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_3_2_1; 
		}
		}
		
		void state_stairs_3_item_3_2_4 () {
			text.text = "You tap on the center of the Flashlight, illuminating a bright white ray. " +
						"The light creates a divide to separate the shadow surrounding the stairs. " +
						"You are concerned the brightness of the Flashlight will give away your position so you move quick. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_3_2_4; 
		}
		}
		
		void state_stairs_3_item_3_4_1 () {
			text.text = "The sparks from the Lighter ignite a small flame. " +
						"You feel the heat radiate on your fingetips. " +
						"You are able to see a small radius of leading downstairs. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_3_4_1; 
		}
		}
		
		void state_stairs_3_item_3_4_2 () {
			text.text = "You tap on the center of the Flashlight, illuminating a bright white ray. " +
						"The light creates a divide to separate the shadow surrounding the stairs. " +
						"You are concerned the brightness of the Flashlight will give away your position so you move quick. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_3_4_2; 
		}
		}
		
		void state_stairs_3_item_4_1_2a () {
			text.text = "The sparks from the Lighter ignite a small flame. " +
						"You feel the heat radiate on your fingetips. " +
						"You are able to see a small radius of leading downstairs. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_4_1_2; 
		}
		}
		
		void state_stairs_3_item_4_1_2b () {
			text.text = "You tap on the center of the Flashlight, illuminating a bright white ray. " +
						"The light creates a divide to separate the shadow surrounding the stairs. " +
						"You are concerned the brightness of the Flashlight will give away your position so you move quick. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_4_1_2; 
		}
		}
		
		void state_stairs_3_item_4_1_3 () {
			text.text = "The sparks from the Lighter ignite a small flame. " +
						"You feel the heat radiate on your fingetips. " +
						"You are able to see a small radius of leading downstairs. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_4_1_3; 
		}
		}
		
		void state_stairs_3_item_4_2_1a () {
			text.text = "The sparks from the Lighter ignite a small flame. " +
						"You feel the heat radiate on your fingetips. " +
						"You are able to see a small radius of leading downstairs. \n\n" +
						"Press S to continue down the Stairs!";;
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_4_2_1; 
		}
		}
		
		void state_stairs_3_item_4_2_1b () {
			text.text = "You tap on the center of the Flashlight, illuminating a bright white ray. " +
						"The light creates a divide to separate the shadow surrounding the stairs. " +
						"You are concerned the brightness of the Flashlight will give away your position so you move quick. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_4_2_1; 
		}
		}
		
		void state_stairs_3_item_4_2_3 () {
			text.text = "You tap on the center of the Flashlight, illuminating a bright white ray. " +
						"The light creates a divide to separate the shadow surrounding the stairs. " +
						"You are concerned the brightness of the Flashlight will give away your position so you move quick. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_4_2_3; 
		}
		}
		
		void state_stairs_3_item_4_3_1 () {
			text.text = "The sparks from the Lighter ignite a small flame. " +
						"You feel the heat radiate on your fingetips. " +
						"You are able to see a small radius of leading downstairs. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_4_3_1; 
		}
		}
		
		void state_stairs_3_item_4_3_2 () {
			text.text = "You tap on the center of the Flashlight, illuminating a bright white ray. " +
						"The light creates a divide to separate the shadow surrounding the stairs. " +
						"You are concerned the brightness of the Flashlight will give away your position so you move quick. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.barracks_0_item_4_3_2; 
		}
		}
		
		void state_barracks_0_item_1 () {
			text.text = "You reached the final step of the stairs and find yourself in the barracks. " +
						"At your right you found a closet that stores the uniforms of the prison guards. " +
						"You don't have much time to waste so you rush to the closet door. \n\n" +
						"Press C to observe the closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_0_item_1; 
		}
		}
		
		void state_barracks_0_item_2 () {
			text.text = "You reached the final step of the stairs and find yourself in the barracks. " +
						"At your right you found a closet that stores the uniforms of the prison guards. " +
						"You don't have much time to waste so you rush to the closet door. \n\n" +
						"Press C to observe the closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_0_item_2; 
		}
		}
		
		void state_barracks_0_item_3 () {
			text.text = "You reached the final step of the stairs and find yourself in the barracks. " +
						"At your right you found a closet that stores the uniforms of the prison guards. " +
						"You don't have much time to waste so you rush to the closet door. \n\n" +
						"Press C to observe the closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_0_item_3; 
		}
		}
		
		void state_barracks_0_item_4 () {
			text.text = "You reached the final step of the stairs and find yourself in the barracks. " +
						"At your right you found a closet that stores the uniforms of the prison guards. " +
						"You don't have much time to waste so you rush to the closet door. \n\n" +
						"Press C to observe the closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_0_item_4; 
		}
		}
		
		void state_barracks_0_item_1_2 () {
			text.text = "You reached the final step of the stairs and find yourself in the barracks. " +
						"At your right you found a closet that stores the uniforms of the prison guards. " +
						"You don't have much time to waste so you rush to the closet door. \n\n" +
						"Press C to observe the closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_0_item_1_2; 
		}
		}
		
		void state_barracks_0_item_1_3 () {
			text.text = "You reached the final step of the stairs and find yourself in the barracks. " +
						"At your right you found a closet that stores the uniforms of the prison guards. " +
						"You don't have much time to waste so you rush to the closet door. \n\n" +
						"Press C to observe the closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_0_item_1_3; 
		}
		}
		
		void state_barracks_0_item_1_4 () {
			text.text = "You reached the final step of the stairs and find yourself in the barracks. " +
						"At your right you found a closet that stores the uniforms of the prison guards. " +
						"You don't have much time to waste so you rush to the closet door. \n\n" +
						"Press C to observe the closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_0_item_1_4; 
		}
		}
		
		void state_barracks_0_item_2_1 () {
			text.text = "You reached the final step of the stairs and find yourself in the barracks. " +
						"At your right you found a closet that stores the uniforms of the prison guards. " +
						"You don't have much time to waste so you rush to the closet door. \n\n" +
						"Press C to observe the closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_0_item_2_1; 
		}
		}
		
		void state_barracks_0_item_2_3 () {
			text.text = "You reached the final step of the stairs and find yourself in the barracks. " +
						"At your right you found a closet that stores the uniforms of the prison guards. " +
						"You don't have much time to waste so you rush to the closet door. \n\n" +
						"Press C to observe the closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_0_item_2_3; 
		}
		}
		
		void state_barracks_0_item_2_4 () {
			text.text = "You reached the final step of the stairs and find yourself in the barracks. " +
						"At your right you found a closet that stores the uniforms of the prison guards. " +
						"You don't have much time to waste so you rush to the closet door. \n\n" +
						"Press C to observe the closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_0_item_2_4; 
		}
		}
		
		void state_barracks_0_item_3_1 () {
			text.text = "You reached the final step of the stairs and find yourself in the barracks. " +
						"At your right you found a closet that stores the uniforms of the prison guards. " +
						"You don't have much time to waste so you rush to the closet door. \n\n" +
						"Press C to observe the closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_0_item_3_1; 
		}
		}
		
		void state_barracks_0_item_3_2 () {
			text.text = "You reached the final step of the stairs and find yourself in the barracks. " +
						"At your right you found a closet that stores the uniforms of the prison guards. " +
						"You don't have much time to waste so you rush to the closet door. \n\n" +
						"Press C to observe the closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_0_item_3_2; 
		}
		}
		
		void state_barracks_0_item_3_4 () {
			text.text = "You reached the final step of the stairs and find yourself in the barracks. " +
						"At your right you found a closet that stores the uniforms of the prison guards. " +
						"You don't have much time to waste so you rush to the closet door. \n\n" +
						"Press C to observe the closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_0_item_3_4; 
		}
		}
		
		void state_barracks_0_item_4_1 () {
			text.text = "You reached the final step of the stairs and find yourself in the barracks. " +
						"At your right you found a closet that stores the uniforms of the prison guards. " +
						"You don't have much time to waste so you rush to the closet door. \n\n" +
						"Press C to observe the closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_0_item_4_1; 
		}
		}
		
		void state_barracks_0_item_4_2 () {
			text.text = "You reached the final step of the stairs and find yourself in the barracks. " +
						"At your right you found a closet that stores the uniforms of the prison guards. " +
						"You don't have much time to waste so you rush to the closet door. \n\n" +
						"Press C to observe the closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_0_item_4_2; 
		}
		}
		
		void state_barracks_0_item_4_3 () {
			text.text = "You reached the final step of the stairs and find yourself in the barracks. " +
						"At your right you found a closet that stores the uniforms of the prison guards. " +
						"You don't have much time to waste so you rush to the closet door. \n\n" +
						"Press C to observe the closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_0_item_4_3; 
		}
		}
		
		void state_barracks_0_item_1_2_3 () {
			text.text = "You reached the final step of the stairs and find yourself in the barracks. " +
						"At your right you found a closet that stores the uniforms of the prison guards. " +
						"You don't have much time to waste so you rush to the closet door. \n\n" +
						"Press C to observe the closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_0_item_1_2_3; 
		}
		}
		
		void state_barracks_0_item_1_2_4 () {
			text.text = "You reached the final step of the stairs and find yourself in the barracks. " +
						"At your right you found a closet that stores the uniforms of the prison guards. " +
						"You don't have much time to waste so you rush to the closet door. \n\n" +
						"Press C to observe the closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_0_item_1_2_4; 
		}
		}
		
		void state_barracks_0_item_1_3_2 () {
			text.text = "You reached the final step of the stairs and find yourself in the barracks. " +
						"At your right you found a closet that stores the uniforms of the prison guards. " +
						"You don't have much time to waste so you rush to the closet door. \n\n" +
						"Press C to observe the closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_0_item_1_3_2; 
		}
		}
		
		void state_barracks_0_item_1_3_4 () {
			text.text = "You reached the final step of the stairs and find yourself in the barracks. " +
						"At your right you found a closet that stores the uniforms of the prison guards. " +
						"You don't have much time to waste so you rush to the closet door. \n\n" +
						"Press C to observe the closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_0_item_1_3_4; 
		}
		}
		
		void state_barracks_0_item_1_4_2 () {
			text.text = "You reached the final step of the stairs and find yourself in the barracks. " +
						"At your right you found a closet that stores the uniforms of the prison guards. " +
						"You don't have much time to waste so you rush to the closet door. \n\n" +
						"Press C to observe the closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_0_item_1_4_2; 
		}
		}
		
		void state_barracks_0_item_1_4_3 () {
			text.text = "You reached the final step of the stairs and find yourself in the barracks. " +
						"At your right you found a closet that stores the uniforms of the prison guards. " +
						"You don't have much time to waste so you rush to the closet door. \n\n" +
						"Press C to observe the closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_0_item_1_2_3; 
		}
		}
		
		void state_barracks_0_item_2_1_3 () {
			text.text = "You reached the final step of the stairs and find yourself in the barracks. " +
						"At your right you found a closet that stores the uniforms of the prison guards. " +
						"You don't have much time to waste so you rush to the closet door. \n\n" +
						"Press C to observe the closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_0_item_2_1_3; 
		}
		}
		
		void state_barracks_0_item_2_1_4 () {
			text.text = "You reached the final step of the stairs and find yourself in the barracks. " +
						"At your right you found a closet that stores the uniforms of the prison guards. " +
						"You don't have much time to waste so you rush to the closet door. \n\n" +
						"Press C to observe the closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_0_item_2_1_4; 
		}
		}
		
		void state_barracks_0_item_2_3_1 () {
			text.text = "You reached the final step of the stairs and find yourself in the barracks. " +
						"At your right you found a closet that stores the uniforms of the prison guards. " +
						"You don't have much time to waste so you rush to the closet door. \n\n" +
						"Press C to observe the closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_0_item_2_3_1; 
		}
		}
		
		void state_barracks_0_item_2_3_4 () {
			text.text = "You reached the final step of the stairs and find yourself in the barracks. " +
						"At your right you found a closet that stores the uniforms of the prison guards. " +
						"You don't have much time to waste so you rush to the closet door. \n\n" +
						"Press C to observe the closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_0_item_2_3_4; 
		}
		}
		
		void state_barracks_0_item_2_4_1 () {
			text.text = "You reached the final step of the stairs and find yourself in the barracks. " +
						"At your right you found a closet that stores the uniforms of the prison guards. " +
						"You don't have much time to waste so you rush to the closet door. \n\n" +
						"Press C to observe the closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_0_item_2_4_1; 
		}
		}
		
		void state_barracks_0_item_2_4_3 () {
			text.text = "You reached the final step of the stairs and find yourself in the barracks. " +
						"At your right you found a closet that stores the uniforms of the prison guards. " +
						"You don't have much time to waste so you rush to the closet door. \n\n" +
						"Press C to observe the closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_0_item_2_4_3; 
		}
		}
		
		void state_barracks_0_item_3_1_2 () {
			text.text = "You reached the final step of the stairs and find yourself in the barracks. " +
						"At your right you found a closet that stores the uniforms of the prison guards. " +
						"You don't have much time to waste so you rush to the closet door. \n\n" +
						"Press C to observe the closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_0_item_3_1_2; 
		}
		}
		
		void state_barracks_0_item_3_1_4 () {
			text.text = "You reached the final step of the stairs and find yourself in the barracks. " +
						"At your right you found a closet that stores the uniforms of the prison guards. " +
						"You don't have much time to waste so you rush to the closet door. \n\n" +
						"Press C to observe the closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_0_item_3_1_4; 
		}
		}
		
		void state_barracks_0_item_3_2_1 () {
			text.text = "You reached the final step of the stairs and find yourself in the barracks. " +
						"At your right you found a closet that stores the uniforms of the prison guards. " +
						"You don't have much time to waste so you rush to the closet door. \n\n" +
						"Press C to observe the closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_0_item_3_2_1; 
		}
		}
		
		void state_barracks_0_item_3_2_4 () {
			text.text = "You reached the final step of the stairs and find yourself in the barracks. " +
						"At your right you found a closet that stores the uniforms of the prison guards. " +
						"You don't have much time to waste so you rush to the closet door. \n\n" +
						"Press C to observe the closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_0_item_3_2_4; 
		}
		}
		
		void state_barracks_0_item_3_4_1 () {
			text.text = "You reached the final step of the stairs and find yourself in the barracks. " +
						"At your right you found a closet that stores the uniforms of the prison guards. " +
						"You don't have much time to waste so you rush to the closet door. \n\n" +
						"Press C to observe the closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_0_item_3_4_1; 
		}
		}
		
		void state_barracks_0_item_3_4_2 () {
			text.text = "You reached the final step of the stairs and find yourself in the barracks. " +
						"At your right you found a closet that stores the uniforms of the prison guards. " +
						"You don't have much time to waste so you rush to the closet door. \n\n" +
						"Press C to observe the closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_0_item_3_4_2; 
		}
		}
		
		void state_barracks_0_item_4_1_2 () {
			text.text = "You reached the final step of the stairs and find yourself in the barracks. " +
						"At your right you found a closet that stores the uniforms of the prison guards. " +
						"You don't have much time to waste so you rush to the closet door. \n\n" +
						"Press C to observe the closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_0_item_4_1_2; 
		}
		}
		
		void state_barracks_0_item_4_1_3 () {
			text.text = "You reached the final step of the stairs and find yourself in the barracks. " +
						"At your right you found a closet that stores the uniforms of the prison guards. " +
						"You don't have much time to waste so you rush to the closet door. \n\n" +
						"Press C to observe the closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_0_item_4_1_3; 
		}
		}
		
		void state_barracks_0_item_4_2_1 () {
			text.text = "You reached the final step of the stairs and find yourself in the barracks. " +
						"At your right you found a closet that stores the uniforms of the prison guards. " +
						"You don't have much time to waste so you rush to the closet door. \n\n" +
						"Press C to observe the closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_0_item_4_2_1; 
		}
		}
		
		void state_barracks_0_item_4_2_3 () {
			text.text = "You reached the final step of the stairs and find yourself in the barracks. " +
						"At your right you found a closet that stores the uniforms of the prison guards. " +
						"You don't have much time to waste so you rush to the closet door. \n\n" +
						"Press C to observe the closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_0_item_4_2_3; 
		}
		}
		
		void state_barracks_0_item_4_3_1 () {
			text.text = "You reached the final step of the stairs and find yourself in the barracks. " +
						"At your right you found a closet that stores the uniforms of the prison guards. " +
						"You don't have much time to waste so you rush to the closet door. \n\n" +
						"Press C to observe the closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_0_item_4_3_1; 
		}
		}
		
		void state_barracks_0_item_4_3_2 () {
			text.text = "You reached the final step of the stairs and find yourself in the barracks. " +
						"At your right you found a closet that stores the uniforms of the prison guards. " +
						"You don't have much time to waste so you rush to the closet door. \n\n" +
						"Press C to observe the closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_0_item_4_3_2; 
		}
		}
		
		void state_closet_0_item_1 () {
			text.text = "You raced to the closet and pull on the handles. It won't budge! " +
						"You inspect between the handles and find a lock. \n\n" +
						"Press L to inspect the Lock!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_4_item_1; 
		}
		}
		
		void state_closet_0_item_2 () {
			text.text = "You raced to the closet and pull on the handles. It won't budge! " +
						"You inspect between the handles and find a lock. \n\n" +
						"Press L to inspect the Lock!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_4_item_2; 
		}
		}
		
		void state_closet_0_item_3 () {
			text.text = "You raced to the closet and pull on the handles. It won't budge! " +
						"You inspect between the handles and find a lock. \n\n" +
						"Press L to inspect the Lock!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_4_item_3; 
		}
		}
		
		void state_closet_0_item_4 () {
			text.text = "You raced to the closet and pull on the handles. It won't budge! " +
						"You inspect between the handles and find a lock. \n\n" +
						"Press L to inspect the Lock!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_4_item_4; 
		}
		}
		
		void state_closet_0_item_1_2 () {
			text.text = "You raced to the closet and pull on the handles. It won't budge! " +
						"You inspect between the handles and find a lock. \n\n" +
						"Press L to inspect the Lock!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_4_item_1_2; 
		}
		}
		
		void state_closet_0_item_1_3 () {
			text.text = "You raced to the closet and pull on the handles. It won't budge! " +
						"You inspect between the handles and find a lock. \n\n" +
						"Press L to inspect the Lock!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_4_item_1_3; 
		}
		}
		
		void state_closet_0_item_1_4 () {
			text.text = "You raced to the closet and pull on the handles. It won't budge! " +
						"You inspect between the handles and find a lock. \n\n" +
						"Press L to inspect the Lock!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_4_item_1_4; 
		}
		}
		
		void state_closet_0_item_2_1 () {
			text.text = "You raced to the closet and pull on the handles. It won't budge! " +
						"You inspect between the handles and find a lock. \n\n" +
						"Press L to inspect the Lock!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_4_item_2_1; 
		}
		}
		
		void state_closet_0_item_2_3 () {
			text.text = "You raced to the closet and pull on the handles. It won't budge! " +
						"You inspect between the handles and find a lock. \n\n" +
						"Press L to inspect the Lock!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_4_item_2_3; 
		}
		}
		
		void state_closet_0_item_2_4 () {
			text.text = "You raced to the closet and pull on the handles. It won't budge! " +
						"You inspect between the handles and find a lock. \n\n" +
						"Press L to inspect the Lock!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_4_item_2_4; 
		}
		}
		
		void state_closet_0_item_3_1 () {
			text.text = "You raced to the closet and pull on the handles. It won't budge! " +
						"You inspect between the handles and find a lock. \n\n" +
						"Press L to inspect the Lock!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_4_item_3_1; 
		}
		}
		
		void state_closet_0_item_3_2 () {
			text.text = "You raced to the closet and pull on the handles. It won't budge! " +
						"You inspect between the handles and find a lock. \n\n" +
						"Press L to inspect the Lock!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_4_item_3_2; 
		}
		}
		
		void state_closet_0_item_3_4 () {
			text.text = "You raced to the closet and pull on the handles. It won't budge! " +
						"You inspect between the handles and find a lock. \n\n" +
						"Press L to inspect the Lock!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_4_item_3_4; 
		}
		}
		
		void state_closet_0_item_4_1 () {
			text.text = "You raced to the closet and pull on the handles. It won't budge! " +
						"You inspect between the handles and find a lock. \n\n" +
						"Press L to inspect the Lock!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_4_item_4_1; 
		}
		}
		
		void state_closet_0_item_4_2 () {
			text.text = "You raced to the closet and pull on the handles. It won't budge! " +
						"You inspect between the handles and find a lock. \n\n" +
						"Press L to inspect the Lock!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_4_item_4_2; 
		}
		}
		
		void state_closet_0_item_4_3 () {
			text.text = "You raced to the closet and pull on the handles. It won't budge! " +
						"You inspect between the handles and find a lock. \n\n" +
						"Press L to inspect the Lock!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_4_item_4_3; 
		}
		}
		
		void state_closet_0_item_1_2_3 () {
			text.text = "You raced to the closet and pull on the handles. It won't budge! " +
						"You inspect between the handles and find a lock. \n\n" +
						"Press L to inspect the Lock!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_4_item_1_2_3; 
		}
		}
		
		void state_closet_0_item_1_2_4 () {
			text.text = "You raced to the closet and pull on the handles. It won't budge! " +
						"You inspect between the handles and find a lock. \n\n" +
						"Press L to inspect the Lock!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_4_item_1_2_4; 
		}
		}
		
		void state_closet_0_item_1_3_2 () {
			text.text = "You raced to the closet and pull on the handles. It won't budge! " +
						"You inspect between the handles and find a lock. \n\n" +
						"Press L to inspect the Lock!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_4_item_1_3_2; 
		}
		}
		
		void state_closet_0_item_1_3_4 () {
			text.text = "You raced to the closet and pull on the handles. It won't budge! " +
						"You inspect between the handles and find a lock. \n\n" +
						"Press L to inspect the Lock!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_4_item_1_3_4; 
		}
		}
		
		void state_closet_0_item_1_4_2 () {
			text.text = "You raced to the closet and pull on the handles. It won't budge! " +
						"You inspect between the handles and find a lock. \n\n" +
						"Press L to inspect the Lock!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_4_item_1_2_3; 
		}
		}
		
		void state_closet_0_item_1_4_3 () {
			text.text = "You raced to the closet and pull on the handles. It won't budge! " +
						"You inspect between the handles and find a lock. \n\n" +
						"Press L to inspect the Lock!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_4_item_1_4_3; 
		}
		}
		
		void state_closet_0_item_2_1_3 () {
			text.text = "You raced to the closet and pull on the handles. It won't budge! " +
						"You inspect between the handles and find a lock. \n\n" +
						"Press L to inspect the Lock!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_4_item_2_1_3; 
		}
		}
		
		void state_closet_0_item_2_1_4 () {
			text.text = "You raced to the closet and pull on the handles. It won't budge! " +
						"You inspect between the handles and find a lock. \n\n" +
						"Press L to inspect the Lock!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_4_item_2_1_4; 
		}
		}
		
		void state_closet_0_item_2_3_1 () {
			text.text = "You raced to the closet and pull on the handles. It won't budge! " +
						"You inspect between the handles and find a lock. \n\n" +
						"Press L to inspect the Lock!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_4_item_2_3_1; 
		}
		}
		
		void state_closet_0_item_2_3_4 () {
			text.text = "You raced to the closet and pull on the handles. It won't budge! " +
						"You inspect between the handles and find a lock. \n\n" +
						"Press L to inspect the Lock!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_4_item_2_3_4; 
		}
		}
		
		void state_closet_0_item_2_4_1 () {
			text.text = "You raced to the closet and pull on the handles. It won't budge! " +
						"You inspect between the handles and find a lock. \n\n" +
						"Press L to inspect the Lock!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_4_item_2_4_1; 
		}
		}
		
		void state_closet_0_item_2_4_3 () {
			text.text = "You raced to the closet and pull on the handles. It won't budge! " +
						"You inspect between the handles and find a lock. \n\n" +
						"Press L to inspect the Lock!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_4_item_2_4_3; 
		}
		}
		
		void state_closet_0_item_3_1_2 () {
			text.text = "You raced to the closet and pull on the handles. It won't budge! " +
						"You inspect between the handles and find a lock. \n\n" +
						"Press L to inspect the Lock!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_4_item_3_1_2; 
		}
		}
		
		void state_closet_0_item_3_1_4 () {
			text.text = "You raced to the closet and pull on the handles. It won't budge! " +
						"You inspect between the handles and find a lock. \n\n" +
						"Press L to inspect the Lock!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_4_item_3_1_4; 
		}
		}
		
		void state_closet_0_item_3_2_1 () {
			text.text = "You raced to the closet and pull on the handles. It won't budge! " +
						"You inspect between the handles and find a lock. \n\n" +
						"Press L to inspect the Lock!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_4_item_3_2_1; 
		}
		}
		
		void state_closet_0_item_3_2_4 () {
			text.text = "You raced to the closet and pull on the handles. It won't budge! " +
						"You inspect between the handles and find a lock. \n\n" +
						"Press L to inspect the Lock!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_4_item_3_2_4; 
		}
		}
		
		void state_closet_0_item_3_4_1 () {
			text.text = "You raced to the closet and pull on the handles. It won't budge! " +
						"You inspect between the handles and find a lock. \n\n" +
						"Press L to inspect the Lock!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_4_item_3_4_1; 
		}
		}
		
		void state_closet_0_item_3_4_2 () {
			text.text = "You raced to the closet and pull on the handles. It won't budge! " +
						"You inspect between the handles and find a lock. \n\n" +
						"Press L to inspect the Lock!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_4_item_3_4_2; 
		}
		}
		
		void state_closet_0_item_4_1_2 () {
			text.text = "You raced to the closet and pull on the handles. It won't budge! " +
						"You inspect between the handles and find a lock. \n\n" +
						"Press L to inspect the Lock!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_4_item_4_1_2; 
		}
		}
		
		void state_closet_0_item_4_1_3 () {
			text.text = "You raced to the closet and pull on the handles. It won't budge! " +
						"You inspect between the handles and find a lock. \n\n" +
						"Press L to inspect the Lock!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_4_item_4_1_3; 
		}
		}
		
		void state_closet_0_item_4_2_1 () {
			text.text = "You raced to the closet and pull on the handles. It won't budge! " +
						"You inspect between the handles and find a lock. \n\n" +
						"Press L to inspect the Lock!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_4_item_4_2_1; 
		}
		}
		
		void state_closet_0_item_4_2_3 () {
			text.text = "You raced to the closet and pull on the handles. It won't budge! " +
						"You inspect between the handles and find a lock. \n\n" +
						"Press L to inspect the Lock!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_4_item_4_2_3; 
		}
		}
		
		void state_closet_0_item_4_3_1 () {
			text.text = "You raced to the closet and pull on the handles. It won't budge! " +
						"You inspect between the handles and find a lock. \n\n" +
						"Press L to inspect the Lock!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_4_item_4_3_1; 
		}
		}
		
		void state_closet_0_item_4_3_2 () {
			text.text = "You raced to the closet and pull on the handles. It won't budge! " +
						"You inspect between the handles and find a lock. \n\n" +
						"Press L to inspect the Lock!";
		 if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_4_item_4_3_2; 
		}
		}
		
		void state_lock_4_item_1 () {
			text.text = "The lock is bolted tight on the wooden door. You try to use the bobby pin, but it broke. " +
						"When you begin to lose hope, you turn around and found a custodial closet behind you. \n\n" +
						"Press C to go to the Custodian closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.custodian_0; 
		}
		}
		
		void state_lock_4_item_2 () {
			text.text = "The lock is bolted tight on the wooden door. You try to use the bobby pin, but it broke. " +
						"When you begin to lose hope, you turn around and found a custodial closet behind you. \n\n" +
						"Press C to go to the Custodian closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.custodian_0; 
		}
		}
		
		void state_lock_4_item_3 () {
			text.text = "The lock is bolted tight on the wooden door. The screws, however, match the tip of your Screwdriver. " +
						"You are able to unscrew all the bolts on the lock. \n\n" +
						"Press U to use the Screwdriver!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.use_item_3; 
		}
		}
		
		void state_lock_4_item_4 () {
			text.text = "The lock is bolted tight on the wooden door. You try to use the bobby pin, but it broke. " +
						"When you begin to lose hope, you turn around and found a custodial closet behind you. \n\n" +
						"Press C to go to the Custodian closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.custodian_0_item_4; 
		}
		}
		
		void state_lock_4_item_1_2 () {
			text.text = "The lock is bolted tight on the wooden door. You try to use the bobby pin, but it broke. " +
						"When you begin to lose hope, you turn around and found a custodial closet behind you. \n\n" +
						"Press C to go to the Custodian closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.custodian_0; 
		}
		}
		
		void state_lock_4_item_1_3 () {
			text.text = "The lock is bolted tight on the wooden door. The screws, however, match the tip of your Screwdriver. " +
						"You are able to unscrew all the bolts on the lock. \n\n" +
						"Press U to use the Screwdriver!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.use_item_3; 
		}
		}
		
		void state_lock_4_item_1_4 () {
			text.text = "The lock is bolted tight on the wooden door. You try to use the bobby pin, but it broke. " +
						"When you begin to lose hope, you turn around and found a custodial closet behind you. \n\n" +
						"Press C to go to the Custodian closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.custodian_0_item_1_4; 
		}
		}
		
		void state_lock_4_item_2_1 () {
			text.text = "The lock is bolted tight on the wooden door. You try to use the bobby pin, but it broke. " +
						"When you begin to lose hope, you turn around and found a custodial closet behind you. \n\n" +
						"Press C to go to the Custodian closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.custodian_0; 
		}
		}
		
		void state_lock_4_item_2_3 () {
			text.text = "The lock is bolted tight on the wooden door. The screws, however, match the tip of your Screwdriver. " +
						"You are able to unscrew all the bolts on the lock. \n\n" +
						"Press U to use the Screwdriver!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.use_item_3; 
		}
		}
		
		void state_lock_4_item_2_4 () {
			text.text = "The lock is bolted tight on the wooden door. You try to use the bobby pin, but it broke. " +
						"When you begin to lose hope, you turn around and found a custodial closet behind you. \n\n" +
						"Press C to go to the Custodian closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.custodian_0_item_2_4; 
		}
		}
		
		void state_lock_4_item_3_1 () {
			text.text = "The lock is bolted tight on the wooden door. The screws, however, match the tip of your Screwdriver. " +
						"You are able to unscrew all the bolts on the lock. \n\n" +
						"Press U to use the Screwdriver!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.use_item_3; 
		}
		}
		
		void state_lock_4_item_3_2 () {
			text.text = "The lock is bolted tight on the wooden door. The screws, however, match the tip of your Screwdriver. " +
						"You are able to unscrew all the bolts on the lock. \n\n" +
						"Press U to use the Screwdriver!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.use_item_3; 
		}
		}
		
		void state_lock_4_item_3_4 () {
			text.text = "The lock is bolted tight on the wooden door. The screws, however, match the tip of your Screwdriver. " +
						"You check behind you to see a custodian closet. You can either unscrew the lock or find keys. \n\n" +
						"Press U to use the Screwdriver or Press C to go to Custodian closet!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.use_item_3; 
		} else if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.custodian_0_item_3_4; 
		}
		}
		
		void state_lock_4_item_4_1 () {
			text.text = "The lock is bolted tight on the wooden door. You try to use the bobby pin, but it broke. " +
						"When you begin to lose hope, you turn around and found a custodial closet behind you. \n\n" +
						"Press C to go to the Custodian closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.custodian_0_item_4_1; 
		}
		}
		
		void state_lock_4_item_4_2 () {
			text.text = "The lock is bolted tight on the wooden door. You try to use the bobby pin, but it broke. " +
						"When you begin to lose hope, you turn around and found a custodial closet behind you. \n\n" +
						"Press C to go to the Custodian closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.custodian_0_item_4_2; 
		}
		}
		
		void state_lock_4_item_4_3 () {
			text.text = "The lock is bolted tight on the wooden door. The screws, however, match the tip of your Screwdriver. " +
						"You check behind you to see a custodian closet. You can either unscrew the lock or find keys. \n\n" +
						"Press U to use the Screwdriver or Press C to go to Custodian closet!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.use_item_3; 
		} else if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.custodian_0_item_4_3; 
		}
		}
		
		void state_lock_4_item_1_2_3 () {
			text.text = "The lock is bolted tight on the wooden door. The screws, however, match the tip of your Screwdriver. " +
						"You are able to unscrew all the bolts on the lock. \n\n" +
						"Press U to use the Screwdriver!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.use_item_3; 
		}
		}
		
		void state_lock_4_item_1_2_4 () {
			text.text = "The lock is bolted tight on the wooden door. You try to use the bobby pin, but it broke. " +
						"When you begin to lose hope, you turn around and found a custodial closet behind you. \n\n" +
						"Press C to go to the Custodian closet!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.custodian_0_item_1_2_4; 
		}
		}
		
		void state_lock_4_item_1_3_2 () {
			text.text = "The lock is bolted tight on the wooden door. The screws, however, match the tip of your Screwdriver. " +
						"You are able to unscrew all the bolts on the lock. \n\n" +
						"Press U to use the Screwdriver!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.use_item_3; 
		}
		}
		
		void state_lock_4_item_1_3_4 () {
			text.text = "The lock is bolted tight on the wooden door. The screws, however, match the tip of your Screwdriver. " +
						"You check behind you to see a custodian closet. You can either unscrew the lock or find keys. \n\n" +
						"Press U to use the Screwdriver or Press C to go to Custodian closet!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.use_item_3; 
		} else if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.custodian_0_item_1_3_4; 
		}
		}
		
		void state_lock_4_item_1_4_2 () {
			text.text = "The lock is bolted tight on the wooden door. You try to use the bobby pin, but it broke. " +
						"When you begin to lose hope, you turn around and found a custodial closet behind you. \n\n" +
						"Press C to go to the Custodian closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.custodian_0_item_1_4_2; 
		}
		}
		
		void state_lock_4_item_1_4_3 () {
			text.text = "The lock is bolted tight on the wooden door. The screws, however, match the tip of your Screwdriver. " +
						"You check behind you to see a custodian closet. You can either unscrew the lock or find keys. \n\n" +
						"Press U to use the Screwdriver or Press C to go to Custodian closet!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.use_item_3; 
		} else if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.custodian_0_item_1_4_3; 
		}
		}
		
		void state_lock_4_item_2_1_3 () {
			text.text = "The lock is bolted tight on the wooden door. The screws, however, match the tip of your Screwdriver. " +
						"You are able to unscrew all the bolts on the lock. \n\n" +
						"Press U to use the Screwdriver!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.use_item_3; 
		}
		}
		
		void state_lock_4_item_2_1_4 () {
			text.text = "The lock is bolted tight on the wooden door. You try to use the bobby pin, but it broke. " +
						"When you begin to lose hope, you turn around and found a custodial closet behind you. \n\n" +
						"Press C to go to the Custodian closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.custodian_0_item_2_1_4; 
		}
		}
		
		void state_lock_4_item_2_3_1 () {
			text.text = "The lock is bolted tight on the wooden door. The screws, however, match the tip of your Screwdriver. " +
						"You are able to unscrew all the bolts on the lock. \n\n" +
						"Press U to use the Screwdriver!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.use_item_3; 
		}
		}
		
		void state_lock_4_item_2_3_4 () {
			text.text = "The lock is bolted tight on the wooden door. The screws, however, match the tip of your Screwdriver. " +
						"You check behind you to see a custodian closet. You can either unscrew the lock or find keys. \n\n" +
						"Press U to use the Screwdriver or Press C to go to Custodian closet!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.use_item_3; 
		} else if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.custodian_0_item_2_3_4; 
		}
		}
		
		void state_lock_4_item_2_4_1 () {
			text.text = "The lock is bolted tight on the wooden door. You try to use the bobby pin, but it broke. " +
						"When you begin to lose hope, you turn around and found a custodial closet behind you. \n\n" +
						"Press C to go to the Custodian closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.custodian_0_item_2_4_1; 
		}
		}
		
		void state_lock_4_item_2_4_3 () {
			text.text = "The lock is bolted tight on the wooden door. The screws, however, match the tip of your Screwdriver. " +
						"You check behind you to see a custodian closet. You can either unscrew the lock or find keys. \n\n" +
						"Press U to use the Screwdriver or Press C to go to Custodian closet!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.use_item_3; 
		} else if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.custodian_0_item_2_4_3; 
		}
		}
		
		void state_lock_4_item_3_1_2 () {
			text.text = "The lock is bolted tight on the wooden door. The screws, however, match the tip of your Screwdriver. " +
						"You are able to unscrew all the bolts on the lock. \n\n" +
						"Press U to use the Screwdriver!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.use_item_3; 
		}
		}
		
		void state_lock_4_item_3_1_4 () {
			text.text = "The lock is bolted tight on the wooden door. The screws, however, match the tip of your Screwdriver. " +
						"You check behind you to see a custodian closet. You can either unscrew the lock or find keys. \n\n" +
						"Press U to use the Screwdriver or Press C to go to Custodian closet!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.use_item_3; 
		} else if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.custodian_0_item_3_1_4; 
		}
		}
		
		void state_lock_4_item_3_2_1 () {
			text.text = "The lock is bolted tight on the wooden door. The screws, however, match the tip of your Screwdriver. " +
						"You are able to unscrew all the bolts on the lock. \n\n" +
						"Press U to use the Screwdriver!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.use_item_3; 
		}
		}
		
		void state_lock_4_item_3_2_4 () {
			text.text = "The lock is bolted tight on the wooden door. The screws, however, match the tip of your Screwdriver. " +
						"You check behind you to see a custodian closet. You can either unscrew the lock or find keys. \n\n" +
						"Press U to use the Screwdriver or Press C to go to Custodian closet!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.use_item_3; 
		} else if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.custodian_0_item_3_2_4; 
		}
		}
		
		void state_lock_4_item_3_4_1 () {
			text.text = "The lock is bolted tight on the wooden door. The screws, however, match the tip of your Screwdriver. " +
						"You check behind you to see a custodian closet. You can either unscrew the lock or find keys. \n\n" +
						"Press U to use the Screwdriver or Press C to go to Custodian closet!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.use_item_3; 
		} else if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.custodian_0_item_3_4_1; 
		}
		}
		
		void state_lock_4_item_3_4_2 () {
			text.text = "The lock is bolted tight on the wooden door. The screws, however, match the tip of your Screwdriver. " +
						"You check behind you to see a custodian closet. You can either unscrew the lock or find keys. \n\n" +
						"Press U to use the Screwdriver or Press C to go to Custodian closet!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.use_item_3; 
		} else if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.custodian_0_item_3_4_2; 
		}
		}
		
		void state_lock_4_item_4_1_2 () {
			text.text = "The lock is bolted tight on the wooden door. You try to use the bobby pin, but it broke. " +
						"When you begin to lose hope, you turn around and found a custodial closet behind you. \n\n" +
						"Press C to go to the Custodian closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.custodian_0_item_4_1_2; 
		}
		}
		
		void state_lock_4_item_4_1_3 () {
			text.text = "The lock is bolted tight on the wooden door. The screws, however, match the tip of your Screwdriver. " +
						"You check behind you to see a custodian closet. You can either unscrew the lock or find keys. \n\n" +
						"Press U to use the Screwdriver or Press C to go to Custodian closet!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.use_item_3; 
		} else if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.custodian_0_item_4_1_3; 
		}
		}
		
		void state_lock_4_item_4_2_1 () {
			text.text = "The lock is bolted tight on the wooden door. You try to use the bobby pin, but it broke. " +
						"When you begin to lose hope, you turn around and found a custodial closet behind you. \n\n" +
						"Press C to go to the Custodian closet!";
		 if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.custodian_0_item_4_2_1; 
		}
		}
		
		void state_lock_4_item_4_2_3 () {
			text.text = "The lock is bolted tight on the wooden door. The screws, however, match the tip of your Screwdriver. " +
						"You check behind you to see a custodian closet. You can either unscrew the lock or find keys. \n\n" +
						"Press U to use the Screwdriver or Press C to go to Custodian closet!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.use_item_3; 
		} else if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.custodian_0_item_4_2_3; 
		}
		}
		
		void state_lock_4_item_4_3_1 () {
			text.text = "The lock is bolted tight on the wooden door. The screws, however, match the tip of your Screwdriver. " +
						"You check behind you to see a custodian closet. You can either unscrew the lock or find keys. \n\n" +
						"Press U to use the Screwdriver or Press C to go to Custodian closet!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.use_item_3; 
		} else if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.custodian_0_item_4_3_1; 
		}
		}
		
		void state_lock_4_item_4_3_2 () {
			text.text = "The lock is bolted tight on the wooden door. The screws, however, match the tip of your Screwdriver. " +
						"You check behind you to see a custodian closet. You can either unscrew the lock or find keys. \n\n" +
						"Press U to use the Screwdriver or Press C to go to Custodian closet!";
		 if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.use_item_3; 
		} else if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.custodian_0_item_4_3_2; 
		}
		}
		
		void state_use_item_3 () {
			text.text = "You successfully detach the lock on the wooden door. \n\n" +
						"Press O to open the Closet!";
		 if (Input.GetKeyDown(KeyCode.O)) {
			myState = States.closet_1; 
		}
		}
		
		
		void state_custodian_0 () {
			text.text = "You arrive at the custodian closet and it is slightly open. " +
						"You slowly push the door and find yourself making eye contact with a custodian. " +
						"The custodian is not pleased to see you, there is awkard silence, but you see keys behind the custodian. \n\n" +
						"Press F to fight the Custodian or Press L to leave the Custodian alone!";
		 if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.custodian_1; 
		} else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.game_over_1; 
		}
		}
		
		void state_custodian_0_item_4 () {
			text.text = "You arrive at the custodian closet and it is slightly open. " +
						"You slowly push the door and find yourself making eye contact with a custodian. " +
						"The custodian is not pleased to see you, there is awkard silence, but you see keys behind the custodian. " +
						"The custodian notices your golden Brass knuckles. \n\n" +
						"Press T to trade Brass knuckles, Press F to fight the Custodian, or Press L to leave the Custodian alone!";
		 if (Input.GetKeyDown(KeyCode.T)) {
			myState = States.use_item_4; 
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.custodian_1; 
		} else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.game_over_1; 
		}
		}
		
		void state_custodian_0_item_1_4 () {
			text.text = "You arrive at the custodian closet and it is slightly open. " +
						"You slowly push the door and find yourself making eye contact with a custodian. " +
						"The custodian is not pleased to see you, there is awkard silence, but you see keys behind the custodian. " +
						"The custodian notices your golden Brass knuckles. \n\n" +
						"Press T to trade Brass knuckles, Press F to fight the Custodian, or Press L to leave the Custodian alone!";
		 if (Input.GetKeyDown(KeyCode.T)) {
			myState = States.use_item_4; 
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.custodian_1; 
		} else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.game_over_1; 
		}
		}
		
		void state_custodian_0_item_2_4 () {
			text.text = "You arrive at the custodian closet and it is slightly open. " +
						"You slowly push the door and find yourself making eye contact with a custodian. " +
						"The custodian is not pleased to see you, there is awkard silence, but you see keys behind the custodian. " +
						"The custodian notices your golden Brass knuckles. \n\n" +
						"Press T to trade Brass knuckles, Press F to fight the Custodian, or Press L to leave the Custodian alone!";
		 if (Input.GetKeyDown(KeyCode.T)) {
			myState = States.use_item_4; 
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.custodian_1; 
		} else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.game_over_1; 
		}
		}
		
		void state_custodian_0_item_3_4 () {
			text.text = "You arrive at the custodian closet and it is slightly open. " +
						"You slowly push the door and find yourself making eye contact with a custodian. " +
						"The custodian is not pleased to see you, there is awkard silence, but you see keys behind the custodian. " +
						"The custodian notices your golden Brass knuckles. \n\n" +
						"Press T to trade Brass knuckles, Press F to fight the Custodian, or Press L to leave the Custodian alone!";
		 if (Input.GetKeyDown(KeyCode.T)) {
			myState = States.use_item_4; 
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.custodian_1; 
		} else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.game_over_1; 
		}
		}
		
		void state_custodian_0_item_4_1 () {
			text.text = "You arrive at the custodian closet and it is slightly open. " +
						"You slowly push the door and find yourself making eye contact with a custodian. " +
						"The custodian is not pleased to see you, there is awkard silence, but you see keys behind the custodian. " +
						"The custodian notices your golden Brass knuckles. \n\n" +
						"Press T to trade Brass knuckles, Press F to fight the Custodian, or Press L to leave the Custodian alone!";
		 if (Input.GetKeyDown(KeyCode.T)) {
			myState = States.use_item_4; 
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.custodian_1; 
		} else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.game_over_1; 
		}
		}
		
		void state_custodian_0_item_4_2 () {
			text.text = "You arrive at the custodian closet and it is slightly open. " +
						"You slowly push the door and find yourself making eye contact with a custodian. " +
						"The custodian is not pleased to see you, there is awkard silence, but you see keys behind the custodian. " +
						"The custodian notices your golden Brass knuckles. \n\n" +
						"Press T to trade Brass knuckles, Press F to fight the Custodian, or Press L to leave the Custodian alone!";
		 if (Input.GetKeyDown(KeyCode.T)) {
			myState = States.use_item_4; 
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.custodian_1; 
		} else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.game_over_1; 
		}
		}
		
		void state_custodian_0_item_4_3 () {
			text.text = "You arrive at the custodian closet and it is slightly open. " +
						"You slowly push the door and find yourself making eye contact with a custodian. " +
						"The custodian is not pleased to see you, there is awkard silence, but you see keys behind the custodian. " +
						"The custodian notices your golden Brass knuckles. \n\n" +
						"Press T to trade Brass knuckles, Press F to fight the Custodian, or Press L to leave the Custodian alone!";
		 if (Input.GetKeyDown(KeyCode.T)) {
			myState = States.use_item_4; 
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.custodian_1; 
		} else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.game_over_1; 
		}
		}
		
		void state_custodian_0_item_1_2_4 () {
			text.text = "You arrive at the custodian closet and it is slightly open. " +
						"You slowly push the door and find yourself making eye contact with a custodian. " +
						"The custodian is not pleased to see you, there is awkard silence, but you see keys behind the custodian. " +
						"The custodian notices your golden Brass knuckles. \n\n" +
						"Press T to trade Brass knuckles, Press F to fight the Custodian, or Press L to leave the Custodian alone!";
		 if (Input.GetKeyDown(KeyCode.T)) {
			myState = States.use_item_4; 
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.custodian_1; 
		} else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.game_over_1; 
		}
		}
		
		void state_custodian_0_item_1_3_4 () {
			text.text = "You arrive at the custodian closet and it is slightly open. " +
						"You slowly push the door and find yourself making eye contact with a custodian. " +
						"The custodian is not pleased to see you, there is awkard silence, but you see keys behind the custodian. " +
						"The custodian notices your golden Brass knuckles. \n\n" +
						"Press T to trade Brass knuckles, Press F to fight the Custodian, or Press L to leave the Custodian alone!";
		 if (Input.GetKeyDown(KeyCode.T)) {
			myState = States.use_item_4; 
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.custodian_1; 
		} else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.game_over_1; 
		}
		}
		
		void state_custodian_0_item_1_4_2 () {
			text.text = "You arrive at the custodian closet and it is slightly open. " +
						"You slowly push the door and find yourself making eye contact with a custodian. " +
						"The custodian is not pleased to see you, there is awkard silence, but you see keys behind the custodian. " +
						"The custodian notices your golden Brass knuckles. \n\n" +
						"Press T to trade Brass knuckles, Press F to fight the Custodian, or Press L to leave the Custodian alone!";
		 if (Input.GetKeyDown(KeyCode.T)) {
			myState = States.use_item_4; 
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.custodian_1; 
		} else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.game_over_1; 
		}
		}
		
		void state_custodian_0_item_1_4_3 () {
			text.text = "You arrive at the custodian closet and it is slightly open. " +
						"You slowly push the door and find yourself making eye contact with a custodian. " +
						"The custodian is not pleased to see you, there is awkard silence, but you see keys behind the custodian. " +
						"The custodian notices your golden Brass knuckles. \n\n" +
						"Press T to trade Brass knuckles, Press F to fight the Custodian, or Press L to leave the Custodian alone!";
		 if (Input.GetKeyDown(KeyCode.T)) {
			myState = States.use_item_4; 
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.custodian_1; 
		} else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.game_over_1; 
		}
		}
		
		void state_custodian_0_item_2_1_4 () {
			text.text = "You arrive at the custodian closet and it is slightly open. " +
						"You slowly push the door and find yourself making eye contact with a custodian. " +
						"The custodian is not pleased to see you, there is awkard silence, but you see keys behind the custodian. " +
						"The custodian notices your golden Brass knuckles. \n\n" +
						"Press T to trade Brass knuckles, Press F to fight the Custodian, or Press L to leave the Custodian alone!";
		 if (Input.GetKeyDown(KeyCode.T)) {
			myState = States.use_item_4; 
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.custodian_1; 
		} else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.game_over_1; 
		}
		}
		
		void state_custodian_0_item_2_3_4 () {
			text.text = "You arrive at the custodian closet and it is slightly open. " +
						"You slowly push the door and find yourself making eye contact with a custodian. " +
						"The custodian is not pleased to see you, there is awkard silence, but you see keys behind the custodian. " +
						"The custodian notices your golden Brass knuckles. \n\n" +
						"Press T to trade Brass knuckles, Press F to fight the Custodian, or Press L to leave the Custodian alone!";
		 if (Input.GetKeyDown(KeyCode.T)) {
			myState = States.use_item_4; 
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.custodian_1; 
		} else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.game_over_1; 
		}
		}
		
		void state_custodian_0_item_2_4_1 () {
			text.text = "You arrive at the custodian closet and it is slightly open. " +
						"You slowly push the door and find yourself making eye contact with a custodian. " +
						"The custodian is not pleased to see you, there is awkard silence, but you see keys behind the custodian. " +
						"The custodian notices your golden Brass knuckles. \n\n" +
						"Press T to trade Brass knuckles, Press F to fight the Custodian, or Press L to leave the Custodian alone!";
		 if (Input.GetKeyDown(KeyCode.T)) {
			myState = States.use_item_4; 
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.custodian_1; 
		} else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.game_over_1; 
		}
		}
		
		void state_custodian_0_item_2_4_3 () {
			text.text = "You arrive at the custodian closet and it is slightly open. " +
						"You slowly push the door and find yourself making eye contact with a custodian. " +
						"The custodian is not pleased to see you, there is awkard silence, but you see keys behind the custodian. " +
						"The custodian notices your golden Brass knuckles. \n\n" +
						"Press T to trade Brass knuckles, Press F to fight the Custodian, or Press L to leave the Custodian alone!";
		 if (Input.GetKeyDown(KeyCode.T)) {
			myState = States.use_item_4; 
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.custodian_1; 
		} else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.game_over_1; 
		}
		}
		
		void state_custodian_0_item_3_1_4 () {
			text.text = "You arrive at the custodian closet and it is slightly open. " +
						"You slowly push the door and find yourself making eye contact with a custodian. " +
						"The custodian is not pleased to see you, there is awkard silence, but you see keys behind the custodian. " +
						"The custodian notices your golden Brass knuckles. \n\n" +
						"Press T to trade Brass knuckles, Press F to fight the Custodian, or Press L to leave the Custodian alone!";
		 if (Input.GetKeyDown(KeyCode.T)) {
			myState = States.use_item_4; 
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.custodian_1; 
		} else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.game_over_1; 
		}
		}
		
		void state_custodian_0_item_3_2_4 () {
			text.text = "You arrive at the custodian closet and it is slightly open. " +
						"You slowly push the door and find yourself making eye contact with a custodian. " +
						"The custodian is not pleased to see you, there is awkard silence, but you see keys behind the custodian. " +
						"The custodian notices your golden Brass knuckles. \n\n" +
						"Press T to trade Brass knuckles, Press F to fight the Custodian, or Press L to leave the Custodian alone!";
		 if (Input.GetKeyDown(KeyCode.T)) {
			myState = States.use_item_4; 
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.custodian_1; 
		} else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.game_over_1; 
		}
		}
		
		void state_custodian_0_item_3_4_1 () {
			text.text = "You arrive at the custodian closet and it is slightly open. " +
						"You slowly push the door and find yourself making eye contact with a custodian. " +
						"The custodian is not pleased to see you, there is awkard silence, but you see keys behind the custodian. " +
						"The custodian notices your golden Brass knuckles. \n\n" +
						"Press T to trade Brass knuckles, Press F to fight the Custodian, or Press L to leave the Custodian alone!";
		 if (Input.GetKeyDown(KeyCode.T)) {
			myState = States.use_item_4; 
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.custodian_1; 
		} else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.game_over_1; 
		}
		}
		
		void state_custodian_0_item_3_4_2 () {
			text.text = "You arrive at the custodian closet and it is slightly open. " +
						"You slowly push the door and find yourself making eye contact with a custodian. " +
						"The custodian is not pleased to see you, there is awkard silence, but you see keys behind the custodian. " +
						"The custodian notices your golden Brass knuckles. \n\n" +
						"Press T to trade Brass knuckles, Press F to fight the Custodian, or Press L to leave the Custodian alone!";
		 if (Input.GetKeyDown(KeyCode.T)) {
			myState = States.use_item_4; 
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.custodian_1; 
		} else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.game_over_1; 
		}
		}
		
		void state_custodian_0_item_4_1_2 () {
			text.text = "You arrive at the custodian closet and it is slightly open. " +
						"You slowly push the door and find yourself making eye contact with a custodian. " +
						"The custodian is not pleased to see you, there is awkard silence, but you see keys behind the custodian. " +
						"The custodian notices your golden Brass knuckles. \n\n" +
						"Press T to trade Brass knuckles, Press F to fight the Custodian, or Press L to leave the Custodian alone!";
		 if (Input.GetKeyDown(KeyCode.T)) {
			myState = States.use_item_4; 
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.custodian_1; 
		} else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.game_over_1; 
		}
		}
		
		void state_custodian_0_item_4_1_3 () {
			text.text = "You arrive at the custodian closet and it is slightly open. " +
						"You slowly push the door and find yourself making eye contact with a custodian. " +
						"The custodian is not pleased to see you, there is awkard silence, but you see keys behind the custodian. " +
						"The custodian notices your golden Brass knuckles. \n\n" +
						"Press T to trade Brass knuckles, Press F to fight the Custodian, or Press L to leave the Custodian alone!";
		 if (Input.GetKeyDown(KeyCode.T)) {
			myState = States.use_item_4; 
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.custodian_1; 
		} else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.game_over_1; 
		}
		}
		
		void state_custodian_0_item_4_2_1 () {
			text.text = "You arrive at the custodian closet and it is slightly open. " +
						"You slowly push the door and find yourself making eye contact with a custodian. " +
						"The custodian is not pleased to see you, there is awkard silence, but you see keys behind the custodian. " +
						"The custodian notices your golden Brass knuckles. \n\n" +
						"Press T to trade Brass knuckles, Press F to fight the Custodian, or Press L to leave the Custodian alone!";
		 if (Input.GetKeyDown(KeyCode.T)) {
			myState = States.use_item_4; 
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.custodian_1; 
		} else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.game_over_1; 
		}
		}
		
		void state_custodian_0_item_4_2_3 () {
			text.text = "You arrive at the custodian closet and it is slightly open. " +
						"You slowly push the door and find yourself making eye contact with a custodian. " +
						"The custodian is not pleased to see you, there is awkard silence, but you see keys behind the custodian. " +
						"The custodian notices your golden Brass knuckles. \n\n" +
						"Press T to trade Brass knuckles, Press F to fight the Custodian, or Press L to leave the Custodian alone!";
		 if (Input.GetKeyDown(KeyCode.T)) {
			myState = States.use_item_4; 
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.custodian_1; 
		} else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.game_over_1; 
		}
		}
		
		void state_custodian_0_item_4_3_1 () {
			text.text = "You arrive at the custodian closet and it is slightly open. " +
						"You slowly push the door and find yourself making eye contact with a custodian. " +
						"The custodian is not pleased to see you, there is awkard silence, but you see keys behind the custodian. " +
						"The custodian notices your golden Brass knuckles. \n\n" +
						"Press T to trade Brass knuckles, Press F to fight the Custodian, or Press L to leave the Custodian alone!";
		 if (Input.GetKeyDown(KeyCode.T)) {
			myState = States.use_item_4; 
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.custodian_1; 
		} else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.game_over_1; 
		}
		}
		
		void state_custodian_0_item_4_3_2 () {
			text.text = "You arrive at the custodian closet and it is slightly open. " +
						"You slowly push the door and find yourself making eye contact with a custodian. " +
						"The custodian is not pleased to see you, there is awkard silence, but you see keys behind the custodian. " +
						"The custodian notices your golden Brass knuckles. \n\n" +
						"Press T to trade Brass knuckles, Press F to fight the Custodian, or Press L to leave the Custodian alone!";
		 if (Input.GetKeyDown(KeyCode.T)) {
			myState = States.use_item_4; 
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.custodian_1; 
		} else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.game_over_1; 
		}
		}
		
		void state_use_item_4 () {
			text.text = "You traded your golden Brass knuckles with the custodian. " +
						"You maintain eye contact with the custodian to chack that they will not use them against you. " +
						"The custodian is thankful for the golden Brass knuckles and gives you the keys. \n\n" +
						"Press K to grab the Keys!";
		 if (Input.GetKeyDown(KeyCode.K)) {
			myState = States.keys_0; 
		}
		}
		
		void state_custodian_1 () {
			text.text = "You throw a quick jab striking the custodian's nose! The custodian, attempts to tackle you! " +
						"You move to a sprawl postion and put the custodian in a guillotine choke! The custodian punches at your rib " +
						"cage in desperation, but you are not letting go! In 20 seconds the custodian passes out! You then reachout for the keys. \n\n" +
						"Press K to grab the keys!";
		 if (Input.GetKeyDown(KeyCode.K)) {
			myState = States.keys_1; 
		}
		}
		
		void state_game_over_1 () {
			text.text = "You reach over the custodian to grab the keys. " +
						"The custodian shoves you to the wall and locks you in the closet. The custodian alerts the prison guards that you " +
						"left your cell. The guards then escort you back to your cell. You missed your opportunity to escape the Booty Warrior! \n\n" +
						"GAME OVER! Press P to play again!";
		 if (Input.GetKeyDown(KeyCode.P)) {
			myState = States.cell; 
		}
		}
		
		void state_keys_0 () {
			text.text = "You are reliefed that you did not have to draw blood to get the keys. " +
						"You quickly return to the closet found in the barracks before the prison guards arrive. \n\n" +
						"Press I to inspect the lock!";
		 if (Input.GetKeyDown(KeyCode.I)) {
			myState = States.lock_5; 
		}
		}
		
		void state_keys_1 () {
			text.text = "You grab the keys over the custodian's body. " +
						"You see them face flat with a small pool of blood pouring down their nose. " +
						"You do not give a second thought and return to the closet found in the barracks. \n\n" +
						"Press I to inspect the lock!";
		 if (Input.GetKeyDown(KeyCode.I)) {
			myState = States.lock_5; 
		}
		}
		
		void state_lock_5 () {
			text.text = "You shuffle throught the keys to find a perfect match. " +
						"Eventually you find the right match and unlock the door. \n\n" +
						"Press O to open the Closet!";
		 if (Input.GetKeyDown(KeyCode.O)) {
			myState = States.closet_1; 
		}
		}
		
		void state_closet_1 () {
			text.text = "You tap on the center of the Flashlight, illuminating a bright white ray. " +
						"You are concerned the brightness of the Flashlight will give away your position so you move quick. \n\n" +
						"Press S to continue down the Stairs!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.uniform_0; 
		}
		}
		
		void state_uniform_0 () {
			text.text = "You put on the uniform over your prison outfit. " +
						"It feels cozy, this is what your tax dollars pays. " +
						"You move forward near the prison's entrance. \n\n" +
						"Press M to move near the entrance!";
		 if (Input.GetKeyDown(KeyCode.M)) {
			myState = States.court_0; 
		}
		}
		
		void state_court_0 () {
			text.text = "You arrive at the courtyard near the entrance. " +
						"You blend in with the other prison guards. Do not blow your cover! " +
						"You can taste freedom on your fingertips. \n\n" +
						"Press R to run to the gate or Press S to slowly make your way to the gate!";
		 if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.gate_0; 
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.game_over_2; 
		}
		}
		
		void state_gate_0 () {
			text.text = "You keep your cool and slowly make your way to the gate. " +
						"One of the prison guards thinks you arrive to cover the night watch. " + 
						"He leaves and you are alone at the front gate. \n\n" +
						"Press E to escape the Prison!";
		 if (Input.GetKeyDown(KeyCode.E)) {
			myState = States.freedom; 
		} 
		}
		
		void state_game_over_2 () {
			text.text = "You lost your cool and decide to make a break for the front gate. " +
						"The prison guards become suspicious and tackle you to stop you on your tracks. " + 
						"They return you to your cell. You missed your chance to escape the Booty Warrior! \n\n" +
						"GAME OVER! Press P to play again!";
		 if (Input.GetKeyDown(KeyCode.P)) {
			myState = States.cell; 
		} 
		}
		
		void state_freedom () {
			text.text = "You check your surroundings to see other prison guards in the nightwatch. " +
						"You prison guards seem to mind their own business, so you continue to walk forward with your hands on " +
						"your hips to look assertive. You managed to get far enough for the guards not to notice. \n\n" +
						"Congratulations you managed to escape the Booty Warrior! Press P to play again!";
		 if (Input.GetKeyDown(KeyCode.P)) {
			myState = States.cell; 
		} 
		}
		
}

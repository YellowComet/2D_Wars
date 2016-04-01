using UnityEngine;
using System.Collections;

public class Unit {	
	Player player;
	int type;
	int health;

	public Unit(Player player, int type, int health) {
		this.player = player;
		this.type = type;
		this.health = health;
	}
}
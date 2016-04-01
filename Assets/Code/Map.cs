using UnityEngine;
using System.Collections;


/*
 * 0 = sea
 * 1 = grass
 * 2 = mountain
 * 3 = road
 * */


public class Map : MonoBehaviour {
	int[,] terrainGrid;
	string[] tileType = new string[] { "SeaTile", "GrassTile", "MountainTile", "RoadTile" };

	public Map() {
		this.terrainGrid = new int[3, 3];

		for (int i = 0; i < terrainGrid.GetLength (0); i++)
			for (int j = 0; j < terrainGrid.GetLength (1); j++)
				terrainGrid [i, j] = (i*j + i + j + 1)%4;
	}

	public void readMapFromFile(string map) {
		// TODO
	}

	public void drawMap() {
		GameObject tile;
		Vector3 pos;

		for (int i = 0; i < terrainGrid.GetLength (0); i++)
			for (int j = 0; j < terrainGrid.GetLength (1); j++) {
				pos = new Vector3 (i, j, 0);
				tile = (GameObject) Resources.Load(tileType[terrainGrid[i,j]]);
				Instantiate (tile, pos, Quaternion.identity);
			}
	}

}
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public enum Menu {
		MainMenu,
		NewGame,
		Continue
	}

	public Menu currentMenu;

	void OnGUI () {

		GUILayout.BeginArea(new Rect(0,0,Screen.width, Screen.height));
		GUILayout.BeginHorizontal();
		GUILayout.FlexibleSpace();
		GUILayout.BeginVertical();
		GUILayout.FlexibleSpace();

		if(currentMenu == Menu.MainMenu) {

			GUILayout.Box("Boxe VR");
			GUILayout.Space(10);

			if(GUILayout.Button("Nouveau Sac")) {
				Game.current = new Game();
				currentMenu = Menu.NewGame;
			}

			if(GUILayout.Button("Continuer")) {
				SaveLoad.Load();
				currentMenu = Menu.Continue;
			}

			if(GUILayout.Button("Quitter")) {
				Application.Quit();
			}
		}

		else if (currentMenu == Menu.NewGame) {

			GUILayout.Box("Création de votre Sac");
			GUILayout.Space(10);

            /*GUILayout.Label("Hauteur");
            Game.current.sac.h = GUILayout.TextField(Game.current.sac.h, 20);*/

            GUILayout.Label("Diametre (cm)");
			Game.current.sac.diametre = float.Parse(GUILayout.TextField(Game.current.sac.diametre.ToString(), 2));
            GUILayout.Label("Hauteur (cm)");
            Game.current.sac.hauteur = float.Parse(GUILayout.TextField(Game.current.sac.hauteur.ToString(), 3));
            GUILayout.Label("Poids (kg)");
            Game.current.sac.masse = float.Parse(GUILayout.TextField(Game.current.sac.masse.ToString(), 3));/*
			GUILayout.Label("Rogue");
			Game.current.rogue.name = GUILayout.TextField(Game.current.rogue.name, 20);
			GUILayout.Label("Wizard");
			Game.current.wizard.name = GUILayout.TextField(Game.current.wizard.name, 20);*/

            if (GUILayout.Button("Save")) {
				//Save the current Game as a new saved Game
				SaveLoad.Save();
				//Move on to game...
				//Application.LoadLevel(1);
                SceneManager.LoadScene(1);
			}

			GUILayout.Space(10);
			if(GUILayout.Button("Cancel")) {
				currentMenu = Menu.MainMenu;
			}

		}

		else if (currentMenu == Menu.Continue) {
			
			GUILayout.Box("Select Save File");
			GUILayout.Space(10);
			
			foreach(Game g in SaveLoad.savedGames) {
				if(GUILayout.Button("hauteur =" + g.sac.hauteur + "diametre =" + g.sac.diametre)) {
					Game.current = g;
					//Move on to game...
					//Application.LoadLevel(1);
                    SceneManager.LoadScene(1);
                }

			}

			GUILayout.Space(10);
			if(GUILayout.Button("Cancel")) {
				currentMenu = Menu.MainMenu;
			}
			
		}

		GUILayout.FlexibleSpace();
		GUILayout.EndVertical();
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		GUILayout.EndArea();

	}
}

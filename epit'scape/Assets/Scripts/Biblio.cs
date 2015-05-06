using UnityEngine;
using System.Collections;

public class Biblio : MonoBehaviour {
    public static bool english;

    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public static string Text(string word)
    {
        switch(word)
        {
            case "retJeu":
                if (english)
                    return "back to game";
                else
                    return "retour au jeu";
            case "recupCles":
                if (english)
                    return "you must \nfind the \nkeys! ";
                else
                    return "tu dois \nretrouver \nles cles!";
            case "savquit":
                if (english)
                    return "save and quit";
                else
                    return "sauvegarder et quitter";
            case "back":
                if (english)
                    return "Back";
                else
                    return "Retour";

            case "newgame":
                if (english)
                    return "New Game";
                else
                    return "Nouvelle Partie";

            case "load":
                if (english)
                    return "Load Game";
                else
                    return "Charger";

            case "select":
                if (english)
                    return "Level Select";
                else
                    return "Niveaux";

            case "selectlvl":
                if (english)
                    return "Select a level";
                else
                    return "Choisir niveau";

            case "mult":
                if (english)
                    return "Multiplayer";
                else
                    return "Multijoueur";

            case "quit":
                if (english)
                    return "Quit";
                else
                    return "Quitter";

            case "saved":
                if (english)
                    return "Saved";
                else
                    return "Sauvegarde";

            case "out":
                if (english)
                    return "Outdoor";
                else
                    return "Cours";

            case "lvl1":
                if (english)
                    return "Floor 2";
                else
                    return "Etage 1";

            case "lvl0":
                if (english)
                    return "Floor 1";
                else
                    return "RDC";

            case "lang":
                if (english)
                    return "Français";
                else
                    return "English";

            default:
                return "???";
        }
    }
}

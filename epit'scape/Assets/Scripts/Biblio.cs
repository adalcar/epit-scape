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
            case "killallzomb2":
                if (english)
                    return "so many zombies, this place is infested, i have to clear it";
                else
                    return "encore des zombies... il y en a partout!";
            case "killallzomb1":
                if (english)
                    return "what the... where do those... zombies come from??";
                else
                    return "Bon sang! ca grouille de... zombies???? ";
            case "Restzomb":
                if (english)
                    return "There are still zombies left! I must clean up this place";
                else
                    return "il reste encore des zombies! je dois nettoyer cet etage";
            case "goUp":
                if (english)
                    return "Doors to the stairs opened. Go to the fourth floor.";
                else
                    return "Les portes des escaliers sont ouvertes. Va au 3e étage.";

            case "findpen":
                if (english)
                    return "I'd better find something to defend myself, there must be something in the offices!";
                else
                    return "Il me faudrait quelque chose pour me defendre, je devrais trouver mon bonheur dans un de ces bureaux";

            case "tutoshoot":
                if (english)
                    return "Use the left mouse button to attack";
                else
                    return "Clic gauche pour attaquer";

            case "tutoswitch":
                if (english)
                    return "Use the scroll wheel to switch between weapons";
                else
                    return "Utilisez la molette de la souris pour changer d'arme";

            case "tutomove":
                if (english)
                    return "Use the arrows or WASD keys to move, and the mouse to look around";
                else
                    return "Utiliser les fleches directionnelles pour se deplacer";

            case "up":
                if (english)
                    return "Forward";
                else
                    return "Avancer";

            case "down":
                if (english)
                    return "Back";
                else
                    return "Reculer";

            case "right":
                if (english)
                    return "Right";
                else
                    return "Droite";

            case "left":
                if (english)
                    return "Left";
                else
                    return "Gauche";

            case "del":
                if (english)
                    return "Erase";
                else
                    return "Supprimer";

            case "retJeu":
                if (english)
                    return "Back to game";
                else
                    return "Retour au jeu";

            case "recupCles":
                if (english)
                    return "It's closed, find the keys !";
                else
                    return "C'est fermé, trouve les clefs !";

            case "savquit":
                if (english)
                    return "Save and quit";
                else
                    return "Sauvegarder et quitter";

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
            case "save":
                if (english)
                    return "Save";
                else
                    return "Sauvegarde";
            default:
                return "???";
        }
    }
}

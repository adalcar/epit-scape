﻿using UnityEngine;
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
            case "findpen":
                if (english)
                    return "I'd better find something to defend myself, there must be something in the offices!";
                else
                    return "Il me faudrait quelque chose pour me defendre, je devrais trouver mon bonheur dans un de ces bureaux";
            case "closedDoor":
                if (english)
                    return "The door is closed, it seems, electronically. There must be a switch somewhere!";
                else
                    return "La porte est fermee electroniquement! il doit y avoir un interrupteur quelque part.";
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
                    return "You must \nfind the \nkeys! ";
                else
                    return "Tu dois \nretrouver \nles cles!";
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

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

            case "bocal":
                if (english)
                    return "ugh... bocal zombies.. shooldn't be so far from the ordinary";
                else
                    return "brr... des bocaliens zombies, rien que l'idee me terrifie";
            case "finalboss":
                if (english)
                    return "why did i ever hope it would end... alright now i'm mad this big guy's gonna eat it raw";
                else
                    return "evidemment, encore un, fallait s'y attendre";
            case "underdone":
                if (english)
                    return "good, let's leave this god-forsaken place and go home, i'm getting tired of those jokes";
                else
                    return "bien, ca c'est fait, sortons d'ici avant que  d'autres ne rappliquent";
            case "killallzomb6":
                if (english)
                    return "nice, a bunch of zombies just arrived, great timing to try out my new weapon!";
                else
                    return "parfait, un paquet de zombies vient d'arriver, pile poil pour tester ma mouvelle arme!";
            case "findBL":
                if (english)
                    return "i swear... a banana... what the heck, come to think of it i heard the ing2 speak of bananas, it was  somewhere deep in the wtf world of the under";
                else
                    return "maintenant que j'y pense, j'avais entendu des ing2 parler de lance bananes, c'etait vers le fond de l'under";
            case "bananadone":
                if (english)
                    return "that was... weird... Alright, let's go to the under, maybe we'll find the answer here";
                else
                    return "bon, on va faire comme si on avait rien vu et on va continuer, l'acces a l'under est ouvert";
            case "banana":
                if (english)
                    return "wait.... what?? giants bananas, too much coding, i'm getting hallucinations... and it's shooting bananas?";
                else
                    return "heu... il se passe quoi la? j'en suis juste a un rush de projet, meme pas a la piscine, pourquoi j'ai des hallucinations?";
            case "goKB":
                if (english)
                    return "Great! the door is open! now I can escape this nightmare and go home! nah just kidding, let's have some more fun, ill surely find some help in the main building";
                else
                    return "Parfait! la porte est ouverte! allons au kb voir comment ca se passe la-bas, avec un peu de chance on trouvera de quoi mettre une fin permanente a cette infestation";
            case "killboss1":
                if (english)
                    return "what the hell?? those guys are huge! i've gotta put those experiments out of their misery";
                else
                    return "mais qu'est-ce que c'est que ces monstres? les supbiotechs avaient serieusement des problemes d'ethique avec leurs experiences!";
            case "killallzomb5":
                if (english)
                    return "alright, it's starting to get boring";
                else
                    return "bon bah, c'est reparti";
            case "killallzomb4":
                if (english)
                    return "here too? well it should be obvious";
                else
                    return "ici aussi? bon, je devrais m'attendre a en trouver partout maintenant";
            case "killallzomb3":
                if (english)
                    return "dammit, they already came back! do they reproduce or what?";
                else
                    return "ils sont deja revenus? c'est pas vrai!";
            case "gobocal1":
                if (english)
                    return "perfect ! i always feel better with a keyboard in my hands! it seems there is no way to open the gates from here, how about the bocal then?";
                else
                    return "Parfait, je me sens toujours mieux avec un clavier dans les mains! bon, pas moyen d'ouvrir les portes depuis l'ordi. allons voir au bocal";
            case "findkeyboard":
                if (english)
                    return "good, it seems the zombies didn't find this place \n let'see if i can find something useful, maybe a way to open the gates";
                else
                    return "bon, les zombies ne sont pas encore arrives ici\n voyons ce que je peux y trouver d'interessant, \n peut-etre un moyen de reouvrir les portes";
            case "clear1":
                if (english)
                    return "good! now i can go";
                else
                    return "ca c'est fait, je dois y aller!";
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

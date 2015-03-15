#pragma strict

var Health = 100;

function ApplyDammage (TheDammage : int)
{
	Health -= TheDammage;
	
	if(Health <= 0)
	{
		Dead();
	}
}

function Dead()
{
	Debug.Log("Player Died");
}

function OnGUI()
{
    GUI.Box(Rect(100,0,100,20), "Vie:" + Health);
}

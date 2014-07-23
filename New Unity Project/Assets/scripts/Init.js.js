#pragma strict

var ballTemp:Rigidbody;
var ball:Rigidbody;
var wltupian:String;
var fanhuiTexture:Texture;
var myStyle:GUIStyle;

function Start () {
	ball = Instantiate( ballTemp, Vector3(0, 1, 0), ballTemp.rotation);
//	wltupian = PlayerPrefs.GetString("wl");
	ball.renderer.material.mainTexture = Resources.Load( "风景1", Texture2D);
	ball.velocity = Vector3( -8, 0, -15);
}

function Update () {
	
}

function OnGUI(){
	var ratioScaleTempH = Screen.height / 960.0;
	var ratioScaleTempV = Screen.width / 540.0;
	
}
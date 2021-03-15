using Godot;
using System;

public class MainMenu : Control
{
	[Export] public string HomePage = "www.godotacademy.info";
	[Export] public NodePath MainGame;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

	public void _on_QuitButton_pressed()
	{
		GetTree().Quit(0);
	}

	public void _on_HomepageButton_pressed()
	{
		OS.ShellOpen(HomePage);
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
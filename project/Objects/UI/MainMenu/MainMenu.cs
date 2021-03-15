using Godot;

public class MainMenu : Control
{
	[Export] public string HomePage = "www.godotacademy.info";
	[Export] public Resource MainGame;

	public void _on_PlayButton_pressed()
	{
		GetTree().ChangeScene(MainGame.ResourcePath);
	}

	public void _on_QuitButton_pressed()
	{
		GetTree().Quit(0);
	}

	public void _on_HomepageButton_pressed()
	{
		OS.ShellOpen(HomePage);
	}
}
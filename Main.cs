using Godot;
using System;

public partial class Main : Node{
	int i;
	[Export] Label lbl;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready(){
		i=0;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta){
		lbl.Text = i.ToString();
	}
	public void Click(){
		i++;
	}
}

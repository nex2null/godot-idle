using Godot;
using System;

public class TurnTimer : Timer
{
	private ProgressBar _actionBar;
	private ProgressBar _healthBar;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		this._actionBar = GetNode<ProgressBar>("../ActionBar");
		this._healthBar = GetNode<ProgressBar>("../HealthBar");
	}

	public void _on_TurnTimer_timeout()
	{
		this._actionBar.Value += 1;
		
		if (this._actionBar.Value == 100)
		{
			this._actionBar.Value = 0;
			this._healthBar.Value -= 10;
		}
		
		if (this._healthBar.Value <= 0)
			this.Stop();
	}
}


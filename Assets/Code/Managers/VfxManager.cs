﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VfxManager : Singleton<VfxManager>
{

	[SerializeField] private ParticleSystem GoalGroundHitVfx;
	[SerializeField] private ParticleSystem DebreeGroundHitVfx;

	[SerializeField] private ChromaticAberration ChromaticAberration;

	protected VfxManager ()
	{
	}

	public void EmitGoalGroundHitVfx (Vector3 position)
	{
		GoalGroundHitVfx.transform.position = position;
		GoalGroundHitVfx.Play ();
	}

	public void EmitDebreeGroundHitVfx (Vector3 position)
	{
		DebreeGroundHitVfx.transform.position = position;
		DebreeGroundHitVfx.Play ();
	}

	public void StartChromaticAbberation ()
	{
		ChromaticAberration.StartVfx ();
	}

	public void StartCharacterGlow ()
	{
		Game.Instance.CharacterControllerP1.CharacterGlowController.StartGlowVfx ();
		Game.Instance.CharacterControllerP2.CharacterGlowController.StartGlowVfx ();
	}

}

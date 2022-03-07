using Verse;
using System;
using RimWorld;

namespace DarkCurseBurning
{
	public class Melee_DarkCurseBurning : DamageWorker_AddInjury
	{
		protected override void ApplySpecialEffectsToPart(Pawn pawn, float totalDamage, DamageInfo dinfo, DamageResult result)
		{
				Log.Message(Convert.ToString(pawn));
				Log.Message(Convert.ToString(dinfo));
				Log.Message(Convert.ToString(result));
				Log.Message(Convert.ToString(totalDamage));
			FinalizeAndAddInjury(pawn, totalDamage, dinfo, result);
		}
	}
}
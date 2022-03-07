using Verse;
using RimWorld;

namespace DarkCurseBurning
{
    public class Projectile_DarkCurseBurning : Bullet
    {
        public ModExtension_DarkCurseBurning Props => base.def.GetModExtension<ModExtension_DarkCurseBurning>();

        protected override void Impact(Thing hitThing)
        {
            base.Impact(hitThing);
            if (Props != null && hitThing != null && hitThing is Pawn hitPawn)
            {
                float rand = Rand.Value;
                if (rand <= Props.addHediffChance)
                {
                    Hediff curseOnPawn = hitPawn.health?.hediffSet?.GetFirstHediffOfDef(Props.hediffToAdd);
                    if (curseOnPawn != null)
                    {
                        return;
                    }
                    else
                    {
                        Hediff hediff = HediffMaker.MakeHediff(Props.hediffToAdd, hitPawn);
                        hediff.Severity = 0.01f;
                        hitPawn.health.AddHediff(hediff);
                    }
                }
            }
        }
    }
}
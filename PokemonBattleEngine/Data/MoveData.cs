﻿using System.Collections.Generic;

namespace Kermalis.PokemonBattleEngine.Data
{
    class PMoveData
    {
        public PType Type;
        public PMoveCategory Category;
        public PMoveEffect Effect;
        public int EffectParam;
        public byte PPTier, Power, Accuracy; // 0 power or accuracy will show up as --
        public sbyte Priority;
        public PMoveFlag Flags;
        public PMoveTarget Targets;

        public static Dictionary<PMove, PMoveData> Data = new Dictionary<PMove, PMoveData>()
        {
            {
                PMove.AquaJet,
                new PMoveData
                {
                    Type = PType.Water, Category = PMoveCategory.Physical,
                    Effect = PMoveEffect.Hit, EffectParam = 0,
                    PPTier = 4, Power = 40, Accuracy = 100, Priority = +1,
                    Flags = PMoveFlag.MakesContact | PMoveFlag.AffectedByProtect | PMoveFlag.AffectedByMirrorMove,
                    Targets = PMoveTarget.AnySurrounding
                }
            },
            {
                PMove.DarkPulse,
                new PMoveData
                {
                    Type = PType.Dark, Category = PMoveCategory.Special,
                    Effect = PMoveEffect.Hit__MaybeFlinch, EffectParam = 20,
                    PPTier = 3, Power = 80, Accuracy = 100, Priority = 0,
                    Flags = PMoveFlag.AffectedByProtect | PMoveFlag.AffectedByMirrorMove,
                    Targets = PMoveTarget.Any
                }
            },
            {
                PMove.DragonPulse,
                new PMoveData
                {
                    Type = PType.Dragon, Category = PMoveCategory.Special,
                    Effect = PMoveEffect.Hit, EffectParam = 0,
                    PPTier = 2, Power = 90, Accuracy = 100, Priority = 0,
                    Flags = PMoveFlag.AffectedByProtect | PMoveFlag.AffectedByMirrorMove,
                    Targets = PMoveTarget.Any
                }
            },
            {
                PMove.Frustration,
                new PMoveData
                {
                    Type = PType.Normal, Category = PMoveCategory.Physical,
                    Effect = PMoveEffect.Hit, EffectParam = 0,
                    PPTier = 4, Power = 0, Accuracy = 100, Priority = 0,
                    Flags = PMoveFlag.AffectedByProtect | PMoveFlag.AffectedByMirrorMove,
                    Targets = PMoveTarget.AnySurrounding
                }
            },
            {
                PMove.Growl,
                new PMoveData
                {
                    Type = PType.Normal, Category = PMoveCategory.Status,
                    Effect = PMoveEffect.Change_Opponent_ATK, EffectParam = -1,
                    PPTier = 8, Power = 0, Accuracy = 100, Priority = 0,
                    Flags = PMoveFlag.AffectedByProtect | PMoveFlag.AffectedByMagicCoat | PMoveFlag.AffectedByMirrorMove | PMoveFlag.SoundBased,
                    Targets = PMoveTarget.AllFoesSurrounding
                }
            },
            {
                PMove.HiddenPower,
                new PMoveData
                {
                    Type = PType.Normal, Category = PMoveCategory.Special,
                    Effect = PMoveEffect.Hit, EffectParam = 0,
                    PPTier = 3, Power = 0, Accuracy = 100, Priority = 0,
                    Flags = PMoveFlag.AffectedByProtect | PMoveFlag.AffectedByMirrorMove,
                    Targets = PMoveTarget.AnySurrounding
                }
            },
            {
                PMove.HydroPump,
                new PMoveData
                {
                    Type = PType.Water, Category = PMoveCategory.Special,
                    Effect = PMoveEffect.Hit, EffectParam = 0,
                    PPTier = 1, Power = 120, Accuracy = 80, Priority = 0,
                    Flags = PMoveFlag.AffectedByProtect | PMoveFlag.AffectedByMirrorMove,
                    Targets = PMoveTarget.AnySurrounding
                }
            },
            {
                PMove.IceBeam,
                new PMoveData
                {
                    Type = PType.Ice, Category = PMoveCategory.Special,
                    Effect = PMoveEffect.Hit__MaybeFreeze, EffectParam = 10,
                    PPTier = 2, Power = 95, Accuracy = 100, Priority = 0,
                    Flags = PMoveFlag.AffectedByProtect | PMoveFlag.AffectedByMirrorMove,
                    Targets = PMoveTarget.AnySurrounding
                }
            },
            {
                PMove.IcePunch,
                new PMoveData
                {
                    Type = PType.Ice, Category = PMoveCategory.Physical,
                    Effect = PMoveEffect.Hit__MaybeFreeze, EffectParam = 10,
                    PPTier = 3, Power = 75, Accuracy = 100, Priority = 0,
                    Flags = PMoveFlag.MakesContact | PMoveFlag.AffectedByProtect | PMoveFlag.AffectedByMirrorMove,
                    Targets = PMoveTarget.AnySurrounding
                }
            },
            {
                PMove.Inferno,
                new PMoveData
                {
                    Type = PType.Fire, Category = PMoveCategory.Special,
                    Effect = PMoveEffect.Hit__MaybeBurn, EffectParam = 100,
                    PPTier = 1, Power = 10, Accuracy = 50, Priority = 0,
                    Flags = PMoveFlag.AffectedByProtect | PMoveFlag.AffectedByMirrorMove,
                    Targets = PMoveTarget.AnySurrounding
                }
            },
            {
                PMove.Leer,
                new PMoveData
                {
                    Type = PType.Normal, Category = PMoveCategory.Status,
                    Effect = PMoveEffect.Change_Opponent_DEF, EffectParam = -1,
                    PPTier = 6, Power = 0, Accuracy = 100, Priority = 0,
                    Flags = PMoveFlag.AffectedByProtect | PMoveFlag.AffectedByMagicCoat | PMoveFlag.AffectedByMirrorMove,
                    Targets = PMoveTarget.AllFoesSurrounding
                }
            },
            {
                PMove.Moonlight,
                new PMoveData
                {
                    Type = PType.Normal, Category = PMoveCategory.Status,
                    Effect = PMoveEffect.Moonlight, EffectParam = 0,
                    PPTier = 1, Power = 0, Accuracy = 0, Priority = 0,
                    Flags = PMoveFlag.AffectedBySnatch,
                    Targets = PMoveTarget.Self
                }
            },
            {
                PMove.NastyPlot,
                new PMoveData
                {
                    Type = PType.Dark, Category = PMoveCategory.Status,
                    Effect = PMoveEffect.Change_User_SPATK, EffectParam = +2,
                    PPTier = 4, Power = 0, Accuracy = 0, Priority = 0,
                    Flags = PMoveFlag.AffectedBySnatch,
                    Targets = PMoveTarget.Self
                }
            },
            {
                PMove.Psychic,
                new PMoveData
                {
                    Type = PType.Psychic, Category = PMoveCategory.Special,
                    Effect = PMoveEffect.Hit__MaybeLower_SPDEF_By1, EffectParam = 10,
                    PPTier = 2, Power = 90, Accuracy = 100, Priority = 0,
                    Flags = PMoveFlag.AffectedByProtect | PMoveFlag.AffectedByMirrorMove,
                    Targets = PMoveTarget.AnySurrounding
                }
            },
            {
                PMove.Retaliate,
                new PMoveData
                {
                    Type = PType.Normal, Category = PMoveCategory.Physical,
                    Effect = PMoveEffect.Hit, EffectParam = 0,
                    PPTier = 1, Power = 70, Accuracy = 100, Priority = 0,
                    Flags = PMoveFlag.AffectedByProtect | PMoveFlag.AffectedByMirrorMove,
                    Targets = PMoveTarget.AnySurrounding
                }
            },
            {
                PMove.Return,
                new PMoveData
                {
                    Type = PType.Normal, Category = PMoveCategory.Physical,
                    Effect = PMoveEffect.Hit, EffectParam = 0,
                    PPTier = 4, Power = 0, Accuracy = 100, Priority = 0,
                    Flags = PMoveFlag.AffectedByProtect | PMoveFlag.AffectedByMirrorMove,
                    Targets = PMoveTarget.AnySurrounding
                }
            },
            {
                PMove.Scratch,
                new PMoveData
                {
                    Type = PType.Normal, Category = PMoveCategory.Physical,
                    Effect = PMoveEffect.Hit, EffectParam = 0,
                    PPTier = 8, Power = 40, Accuracy = 100, Priority = 0,
                    Flags = PMoveFlag.MakesContact | PMoveFlag.AffectedByProtect | PMoveFlag.AffectedByMirrorMove,
                    Targets = PMoveTarget.AnySurrounding
                }
            },
            {
                PMove.ShellSmash,
                new PMoveData
                {
                    Type = PType.Normal, Category = PMoveCategory.Status,
                    Effect = PMoveEffect.Lower_DEF_SPDEF_By1_Raise_ATK_SPATK_SPD_By2, EffectParam = 100,
                    PPTier = 3, Power = 0, Accuracy = 0, Priority = 0,
                    Flags = PMoveFlag.AffectedBySnatch,
                    Targets = PMoveTarget.Self
                }
            },
            {
                PMove.Tackle,
                new PMoveData
                {
                    Type = PType.Normal, Category = PMoveCategory.Physical,
                    Effect = PMoveEffect.Hit, EffectParam = 0,
                    PPTier = 7, Power = 50, Accuracy = 100, Priority = 0,
                    Flags = PMoveFlag.MakesContact | PMoveFlag.AffectedByProtect | PMoveFlag.AffectedByMirrorMove,
                    Targets = PMoveTarget.AnySurrounding
                }
            },
            {
                PMove.Thunder,
                new PMoveData
                {
                    Type = PType.Electric, Category = PMoveCategory.Special,
                    Effect = PMoveEffect.Hit__MaybeParalyze, EffectParam = 30,
                    PPTier = 2, Power = 120, Accuracy = 70, Priority = 0,
                    Flags = PMoveFlag.AffectedByProtect | PMoveFlag.AffectedByMirrorMove,
                    Targets = PMoveTarget.AnySurrounding
                }
            },
            {
                PMove.Thunderbolt,
                new PMoveData
                {
                    Type = PType.Electric, Category = PMoveCategory.Special,
                    Effect = PMoveEffect.Hit__MaybeParalyze, EffectParam = 10,
                    PPTier = 3, Power = 95, Accuracy = 100, Priority = 0,
                    Flags = PMoveFlag.AffectedByProtect | PMoveFlag.AffectedByMirrorMove,
                    Targets = PMoveTarget.AnySurrounding
                }
            },
            {
                PMove.Toxic,
                new PMoveData
                {
                    Type = PType.Poison, Category = PMoveCategory.Status,
                    Effect = PMoveEffect.Toxic, EffectParam = 0,
                    PPTier = 2, Power = 0, Accuracy = 90, Priority = 0,
                    Flags = PMoveFlag.AffectedByProtect | PMoveFlag.AffectedByMagicCoat | PMoveFlag.AffectedByMirrorMove,
                    Targets = PMoveTarget.AnySurrounding
                }
            },
            {
                PMove.Transform,
                new PMoveData
                {
                    Type = PType.Normal, Category = PMoveCategory.Status,
                    Effect = PMoveEffect.Transform, EffectParam = 0,
                    PPTier = 2, Power = 0, Accuracy = 0, Priority = 0,
                    Flags = PMoveFlag.None,
                    Targets = PMoveTarget.Self
                }
            },
            {
                PMove.Waterfall,
                new PMoveData
                {
                    Type = PType.Water, Category = PMoveCategory.Physical,
                    Effect = PMoveEffect.Hit__MaybeFlinch, EffectParam = 20,
                    PPTier = 3, Power = 80, Accuracy = 100, Priority = 0,
                    Flags = PMoveFlag.MakesContact | PMoveFlag.AffectedByProtect | PMoveFlag.AffectedByMirrorMove,
                    Targets = PMoveTarget.AnySurrounding
                }
            },
        };
    }
}

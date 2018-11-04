﻿using Ether.Network.Packets;
using Kermalis.PokemonBattleEngine.Data;
using Kermalis.PokemonBattleEngine.Packets;
using System;

namespace Kermalis.PokemonBattleEngine.Battle
{
    public sealed partial class PBattle
    {
        public delegate void BattleEvent(INetPacket packet);
        public event BattleEvent OnNewEvent;

        void BroadcastSwitchIn(PPokemon pkmn)
            => OnNewEvent?.Invoke(new PPkmnSwitchInPacket(pkmn));
        void BroadcastMoveUsed()
            => OnNewEvent?.Invoke(new PPkmnMovePacket(bAttacker, bMove));
        void BroadcastMiss()
            => OnNewEvent?.Invoke(new PMoveMissedPacket(bAttacker));
        void BroadcastFlinch()
            => OnNewEvent?.Invoke(new PPkmnFlinchedPacket(bAttacker));
        void BroadcastHPChanged(PPokemon pkmn, int change)
            => OnNewEvent?.Invoke(new PPkmnHPChangedPacket(pkmn, change));
        void BroadcastEffectiveness(double effectiveness)
            => OnNewEvent?.Invoke(new PMoveEffectivenessPacket(bDefender, effectiveness));
        void BroadcastFaint(PPokemon pkmn)
            => OnNewEvent?.Invoke(new PPkmnFaintedPacket(pkmn));
        void BroadcastCrit()
        {
            if (bLandedCrit)
                OnNewEvent?.Invoke(new PMoveCritPacket());
        }
        void BroadcastProtect()
            => OnNewEvent?.Invoke(new PPkmnProtectPacket(bDefender));

        void BroadcastStatChange(PPokemon pkmn, PStat stat, sbyte change, bool isTooMuch)
            => OnNewEvent?.Invoke(new PPkmnStatChangedPacket(pkmn, stat, change, isTooMuch));
        void BroadcastStatus1Change(PPokemon pkmn)
            => OnNewEvent?.Invoke(new PStatus1ChangePacket(pkmn));
        void BroadcastStatus1Ended(PPokemon pkmn)
            => OnNewEvent?.Invoke(new PStatus1EndedPacket(pkmn));
        void BroadcastStatus1CausedImmobility(PPokemon pkmn)
            => OnNewEvent?.Invoke(new PStatus1CausedImmobilityPacket(pkmn));
        void BroadcastStatus1CausedDamage(PPokemon pkmn)
            => OnNewEvent?.Invoke(new PStatus1CausedDamagePacket(pkmn));
        void BroadcastFail()
            => OnNewEvent?.Invoke(new PMoveFailPacket());
        void BroadcastItemUsed(PPokemon pkmn)
            => OnNewEvent?.Invoke(new PItemUsedPacket(pkmn));
        void BroadcastPPChanged(PPokemon pkmn, PMove move, int change)
            => OnNewEvent?.Invoke(new PMovePPChangedPacket(pkmn, move, change));
        void BroadcastLimber(PPokemon pkmn, bool prevented) // Prevented or cured
            => OnNewEvent?.Invoke(new PAbilityLimberPacket(pkmn, prevented));



        public static void ConsoleBattleEventHandler(INetPacket packet)
        {
            PPokemon pkmn;
            string message;
            double percentage;

            switch (packet)
            {
                case PPkmnSwitchInPacket psip:
                    Console.WriteLine("{1} sent out {0}!", PKnownInfo.Instance.Pokemon(psip.PokemonId).Shell.Nickname, PKnownInfo.Instance.DisplayName(psip.Local));
                    break;
                case PPkmnMovePacket pmp:
                    Console.WriteLine("{0} used {1}!", PKnownInfo.Instance.Pokemon(pmp.PokemonId).Shell.Nickname, pmp.Move);
                    break;
                case PPkmnHPChangedPacket phcp:
                    pkmn = PKnownInfo.Instance.Pokemon(phcp.PokemonId);
                    var hp = Math.Abs(phcp.Change);
                    percentage = (double)hp / pkmn.MaxHP;
                    Console.WriteLine("{0} {3} {1} ({2:P2}) HP!", pkmn.Shell.Nickname, hp, percentage, phcp.Change < 0 ? "lost" : "gained");
                    break;
                case PMoveEffectivenessPacket mep:
                    if (mep.Effectiveness == 0)
                        message = "It doesn't affect {0}...";
                    else if (mep.Effectiveness > 1)
                        message = "It's super effective!";
                    else if (mep.Effectiveness < 1)
                        message = "It's not very effective...";
                    else
                        break;
                    Console.WriteLine(message, PKnownInfo.Instance.Pokemon(mep.PokemonId).Shell.Nickname);
                    break;
                case PPkmnFlinchedPacket pflp:
                    Console.WriteLine("{0} flinched and couldn't move!", PKnownInfo.Instance.Pokemon(pflp.PokemonId).Shell.Nickname);
                    break;
                case PMoveMissedPacket mmp:
                    Console.WriteLine("{0}'s attack missed!", PKnownInfo.Instance.Pokemon(mmp.PokemonId).Shell.Nickname);
                    break;
                case PPkmnFaintedPacket pfap:
                    Console.WriteLine("{0} fainted!", PKnownInfo.Instance.Pokemon(pfap.PokemonId).Shell.Nickname);
                    break;
                case PPkmnProtectPacket ppp:
                    Console.WriteLine("{0} protected itself!", PKnownInfo.Instance.Pokemon(ppp.PokemonId).Shell.Nickname);
                    break;
                case PMoveCritPacket _:
                    Console.WriteLine("A critical hit!");
                    break;
                case PMoveFailPacket _:
                    Console.WriteLine("But it failed!");
                    break;
                case PPkmnStatChangedPacket pscp:
                    switch (pscp.Change)
                    {
                        case -2: message = "harshly fell"; break;
                        case -1: message = "fell"; break;
                        case +1: message = "rose"; break;
                        case +2: message = "sharply rose"; break;
                        default:
                            if (pscp.IsTooMuch && pscp.Change < 0)
                                message = "won't go lower";
                            else if (pscp.IsTooMuch && pscp.Change > 0)
                                message = "won't go higher";
                            else if (pscp.Change <= -3)
                                message = "severely fell";
                            else if (pscp.Change >= 3)
                                message = "rose drastically";
                            else
                                throw new ArgumentOutOfRangeException(nameof(pscp.Change), $"Invalid stat change: {pscp.Change}"); // +0
                            break;
                    }
                    Console.WriteLine("{0}'s {1} {2}!", PKnownInfo.Instance.Pokemon(pscp.PokemonId).Shell.Nickname, pscp.Stat, message);
                    break;
                case PStatus1ChangePacket scp:
                    switch (scp.Status1)
                    {
                        case PStatus1.Asleep: message = "fell asleep"; break;
                        case PStatus1.Burned: message = "was burned"; break;
                        case PStatus1.Frozen: message = "was frozen solid"; break;
                        case PStatus1.BadlyPoisoned:
                        case PStatus1.Poisoned: message = "was poisoned"; break;
                        case PStatus1.Paralyzed: message = "is paralyzed! It may be unable to move"; break;
                        default: throw new ArgumentOutOfRangeException(nameof(scp.Status1), $"Invalid status1 change: {scp.Status1}");
                    }
                    Console.WriteLine("{0} {1}!", PKnownInfo.Instance.Pokemon(scp.PokemonId).Shell.Nickname, message);
                    break;
                case PStatus1EndedPacket sep:
                    switch (sep.Status1)
                    {
                        case PStatus1.Asleep: message = "woke up!"; break;
                        case PStatus1.Frozen: message = "thawed out!"; break;
                        case PStatus1.Paralyzed: message = "was cured of paralysis."; break;
                        default: throw new ArgumentOutOfRangeException(nameof(sep.Status1), $"Invalid status1 ending: {sep.Status1}");
                    }
                    Console.WriteLine("{0} {1}", PKnownInfo.Instance.Pokemon(sep.PokemonId).Shell.Nickname, message);
                    break;
                case PStatus1CausedImmobilityPacket scip:
                    switch (scip.Status1)
                    {
                        case PStatus1.Asleep: message = "is fast asleep."; break;
                        case PStatus1.Frozen: message = "is frozen solid!"; break;
                        case PStatus1.Paralyzed: message = "is paralyzed! It can't move!"; break;
                        default: throw new ArgumentOutOfRangeException(nameof(scip.Status1), $"Invalid status1 causing immobility: {scip.Status1}");
                    }
                    Console.WriteLine("{0} {1}", PKnownInfo.Instance.Pokemon(scip.PokemonId).Shell.Nickname, message);
                    break;
                case PStatus1CausedDamagePacket scdp:
                    switch (scdp.Status1)
                    {
                        case PStatus1.Burned: message = "was hurt by its burn"; break;
                        case PStatus1.BadlyPoisoned:
                        case PStatus1.Poisoned: message = "was hurt by poison"; break;
                        default: throw new ArgumentOutOfRangeException(nameof(scdp.Status1), $"Invalid status1 causing damage: {scdp.Status1}");
                    }
                    Console.WriteLine("{0} {1}!", PKnownInfo.Instance.Pokemon(scdp.PokemonId).Shell.Nickname, message);
                    break;
                case PItemUsedPacket iup:
                    switch (iup.Item)
                    {
                        case PItem.Leftovers: message = "restored a little HP using its Leftovers"; break;
                        default: throw new ArgumentOutOfRangeException(nameof(iup.Item), $"Invalid item used: {iup.Item}");
                    }
                    Console.WriteLine("{0} {1}!", PKnownInfo.Instance.Pokemon(iup.PokemonId).Shell.Nickname, message);
                    break;
                case PAbilityLimberPacket alp:
                    Console.Write("{0}'s Limber: ", PKnownInfo.Instance.Pokemon(alp.PokemonId).Shell.Nickname);
                    break;
            }
        }
    }
}

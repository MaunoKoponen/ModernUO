using System;
using System.Collections;
using Server.Items;
using Server.Targeting;

namespace Server.Mobiles
{
	public class Troll : BaseCreature
	{
		public override string CorpseName => "a troll corpse";
		public override string DefaultName => "a troll";

		[Constructible]
		public Troll () : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Body = Utility.RandomList( 53, 54 );
			BaseSoundID = 461;

			SetStr( 176, 205 );
			SetDex( 46, 65 );
			SetInt( 46, 70 );

			SetHits( 106, 123 );

			SetDamage( 8, 14 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 35, 45 );
			SetResistance( ResistanceType.Fire, 25, 35 );
			SetResistance( ResistanceType.Cold, 15, 25 );
			SetResistance( ResistanceType.Poison, 5, 15 );
			SetResistance( ResistanceType.Energy, 5, 15 );

			SetSkill( SkillName.MagicResist, 45.1, 60.0 );
			SetSkill( SkillName.Tactics, 50.1, 70.0 );
			SetSkill( SkillName.Wrestling, 50.1, 70.0 );

			Fame = 3500;
			Karma = -3500;

			VirtualArmor = 40;
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.Average );
		}

		public override bool CanRummageCorpses => true;
		public override int TreasureMapLevel => 1;
		public override int Meat => 2;

		public Troll( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}

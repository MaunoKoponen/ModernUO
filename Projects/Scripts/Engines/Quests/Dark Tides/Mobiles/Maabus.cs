using Server.Mobiles;

namespace Server.Engines.Quests.Necro
{
  public class Maabus : BaseQuester
  {
    public Maabus()
    {
    }

    public Maabus(Serial serial) : base(serial)
    {
    }

    public override string DefaultName => "Maabus";

    public override void InitBody()
    {
      Body = 0x94;
    }

    public override bool CanTalkTo(PlayerMobile to) => false;

    public override void OnTalk(PlayerMobile player, bool contextMenu)
    {
    }

    public override void Serialize(GenericWriter writer)
    {
      base.Serialize(writer);

      writer.Write(0); // version
    }

    public override void Deserialize(GenericReader reader)
    {
      base.Deserialize(reader);

      int version = reader.ReadInt();
    }
  }
}
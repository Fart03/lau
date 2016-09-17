// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLChannelParticipantModerator : TLChannelParticipantBase, ITLChannelInviter 
	{

		public TLChannelParticipantModerator() { }
		public TLChannelParticipantModerator(TLBinaryReader from, TLType type = TLType.ChannelParticipantModerator)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.ChannelParticipantModerator; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.ChannelParticipantModerator)
		{
			UserId = from.ReadInt32();
			InviterId = from.ReadInt32();
			Date = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x91057FEF);
			to.Write(UserId);
			to.Write(InviterId);
			to.Write(Date);
		}
	}
}
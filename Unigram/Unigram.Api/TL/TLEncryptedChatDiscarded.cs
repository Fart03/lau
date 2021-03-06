// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLEncryptedChatDiscarded : TLEncryptedChatBase 
	{
		public TLEncryptedChatDiscarded() { }
		public TLEncryptedChatDiscarded(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.EncryptedChatDiscarded; } }

		public override void Read(TLBinaryReader from)
		{
			Id = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x13D6DD27);
			to.Write(Id);
		}
	}
}
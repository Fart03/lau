// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLInputStickerSetItem : TLObject 
	{
		[Flags]
		public enum Flag : Int32
		{
			MaskCoords = (1 << 0),
		}

		public bool HasMaskCoords { get { return Flags.HasFlag(Flag.MaskCoords); } set { Flags = value ? (Flags | Flag.MaskCoords) : (Flags & ~Flag.MaskCoords); } }

		public Flag Flags { get; set; }
		public TLInputDocumentBase Document { get; set; }
		public String Emoji { get; set; }
		public TLMaskCoords MaskCoords { get; set; }

		public TLInputStickerSetItem() { }
		public TLInputStickerSetItem(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputStickerSetItem; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			Document = TLFactory.Read<TLInputDocumentBase>(from);
			Emoji = from.ReadString();
			if (HasMaskCoords) MaskCoords = TLFactory.Read<TLMaskCoords>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.Write(0xFFA0A496);
			to.Write((Int32)Flags);
			to.WriteObject(Document);
			to.Write(Emoji);
			if (HasMaskCoords) to.WriteObject(MaskCoords);
		}

		private void UpdateFlags()
		{
			HasMaskCoords = MaskCoords != null;
		}
	}
}
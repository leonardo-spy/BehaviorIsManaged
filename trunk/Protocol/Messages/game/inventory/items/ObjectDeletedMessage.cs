// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ObjectDeletedMessage.xml' the '27/06/2012 15:55:11'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class ObjectDeletedMessage : NetworkMessage
	{
		public const uint Id = 3024;
		public override uint MessageId
		{
			get
			{
				return 3024;
			}
		}
		
		public int objectUID;
		
		public ObjectDeletedMessage()
		{
		}
		
		public ObjectDeletedMessage(int objectUID)
		{
			this.objectUID = objectUID;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(objectUID);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			objectUID = reader.ReadInt();
			if ( objectUID < 0 )
			{
				throw new Exception("Forbidden value on objectUID = " + objectUID + ", it doesn't respect the following condition : objectUID < 0");
			}
		}
	}
}
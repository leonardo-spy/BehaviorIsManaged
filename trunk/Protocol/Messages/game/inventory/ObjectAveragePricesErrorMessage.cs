// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ObjectAveragePricesErrorMessage.xml' the '27/06/2012 15:55:08'
using System;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
	public class ObjectAveragePricesErrorMessage : NetworkMessage
	{
		public const uint Id = 6336;
		public override uint MessageId
		{
			get
			{
				return 6336;
			}
		}
		
		
		public override void Serialize(IDataWriter writer)
		{
		}
		
		public override void Deserialize(IDataReader reader)
		{
		}
	}
}
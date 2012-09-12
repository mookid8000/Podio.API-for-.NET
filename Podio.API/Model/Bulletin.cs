using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Podio.API.Model
{
	[DataContract]
	public class Bulletin 
	{


		[DataMember(Name = "bulletin_id", IsRequired=false)]
		public int BulletinId { get; set; }


		[DataMember(Name = "title", IsRequired=false)]
		public string Title { get; set; }


		[DataMember(Name = "summary", IsRequired=false)]
		public string Summary { get; set; }


		[DataMember(Name = "text", IsRequired=false)]
		public string Text { get; set; }


		[DataMember(Name = "locale", IsRequired=false)]
		public string Locale { get; set; }


		[DataMember(Name = "target_group", IsRequired=false)]
		public string TargetGroup { get; set; }


		[DataMember(Name = "created_on", IsRequired=false)]
		public DateTime CreatedOn { get; set; }


		[DataMember(Name = "sent_on", IsRequired=false)]
		public DateTime SentOn { get; set; }


		[DataMember(Name = "created_by", IsRequired=false)]
		public ByLine CreatedBy { get; set; }


		[DataMember(Name = "sent_by", IsRequired=false)]
		public ByLine SentBy { get; set; }


	}
}

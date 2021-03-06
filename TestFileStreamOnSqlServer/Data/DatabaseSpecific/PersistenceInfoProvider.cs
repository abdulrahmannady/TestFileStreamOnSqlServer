//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro v5.5.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace FileStream.DatabaseSpecific
{
	/// <summary>Singleton implementation of the PersistenceInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	internal static class PersistenceInfoProviderSingleton
	{
		private static readonly IPersistenceInfoProvider _providerInstance = new PersistenceInfoProviderCore();

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static PersistenceInfoProviderSingleton() {	}

		/// <summary>Gets the singleton instance of the PersistenceInfoProviderCore</summary>
		/// <returns>Instance of the PersistenceInfoProvider.</returns>
		public static IPersistenceInfoProvider GetInstance() { return _providerInstance; }
	}

	/// <summary>Actual implementation of the PersistenceInfoProvider. Used by singleton wrapper.</summary>
	internal class PersistenceInfoProviderCore : PersistenceInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="PersistenceInfoProviderCore"/> class.</summary>
		internal PersistenceInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores with the structure of hierarchical types.</summary>
		private void Init()
		{
			this.InitClass();
			InitAttachmentEntityMappings();
		}

		/// <summary>Inits AttachmentEntity's mappings</summary>
		private void InitAttachmentEntityMappings()
		{
			this.AddElementMapping("AttachmentEntity", @"MyFileStreamDB", @"dbo", "Attachment", 5, 0);
			this.AddElementFieldMapping("AttachmentEntity", "File", "File", true, "VarBinary", 2147483647, 0, 0, false, "", null, typeof(System.Byte[]), 0);
			this.AddElementFieldMapping("AttachmentEntity", "Fsunique", "FSUnique", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 1);
			this.AddElementFieldMapping("AttachmentEntity", "Id", "Id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("AttachmentEntity", "MimeType", "MimeType", true, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("AttachmentEntity", "OriginalFileName", "OriginalFileName", true, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 4);
		}

	}
}

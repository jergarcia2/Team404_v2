namespace Team404_v2.Models
{
	using System;
	using System.Data.Entity;
	using System.Linq;

	public class MyModel : DbContext
	{
		// Your context has been configured to use a 'CaseModel' connection string from your application's 
		// configuration file (App.config or Web.config). By default, this connection string targets the 
		// 'Team404_v2.Models.CaseModel' database on your LocalDb instance. 
		// 
		// If you wish to target a different database and/or database provider, modify the 'CaseModel' 
		// connection string in the application configuration file.
		public MyModel()
			: base("name=mydatabase")
		{
			Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MyModel>());

		}

		// Add a DbSet for each entity type that you want to include in your model. For more information 
		// on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.
		//Computer Parts

		public class Product
		{

			public virtual DbSet<CPCases> CPCases { get; set; }
			public virtual DbSet<CPMemory> CPMemory { get; set; }
			public virtual DbSet<CPCoolingSystems> CPCoolingSystems { get; set; }
			public virtual DbSet<CPMotherboard> CPMotherboard { get; set; }
			public virtual DbSet<CPPowerSupply> CPPowerSupply { get; set; }
			public virtual DbSet<CPSoundCards> CPSoundCards { get; set; }
			public virtual DbSet<CPVideoCards> CPVideoCards { get; set; }
			public virtual DbSet<CPProcessors> CPProcessors { get; set; }


			//Accessories
			public virtual DbSet<AAdapters> AAdapters { get; set; }
			public virtual DbSet<AChargers> AChargers { get; set; }
			public virtual DbSet<AMiscCables> AMiscCables { get; set; }
			public virtual DbSet<APhones> APhones { get; set; }
			public virtual DbSet<AStorageDevices> AStorageDevices { get; set; }

			//bundles 

			public virtual DbSet<BeginnerBundles> BeginnerBundles { get; set; }
			public virtual DbSet<MidGradeBundles> MidGradeBundles { get; set; }
			public virtual DbSet<ProfessionalBundles> ProfessionalBundles { get; set; }

		}
		public virtual DbSet<Wishlist> Wishlist { get; set; }

	}

	//public class MyEntity
	//{
	//    public int Id { get; set; }
	//    public string Name { get; set; }
	//}
}
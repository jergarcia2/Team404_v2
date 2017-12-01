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
			: base("name=DefaultConnection")
		{
			Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MyModel>());
		}

		// Add a DbSet for each entity type that you want to include in your model. For more information 
		// on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.
		//Computer Parts

		public virtual DbSet<Products> Products { get; set; }
		public virtual DbSet<Bundles> Bundles { get; set; }
		public virtual DbSet<Wishlist> Wishlists { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
    }

	//public class MyEntity
	//{
	//    public int Id { get; set; }
	//    public string Name { get; set; }
	//}
}
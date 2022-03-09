using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
    public class TraversalContext:DbContext
    {
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"server=(localdb)\MSSQLLocalDB; database=TraversalDb; integrated security=true");
		}

		//entity'lerin sql e yansıtılması
		public DbSet<About> Abouts { get; set; }
		public DbSet<About2> About2s { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Destination> Destinations { get; set; }
		public DbSet<Feature> Features { get; set; }
		public DbSet<FeatureBack> FeatureBacks { get; set; }
		public DbSet<Guide> Guides { get; set; }
		public DbSet<NewsLetter> NewsLetters { get; set; }
		public DbSet<SubAbout> SubAbouts { get; set; }
		public DbSet<Testimonial> Testimonials { get; set; }
	}
}

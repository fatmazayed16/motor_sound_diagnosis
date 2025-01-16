﻿namespace jwtauth;

public class ApplicationDbContext : DbContext
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){ }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
				=> modelBuilder.ApplyConfiguration(new UserConfigration())
								.ApplyConfiguration(new RefreshTokenConfigration())
								.ApplyConfiguration(new HomeSectionConfigration());
}

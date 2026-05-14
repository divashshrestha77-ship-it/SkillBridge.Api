using Microsoft.EntityFrameworkCore;
using SkillBridge.api.Entities;
using SkillBridge.Api.Entities;
using SkillBridge.Api.Migrations;

public class SkillBridgeDbContext : DbContext
{
    public SkillBridgeDbContext(DbContextOptions<SkillBridgeDbContext> options) :base(options)
    {
        
    }

    public DbSet<User> Users {get; set;}
    public DbSet<Job> Jobs {get; set;}
    public DbSet<JobApplicaitions> JobApplocation {get; set;}
    public DbSet<UserProfile> UserProfiles {get; set;}



}
using System;
using System.Collections.Generic;
using DatabaseLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseLayer.Context;

public partial class TodolistDbContext : DbContext
{
    public TodolistDbContext()
    {
    }
    public TodolistDbContext(DbContextOptions<TodolistDbContext> options)
        : base(options)
    {
    }
    public virtual DbSet<Profile> Profiles { get; set; }
    public virtual DbSet<Todolist> Todolists { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Todolist>(entity =>
        {
            entity.HasOne(d => d.ProfileIdTodoNavigation).WithMany(p => p.Todolists).HasForeignKey(d => d.ProfileId);
        });
    }
}

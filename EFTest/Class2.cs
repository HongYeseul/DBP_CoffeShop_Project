using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Storage;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using EFTest;

class MyDbContext : DbContext
{
    public DbSet<MyData> Data { get; set; }
    public DbSet<MyData> Number { get; set; }
    public DbSet<MyData> Name { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql("Server=49.50.174.201;Database=s5533142;Uid=s5533142;Pwd=s5533142;Charset=utf8",
            options => options
                .CharSet(CharSet.Utf8)
                .CharSetBehavior(CharSetBehavior.AppendToAllColumns));
    }
}
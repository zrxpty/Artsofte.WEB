using Artsofte.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Artsofte.DAL
{
    public class AppDbContext: DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ProgrammingLanguage> ProgrammingLanguages { get; set; }
        public DbSet<Departament> Departaments { get; set;}

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Departament>().HasData(
                new Departament[]
                {
                    new Departament{Id=Guid.NewGuid(), Name="AI", Floor=4},
                    new Departament{Id=Guid.NewGuid(), Name="Analytics", Floor=5},
                    new Departament{Id=Guid.NewGuid(), Name="GameDev", Floor=3},
                }
                );
            builder.Entity<ProgrammingLanguage>().HasData(
                new ProgrammingLanguage[]
                {
                    new ProgrammingLanguage{Id=Guid.NewGuid(), Name="C#"},
                    new ProgrammingLanguage{Id=Guid.NewGuid(), Name="C++"},
                    new ProgrammingLanguage{Id=Guid.NewGuid(), Name="Python"},
                    new ProgrammingLanguage{Id=Guid.NewGuid(), Name="Scala"},
                    new ProgrammingLanguage{Id=Guid.NewGuid(), Name="Go"},
                    new ProgrammingLanguage{Id=Guid.NewGuid(), Name="JavaScript"},
                    new ProgrammingLanguage{Id=Guid.NewGuid(), Name="Кумир"},
                }
            );

            
        }
    }
}

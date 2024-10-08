using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

public class ClinicDbContext : DbContext
{
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<PatientOPD> patientOPDs { get; set; }
    public DbSet<ServiceTypes>  serviceTypes { get; set; }
    public string DbPath { get; }

    public ClinicDbContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Combine(path, "eyeclinic.db");
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}
